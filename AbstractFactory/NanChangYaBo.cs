using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    /// <summary>
    /// 南昌的鸭脖类，因为江西人喜欢吃辣的，所以南昌的鸭脖稍微会比上海做的辣
    /// </summary>
    public class NanChangYaBo:YaBo
    {
        public override void Print()
        {
            Console.WriteLine("南昌的鸭脖");
        }
    }
}
