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
            matrixMereteLabel = new Label();
            mMeretTextBox = new TextBox();
            xLabel = new Label();
            nMeretTextBox = new TextBox();
            ujMatrixButton = new Button();
            szamitasButton = new Button();
            elemszamLabel = new Label();
            demo1_3x3Button = new Button();
            nevjegyButton = new Button();
            demo2_3x3Button = new Button();
            random_3x3Button = new Button();
            demo3_4x5Button = new Button();
            random_4x4Button = new Button();
            random_5x5Button = new Button();
            rangLabel = new Label();
            SuspendLayout();
            // 
            // matrixMereteLabel
            // 
            matrixMereteLabel.AutoSize = true;
            matrixMereteLabel.Location = new Point(12, 19);
            matrixMereteLabel.Name = "matrixMereteLabel";
            matrixMereteLabel.Size = new Size(84, 15);
            matrixMereteLabel.TabIndex = 900;
            matrixMereteLabel.Text = "Mátrix mérete:";
            // 
            // mMeretTextBox
            // 
            mMeretTextBox.Location = new Point(98, 16);
            mMeretTextBox.Name = "mMeretTextBox";
            mMeretTextBox.Size = new Size(30, 23);
            mMeretTextBox.TabIndex = 1;
            mMeretTextBox.Text = "3";
            mMeretTextBox.TextAlign = HorizontalAlignment.Center;
            mMeretTextBox.WordWrap = false;
            // 
            // xLabel
            // 
            xLabel.AutoSize = true;
            xLabel.Location = new Point(130, 19);
            xLabel.Name = "xLabel";
            xLabel.Size = new Size(14, 15);
            xLabel.TabIndex = 901;
            xLabel.Text = "X";
            // 
            // nMeretTextBox
            // 
            nMeretTextBox.Location = new Point(146, 16);
            nMeretTextBox.Name = "nMeretTextBox";
            nMeretTextBox.Size = new Size(30, 23);
            nMeretTextBox.TabIndex = 2;
            nMeretTextBox.Text = "3";
            nMeretTextBox.TextAlign = HorizontalAlignment.Center;
            nMeretTextBox.WordWrap = false;
            // 
            // ujMatrixButton
            // 
            ujMatrixButton.Location = new Point(182, 16);
            ujMatrixButton.Name = "ujMatrixButton";
            ujMatrixButton.Size = new Size(88, 23);
            ujMatrixButton.TabIndex = 3;
            ujMatrixButton.Text = "&Új mátrix";
            ujMatrixButton.UseVisualStyleBackColor = true;
            ujMatrixButton.Click += ujMatrixButton_Click;
            // 
            // szamitasButton
            // 
            szamitasButton.Location = new Point(397, 80);
            szamitasButton.Name = "szamitasButton";
            szamitasButton.Size = new Size(75, 23);
            szamitasButton.TabIndex = 0;
            szamitasButton.Text = "Számítás";
            szamitasButton.UseVisualStyleBackColor = true;
            szamitasButton.Visible = false;
            szamitasButton.Click += szamitasButton_Click;
            // 
            // elemszamLabel
            // 
            elemszamLabel.AutoSize = true;
            elemszamLabel.Location = new Point(12, 279);
            elemszamLabel.Name = "elemszamLabel";
            elemszamLabel.Size = new Size(63, 15);
            elemszamLabel.TabIndex = 902;
            elemszamLabel.Text = "Elemszám:";
            elemszamLabel.Visible = false;
            // 
            // demo1_3x3Button
            // 
            demo1_3x3Button.Location = new Point(14, 80);
            demo1_3x3Button.Name = "demo1_3x3Button";
            demo1_3x3Button.Size = new Size(130, 23);
            demo1_3x3Button.TabIndex = 8;
            demo1_3x3Button.Text = "Demo 1 - 3x3";
            demo1_3x3Button.UseVisualStyleBackColor = true;
            demo1_3x3Button.Click += demo1_3x3Button_Click;
            // 
            // nevjegyButton
            // 
            nevjegyButton.Location = new Point(276, 16);
            nevjegyButton.Name = "nevjegyButton";
            nevjegyButton.Size = new Size(88, 23);
            nevjegyButton.TabIndex = 903;
            nevjegyButton.TabStop = false;
            nevjegyButton.Text = "Névjegy";
            nevjegyButton.UseVisualStyleBackColor = true;
            nevjegyButton.Click += nevjegyButton_Click;
            // 
            // demo2_3x3Button
            // 
            demo2_3x3Button.Location = new Point(14, 109);
            demo2_3x3Button.Name = "demo2_3x3Button";
            demo2_3x3Button.Size = new Size(130, 23);
            demo2_3x3Button.TabIndex = 9;
            demo2_3x3Button.Text = "Demo 2 - 3x3";
            demo2_3x3Button.UseVisualStyleBackColor = true;
            demo2_3x3Button.Click += demo2_3x3Button_Click;
            // 
            // random_3x3Button
            // 
            random_3x3Button.Location = new Point(14, 183);
            random_3x3Button.Name = "random_3x3Button";
            random_3x3Button.Size = new Size(130, 23);
            random_3x3Button.TabIndex = 11;
            random_3x3Button.Text = "Random - 3x3";
            random_3x3Button.UseVisualStyleBackColor = true;
            random_3x3Button.Click += random_3x3Button_Click;
            // 
            // demo3_4x5Button
            // 
            demo3_4x5Button.Location = new Point(14, 138);
            demo3_4x5Button.Name = "demo3_4x5Button";
            demo3_4x5Button.Size = new Size(130, 23);
            demo3_4x5Button.TabIndex = 10;
            demo3_4x5Button.Text = "Demo 3 - 4x5";
            demo3_4x5Button.UseVisualStyleBackColor = true;
            demo3_4x5Button.Click += demo3_4x5Button_Click;
            // 
            // random_4x4Button
            // 
            random_4x4Button.Location = new Point(14, 212);
            random_4x4Button.Name = "random_4x4Button";
            random_4x4Button.Size = new Size(130, 23);
            random_4x4Button.TabIndex = 904;
            random_4x4Button.Text = "Random - 4x4";
            random_4x4Button.UseVisualStyleBackColor = true;
            random_4x4Button.Click += random_4x4Button_Click;
            // 
            // random_5x5Button
            // 
            random_5x5Button.Location = new Point(14, 241);
            random_5x5Button.Name = "random_5x5Button";
            random_5x5Button.Size = new Size(130, 23);
            random_5x5Button.TabIndex = 905;
            random_5x5Button.Text = "Random - 5x5";
            random_5x5Button.UseVisualStyleBackColor = true;
            random_5x5Button.Click += random_5x5Button_Click;
            // 
            // rangLabel
            // 
            rangLabel.AutoSize = true;
            rangLabel.Location = new Point(12, 301);
            rangLabel.Name = "rangLabel";
            rangLabel.Size = new Size(37, 15);
            rangLabel.TabIndex = 906;
            rangLabel.Text = "Rang:";
            rangLabel.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(644, 461);
            Controls.Add(rangLabel);
            Controls.Add(random_5x5Button);
            Controls.Add(random_4x4Button);
            Controls.Add(demo3_4x5Button);
            Controls.Add(random_3x3Button);
            Controls.Add(demo2_3x3Button);
            Controls.Add(nevjegyButton);
            Controls.Add(demo1_3x3Button);
            Controls.Add(elemszamLabel);
            Controls.Add(szamitasButton);
            Controls.Add(mMeretTextBox);
            Controls.Add(ujMatrixButton);
            Controls.Add(nMeretTextBox);
            Controls.Add(xLabel);
            Controls.Add(matrixMereteLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            HelpButton = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(660, 500);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lépcsős mátrix - v0.32 (Budapesti Corvinus Egyetem)";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label matrixMereteLabel;
        private TextBox mMeretTextBox;
        private Label xLabel;
        private TextBox nMeretTextBox;
        private Button ujMatrixButton;
        private Button szamitasButton;
        private Label elemszamLabel;
        private Button demo1_3x3Button;
        private Button nevjegyButton;
        private Button demo2_3x3Button;
        private Button random_3x3Button;
        private Button demo3_4x5Button;
        private Button random_4x4Button;
        private Button random_5x5Button;
        private Label rangLabel;
    }
}
