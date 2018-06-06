using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baseball
{
    class CricketPlayer
    {
        public void TakeTurn(IBaseballBat bat)
        {
            bat.Swing();
        }
    }
}
