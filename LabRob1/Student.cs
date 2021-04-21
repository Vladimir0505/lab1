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
        private double Reitengresult { get; set; } = 0;
        private int Reiting { get; set; }
        private double Srreiting { get; set; }
        private int count { get;set; }

        internal Student(string name, string id, char cours) : base(name, id, cours)
        {

        }
        private int Evaluation()
        {
            Random n = new();
            Reiting = n.Next(60, 100);
            return Reiting;
        }
        public double SumReiting()
        {
            Reitengresult += Reiting;
            return Reitengresult;
        }
        public double SrReiting()
        {
            Srreiting += Reiting;
            return Srreiting / count;
        }
        int[] ReitingMass = new int[10];
        public int[] ReitingMasss()
        {
            for (int i = 0; i < ReitingMass.Length; i++)
            {
                ReitingMass[i] = Evaluation();
                count = i;
            }
            count++;
            return ReitingMass;
        }




    }
}
