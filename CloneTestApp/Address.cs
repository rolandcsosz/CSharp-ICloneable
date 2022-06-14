using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloneTestApp
{
    class Address : ICloneable
    {
        public String Country { get; set; }
        public String City { get; set; }

        public String PostalCode { get; set; }
        public String Street { get; set; }

        public object Clone()
        {
            return new Address()
            {
                Country = this.Country,
                City = this.City,
                PostalCode = this.PostalCode,
                Street = this.Street
            };
        }

        override
        public String ToString()
        {
            return $"{Country},{City},{PostalCode},{Street}";
        }

    }
}
