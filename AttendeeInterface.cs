using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dbex
{
    internal class AttendeeInterface
    {
        private int id;
        private string name;
        private string role;

        public AttendeeInterface(int id, string name, string role)
        {
            this.id = id;
            this.name = name;
            this.role = role;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Role { get => role; set => role = value; }

    }
}
