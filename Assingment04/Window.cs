using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingment04
{
    abstract class Window
    {
        public int top { get; set; }
        public int left { get; set; }
        public Window()
        {

        }
        public Window(int top, int left)
        {
            this.top = top;
            this.left = left;
        }
        public abstract void DrawWindow();
    }
}
