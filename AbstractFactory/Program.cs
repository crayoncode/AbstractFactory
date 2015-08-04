using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            //南昌工厂制作
            AbstractFactory nanChangFactory = new NanChangFactory();
            YaBo nanChangYabo = nanChangFactory.CreateYaBo();
            nanChangYabo.Print();
            YaJia nanChangYajia= nanChangFactory.CreateYaJia();
            nanChangYajia.Print();


             // 上海工厂制作上海的鸭脖和鸭架
              AbstractFactory shangHaiFactory = new ShangHaiFactory();
              shangHaiFactory.CreateYaBo().Print();
              shangHaiFactory.CreateYaJia().Print();
            Console.ReadKey();
        }
    }
}
