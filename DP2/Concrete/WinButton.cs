using DP2.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP2.Concrete
{
    public class WinButton : Button
    {
        public override void Click() => Console.WriteLine("Click Button");

        public override void DoubleClick() => Console.WriteLine("Double Click  Button");

        public override void Render() => Console.WriteLine("Render Button");
    }
}
