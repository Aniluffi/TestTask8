using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cocult
{
    /// <summary>
    /// интерфейс методов для класса Comands
    /// </summary>
    interface IComand
    {
        /// <summary>
        /// метод для нахождения площади квадрата
        /// </summary>
        /// <param name="n">сторона квадрата</param>
        /// <returns>площадь квадрата</returns>
        double SSquare(double n);
        /// <summary>
        /// метод для нахождения периметра квадрата
        /// </summary>
        /// <param name="n">сторона квадрата</param>
        /// <returns>периметр квадрата</returns>
        double PSquare(double n);

        /// <summary>
        /// метод для нахождения площади прямоугольника
        /// </summary>
        /// <param name="a">сторона 1 прямоугольника</param>
        /// <param name="b">сторона 2 прямоугольника</param>
        /// <returns>площадь прямоугольника</returns>
        double SRectangle(double a,double b);
        /// <summary>
        /// метод для нахождения периметра прямоугольника
        /// </summary>
        /// <param name="a">сторона 1 прямоугольника</param>
        /// <param name="b">сторона 2 прямоугольника</param>
        /// <returns>периметр прямоугольника</returns>
        double PRectangle(double a, double b);

        /// <summary>
        /// метод для нахождения площади треугольника
        /// </summary>
        /// <param name="a">сторона 1</param>
        /// <param name="b">сторона 2</param>
        /// <param name="c">сторона 3</param>
        /// <returns>площадь</returns>
        double STringle(double a, double b,double c);
        /// <summary>
        /// метод для нахождения периметра треугольника
        /// </summary>
        /// <param name="a">сторона 1</param>
        /// <param name="b">сторона 2</param>
        /// <param name="c">сторона 3</param>
        /// <returns>периметр</returns>
        double PTringle(double a, double b, double c);

        /// <summary>
        /// метод для нахождения площади круга
        /// </summary>
        /// <param name="r">радиус</param>
        /// <returns>площадь</returns>
        double SCircle(double r);
        /// <summary>
        /// метод для нахождения периметр круга
        /// </summary>
        /// <param name="r">радиус</param>
        /// <returns>периметр</returns>
        double PCircle(double r);

        /// <summary>
        /// метод для нахождения площади мнгоугольника
        /// </summary>
        /// <param name="n">колличество вершин</param>
        /// <returns>площадь</returns>
        double SPolygon(int n);
        /// <summary>
        /// метод для нахождения периметр мнгоугольника
        /// </summary>
        /// <param name="n">колличество вершин</param>
        /// <returns>периметр</returns>
        double PPolygon(int n);

        /// <summary>
        /// Метод для получения суммы всех площадей
        /// </summary>
        /// <returns>возращает сумму всех площадей</returns>
        double SumAllP();
        /// <summary>
        /// метод для суммы всех периметров
        /// </summary>
        /// <returns>возращает сумму всех периметров</returns>
        double SumAllS();

        /// <summary>
        /// метод для получения всех введенных фигур
        /// </summary>
        /// <returns>введенные фигуры</returns>
        string ListInputFigure();

        /// <summary>
        /// метод для вычисления суммы площадей квадратов
        /// </summary>
        /// <returns>сумма площадей квадратов</returns>
        double SumSSquare();
        /// <summary>
        /// метод для вычисления суммы периметров квадратов
        /// </summary>
        /// <returns>сумма периметров квадратов</returns>
        double SumPSquare();

        /// <summary>
        /// метод для вычисления суммы площадей прямоугольников
        /// </summary>
        /// <returns>сумма площадей прямоугольников</returns>
        double SumSRectangle();
        /// <summary>
        /// метод для вычисления суммы периметров прямоугольников
        /// </summary>
        /// <returns>сумма периметров прямоугольников</returns>
        double SumPRectangle();

        /// <summary>
        /// метод для вычисления суммы площадей треугольников
        /// </summary>
        /// <returns>сумма площадей треугольников</returns>
        double SumSTringle();
        /// <summary>
        /// метод для вычисления суммы периметров треугольников
        /// </summary>
        /// <returns>сумма периметров треугольников</returns>
        double SumPTringle();

        /// <summary>
        /// метод для вычисления суммы площадей кругов
        /// </summary>
        /// <returns>сумма площадей  кругов</returns>
        double SumSCircle();
        /// <summary>
        /// метод для вычисления суммы периметров кругов
        /// </summary>
        /// <returns>сумма периметров кругов</returns>
        double SumPCircle();

        /// <summary>
        /// метод для подсчета суммы площади всех многоугольников
        /// </summary>
        /// <returns>сумма всех площади многоугольников</returns>
        double SumSPolygon();
        /// <summary>
        /// метод для подсчета суммы периметров всех многоугольников
        /// </summary>
        /// <returns>сумма всех периметров многоугольников</returns>
        double SumPPolygon();

        /// <summary>
        /// метод для выхода из приложения
        /// </summary>
        void Exit();
    }
}
