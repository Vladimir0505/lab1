using System;
using System.Collections;

namespace LabRob1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new("Vlaod", "1232434", '1');
            Student student2 = new("Lolo",  "1323225", '5');
            Console.WriteLine($"{student1} \t {student2}");
            for (int i = 0; i < 10; i++)
            {
                student1.SumReiting(); student2.SumReiting(); student1.SrReiting(); student2.SrReiting();
                Console.WriteLine($"Student №1 {student1[i]} = {student1.ReitingMasss()}  \t Student №2 {student2[i]} = {student2.ReitingMasss()}");
               
            }
            Console.WriteLine($"{ student1.SumReiting()} {student1.SrReiting()} {student2.SumReiting()} {student2.SrReiting()} ");
            



        }
    }
}
