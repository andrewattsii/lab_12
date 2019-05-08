using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_12
{
    class Student : Person
    {
        private int year;
        private double fee;


        public Student(string _name, string _address , int _year, double _fee):base(_name,_address)
        {
            year = _year;
            fee = _fee;
        }
        public Student()
        {

        }
        public override string ToString()
        {
            return ($" {base.ToString()}\n Year : {year}\n Fee : {fee}");
        }




    }
}
