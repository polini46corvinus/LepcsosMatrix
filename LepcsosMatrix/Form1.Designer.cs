namespace LepcsosMatrix
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            tabPage1 = new TabPage();
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            fuggetlenLabel = new MaterialSkin.Controls.MaterialLabel();
            lepesenkentCheckBox = new MaterialSkin.Controls.MaterialSwitch();
            demo1_3x3Button = new MaterialSkin.Controls.MaterialButton();
            determinansLabel = new MaterialSkin.Controls.MaterialLabel();
            demo2_3x3Button = new MaterialSkin.Controls.MaterialButton();
            rangLabel = new MaterialSkin.Controls.MaterialLabel();
            demo3_3x3Button = new MaterialSkin.Controls.MaterialButton();
            elemszamLabel = new MaterialSkin.Controls.MaterialLabel();
            random_3x3Button = new MaterialSkin.Controls.MaterialButton();
            random_4x4Button = new MaterialSkin.Controls.MaterialButton();
            random_5x5Button = new MaterialSkin.Controls.MaterialButton();
            szamitasButton = new MaterialSkin.Controls.MaterialButton();
            materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            mMeretTextBox = new MaterialSkin.Controls.MaterialTextBox();
            nMeretTextBox = new MaterialSkin.Controls.MaterialTextBox();
            ujMatrixButton = new MaterialSkin.Controls.MaterialButton();
            nevjegyButton = new MaterialSkin.Controls.MaterialButton();
            materialTabControl2 = new MaterialSkin.Controls.MaterialTabControl();
            tabPage2 = new TabPage();
            materialCard2 = new MaterialSkin.Controls.MaterialCard();
            materialCard3 = new MaterialSkin.Controls.MaterialCard();
            materialTabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            materialCard1.SuspendLayout();
            materialTabControl2.SuspendLayout();
            tabPage2.SuspendLayout();
            materialCard2.SuspendLayout();
            SuspendLayout();
            // 
            // materialTabControl1
            // 
            materialTabControl1.Controls.Add(tabPage1);
            materialTabControl1.Depth = 0;
            materialTabControl1.Location = new Point(16, 215);
            materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            materialTabControl1.Multiline = true;
            materialTabControl1.Name = "materialTabControl1";
            materialTabControl1.SelectedIndex = 0;
            materialTabControl1.Size = new Size(227, 500);
            materialTabControl1.TabIndex = 910;
            materialTabControl1.TabStop = false;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(materialCard1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(219, 472);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(fuggetlenLabel);
            materialCard1.Controls.Add(lepesenkentCheckBox);
            materialCard1.Controls.Add(demo1_3x3Button);
            materialCard1.Controls.Add(determinansLabel);
            materialCard1.Controls.Add(demo2_3x3Button);
            materialCard1.Controls.Add(rangLabel);
            materialCard1.Controls.Add(demo3_3x3Button);
            materialCard1.Controls.Add(elemszamLabel);
            materialCard1.Controls.Add(random_3x3Button);
            materialCard1.Controls.Add(random_4x4Button);
            materialCard1.Controls.Add(random_5x5Button);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(4, 5);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(203, 453);
            materialCard1.TabIndex = 0;
            // 
            // fuggetlenLabel
            // 
            fuggetlenLabel.AutoSize = true;
            fuggetlenLabel.Depth = 0;
            fuggetlenLabel.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            fuggetlenLabel.Location = new Point(15, 426);
            fuggetlenLabel.MouseState = MaterialSkin.MouseState.HOVER;
            fuggetlenLabel.Name = "fuggetlenLabel";
            fuggetlenLabel.Size = new Size(146, 19);
            fuggetlenLabel.TabIndex = 1;
            fuggetlenLabel.Text = "Lineárisan független";
            fuggetlenLabel.Visible = false;
            // 
            // lepesenkentCheckBox
            // 
            lepesenkentCheckBox.AutoSize = true;
            lepesenkentCheckBox.Depth = 0;
            lepesenkentCheckBox.Location = new Point(9, 322);
            lepesenkentCheckBox.Margin = new Padding(0);
            lepesenkentCheckBox.MouseLocation = new Point(-1, -1);
            lepesenkentCheckBox.MouseState = MaterialSkin.MouseState.HOVER;
            lepesenkentCheckBox.Name = "lepesenkentCheckBox";
            lepesenkentCheckBox.Ripple = true;
            lepesenkentCheckBox.Size = new Size(147, 37);
            lepesenkentCheckBox.TabIndex = 0;
            lepesenkentCheckBox.TabStop = false;
            lepesenkentCheckBox.Text = "Lépésenként";
            lepesenkentCheckBox.UseVisualStyleBackColor = true;
            // 
            // demo1_3x3Button
            // 
            demo1_3x3Button.AutoSize = false;
            demo1_3x3Button.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            demo1_3x3Button.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            demo1_3x3Button.Depth = 0;
            demo1_3x3Button.HighEmphasis = false;
            demo1_3x3Button.Icon = null;
            demo1_3x3Button.Location = new Point(18, 16);
            demo1_3x3Button.Margin = new Padding(4, 6, 4, 6);
            demo1_3x3Button.MouseState = MaterialSkin.MouseState.HOVER;
            demo1_3x3Button.Name = "demo1_3x3Button";
            demo1_3x3Button.NoAccentTextColor = Color.Empty;
            demo1_3x3Button.Size = new Size(119, 36);
            demo1_3x3Button.TabIndex = 0;
            demo1_3x3Button.TabStop = false;
            demo1_3x3Button.Text = "Demo 1 - 3x3";
            demo1_3x3Button.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            demo1_3x3Button.UseAccentColor = false;
            demo1_3x3Button.UseVisualStyleBackColor = true;
            demo1_3x3Button.Click += demo1_3x3Button_Click;
            // 
            // determinansLabel
            // 
            determinansLabel.AutoSize = true;
            determinansLabel.Depth = 0;
            determinansLabel.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            determinansLabel.Location = new Point(15, 405);
            determinansLabel.MouseState = MaterialSkin.MouseState.HOVER;
            determinansLabel.Name = "determinansLabel";
            determinansLabel.Size = new Size(172, 19);
            determinansLabel.TabIndex = 0;
            determinansLabel.Text = "Determináns: nem n x n!";
            determinansLabel.Visible = false;
            // 
            // demo2_3x3Button
            // 
            demo2_3x3Button.AutoSize = false;
            demo2_3x3Button.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            demo2_3x3Button.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            demo2_3x3Button.Depth = 0;
            demo2_3x3Button.HighEmphasis = false;
            demo2_3x3Button.Icon = null;
            demo2_3x3Button.Location = new Point(18, 62);
            demo2_3x3Button.Margin = new Padding(4, 6, 4, 6);
            demo2_3x3Button.MouseState = MaterialSkin.MouseState.HOVER;
            demo2_3x3Button.Name = "demo2_3x3Button";
            demo2_3x3Button.NoAccentTextColor = Color.Empty;
            demo2_3x3Button.Size = new Size(119, 36);
            demo2_3x3Button.TabIndex = 0;
            demo2_3x3Button.TabStop = false;
            demo2_3x3Button.Text = "Demo 2 - 3x3";
            demo2_3x3Button.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            demo2_3x3Button.UseAccentColor = false;
            demo2_3x3Button.UseVisualStyleBackColor = true;
            demo2_3x3Button.Click += demo2_3x3Button_Click;
            // 
            // rangLabel
            // 
            rangLabel.AutoSize = true;
            rangLabel.Depth = 0;
            rangLabel.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            rangLabel.Location = new Point(15, 384);
            rangLabel.MouseState = MaterialSkin.MouseState.HOVER;
            rangLabel.Name = "rangLabel";
            rangLabel.Size = new Size(42, 19);
            rangLabel.TabIndex = 0;
            rangLabel.Text = "Rang:";
            rangLabel.Visible = false;
            // 
            // demo3_3x3Button
            // 
            demo3_3x3Button.AutoSize = false;
            demo3_3x3Button.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            demo3_3x3Button.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            demo3_3x3Button.Depth = 0;
            demo3_3x3Button.HighEmphasis = false;
            demo3_3x3Button.Icon = null;
            demo3_3x3Button.Location = new Point(18, 108);
            demo3_3x3Button.Margin = new Padding(4, 6, 4, 6);
            demo3_3x3Button.MouseState = MaterialSkin.MouseState.HOVER;
            demo3_3x3Button.Name = "demo3_3x3Button";
            demo3_3x3Button.NoAccentTextColor = Color.Empty;
            demo3_3x3Button.Size = new Size(119, 36);
            demo3_3x3Button.TabIndex = 0;
            demo3_3x3Button.TabStop = false;
            demo3_3x3Button.Text = "Demo 3 - 4x5";
            demo3_3x3Button.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            demo3_3x3Button.UseAccentColor = false;
            demo3_3x3Button.UseVisualStyleBackColor = true;
            demo3_3x3Button.Click += demo3_4x5Button_Click;
            // 
            // elemszamLabel
            // 
            elemszamLabel.AutoSize = true;
            elemszamLabel.Depth = 0;
            elemszamLabel.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            elemszamLabel.Location = new Point(15, 363);
            elemszamLabel.MouseState = MaterialSkin.MouseState.HOVER;
            elemszamLabel.Name = "elemszamLabel";
            elemszamLabel.Size = new Size(79, 19);
            elemszamLabel.TabIndex = 0;
            elemszamLabel.Text = "Elemszám:";
            elemszamLabel.Visible = false;
            // 
            // random_3x3Button
            // 
            random_3x3Button.AutoSize = false;
            random_3x3Button.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            random_3x3Button.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            random_3x3Button.Depth = 0;
            random_3x3Button.HighEmphasis = true;
            random_3x3Button.Icon = null;
            random_3x3Button.Location = new Point(16, 177);
            random_3x3Button.Margin = new Padding(4, 6, 4, 6);
            random_3x3Button.MouseState = MaterialSkin.MouseState.HOVER;
            random_3x3Button.Name = "random_3x3Button";
            random_3x3Button.NoAccentTextColor = Color.Empty;
            random_3x3Button.Size = new Size(146, 36);
            random_3x3Button.TabIndex = 0;
            random_3x3Button.TabStop = false;
            random_3x3Button.Text = "Random - 3x3";
            random_3x3Button.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            random_3x3Button.UseAccentColor = false;
            random_3x3Button.UseVisualStyleBackColor = true;
            random_3x3Button.Click += random_3x3Button_Click;
            // 
            // random_4x4Button
            // 
            random_4x4Button.AutoSize = false;
            random_4x4Button.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            random_4x4Button.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            random_4x4Button.Depth = 0;
            random_4x4Button.HighEmphasis = true;
            random_4x4Button.Icon = null;
            random_4x4Button.Location = new Point(16, 223);
            random_4x4Button.Margin = new Padding(4, 6, 4, 6);
            random_4x4Button.MouseState = MaterialSkin.MouseState.HOVER;
            random_4x4Button.Name = "random_4x4Button";
            random_4x4Button.NoAccentTextColor = Color.Empty;
            random_4x4Button.Size = new Size(146, 36);
            random_4x4Button.TabIndex = 0;
            random_4x4Button.TabStop = false;
            random_4x4Button.Text = "Random - 4x4";
            random_4x4Button.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            random_4x4Button.UseAccentColor = false;
            random_4x4Button.UseVisualStyleBackColor = true;
            random_4x4Button.Click += random_4x4Button_Click;
            // 
            // random_5x5Button
            // 
            random_5x5Button.AutoSize = false;
            random_5x5Button.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            random_5x5Button.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            random_5x5Button.Depth = 0;
            random_5x5Button.HighEmphasis = true;
            random_5x5Button.Icon = null;
            random_5x5Button.Location = new Point(16, 269);
            random_5x5Button.Margin = new Padding(4, 6, 4, 6);
            random_5x5Button.MouseState = MaterialSkin.MouseState.HOVER;
            random_5x5Button.Name = "random_5x5Button";
            random_5x5Button.NoAccentTextColor = Color.Empty;
            random_5x5Button.Size = new Size(146, 36);
            random_5x5Button.TabIndex = 0;
            random_5x5Button.TabStop = false;
            random_5x5Button.Text = "Random - 5x5";
            random_5x5Button.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            random_5x5Button.UseAccentColor = false;
            random_5x5Button.UseVisualStyleBackColor = true;
            random_5x5Button.Click += random_5x5Button_Click;
            // 
            // szamitasButton
            // 
            szamitasButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            szamitasButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            szamitasButton.Depth = 0;
            szamitasButton.HighEmphasis = true;
            szamitasButton.Icon = null;
            szamitasButton.Location = new Point(289, 538);
            szamitasButton.Margin = new Padding(4, 6, 4, 6);
            szamitasButton.MouseState = MaterialSkin.MouseState.HOVER;
            szamitasButton.Name = "szamitasButton";
            szamitasButton.NoAccentTextColor = Color.Empty;
            szamitasButton.Size = new Size(93, 36);
            szamitasButton.TabIndex = 900;
            szamitasButton.Text = "Számítás";
            szamitasButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            szamitasButton.UseAccentColor = false;
            szamitasButton.UseVisualStyleBackColor = true;
            szamitasButton.Visible = false;
            szamitasButton.Click += szamitasButton_Click;
            // 
            // materialLabel4
            // 
            materialLabel4.AutoSize = true;
            materialLabel4.Depth = 0;
            materialLabel4.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel4.Location = new Point(23, 36);
            materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel4.Name = "materialLabel4";
            materialLabel4.Size = new Size(102, 19);
            materialLabel4.TabIndex = 0;
            materialLabel4.Text = "Mátrix mérete:";
            // 
            // materialLabel5
            // 
            materialLabel5.AutoSize = true;
            materialLabel5.Depth = 0;
            materialLabel5.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel5.Location = new Point(187, 36);
            materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel5.Name = "materialLabel5";
            materialLabel5.Size = new Size(9, 19);
            materialLabel5.TabIndex = 0;
            materialLabel5.Text = "x";
            // 
            // mMeretTextBox
            // 
            mMeretTextBox.AnimateReadOnly = false;
            mMeretTextBox.BorderStyle = BorderStyle.None;
            mMeretTextBox.Depth = 0;
            mMeretTextBox.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            mMeretTextBox.LeadingIcon = null;
            mMeretTextBox.Location = new Point(131, 23);
            mMeretTextBox.MaxLength = 50;
            mMeretTextBox.MouseState = MaterialSkin.MouseState.OUT;
            mMeretTextBox.Multiline = false;
            mMeretTextBox.Name = "mMeretTextBox";
            mMeretTextBox.Size = new Size(50, 50);
            mMeretTextBox.TabIndex = 0;
            mMeretTextBox.Text = "3";
            mMeretTextBox.TrailingIcon = null;
            // 
            // nMeretTextBox
            // 
            nMeretTextBox.AnimateReadOnly = false;
            nMeretTextBox.BorderStyle = BorderStyle.None;
            nMeretTextBox.Depth = 0;
            nMeretTextBox.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            nMeretTextBox.LeadingIcon = null;
            nMeretTextBox.Location = new Point(202, 23);
            nMeretTextBox.MaxLength = 50;
            nMeretTextBox.MouseState = MaterialSkin.MouseState.OUT;
            nMeretTextBox.Multiline = false;
            nMeretTextBox.Name = "nMeretTextBox";
            nMeretTextBox.Size = new Size(50, 50);
            nMeretTextBox.TabIndex = 1;
            nMeretTextBox.Text = "3";
            nMeretTextBox.TrailingIcon = null;
            // 
            // ujMatrixButton
            // 
            ujMatrixButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ujMatrixButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            ujMatrixButton.Depth = 0;
            ujMatrixButton.HighEmphasis = true;
            ujMatrixButton.Icon = null;
            ujMatrixButton.Location = new Point(267, 29);
            ujMatrixButton.Margin = new Padding(4, 6, 4, 6);
            ujMatrixButton.MouseState = MaterialSkin.MouseState.HOVER;
            ujMatrixButton.Name = "ujMatrixButton";
            ujMatrixButton.NoAccentTextColor = Color.Empty;
            ujMatrixButton.Size = new Size(97, 36);
            ujMatrixButton.TabIndex = 2;
            ujMatrixButton.Text = "Új mátrix";
            ujMatrixButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            ujMatrixButton.UseAccentColor = false;
            ujMatrixButton.UseVisualStyleBackColor = true;
            ujMatrixButton.Click += ujMatrixButton_Click;
            // 
            // nevjegyButton
            // 
            nevjegyButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            nevjegyButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            nevjegyButton.Depth = 0;
            nevjegyButton.HighEmphasis = false;
            nevjegyButton.Icon = null;
            nevjegyButton.Location = new Point(372, 29);
            nevjegyButton.Margin = new Padding(4, 6, 4, 6);
            nevjegyButton.MouseState = MaterialSkin.MouseState.HOVER;
            nevjegyButton.Name = "nevjegyButton";
            nevjegyButton.NoAccentTextColor = Color.Empty;
            nevjegyButton.Size = new Size(85, 36);
            nevjegyButton.TabIndex = 0;
            nevjegyButton.TabStop = false;
            nevjegyButton.Text = "Névjegy";
            nevjegyButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            nevjegyButton.UseAccentColor = false;
            nevjegyButton.UseVisualStyleBackColor = true;
            nevjegyButton.Click += nevjegyButton_Click;
            // 
            // materialTabControl2
            // 
            materialTabControl2.Controls.Add(tabPage2);
            materialTabControl2.Depth = 0;
            materialTabControl2.Location = new Point(12, 69);
            materialTabControl2.MouseState = MaterialSkin.MouseState.HOVER;
            materialTabControl2.Multiline = true;
            materialTabControl2.Name = "materialTabControl2";
            materialTabControl2.SelectedIndex = 0;
            materialTabControl2.Size = new Size(527, 141);
            materialTabControl2.TabIndex = 0;
            materialTabControl2.TabStop = false;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(materialCard2);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(519, 113);
            tabPage2.TabIndex = 0;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // materialCard2
            // 
            materialCard2.BackColor = Color.FromArgb(255, 255, 255);
            materialCard2.Controls.Add(nevjegyButton);
            materialCard2.Controls.Add(materialLabel4);
            materialCard2.Controls.Add(ujMatrixButton);
            materialCard2.Controls.Add(materialLabel5);
            materialCard2.Controls.Add(nMeretTextBox);
            materialCard2.Controls.Add(mMeretTextBox);
            materialCard2.Depth = 0;
            materialCard2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard2.Location = new Point(4, 5);
            materialCard2.Margin = new Padding(14);
            materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard2.Name = "materialCard2";
            materialCard2.Padding = new Padding(14);
            materialCard2.Size = new Size(493, 100);
            materialCard2.TabIndex = 0;
            // 
            // materialCard3
            // 
            materialCard3.AutoSize = true;
            materialCard3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialCard3.BackColor = Color.FromArgb(255, 255, 255);
            materialCard3.Depth = 0;
            materialCard3.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard3.Location = new Point(582, 215);
            materialCard3.Margin = new Padding(14);
            materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard3.Name = "materialCard3";
            materialCard3.Padding = new Padding(14);
            materialCard3.Size = new Size(28, 28);
            materialCard3.TabIndex = 0;
            materialCard3.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            CausesValidation = false;
            ClientSize = new Size(900, 724);
            Controls.Add(materialCard3);
            Controls.Add(materialTabControl2);
            Controls.Add(materialTabControl1);
            Controls.Add(szamitasButton);
            DrawerAutoHide = false;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimumSize = new Size(900, 700);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lépcsős mátrix - v0.7 (Budapesti Corvinus Egyetem)";
            Load += Form1_Load;
            materialTabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            materialCard1.ResumeLayout(false);
            materialCard1.PerformLayout();
            materialTabControl2.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            materialCard2.ResumeLayout(false);
            materialCard2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private TabPage tabPage1;
        private MaterialSkin.Controls.MaterialButton random_5x5Button;
        private MaterialSkin.Controls.MaterialButton random_4x4Button;
        private MaterialSkin.Controls.MaterialButton random_3x3Button;
        private MaterialSkin.Controls.MaterialButton demo3_3x3Button;
        private MaterialSkin.Controls.MaterialButton demo2_3x3Button;
        private MaterialSkin.Controls.MaterialButton demo1_3x3Button;
        private MaterialSkin.Controls.MaterialLabel determinansLabel;
        private MaterialSkin.Controls.MaterialLabel rangLabel;
        private MaterialSkin.Controls.MaterialLabel elemszamLabel;
        private MaterialSkin.Controls.MaterialButton szamitasButton;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialTextBox mMeretTextBox;
        private MaterialSkin.Controls.MaterialTextBox nMeretTextBox;
        private MaterialSkin.Controls.MaterialButton ujMatrixButton;
        private MaterialSkin.Controls.MaterialButton nevjegyButton;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl2;
        private TabPage tabPage2;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private MaterialSkin.Controls.MaterialSwitch lepesenkentCheckBox;
        private MaterialSkin.Controls.MaterialCard materialCard3;
        private MaterialSkin.Controls.MaterialLabel fuggetlenLabel;
    }
}
