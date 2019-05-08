using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_12
{
    class Person
    {
        private string name;
        private string address;


      
        public Person(string _name, string _address)
        {
            name = _name;
            address = _address;
        }
        public Person()
        {

        }
        public override string ToString()
        {
            return ($" Name :{name} \n Address : {address} ");
            
        }






    }
}
