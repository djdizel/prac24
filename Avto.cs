using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac24
{
    internal class Avto
    {
        /// <summary>
        /// скрытые поля
        /// </summary>
        string brand;
        string color;
        double skor;
        /// <summary>
        /// Инкапсуляция полей
        /// </summary>
        public string Brand { get { return brand;} set { brand = value; } }
        public string Color { get { return color; } set { color = value; } }
        public double Skor { get { return skor; } set { if (value < 20) { skor = 20; } else if (value > 120) { skor = 120; } else { skor = value; } } }
        /// <summary>
        /// Конструктор без параметров
        /// </summary>
        public Avto() { }
        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        /// <param name="brand"></param>
        /// <param name="color"></param>
        /// <param name="skor"></param>
        public Avto(string brand, string color, double skor) 
        { 
        this.Brand = brand;
        this.Color = color;
        this.Skor = skor;
        }
        /// <summary>
        /// метод для вывода значений об объекте.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Brand = {Brand}, Color = {Color}, Skor = {Skor}";
        }
    }
}
