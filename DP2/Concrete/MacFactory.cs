using DP2.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP2.Concrete
{
    public class MacFactory : IGUIFactory
    {
        public Button CreateButton() => new MacButton();

        public Checkbox CreateCheckbox() => new MacCheckbox();

    }
}
