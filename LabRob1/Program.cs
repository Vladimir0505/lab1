using System;
using System.Collections;

namespace LabRob1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new("Vlaod", 1, "5");
            Student student2 = new("Lolo", 1, "2");
            Console.WriteLine($"{student1} \t {student2}");
            for (int i = 0; i < 10; i++)
            {
                //student1.SumReiting(); student2.SumReiting(); student1.SrReiting(); student2.SrReiting();
                Console.WriteLine($"Student №1 {student1[i]}" +
                    $"  \t Student №2 {student2[i]}");
            }
            Console.WriteLine($"Балы первого и второго студента { student1.SumReiting()}\t{ student2.SumReiting()} ");
            Console.WriteLine($"Средний балл первого и втогоро  {student1.SrReiting()}\t{student2.SrReiting()}");
            


        }
    }
}
