using MaterialSkin;
using MaterialSkin.Controls;
using System.Collections.Immutable;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq.Expressions;

namespace LepcsosMatrix
{
    public partial class Form1 : MaterialForm
    {
        List<InputMezo> inputMezoList = new List<InputMezo>();
        List<OutputMezo> outputMezoList = new List<OutputMezo>();
        List<decimal[]> mLista = new List<decimal[]>();

        byte mDb = 0; // m = sor
        byte nDb = 0; // n = oszlop
        byte rang = new byte();

        public Form1()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Indigo600, Primary.Indigo800,
                Primary.Blue300, Accent.Indigo200, TextShade.WHITE);
        }
        private void Form1_Load(object sender, EventArgs e) { }
        private void ujMatrixButton_Click(object sender, EventArgs e)
        {
            //Törlés, üres lista beállítás
            szamitasButton.Visible = false;
            elemszamLabel.Visible = false;
            rangLabel.Visible = false;
            fuggetlenLabel.Visible = false;
            determinansLabel.Visible = false;
            materialCard3.Visible = false;
            try
            {
                List<Control> del = new List<Control>();
                foreach (Control i in Controls) { if (i is InputMezo || i is OutputMezo) { del.Add(i); } }
                foreach (Control torold in del) { Controls.Remove(torold); }
                inputMezoList.Clear();
                outputMezoList.Clear();
                mLista.Clear();
                del.Clear();

                bool hiba = false;

                mDb = Convert.ToByte(mMeretTextBox.Text);
                nDb = Convert.ToByte(nMeretTextBox.Text);
                if (mDb < 2 || nDb < 2)
                { MessageBox.Show("Minimális méret: 2x2"); hiba = true; };
                if (mDb > 12 || nDb > 12)
                { MessageBox.Show("Maximális méret: 12x12"); hiba = true; };

                if (hiba == false)
                {
                    for (byte i = 0; i < mDb; i++)
                    {
                        for (byte j = 0; j < nDb; j++)
                        {
                            InputMezo im = new InputMezo();
                            im.Left = 240 + 52 * j;
                            im.Top = 215 + 52 * i;
                            Controls.Add(im);
                            inputMezoList.Add(im);
                        }
                    }
                    szamitasButton.Left = inputMezoList[0].Left + 3;
                    szamitasButton.Top = inputMezoList[^1].Bottom + 10;
                    szamitasButton.Visible = true;
                    elemszamLabel.Text = ("Elemszám: " + inputMezoList.Count()).ToString();
                    elemszamLabel.Visible = true;
                }
            }
            catch (Exception ex) { MessageBox.Show("Beviteli hiba a mátrix létrehozásakor!\n\n" + ex.Message, "Hiba"); }
        }

        private void szamitasButton_Click(object sender, EventArgs e)
        {
            try
            {
                List<Control> del = new List<Control>();
                foreach (Control i in materialCard3.Controls) { if (i is OutputMezo) { del.Add(i); } }
                foreach (Control torold in del) { materialCard3.Controls.Remove(torold); }
                del.Clear();
                decimal[] mTomb = new decimal[nDb];
                mLista.Clear();
                outputMezoList.Clear();

                // Input mezõ generálás
                for (byte i = 0; i <= inputMezoList.Count; i++)
                {
                    if (i != 0 && i % nDb == 0)
                    {
                        mLista.Add(mTomb);
                        mTomb = new decimal[nDb];
                    }
                    if (i < inputMezoList.Count)
                    {
                        mTomb[i % nDb] = (Convert.ToDecimal(inputMezoList[i].Text.Replace(".", ",")));
                    }
                }

                VezetoElemAzonosito();
                RangSzamito();
                Determinans();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }


        private void VezetoElemAzonosito()
        {
            // Set up
            byte[] vezetoElemIndex = new byte[mDb];
            Array.Fill(vezetoElemIndex, byte.MaxValue);
            for (byte i = 0; i < mDb; i++)
            {
                for (byte j = 0; j < nDb; j++)
                {
                    if (mLista[i][j] != 0)
                    {
                        vezetoElemIndex[i] = j;
                        break;
                    }
                }
            }
            SortCheck(vezetoElemIndex);
        }

        private void SortCheck(byte[] vezetoelem)
        {
            byte[] sorted_vezetoelem = new byte[mDb];
            for (byte i = 0; i < mDb; i++) { sorted_vezetoelem[i] = vezetoelem[i]; }

            Array.Sort(sorted_vezetoelem);
            if (Enumerable.SequenceEqual<byte>(vezetoelem, sorted_vezetoelem) == false)
            {
                //MessageBox.Show("sort cserélek");
                SorCsere(vezetoelem);
            }
            else { Kivonas(vezetoelem); }
        }

        private void SorCsere(byte[] vezetoelem)
        {
            decimal[] elobbisor = new decimal[nDb];
            decimal[] utobbisor = new decimal[nDb];
            byte elobbisorindex = new byte();
            byte utobbisorindex = new byte();
            for (byte i = 1; i < mDb; i++)
            {
                if (vezetoelem[i] < vezetoelem[i - 1])
                {
                    elobbisorindex = (byte)(i - 1);
                    utobbisorindex = i;

                    for (byte j = 0; j < nDb; j++)
                    {
                        utobbisor[j] = mLista[i][j];
                        elobbisor[j] = mLista[i - 1][j]; // a kutyafáját ez megszivatott ám
                    }
                }
            }

            for (byte i = 0; i < elobbisor.Length; i++)
            {
                elobbisor[i] = elobbisor[i] * (-1);
            }

            for (byte i = 0; i < nDb; i++)
            {
                mLista[utobbisorindex][i] = elobbisor[i];
                mLista[elobbisorindex][i] = utobbisor[i];
            }
            if (lepesenkentCheckBox.Checked)
            {
                MessageBox.Show("Sorcsere");
                Output();
            }

            VezetoElemAzonosito();
        }

        private void Kivonas(byte[] vezetoelem)
        {
            //MessageBox.Show("kivonás");
            bool voltkivonas = false;
            decimal szorzo = new decimal();
            byte elobbisorindex = new byte();
            byte utobbisorindex = new byte();

            for (byte i = 1; i < mDb; i++)
            {
                if (vezetoelem[i] == vezetoelem[i - 1] && vezetoelem[i] != 255)
                {
                    elobbisorindex = (byte)(i - 1);
                    utobbisorindex = i;
                    szorzo = mLista[i][vezetoelem[i]] / mLista[i - 1][vezetoelem[i]];
                    voltkivonas = true;
                    break;
                }
            }
            if (voltkivonas == true)
            {
                decimal[] elobbisor = new decimal[nDb];
                decimal[] utobbisor = new decimal[nDb];

                for (byte i = 0; i < nDb; i++)
                {
                    elobbisor[i] = mLista[elobbisorindex][i];
                    utobbisor[i] = mLista[utobbisorindex][i];
                }

                for (byte i = 0; i < nDb; i++)
                {
                    mLista[utobbisorindex][i] -= Math.Round(elobbisor[i] * szorzo, 10);
                }
                if (lepesenkentCheckBox.Checked)
                {
                    MessageBox.Show($"Kivonás: ({Math.Round(szorzo, 3)} * )");
                    Output();
                }
                VezetoElemAzonosito();
            }
        }

        private void RangSzamito()
        {
            rang = (byte)mLista.Count();
            bool ures = false;
            byte uressorok = 0;
            for (byte i = 0; i < mDb; i++)
            {
                for (byte j = 0; j < nDb; j++)
                {
                    if (Math.Abs(mLista[i][j]) > 0.01m)
                    {
                        ures = false;
                        break;
                    }
                    else
                    {
                        ures = true;
                    }
                }
                if (ures == true)
                {
                    uressorok++;
                    ures = false;
                }
            }
            rangLabel.Text = "Rang: " + (rang - uressorok).ToString();
            rangLabel.Visible = true;
            if (rang-uressorok<mDb) { fuggetlenLabel.Text = "Lin. függő";}
            else { fuggetlenLabel.Text = "Lin. független"; }
            fuggetlenLabel.Visible = true;
            Output();
        }

        private void Output()
        {
            List<Control> del = new List<Control>();
            foreach (Control i in materialCard3.Controls) { if (i is OutputMezo) { del.Add(i); } }
            foreach (Control torold in del) { materialCard3.Controls.Remove(torold); }
            del.Clear();

            // Output mezõ generálás
            for (byte i = 0; i < mDb; i++)
            {
                for (byte j = 0; j < nDb; j++)
                {
                    OutputMezo om = new OutputMezo();
                    om.Left = 20 + 62 * j;
                    om.Top = 62 * i;
                    if (Math.Abs(mLista[i][j]) < 0.001m)
                    {
                        om.HighEmphasis = true;
                        om.Text = Convert.ToDouble(0).ToString();
                    }
                    else
                    {
                        om.Text = Convert.ToDouble(Math.Round(mLista[i][j], 3)).ToString();
                        om.HighEmphasis = false;
                    }
                    materialCard3.Left = inputMezoList[nDb - 1].Right + 20;
                    materialCard3.Controls.Add(om);
                    outputMezoList.Add(om);
                }
            }
            materialCard3.Visible = true;
        }

        private void Determinans()
        {
            double det = Convert.ToDouble(mLista[0][0]);
            if (mDb == nDb)
            {
                for (byte i = 1; i < nDb; i++)
                {
                    det *= Convert.ToDouble(mLista[i][i]);
                }
                if (Math.Abs(det) < 0.001)
                {
                    determinansLabel.Text = "Determináns: 0";
                }
                else
                {
                    determinansLabel.Text = ($"Determináns: {Math.Round(det, 3)}").ToString();
                }
                
            }
            else { determinansLabel.Text = "Determináns: nem n x n!"; }
            determinansLabel.Visible = true;
        }

        private void nevjegyButton_Click(object sender, EventArgs e)
        {
            Nevjegy nevjegy = new Nevjegy();
            nevjegy.ShowDialog();
        }

        private void demo1_3x3Button_Click(object sender, EventArgs e)
        {
            try
            {
                mMeretTextBox.Text = 3.ToString();
                nMeretTextBox.Text = 3.ToString();
                ujMatrixButton_Click(sender, e);
                {
                    inputMezoList[0].Text = "2";
                    inputMezoList[1].Text = "4";
                    inputMezoList[2].Text = "1";

                    inputMezoList[3].Text = "4";
                    inputMezoList[4].Text = "0";
                    inputMezoList[5].Text = "2";

                    inputMezoList[6].Text = "1";
                    inputMezoList[7].Text = "3";
                    inputMezoList[8].Text = "0";
                }
                szamitasButton_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void demo2_3x3Button_Click(object sender, EventArgs e)
        {
            try
            {
                mMeretTextBox.Text = 3.ToString();
                nMeretTextBox.Text = 3.ToString();
                ujMatrixButton_Click(sender, e);
                {
                    inputMezoList[0].Text = "1";
                    inputMezoList[1].Text = "0";
                    inputMezoList[2].Text = "3";

                    inputMezoList[3].Text = "0";
                    inputMezoList[4].Text = "1";
                    inputMezoList[5].Text = "1";

                    inputMezoList[6].Text = "0";
                    inputMezoList[7].Text = "2";
                    inputMezoList[8].Text = "2";
                }
                szamitasButton_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void random_3x3Button_Click(object sender, EventArgs e)
        {
            try
            {
                mMeretTextBox.Text = 3.ToString();
                nMeretTextBox.Text = 3.ToString();
                ujMatrixButton_Click(sender, e);
                {
                    Random rnd = new Random();
                    for (byte i = 0; i < inputMezoList.Count; i++) { inputMezoList[i].Text = rnd.Next(0, 10).ToString(); }
                }
                szamitasButton_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void demo3_4x5Button_Click(object sender, EventArgs e)
        {
            try
            {
                mMeretTextBox.Text = 4.ToString();
                nMeretTextBox.Text = 5.ToString();
                ujMatrixButton_Click(sender, e);
                {
                    inputMezoList[0].Text = "2";
                    inputMezoList[1].Text = "-1";
                    inputMezoList[2].Text = "-1";
                    inputMezoList[3].Text = "3";
                    inputMezoList[4].Text = "0";

                    inputMezoList[5].Text = "1";
                    inputMezoList[6].Text = "1";
                    inputMezoList[7].Text = "4";
                    inputMezoList[8].Text = "0";
                    inputMezoList[9].Text = "3";

                    inputMezoList[10].Text = "-1";
                    inputMezoList[11].Text = "1";
                    inputMezoList[12].Text = "2";
                    inputMezoList[13].Text = "-2";
                    inputMezoList[14].Text = "1";

                    inputMezoList[15].Text = "3";
                    inputMezoList[16].Text = "-1";
                    inputMezoList[17].Text = "0";
                    inputMezoList[18].Text = "4";
                    inputMezoList[19].Text = "1";
                }
                szamitasButton_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void random_4x4Button_Click(object sender, EventArgs e)
        {
            try
            {
                mMeretTextBox.Text = 4.ToString();
                nMeretTextBox.Text = 4.ToString();
                ujMatrixButton_Click(sender, e);
                {
                    Random rnd = new Random();
                    for (byte i = 0; i < inputMezoList.Count; i++) { inputMezoList[i].Text = rnd.Next(0, 10).ToString(); }
                }
                szamitasButton_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void random_5x5Button_Click(object sender, EventArgs e)
        {
            try
            {
                mMeretTextBox.Text = 5.ToString();
                nMeretTextBox.Text = 5.ToString();
                ujMatrixButton_Click(sender, e);
                {
                    Random rnd = new Random();
                    for (byte i = 0; i < inputMezoList.Count; i++) { inputMezoList[i].Text = rnd.Next(0, 10).ToString(); }
                }
                szamitasButton_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}