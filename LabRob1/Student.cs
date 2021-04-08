using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabRob1
{
    internal class Student : Person
    {
        private int Reitengresult { get; set; } = 0;
        private int Reiting { get; set; }
        private double Srreiting { get; set; }
        internal Student(string name, int id, string cours) : base(name, id, cours)
        {

        }
        public int Evaluation()
        {
            Random n = new();
            Reiting = n.Next(60, 100);
            return Reiting;
        }
        internal int SumReiting()
        {
            Reitengresult += Reiting;
            return Reitengresult;
        }
        internal double SrReiting()
        {
            Srreiting += Reiting;
            return Srreiting / 10;
        }
        public int[] ReitingMasss()
        {
            int[] ReitingMass = new int[10];
            for (int i = 0; i < ReitingMass.Length; i++)
            {
                ReitingMass[i] += Evaluation();
            }
            return ReitingMass;
        }
        internal string[] subject = new[] { "Algebra", "English", "History", "Biology", "Chemistry",
                        "Geometry", "Musica", "Adeptness", "Health", "Literture"  };
        internal virtual string this[int numberg]
        {
            get
            {
                return subject[numberg];
            }
        }
        

    }
}
