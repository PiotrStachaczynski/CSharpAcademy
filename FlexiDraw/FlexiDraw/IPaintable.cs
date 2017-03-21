﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace FlexiDraw
{
    interface IPaintable
    {
        void SetPenSize(TrackBar s, int size, Pen pen);
    }
}
