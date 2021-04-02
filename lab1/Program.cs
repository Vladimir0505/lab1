using System;
using System.Collections.Generic;
using System.Linq;

namespace lab1
{
    public class Person
    {
        public string Name { get; }
        public int Id { get; set; }
        public string Cours { get; set; }

        public override string ToString()
        {
            if (string.IsNullOrWhiteSpace(Name) && Name.Length > 0)
                return base.ToString();
            return Name + "\t" + Id + "\t" + Cours;
        }
        public Person(string name, int id, string cours)
        {
            this.Name = name;
            this.Id = id;
            this.Cours = cours;
        }
    }
    public class Student : Person
    {
        int Reitengresult { get; set; } = 0;
        int Reiting { get; set; }
        double ppf { get; set; }
        public Student(string name, int id, string cours) : base(name, id, cours)
        {

        }
        public int Evaluation()
        {
            Random n = new Random();
            Reiting = n.Next(60, 100);
            return Reiting;
        }
        public int Merfkdv()
        {
            Reitengresult += Reiting;
            return Reitengresult;
        }
        public double PPf()
        {
            ppf += Reiting;
            return ppf / 10;
        }
        public int[] ReitingMasss()
        {
            int[] ReitingMass = new int[10];
            for (int i = 0; i < ReitingMass.Length; i++)
                ReitingMass[i] += Evaluation();
            return ReitingMass;
        }
        public int Rasg()
        {
            foreach (var item in ReitingMasss())
            {
                Reiting = item;
            }
            return Reiting;
        }
        string[] subject = new string[] { "Algebra", "English", "History", "Biology", "Chemistry",
                        "Geometry", "Musica", "Adeptness", "Health", "Literture" };
        public string this[int numberg]
        {
            get
            {
                return subject[numberg];
            }
        }
        static void Main(string[] args)
        {
            Student student1 = new Student("Vlall", 1, "5");
            Student student2 = new Student("lolo", 1, "2");
            Console.WriteLine($"{student1} \t {student2}");
            for (int i = 0; i < 10; i++)
            {
                student1.Merfkdv(); student2.Merfkdv(); student1.PPf(); student2.PPf();
                Console.WriteLine($"Student №1 {student1[i]} = {student1.Rasg()}   \t  Student №2 {student2[i]} = {student2.Rasg()}");
            }
                Console.WriteLine($"Балы первого и второго студента { student1.Merfkdv()}\t{ student2.Merfkdv()} ");
                Console.WriteLine($"Средний балл первого и втогоро  {student1.PPf()}\t{student2.PPf()}");


        }
    }
}