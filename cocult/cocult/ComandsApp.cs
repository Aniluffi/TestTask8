using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cocult
{
    /// <summary>
    /// метод хранящий команды приложения
    /// </summary>
    class ComandsApp : Comands
    {
        /// <summary>
        /// команда для работы с квадратом
        /// </summary>
        public void Square()
        {
            Console.Clear();

            Console.WriteLine("Введите сторону квадрата:");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Вы желаете найти S(1) или P(2)");

            if (Convert.ToInt32(Console.ReadLine()) == 1) Console.WriteLine($"S = {SSquare(a)}");
            else Console.WriteLine($"P = {PSquare(a)}");
        }

        /// <summary>
        /// команда для работы с прямоугольником
        /// </summary>
        public void Rectangle()
        {
            Console.Clear();

            Console.WriteLine("Введите сторону1 прямоугольника:");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите сторону2 прямоугольника:");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Вы желаете найти S(1) или P(2)");

            if (Convert.ToInt32(Console.ReadLine()) == 1) Console.WriteLine($"S = {PRectangle(a, b)}");
            else Console.WriteLine($"P = {PRectangle(a,b)}");
        }

        /// <summary>
        /// команда для работы с кругом
        /// </summary>
        public void Circle()
        {
            Console.Clear();

            Console.WriteLine("Введите радиус круга:");

            double r = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Вы желаете найти S(1) или P(2)");

            if (Convert.ToInt32(Console.ReadLine()) == 1) Console.WriteLine($"S = {SCircle(r)}");
            else Console.WriteLine($"P = {PCircle(r)}");
        }

        /// <summary>
        /// команда для работы с треугольником
        /// </summary>
        public void Tringle()
        {
            Console.Clear();

            Console.WriteLine("Введите сторону1 треугольника:");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите сторону2 треугольника:");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите сторону3 треугольника:");
            double c = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Вы желаете найти S(1) или P(2)");

            if (Convert.ToInt32(Console.ReadLine()) == 1) Console.WriteLine($"S = {STringle(a,b,c)}");
            else Console.WriteLine($"P = {PTringle(a, b, c)}");
        }

        /// <summary>
        /// команда для работы с многоугольником
        /// </summary>
        public void Polygon()
        {
            Console.Clear();

            Console.Write("Введите колличество вершин: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Вы желаете найти S(1) или P(2)");

            if (Convert.ToInt32(Console.ReadLine()) == 1) Console.WriteLine($"S = {SPolygon(n)}");
            else Console.WriteLine($"P = {PPolygon(n)}");
        }

        /// <summary>
        /// команда для вывода суммы всех периметров
        /// </summary>
        public void AllP()
        {
            Console.Clear();
            Console.WriteLine($"Сумма всех P = {SumAllP()}");
        }

        /// <summary>
        /// команда для вывода суммы всех площадей
        /// </summary>
        public void AllS()
        {
            Console.Clear();
            Console.WriteLine($"Сумма всех S = {SumAllS()}");
        }

        /// <summary>
        /// команда для вывода всех введенных фигур
        /// </summary>
        public void PrintEnteredShapes()
        {
            Console.Clear();
            Console.WriteLine($"Список введенных фигур:\n");
            Console.WriteLine(ListInputFigure());
        }

        /// <summary>
        /// команда для вывода суммы всех площадей квадратов
        /// </summary>
        public void PrintSumSSquare()
        {
            Console.Clear();
            Console.WriteLine($"Сумарная площадь квадратов - {SumSSquare()}");
        }

        /// <summary>
        /// команда для вывода суммы всех площадей кругов
        /// </summary>
        public void PrintSumSCircle()
        {
            Console.Clear();
            Console.WriteLine($"Сумарная площадь кругов - {SumSCircle()}");
        }

        /// <summary>
        /// команда для вывода суммы всех площадей прямоугольников
        /// </summary>
        public void PrintSumSRectangle()
        {
            Console.Clear();
            Console.WriteLine($"Сумарная площадь прямоугольников - {SumSRectangle()}");
        }

        /// <summary>
        /// команда для вывода суммы всех площадей треугольников
        /// </summary>
        public void PrintSumSTriangle()
        {
            Console.Clear();
            Console.WriteLine($"Сумарная площадь треугольников - {SumSTringle()}");
        }

        /// <summary>
        /// команда для вывода суммы всех площадей многоугольников
        /// </summary>
        public void PrintSumSPolygon()
        {
            Console.Clear();
            Console.WriteLine($"Сумарная площадь многоугольников - {SumSPolygon()}");
        }

        /// <summary>
        /// команда для вывода суммы всех периметров квадратов
        /// </summary>
        public void PrintSumPSquare()
        {
            Console.Clear();
            Console.WriteLine($"Сумарная периметров квадратов - {SumPSquare()}");
        }

        /// <summary>
        /// команда для вывода суммы всех периметров кругов
        /// </summary>
        public void PrintSumPCircle()
        {
            Console.Clear();
            Console.WriteLine($"Сумарная периметров кругов - {SumPCircle}");
        }

        /// <summary>
        /// команда для вывода суммы всех периметров прямоугольников
        /// </summary>
        public void PrintSumPRectangle()
        {
            Console.Clear();
            Console.WriteLine($"Сумарная периметров прямоугольников - {SumPRectangle()}");
        }

        /// <summary>
        /// команда для вывода суммы всех периметров треугольников
        /// </summary>
        public void PrintSumPTriangle()
        {
            Console.Clear();
            Console.WriteLine($"Сумарная периметров треугольников - {SumPTringle()}");
        }

        /// <summary>
        /// команда для вывода суммы всех периметров многоугольников
        /// </summary>
        public void PrintSumPPolygon()
        {
            Console.Clear();
            Console.WriteLine($"Сумарная периметров многоугольников - {SumPPolygon()}");
        }

        /// <summary>
        /// команда для выхода из приложения
        /// </summary>
        public void AppExit()
        {
            Console.Clear();
            Console.WriteLine($"Программа завершена!");
            Exit();
        }
    }
}
