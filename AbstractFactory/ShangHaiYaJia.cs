using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    /// <summary>
    /// 上海的鸭架
    /// </summary>
     public class ShangHaiYaJia:YaJia 
    {
         public override void Print()
         {
             Console.WriteLine("上海的鸭架子");
         }
    }
}
