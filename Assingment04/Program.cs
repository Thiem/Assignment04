using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingment04
{
    class Program
    {
        static void Main(string[] args)
        {
            Window[] window = new Window[3];
            window[0] = new ListBox(50, 100, "Content of list box 1");
            window[1] = new ListBox(200, 100, "Content of list box 2");
            window[2] = new Button(30, 50);

            for (int i = 0; i < 3; i++)
            {
                window[i].DrawWindow();
            }
            Console.ReadKey();
        }
    }
}
