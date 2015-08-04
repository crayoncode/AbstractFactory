using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    /// <summary>
    /// 南昌的鸭架
    /// </summary>
    public class NanChangYaJia:YaJia 
    {
        public override void Print()
        {
            Console.WriteLine("南昌的鸭架子");
        }
    }
}
