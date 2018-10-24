using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CDay1023
{
    class Car
    {
        public string  chePai;
        public string name;
        public string color;
        public int  money;
        public string carName;

        public  void red()
        {
            Console.WriteLine("车牌号{0}闯红灯了，扣6分", chePai);
        }

        public  void moneyBuy()
        {
            Console.WriteLine("我的{0}车买的时候{1}钱", name, money);
        }
        public  void desploy()
        {
            Console.WriteLine("车牌是{0}，品牌是{1}，颜色是{2}",chePai ,carName ,color );
        }
        
    }
}
