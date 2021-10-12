using System;

namespace Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lemon lemon = new Lemon("Lemon", 'C');
            //Apple apple = new Apple("Apple", 'C');
            //Pineapple pineapple = new Pineapple("Pineapple", 'C');

            //BasketList<Base> basketlist = new BasketList<Base>();

            //basketlist.Add(lemon);
            //basketlist.Add(apple);
            //basketlist.Add(pineapple);

            //Console.WriteLine(basketlist.Count);
            //Console.WriteLine("Fruits: ");

            //foreach (var item in basketlist.GetArray())
            //{
            //    Console.WriteLine(item.Name);
            //    Console.WriteLine(item.Vitamin);
            //}


            Fruits fruits1 = new Fruits("Apple", 'C');
            Fruits fruits2 = new Fruits("Pineapple", 'C');
            Fruits fruits3 = new Fruits("Lemon", 'C');

            BasketList<Fruits> basketlist = new BasketList<Fruits>();

            basketlist.Add(fruits1);
            basketlist.Add(fruits2);
            basketlist.Add(fruits3);

            Console.WriteLine(basketlist.Count);
            Console.WriteLine("Fruits: ");

            foreach (var item in basketlist.GetArray())
            {
                Console.WriteLine(item.Name);
                Console.WriteLine(item.Vitamin);
            }
        }
    }
}
