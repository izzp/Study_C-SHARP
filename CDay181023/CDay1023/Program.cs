using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CDay1023
{
    class Program
    {
        static void Main(string[] args)
        {
            Car haHa=new Car() ;
            haHa.chePai = "冀A88888";
            haHa .carName="别克君威";
            haHa.color = "红色";
            haHa.money = 200000;
            haHa.red();
            haHa.desploy();
            Car haH = new Car();
            haH.chePai = "冀A66666";
            haH.carName  = "大众迈腾";
            haH.color = "银色";
            haH.money = 180000;
            haH.red();
            haH.desploy();
        }
    }
}
