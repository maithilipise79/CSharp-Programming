using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionProject.Entity
{
    public class Teacher: IComparable<Teacher>
    {
        public string Name { get; set; }
        public string Subject {  get; set; }
        public int Experiance {  get; set; }

        public Teacher() { }
        public Teacher(string name, string subject, int experiance)
        {
            Name = name;
            this.Subject = subject;
            Experiance = experiance;
        }

        public override string ToString()
        {
            return $"Name :{Name} , Subject :{Subject} ,Experiance :{Experiance}";
        }

        public int CompareTo(Teacher? other)
        {
            return this.Experiance.CompareTo(other.Experiance);
        }
    }
}
