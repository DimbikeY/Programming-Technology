using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClass
{
    class Publisher
    {
        struct LicenseNumber // в виде структуры
        {
            public int licenseNumber;
            public DateTime data;

            public override string ToString()
            {
                string s = String.Format("Лиценщия N-{0} от {1} г.", licenseNumber, data.Year);
                return s;
            }
        }
        public string Name { get; set; } 
        public string EmailAdress { get; set; }
        private LicenseNumber LinNumber;
        
        public Publisher(string name, string emailAdress, int lnumber, DateTime data)
        {
            Name = name;
            EmailAdress = emailAdress;
            LinNumber.licenseNumber = lnumber; // структура
            LinNumber.data = data;
        }
        public override string ToString()
        {
            string s = String.Format(": {0}, электронный адрес: {1}, {2}", Name, EmailAdress, LinNumber);
            return s;
        }
    }
}
