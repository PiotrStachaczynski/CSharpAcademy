using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace FlexiDraw
{
    public class Drawable : IPaintable
    {
        


        public void SetPenSize(TrackBar s, int size,Pen pen)
        {
            size = s.Value;
            pen.Width = size;
            
        }
    }
}
