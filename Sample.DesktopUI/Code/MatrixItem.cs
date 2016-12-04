namespace Sample.DesktopUI
{
    public class MatrixItem
    {
        public double Percentage { get; set; }
        public string MatrixName { get; set; }
        public int MatrixId { get; set; }

        public MatrixItem()
        { }

        public MatrixItem(int id, string matrixName)
        {
            this.MatrixId = id;
            this.MatrixName = matrixName;
        }

        public override string ToString()
        {
            return this.MatrixName;
        }
    }
}
