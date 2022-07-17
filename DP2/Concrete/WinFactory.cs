using DP2.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP2.Concrete
{
    public class WinFactory : IGUIFactory
    {
       

        public Button CreateButton() => new WinButton();

        public Checkbox CreateCheckbox() => new WinCheckbox();
    }
}
