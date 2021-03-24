using System;
using System.Collections.Generic;

namespace ConsoleApp3 {
    class Entry
    {
        static void Main(string[] args)
        {
            var p = new Program();
            var s = p.pakowanie(20, 2, 2);
            System.Console.WriteLine(s);
            Console.ReadLine();
        }
    }
    public class Program
    {
        public string pakowanie(int capacity, int n, int seed)
        {
            int sumWeight = 0, sumValue = 0;

        //    Console.Write("Podaj pojemnosc plecaka: ");
         //   capacity = Convert.ToInt32(Console.ReadLine());
        //    Console.Write("Podaj ilosc przedmiotow: ");
          //  n = Convert.ToInt32(Console.ReadLine());
         //   Console.Write("Podaj ziarno: ");
           // seed = Convert.ToInt32(Console.ReadLine());
          //  Console.WriteLine("c {0} s {1} n {2}", capacity, seed, n);

            RandomNumberGenerator rand = new RandomNumberGenerator(seed);

            // tworzenie przedmiotow
            Item[] itemArray = new Item[n];

            for (int i = 0; i < n; i++)
            {
                itemArray[i] = new Item();
                itemArray[i].value = rand.nextInt(1, 29);
                itemArray[i].weight = rand.nextInt(1, 29);
            }

         //   for (int i = 0; i < n; i++)
         //   {
          //      Console.WriteLine(" przedmiot {0} wartosc {1} waga {2}", i, itemArray[i].value, itemArray[i].weight);
          //  }

            //implementacja algorytmu naiwnego
            List<int> packedItems = new List<int>();

            for (int i = 0; i < n; i++)
            {
                if (sumWeight + itemArray[i].weight > capacity) break;
                else
                {
                    packedItems.Add(i);
                    sumValue += itemArray[i].value;
                    sumWeight += itemArray[i].weight;
                }
            }

            // wypisanie zapakowanych przedmiotow
           // Console.WriteLine();
          //  Console.WriteLine(" zapakowane przedmioty: ");
          //  for (int i = 0; i < packedItems.Count; i++)
           // {
           //     Console.WriteLine(" przedmiot {0} waga {1} wartosc {2}", packedItems[i], itemArray[packedItems[i]].value, itemArray[packedItems[i]].weight);
         //   }
         //   Console.WriteLine(" lacznna waga {0} laczna wartosc {1}", sumWeight, sumValue);
            return $"Summary weight: {sumWeight}, summary value: {sumValue}";
        }
    }
}