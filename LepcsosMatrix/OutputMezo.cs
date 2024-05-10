using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LepcsosMatrix
{
    public class OutputMezo : Label
    {
        public OutputMezo()
        {
            AutoSize = false;
            Size = new Size(60, 60);
            BackColor = Color.White;
            TextAlign = ContentAlignment.MiddleCenter;
            BorderStyle = BorderStyle.FixedSingle;
        }
    }
}
