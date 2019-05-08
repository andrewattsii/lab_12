using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_12
{
    class Staff : Person
    {
        private string school;
        private double pay;


        public Staff(string _name, string _address, string _school, double _pay):base(_name, _address)
        {
            school = _school;
            pay = _pay;
        }
        public Staff()
        {

        }
        public override string ToString()
        {
            return ($" {base.ToString()}\n School : {school}\n Pay : {pay}");
        }

    }
}
