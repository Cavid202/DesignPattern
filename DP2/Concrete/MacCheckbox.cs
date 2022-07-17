using DP2.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP2.Concrete
{
    public class MacCheckbox : Checkbox
    {
        public override void Select() => Console.WriteLine("Selected Mac Checkbox");

        public override void UnSelect() => Console.WriteLine("UnSelected Mac Checkbox");

        public override void Render() => Console.WriteLine("Rendered Mac Checkbox");
    }
}
