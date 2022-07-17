using DP2.Abstract;
using DP2.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP2
{
    public class Application
    {

        private IGUIFactory _factory;

        private Button _button;
        private Checkbox _checkbox;
        private MacFactory macFactory;

        public Application(MacFactory macFactory)
        {
            this.macFactory = macFactory;
        }


       

        public void CreateButton()
        {
           
            Console.WriteLine("Button assign!");
        }
        public void CreateChecbox()
        {
            Console.WriteLine("Checkbox assign!");
        }

        public void PaintButton(ConsoleColor color)
        {
         
            Console.WriteLine("Button painted!");
        }
        public void PaintCheckbox(ConsoleColor color)
        {
         
            Console.WriteLine("Checkbox painted!");
        }


    }
}
