using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baseball
{
    class Program
    {
        static void Main(string[] args)
        {
            var woodenBat = new WoodenBat();
            var aluminumBat = new AluminumBat();
            var compositeBat = new CompositeBat();
            //var hank = new BaseballPlayer();
            //var seamus = new BaseballPlayer();
            var ernest = new CricketPlayer();
            

            //seamus.TakeTurn(woodenBat);
            //seamus.TakeTurn(aluminumBat);
            //seamus.TakeTurn(compositeBat);
            //hank.TakeTurn(woodenBat);
            //hank.TakeTurn(aluminumBat);
            //hank.TakeTurn(compositeBat);
            ernest.TakeTurn(woodenBat);
            ernest.TakeTurn(aluminumBat);
            ernest.TakeTurn(compositeBat);

        }
    }
}
