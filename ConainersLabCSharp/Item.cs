using System;
using System.Collections.Generic;
using System.Text;

namespace ConainersLabCSharp
{
    class Item
    {
        private string name { get; set; }
        private double weight { get; set; }
        private string color { get; set; }
        private bool flat { get; set; }
        private bool doesTheItemLieInContainer { get; set; }

        public Item(string Name, double Weight, string Color, bool Flat)
        {
            name = Name;
            weight = Weight;
            color = Color;
            flat = Flat;
            doesTheItemLieInContainer = false;
        }

        public void getInfo()
        {
                Console.WriteLine("Имя: {name} "+  
                $"Вес: {weight} "+
                $"Цвет: { color} " +
                $"Плоскость: { flat} " +
                $"Лежит ли в контэйнерt: { doesTheItemLieInContainer} ");
        }
    }
}
