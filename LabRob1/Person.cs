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
        internal string Id { get; }
        internal char Cours { get; }   
        public override string ToString()
        {
            if (string.IsNullOrWhiteSpace(Name))
                throw new Exception("Имя не должно быть пустым");
            foreach (char c in Name)
                if (char.IsNumber(c)||char.IsWhiteSpace(c)) 
                    throw new Exception("В имени есть числа или пробелы");

            if (char.IsWhiteSpace(Cours)||Cours<='0'||Cours>'5')
                    throw new Exception("Курс не должен быть пустым и иметь значения от 1 до 5");
            foreach (char i in Id)

                if (char.IsWhiteSpace(i)||Id.Length!=7)
                    throw new Exception("В зачетной книге должно быть 7 чимволов и не должно быть пробелов ");
            return Name +"\t"+ Cours + "\t" + Id;
            
        }
         
        public Person(string name, string id, char cours)
        {
            this.Name = name;
            this.Id = id;
            this.Cours = cours;
        }
    }
}
