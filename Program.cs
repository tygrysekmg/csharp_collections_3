using System;
using System.Collections.Generic;


namespace helloworld
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string> { "<name>", "Ana", "Felipe" };
           
           
            Console.WriteLine();
            names.Add("Maria");
            names.Add("Bill");
            names.Remove("Ana");
            foreach (var name in names)
            {
            var index = names.IndexOf("Felipe");
             var notFound = names.IndexOf("Not Found");
             if (index != -1)
              Console.WriteLine($"The name {names[index]} is at index {index}");


              Console.WriteLine($"When an item is not found, IndexOf returns {notFound}");
              

            }

     names.Sort();
foreach (var name in names)
{
  Console.WriteLine($"Hello {name.ToUpper()}!");
}

         }
    }
}
