using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dbex
{
    internal class Admin:AttendeeInterface
    {
        public Admin(int id, string name, string role) : base(id, name, role)
        {

        }
    }
}
