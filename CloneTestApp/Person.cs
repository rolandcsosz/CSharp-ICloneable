using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloneTestApp
{
    class Person:ICloneable
    {
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public int Age { get; set; }
        public Address Address { get; set; }

        override
        public String ToString()
        {
            return $"[{GetHashCode()}] : first name: {FirstName}; last name: {LastName}; age: {Age}; [{Address.GetHashCode()}] : adress: {Address}";
        }
        public object Clone()
        {
            return new Person()
            {
                FirstName = this.FirstName,
                LastName = this.LastName,
                Age = this.Age,
                Address = (Address)this.Address.Clone()
            
        };
        }
    }
}
