using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LepcsosMatrix
{
    internal class InputMezo : TextBox
    {
        public InputMezo()
        {
            MaxLength = 4;
            TextAlign = HorizontalAlignment.Center;
            Font = new Font(Font.FontFamily, 18);
            Size = new Size(60, 23);
        }
    }
}
