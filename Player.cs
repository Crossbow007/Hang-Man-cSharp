using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalHangMan
{
    class Player
    {
      
       
            public string firstName { get; set; }
            public string lastName { get; set; }
            public string postalCode { get; set; }
            public int noWin { get; }
            public int noLoss { get; }

        public Player(string initialFirstName, string initialLastName, string initialPostalCode)
            {
                firstName = initialFirstName;
                lastName = initialLastName;
                postalCode = initialPostalCode;
                noWin = 0;
                noLoss = 0;
            }
        
    }
}
