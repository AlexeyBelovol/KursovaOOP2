using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class Team
    {
        public string Name { get; set; }

        public Team(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
