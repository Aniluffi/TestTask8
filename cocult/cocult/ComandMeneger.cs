using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cocult
{
    /// <summary>
    /// класс для работы с командами
    /// </summary>
    class ComandMeneger
    {
        /// <summary>
        /// поле для хранения команд
        /// </summary>
        private Dictionary<int,Action> _comands = new Dictionary<int,Action>();

        /// <summary>
        /// метод для регистрирования команд
        /// </summary>
        /// <param name="n">ключ команды</param>
        /// <param name="comand">команда</param>
        public void ComandRegister(int n,Action comand)
        {
            _comands[n] = comand;
        }

        /// <summary>
        /// метод для запуска команды по ключу
        /// </summary>
        /// <param name="comand">ключ команды</param>
        public void Ex(int comand)
        {
            if (_comands.TryGetValue(comand, out var action))
            {
                action();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Ошибка при вводе!\n");
            }
        }
    }
}
