using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cocult
{
    /// <summary>
    /// класс для работы с приложением
    /// </summary>
    class App:ComandsApp
    {
        /// <summary>
        /// список для хранения данных о введенных фигурах 
        /// </summary>
        private ListFigure<Figure> _listEnteredShapes = new ListFigure<Figure>();

        /// <summary>
        /// поле которое управляет командами
        /// </summary>
        ComandMeneger _comandMeneger = new ComandMeneger();

        /// <summary>
        /// конструктор, который добавляет команды
        /// </summary>
        public App()
        {
            AddComand();
        }

        /// <summary>
        /// метод который запускает программу
        /// </summary>
        public void Run()
        {
            while (true)
            {
                Console.WriteLine("\n1 - квадрат, вводим сторону одну" +
                    "\n2 - прямоугольник, вводим два стороны" +
                    "\n3 - Круг, вводим радиус" +
                    "\n4 - треугольник, вводим три стороны" +
                    "\n5 - многоугольник" +
                    "\n6 - вывести сумму всех периметров" +
                    "\n7 - вывести сумму всех площадей" +
                    "\n8 - вывод списка всех фигур ранее введенных" +
                    "\n9 - вывод суммы площадей всех квадратов" +
                    "\n10 - вывод суммы площадей всех кругов" +
                    "\n11 - вывод суммы площадей всех прямоугольников" +
                    "\n12 - вывод суммы площадей всех треугольников" +
                    "\n13 - вывод суммы площадей всех многоугольников" +
                    "\n14 - вывод суммы периметров всех квадратов" +
                    "\n15 - вывод суммы периметров всех кругов" +
                    "\n16 - вывод суммы периметров всех прямоугольников" +
                    "\n17 - вывод суммы периметров всех треугольников" +
                    "\n18 - вывод суммы периметров всех многоугольников" +
                    "\n19 - выйти из программы\n");

                Console.WriteLine("Введите номер действия:");

                _comandMeneger.Ex(Convert.ToInt32(Console.ReadLine()));
            }
        }

        /// <summary>
        /// метод добавляющий команды
        /// </summary>
        private void AddComand()
        {
            _comandMeneger.ComandRegister(1,Square);
            _comandMeneger.ComandRegister(2,Rectangle);
            _comandMeneger.ComandRegister(3,Circle);
            _comandMeneger.ComandRegister(4,Tringle);
            _comandMeneger.ComandRegister(5,Polygon);
            _comandMeneger.ComandRegister(6,AllP);
            _comandMeneger.ComandRegister(7,AllS);
            _comandMeneger.ComandRegister(8,PrintEnteredShapes);
            _comandMeneger.ComandRegister(9,PrintSumSSquare);
            _comandMeneger.ComandRegister(10,PrintSumSCircle);
            _comandMeneger.ComandRegister(11,PrintSumSRectangle);
            _comandMeneger.ComandRegister(12,PrintSumSTriangle);
            _comandMeneger.ComandRegister(13,PrintSumSPolygon);
            _comandMeneger.ComandRegister(14, PrintSumPSquare);
            _comandMeneger.ComandRegister(15, PrintSumPCircle);
            _comandMeneger.ComandRegister(16, PrintSumPRectangle);
            _comandMeneger.ComandRegister(17, PrintSumPTriangle);
            _comandMeneger.ComandRegister(18, PrintSumPPolygon);
            _comandMeneger.ComandRegister(19, AppExit);
        }
    }
}
