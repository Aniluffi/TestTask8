using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace cocult
{
    /// <summary>
    /// вспомогательный класс для класса ComandsApp
    /// </summary>
    class Comands : IComand
    {
        /// <summary>
        /// список для хранения данных о введенных фигурах 
        /// </summary>
        private ListFigure<Figure> listEnteredShapes = new ListFigure<Figure>();

        /// <summary>
        /// метод для нахождения площади квадрата
        /// </summary>
        /// <param name="n">сторона квадрата</param>
        /// <returns>площадь квадрата</returns>
        public double SSquare(double n)
        {
            Square sq = new Square(n);
            listEnteredShapes.Add(sq);
            return sq.S();
        }
        /// <summary>
        /// метод для нахождения периметра квадрата
        /// </summary>
        /// <param name="n">сторона квадрата</param>
        /// <returns>периметр квадрата</returns>
        public double PSquare(double n)
        {
            Square sq = new Square(n);
            listEnteredShapes.Add(sq);
            return sq.P();
        }

        /// <summary>
        /// метод для нахождения площади прямоугольника
        /// </summary>
        /// <param name="a">сторона 1 прямоугольника</param>
        /// <param name="b">сторона 2 прямоугольника</param>
        /// <returns>площадь прямоугольника</returns>
        public double SRectangle(double a,double b)
        {
            Rectangle rectangle = new Rectangle(a, b);
            listEnteredShapes.Add(rectangle);
            return rectangle.S();
        }
        /// <summary>
        /// метод для нахождения периметра прямоугольника
        /// </summary>
        /// <param name="a">сторона 1 прямоугольника</param>
        /// <param name="b">сторона 2 прямоугольника</param>
        /// <returns>периметр прямоугольника</returns>
        public double PRectangle(double a, double b)
        {
            Rectangle rectangle = new Rectangle(a, b);
            listEnteredShapes.Add(rectangle);
            return rectangle.S();
        }

        /// <summary>
        /// метод для нахождения площади треугольника
        /// </summary>
        /// <param name="a">сторона 1</param>
        /// <param name="b">сторона 2</param>
        /// <param name="c">сторона 3</param>
        /// <returns>площадь</returns>
        public double STringle(double a, double b, double c)
        {
            Triangle tr = new Triangle(a, b, c);
            listEnteredShapes.Add(tr);
            return tr.S();
        }
        /// <summary>
        /// метод для нахождения периметра треугольника
        /// </summary>
        /// <param name="a">сторона 1</param>
        /// <param name="b">сторона 2</param>
        /// <param name="c">сторона 3</param>
        /// <returns>периметр</returns>
        public double PTringle(double a, double b, double c)
        {
            Triangle tr = new Triangle(a, b, c);
            listEnteredShapes.Add(tr);
            return tr.P();
        }

        /// <summary>
        /// метод для нахождения площади круга
        /// </summary>
        /// <param name="r">радиус</param>
        /// <returns>площадь</returns>
        public double SCircle(double r)
        {
            Circle cir = new Circle(r);
            listEnteredShapes.Add(cir);
            return cir.S();
        }
        /// <summary>
        /// метод для нахождения периметр круга
        /// </summary>
        /// <param name="r">радиус</param>
        /// <returns>периметр</returns>
        public double PCircle(double r)
        {
            Circle cir = new Circle(r);
            listEnteredShapes.Add(cir);
            return cir.P();
        }

        /// <summary>
        /// метод для нахождения площади мнгоугольника
        /// </summary>
        /// <param name="n">колличество вершин</param>
        /// <returns>площадь</returns>
        public double SPolygon(int n)
        {
            Polygon polygon = new Polygon();
            polygon.Input(n);
            listEnteredShapes.Add(polygon);
            return polygon.S();
        }
        /// <summary>
        /// метод для нахождения периметр мнгоугольника
        /// </summary>
        /// <param name="n">колличество вершин</param>
        /// <returns>периметр</returns>
        public double PPolygon(int n)
        {
            Polygon polygon = new Polygon();
            polygon.Input(n);
            listEnteredShapes.Add(polygon);
            return polygon.P();
        }

        /// <summary>
        /// Метод для получения суммы всех площадей
        /// </summary>
        /// <returns>возращает сумму всех площадей</returns>
        public double SumAllP()
        {
            return listEnteredShapes.PType<Figure>();
        }
        /// <summary>
        /// метод для суммы всех периметров
        /// </summary>
        /// <returns>возращает сумму всех периметров</returns>
        public double SumAllS()
        {
            return listEnteredShapes.SType<Figure>();
        }
        /// <summary>
        /// метод для получения всех введенных фигур
        /// </summary>
        /// <returns>введенные фигуры</returns>
        public string ListInputFigure()
        {
            return listEnteredShapes.ToString();
        }

        /// <summary>
        /// метод для вычисления суммы площадей квадратов
        /// </summary>
        /// <returns>сумма площадей квадратов</returns>
        public double SumSSquare()
        {
            return listEnteredShapes.SType<Square>();
        }
        /// <summary>
        /// метод для вычисления суммы периметров квадратов
        /// </summary>
        /// <returns>сумма периметров квадратов</returns>
        public double SumPSquare()
        {
            return listEnteredShapes.PType<Square>();
        }

        /// <summary>
        /// метод для вычисления суммы площадей прямоугольников
        /// </summary>
        /// <returns>сумма площадей прямоугольников</returns>
        public double SumSRectangle()
        {
            return listEnteredShapes.SType<Rectangle>();
        }
        /// <summary>
        /// метод для вычисления суммы периметров прямоугольников
        /// </summary>
        /// <returns>сумма периметров прямоугольников</returns>
        public double SumPRectangle()
        {
            return listEnteredShapes.PType<Rectangle>();
        }

        /// <summary>
        /// метод для вычисления суммы площадей треугольников
        /// </summary>
        /// <returns>сумма площадей треугольников</returns>
        public double SumSTringle()
        {
            return listEnteredShapes.SType<Triangle>();
        }
        /// <summary>
        /// метод для вычисления суммы периметров треугольников
        /// </summary>
        /// <returns>сумма периметров треугольников</returns>
        public double SumPTringle()
        {
            return listEnteredShapes.PType<Triangle>();
        }

        /// <summary>
        /// метод для вычисления суммы площадей кругов
        /// </summary>
        /// <returns>сумма площадей  кругов</returns>
        public double SumSCircle()
        {
            return listEnteredShapes.SType<Circle>();
        }

        /// <summary>
        /// метод для вычисления суммы периметров кругов
        /// </summary>
        /// <returns>сумма периметров кругов</returns>
        public double SumPCircle()
        {
            return listEnteredShapes.PType<Circle>();
        }

        /// <summary>
        /// метод для подсчета суммы площади всех многоугольников
        /// </summary>
        /// <returns>сумма всех площади многоугольников</returns>
        public double SumSPolygon()
        {
            return listEnteredShapes.SType<Polygon>();
        }
        /// <summary>
        /// метод для подсчета суммы периметров всех многоугольников
        /// </summary>
        /// <returns>сумма всех периметров многоугольников</returns>
        public double SumPPolygon()
        {
            return listEnteredShapes.PType<Polygon>();
        }
        /// <summary>
        /// метод для выхода из приложения
        /// </summary>
        public void Exit()
        {
            Environment.Exit(0);
        }
    }
}
