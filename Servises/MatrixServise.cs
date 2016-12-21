using Sample.BusinessEntity;
using Sample.Entities;
using Sample.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample.Servises
{
    public class MatrixService : IMatrixService
    {

        #region Fields

        private string _connectionString;

        private SqlMatrixRepository _matrixRepository;
        private SqlPercentageRepository _percentageRepository;
        private SqlPercentToCompoundRepository _percentToCompoundRepository;

        #endregion

        #region Properties

        public SqlMatrixRepository MatrixRepository
        {
            get
            {
                if (this._matrixRepository == null)
                {
                    this._matrixRepository = new SqlMatrixRepository(this._connectionString);
                }
                return this._matrixRepository;
            }

            set { this._matrixRepository = value; }
        }
        public SqlPercentageRepository PercentageRepository
        {
            get
            {
                if (this._percentageRepository == null)
                {
                    this._percentageRepository = new SqlPercentageRepository(this._connectionString);
                }
                return this._percentageRepository;
            }

            set { _percentageRepository = value; }
        }
        public SqlPercentToCompoundRepository PercentToCompoundRepository
        {
            get
            {
                if (this._percentToCompoundRepository == null)
                {
                    this._percentToCompoundRepository = new SqlPercentToCompoundRepository(this._connectionString);
                }
                return this._percentToCompoundRepository;
            }

            set { this._percentToCompoundRepository = value; }
        }

        #endregion

        #region Constructors

        public MatrixService(string connectionString)
        {
            this._connectionString = connectionString;
        }

        #endregion

        #region Methods

        public void SetMatrixWithIdInto(BusinessMatrix matrixGroup, int id)
        {
            var matrix = this.MatrixRepository.GetMatrixById(id);

            if (matrix == null)
            {
                throw new ArgumentException(string.Format("Matrix with Id = {0} was not found in database.", id));
            }

            matrixGroup.Matrix = matrix;

            if (matrixGroup.Percentage.Number > 0)
            {
                SetPercentageWiyhNumberInto(matrixGroup, matrixGroup.Percentage.Number);
            }
        }

        public void SetPercentageWiyhNumberInto(BusinessMatrix matrixGroup, double number)
        {
            if (number < 0)
            {
                throw new ArgumentException("Percentage number should be bigger that zero.");
            }

            var percentage = this.PercentageRepository.GetPercentageWithValues(number, matrixGroup.Matrix.Id, null);

            if (percentage != null)
            {
                percentage = new Percentage(-1, number, null, matrixGroup.Matrix.Id);
            }

            matrixGroup.Percentage = percentage;

            if (matrixGroup.PercentToCompound.CompoundId > 0)
            {
                SetPercentageToCompoundWithCompoundIdInto(matrixGroup, matrixGroup.PercentToCompound.CompoundId);
            }
        }

        public void SetPercentageToCompoundWithCompoundIdInto(BusinessMatrix matrixGroup, int compoundId)
        {
            var percentageToCompound = from item in this.PercentToCompoundRepository.GetAllWithCompountId(compoundId)
                                       where item.PercentId == matrixGroup.Percentage.Id
                                       select item;

            if (percentageToCompound.Count() > 0)
                matrixGroup.PercentToCompound = percentageToCompound.ToArray()[0];
            else
                matrixGroup.PercentToCompound = new PercentToCompound(matrixGroup.Percentage.Id, compoundId);
        }

        #endregion

    }
}
