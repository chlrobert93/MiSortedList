using System;
using System.Collections;


namespace MiSortedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedList lista = new SortedList();
            
            lista.Add(4, "Cuarto");
            lista.Add(2, "Segundo");
            lista.Add(3, "Tercero");
            lista.Add(1, "Primero");

            foreach (object clave in lista.Keys)
            {
                Console.WriteLine("{0} - {1}", clave.ToString(), lista[clave].ToString());

            }

            Console.ReadKey();


        }
    }
}
