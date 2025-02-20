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
        string model;
        string color;
        double skor;
        /// <summary>
        /// Инкапсуляция полей
        /// </summary>
        public string Model { get { if (model == null || model == string.Empty) { return "Неизвестный"; } return model; } set { model = value; } }
        public string Color { get { if (color == null || color == string.Empty) { return "Неизвестный"; } return color; } set { color = value; } }
        public double Skor { get { return skor; } set { if (value < 60) { skor = 60; } else if (value > 150) { skor = 150; } else { skor = value; } } }
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
        public Avto(string model, string color, double skor) 
        { 
        this.Model = model;
        this.Color = color;
        this.Skor = skor;
        }
        /// <summary>
        /// метод для вывода значений об объекте.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Brand = {Model}, Color = {Color}, Skor = {Skor}";
        }
    }
}
