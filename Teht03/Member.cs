using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht03
{
    class Member
    {
        public string Name { get; set; }
        public string ID { get; set; }
        public string Privilege { get; set; } 

        public override string ToString()
        {
            return "Name : " + Name + " ID: " + ID;
        }
    }
}
