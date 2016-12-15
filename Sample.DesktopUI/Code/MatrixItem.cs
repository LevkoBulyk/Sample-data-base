using Sample.Entities;

namespace Sample.DesktopUI
{
    public class MatrixItem
    {
        public double Percentage { get; set; }
        public Matrix Matrix { get; set; }

        public MatrixItem()
        {
            this.Matrix = new Matrix();
        }

        public MatrixItem(Matrix matrix)
        {
            this.Matrix = matrix;
        }

        public override string ToString()
        {
            return this.Matrix.Name;
        }
    }
}
