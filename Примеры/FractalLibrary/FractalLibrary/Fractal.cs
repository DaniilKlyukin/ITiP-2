using System.Drawing;

namespace FractalLibrary
{
    public class Fractal
    {
        /// <summary>
        /// Фрактал
        /// </summary>
        /// <param name="centerX">Координата X центра комплексной области</param>
        /// <param name="centerY">Координата Y центра комплексной области</param>
        /// <param name="width">Ширина комплексной области</param>
        /// <param name="rows">Количество строк сетки</param>
        /// <param name="columns">Количество столбцов сетки</param>
        public Fractal(double centerX, double centerY, double width, int rows, int columns)
        {
            CenterX = centerX;
            CenterY = centerY;
            Width = width;
            Rows = rows;
            Columns = columns;
        }

        // Координата X центра комплексной области
        public double CenterX { get; }

        // Координата Y центра комплексной области
        public double CenterY { get; }

        // Ширина комплексной области
        public double Width { get; }

        // Высота комплексной области, рассчитывается автоматически пропорционально ширине
        public double Height => Width * Rows / Columns;

        // Количество строк сетки
        public int Rows { get; }

        // Количество столбцов сетки
        public int Columns { get; }

        /// <summary>
        /// Рассчитать значения (количество итераций) в каждой ячейке
        /// </summary>
        /// <returns></returns>
        public double[,] Calculate()
        {
            var values = new double[Rows, Columns];

            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    var x = Width * j / (Columns - 1);
                    var y = // TODO самостоятельно

                    var iterations = 0;

                    // TODO Вычислить по формулам количество итераций для заданной точки

                    values[i, j] = iterations;
                }
            }

            return values;
        }
    }

    /// <summary>
    /// Класс для перевода сеточных значений ячеек в цвета
    /// </summary>
    public abstract class Painter
    {
        public abstract Color[,] Paint(double[,] gridValues);
    }

    /// <summary>
    /// Класс для перевода сеточных значений ячеек в ЧБ цвета
    /// </summary>
    public class GrayScalePainter : Painter
    {
        public override Color[,] Paint(double[,] gridValues)
        {
            // TODO Для перевода можно найти минимальное и максимальное количество итераций, значение цвета = 255*(количество итераций в ячейке - мин) / (макс - мин)
        }
    }
}
