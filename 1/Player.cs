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

        public void setPlayerall(Char playerId, String LastName,String FirstName,Char Gender,Decimal Height,Decimal Weidth,String ShirtNumber,String Email,Char CountryCode,int TeamId)
        {
            this.PlayerId  = playerId;
            this.LastName = LastName;
            this.FirstName = FirstName;
            this.Gender = Gender;
            this.Height = Height;
            this.Weidth = Weidth;
            this.ShirtNumber = ShirtNumber;
            this.Email = Email;
            this.CountryCode = CountryCode;
            this.TeamId = TeamId;
        }

        

       
    }
}
