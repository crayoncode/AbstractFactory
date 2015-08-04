using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class ShangHaiFactory:AbstractFactory
    {
        public override YaBo CreateYaBo()
        {
            return new ShangHaiYaBo();
        }

        public override YaJia CreateYaJia()
        {
            return new ShangHaiYaJia();
        }
    }
}
