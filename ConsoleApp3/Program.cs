using System;
using System.Collections.Generic;

namespace ConsoleApp3 {
    class Entry
    {
        static void Main(string[] args)
        {
            var p = new Program();
            var s = p.pakowanie(2, 200, 3);
            System.Console.WriteLine(s);
            Console.ReadLine();
        }
    }
    public class Program
    {
        public string pakowanie(int capacity, int n, int seed)
        {
            int sumWeight = 0, sumValue = 0;

            RandomNumberGenerator rand = new RandomNumberGenerator(seed);

            // tworzenie przedmiotow
            Item[] itemArray = new Item[n];

            for (int i = 0; i < n; i++)
            {
                itemArray[i] = new Item();
                itemArray[i].value = rand.nextInt(1, 29);
                itemArray[i].weight = rand.nextInt(1, 29);
            }


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

            return $"Summary weight: {sumWeight}, summary value: {sumValue}";
        }
    }
}