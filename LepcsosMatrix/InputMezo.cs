using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LepcsosMatrix
{
    internal class InputMezo : MaterialTextBox
    {
        public InputMezo()
        {
            MaxLength = 4;
            Font = new Font(Font.FontFamily, 18);
            Size = new Size(50,50);
            TabIndex = 800;
        }
    }
}
