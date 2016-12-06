using Sample.BusinessEntity;
using Sample.Entities;
using Sample.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servises
{
    public class CompoundServise : ICompoundServise
    {

        #region Fields

        private string _connectionString;
        private Compound _compound;
        private SqlPercentageRepository _sqlPercentageRepository;
        private SqlCompoundRepository _sqlCompoundRepository;
        private SqlPercentToCompoundRepository _sqlPercentToCompoundRepository;
        private SqlDopantRepository _sqlDopantRepository;
        private SqlMatrixRepository _sqlMatrixRepository;

        #endregion

        #region Properties

        public SqlPercentageRepository PercentageRepository
        {
            get
            {
                if (this._sqlPercentageRepository == null)
                {
                    this._sqlPercentageRepository = new SqlPercentageRepository(this._connectionString);
                }
                return this._sqlPercentageRepository;
            }

            set { _sqlPercentageRepository = value; }
        }
        public SqlCompoundRepository CompoundRepository
        {
            get
            {
                if (this._sqlCompoundRepository == null)
                {
                    this._sqlCompoundRepository = new SqlCompoundRepository(this._connectionString);
                }
                return this._sqlCompoundRepository;
            }

            set { this._sqlCompoundRepository = value; }
        }
        public SqlPercentToCompoundRepository PercentToCompoundRepository
        {
            get
            {
                if (this._sqlPercentToCompoundRepository == null)
                {
                    this._sqlPercentToCompoundRepository = new SqlPercentToCompoundRepository(this._connectionString);
                }
                return this._sqlPercentToCompoundRepository;
            }

            set { this._sqlPercentToCompoundRepository = value; }
        }
        public SqlDopantRepository DopantRepository
        {
            get
            {
                if (this._sqlDopantRepository == null)
                {
                    this._sqlDopantRepository = new SqlDopantRepository(this._connectionString);
                }
                return this._sqlDopantRepository;
            }

            set { this._sqlDopantRepository = value; }
        }
        public SqlMatrixRepository MatrixRepository
        {
            get
            {
                if (this._sqlMatrixRepository == null)
                {
                    this._sqlMatrixRepository = new SqlMatrixRepository(this._connectionString);
                }
                return this._sqlMatrixRepository;
            }

            set { this._sqlMatrixRepository = value; }
        }

        #endregion

        #region Constructors

        public CompoundServise(string connectionString)
        {
            this._connectionString = connectionString;
        }

        #endregion

        #region Realisation of ICompoundServise

        public BusinessCompound GetCompoundWithId(int id)
        {
            var compound = this.CompoundRepository.GetCompoundById(id);

            if (compound != null)
            {
                var resultCompound = new BusinessCompound();
                resultCompound.Compound = compound;
                var connections = this.PercentToCompoundRepository.GetAllWithCompountId(id);

                if (connections.Count > 0)
                {
                    resultCompound.PercentageToCompound = connections;

                    foreach (var item in connections)
                    {
                        var percentage = this.PercentageRepository.GetPersentageById(item.PercentId);
                        if (percentage != null)
                        {
                            if (percentage.MatrixId != null)
                            {
                                var matrix = this.MatrixRepository.GetMatrixById((int)percentage.MatrixId);
                                resultCompound.Matrixes.Add(percentage, matrix);
                            }
                            else if (percentage.DopantId != null)
                            {
                                var dopant = this.DopantRepository.GetDopantById((int)percentage.DopantId);
                                resultCompound.Dopants.Add(percentage, dopant);
                            }
                        }
                        resultCompound.PercentageToCompound.Add(item);
                    }
                }
                return resultCompound;
            }

            return null;
        }

        public IEnumerable<BusinessCompound> GetAllCompounds()
        {
            var result = new List<BusinessCompound>();

            foreach (var item in this._sqlCompoundRepository.GetAllCompounds())
            {
                result.Add(GetCompoundWithId(item.Id));
            }

            return result;
        }

        public IEnumerable<BusinessCompound> SearchCompoundWithNameLike(string name)
        {
            var matrixes = this._sqlMatrixRepository.SearchMatrixesByName(name);
            var dopants = this._sqlDopantRepository.SeachDopantsByName(name);

            var percentages = this._sqlPercentageRepository.GetAllPercents();

            var percentageToCompound = this._sqlPercentToCompoundRepository.GetAllPercentToCompound();

            var ids = from ptc in percentageToCompound
                      join p in percentages on ptc.PercentId equals p.Id
                      join d in dopants on p.DopantId equals d.Id
                      join m in matrixes on p.MatrixId equals m.Id
                      select ptc.CompoundId;

            var result = new List<BusinessCompound>();
            foreach (var id in ids)
            {
                result.Add(GetCompoundWithId(id));
            }

            return result;
        }

        public BusinessCompound InsertCompound(BusinessCompound compound)
        {
            var inserted = this.CompoundRepository.InsertCompound(compound.Compound);

            SaveChangesInCompound(compound, inserted);

            return GetCompoundWithId(inserted.Id);
        }

        public BusinessCompound UpdateCompoundWithId(int id, BusinessCompound compound)
        {
            var inserted = compound.Compound;
            if (inserted.WasModified)
            {
                this._sqlCompoundRepository.UpdateCompound(inserted.Id, inserted);
            }

            SaveChangesInCompound(compound, inserted);

            return GetCompoundWithId(inserted.Id);
        }

        public void DeleteCompoundWithId(int id)
        {
            var compound = GetCompoundWithId(id);

            foreach (var item in compound.PercentageToCompound)
            {
                this._sqlPercentToCompoundRepository.DeletePercentToCompoundWithId(item.Id);
            }

            this._sqlCompoundRepository.DeleteCompound(compound.Compound.Id);
        }

        #endregion

        #region Another methods

        public void RemovePercentToCompoundAt(int percentId, BusinessCompound compound)
        {
            foreach (var item in compound.PercentageToCompound)
            {
                if (item.PercentId == percentId)
                {
                    this._sqlPercentToCompoundRepository.DeletePercentToCompoundWithId(item.Id);
                    compound.PercentageToCompound.Remove(item);
                }
            }
        }

        #endregion

        #region Helping methods

        private bool PercentageToCompoundIsInList(Percentage percent, BusinessCompound compound)
        {
            foreach (var item in compound.PercentageToCompound)
            {
                if (item.PercentId == percent.Id)
                {
                    return true;
                }
            }
            return false;
        }

        private void SavePercentage(Percentage percent)
        {
            if (this.PercentageRepository.GetPercentageWithValues(percent.Number, percent.MatrixId, percent.DopantId) == null)
            {
                this.PercentageRepository.InsertPersentage(percent);
            }
            else if (percent.WasModified)
            {
                this.PercentageRepository.UpdatePercentage(percent.Id, percent);
            }
        }

        private void SaveChangesInCompound(BusinessCompound compound, Compound inserted)
        {
            foreach (var percent in compound.Matrixes.Keys)
            {
                var currentMatrix = compound.Matrixes[percent];
                if (currentMatrix.WasModified)
                {
                    currentMatrix = this.MatrixRepository.UpdateMatrixWithId(currentMatrix.Id, currentMatrix);
                    percent.MatrixId = currentMatrix.Id;
                }

                SavePercentage(percent);

                if (!PercentageToCompoundIsInList(percent, compound))
                {
                    this._sqlPercentToCompoundRepository.InsertPercentToCompound(new PercentToCompound(percent.Id, inserted.Id));
                }
            }

            foreach (var percent in compound.Dopants.Keys)
            {
                var currentDopant = compound.Dopants[percent];
                if (currentDopant.WasModified)
                {
                    currentDopant = this.DopantRepository.UpdateDopantWithId(currentDopant.Id, currentDopant);
                    percent.DopantId = currentDopant.Id;
                }

                SavePercentage(percent);

                if (!PercentageToCompoundIsInList(percent, compound))
                {
                    this._sqlPercentToCompoundRepository.InsertPercentToCompound(new PercentToCompound(percent.Id, inserted.Id));
                }
            }
        }

        #endregion

    }
}
