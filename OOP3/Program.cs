using OOP3_IDZ_LIB;
namespace ЛР3_ИДЗ
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrix matrix = new Matrix(3, 3);
            Matrix.PrintMatrix(matrix);
            Matrix.GetMinMax(matrix);
            Matrix.PrintResultMatrix(matrix);
        }
    }
}