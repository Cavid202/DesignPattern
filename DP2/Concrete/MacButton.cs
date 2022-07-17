using DP2.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP2.Concrete
{
    public class MacButton : Button
    {
        public override void Click() => Console.WriteLine("Clicked Mac Button");

        public override void DoubleClick() => Console.WriteLine("Double Clicked Mac Button");

        public override void Render() => Console.WriteLine("Rendered Mac Button");
    }
}
