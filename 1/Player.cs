using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    internal class Player
    {
        Char PlayerId;
        String LastName;
        String FirstName;
        Char Gender;
        Decimal Height;
        Decimal Weidth;
        String ShirtNumber;
        String Email;
        Char CountryCode;
        int TeamId;

        public void setPlayerCode(Char playerId)
        {
            this.PlayerId  = playerId;
        }

        public void setPlayerCode(String LastName)
        {
            this.LastName = LastName;
        }

       
    }
}
