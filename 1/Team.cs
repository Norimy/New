using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    internal class Team
    {
        int Teamld;
        public string Name, Abbr, Logo;


        public void setTeamall(int Teamld, string Name, string Abbr, string Logo)
        {
            this.Teamld = Teamld;
            this.Name = Name;
            this.Abbr = Abbr;
            this.Logo = Logo;
        }
    }
}
