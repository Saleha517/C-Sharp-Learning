using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Class_08
{
    internal class Student
    {
        public int id;
        public string name;
        public string Batch_Code;


        public Student(int Id , string Name , string Batch)
        {
            this.id = Id ;
            this.name = Name ;
            this.Batch_Code = Batch ;

        }

        public void Display()
        {
            Console.WriteLine($"StudentID: {id} , Name: {name} , Batch: {Batch_Code}");
        }
    }
}
