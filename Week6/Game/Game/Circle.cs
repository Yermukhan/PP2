using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class Circle :Shape
    {
        public int r;
        public Circle (int x,int y,int r):base(x,y)
        {
            this.r = r;

        }
    }
}
