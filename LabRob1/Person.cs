using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabRob1
{
    internal class Person
    {
        internal string Name { get; }
        internal int Id { get; }
        internal string Cours { get;}

        public override string ToString()
        {
            if (string.IsNullOrWhiteSpace(Name))
                throw new Exception("Имя не должно быть пустым");
            return Name;
            
        }
        public Person(string name, int id, string cours)
        {
            this.Name = name;
            this.Id = id;
            this.Cours = cours;
        }
    }
}
