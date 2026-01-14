namespace ColorMatchOutfit
{
    partial class ColorMatching
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
            label1 = new Label();
            MainColor = new PictureBox();
            btngenerate = new Button();
            btnSave = new Button();
            comboStyle = new ComboBox();
            listSaved = new ListBox();
            pic1Match = new PictureBox();
            pic2Match = new PictureBox();
            pic3Match = new PictureBox();
            LblStatus = new Label();
            btnRemove = new Button();
            ((System.ComponentModel.ISupportInitialize)MainColor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic1Match).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic2Match).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic3Match).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(255, 192, 192);
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Yu Gothic UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(310, 22);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(152, 37);
            label1.TabIndex = 0;
            label1.Text = "Main Color";
            // 
            // MainColor
            // 
            MainColor.BackColor = Color.PeachPuff;
            MainColor.Location = new Point(274, 86);
            MainColor.Name = "MainColor";
            MainColor.Size = new Size(129, 79);
            MainColor.SizeMode = PictureBoxSizeMode.StretchImage;
            MainColor.TabIndex = 1;
            MainColor.TabStop = false;
            // 
            // btngenerate
            // 
            btngenerate.BackColor = Color.FromArgb(255, 192, 192);
            btngenerate.FlatStyle = FlatStyle.Popup;
            btngenerate.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btngenerate.Location = new Point(517, 144);
            btngenerate.Name = "btngenerate";
            btngenerate.Size = new Size(85, 36);
            btngenerate.TabIndex = 2;
            btngenerate.Text = "generate";
            btngenerate.UseVisualStyleBackColor = false;
            btngenerate.Click += btngenerate_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(255, 192, 192);
            btnSave.FlatStyle = FlatStyle.Popup;
            btnSave.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(424, 144);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(87, 36);
            btnSave.TabIndex = 3;
            btnSave.Text = "save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // comboStyle
            // 
            comboStyle.BackColor = Color.White;
            comboStyle.FlatStyle = FlatStyle.Popup;
            comboStyle.FormattingEnabled = true;
            comboStyle.Location = new Point(424, 86);
            comboStyle.Name = "comboStyle";
            comboStyle.Size = new Size(121, 23);
            comboStyle.TabIndex = 7;
            // 
            // listSaved
            // 
            listSaved.BackColor = Color.FromArgb(255, 224, 192);
            listSaved.FormattingEnabled = true;
            listSaved.ItemHeight = 15;
            listSaved.Location = new Point(599, 297);
            listSaved.Name = "listSaved";
            listSaved.Size = new Size(120, 94);
            listSaved.TabIndex = 8;
            // 
            // pic1Match
            // 
            pic1Match.BackColor = Color.Bisque;
            pic1Match.Location = new Point(159, 220);
            pic1Match.Name = "pic1Match";
            pic1Match.Size = new Size(100, 50);
            pic1Match.TabIndex = 9;
            pic1Match.TabStop = false;
            // 
            // pic2Match
            // 
            pic2Match.BackColor = Color.Bisque;
            pic2Match.Location = new Point(159, 297);
            pic2Match.Name = "pic2Match";
            pic2Match.Size = new Size(100, 50);
            pic2Match.TabIndex = 10;
            pic2Match.TabStop = false;
            // 
            // pic3Match
            // 
            pic3Match.BackColor = Color.Bisque;
            pic3Match.Location = new Point(159, 366);
            pic3Match.Name = "pic3Match";
            pic3Match.Size = new Size(100, 50);
            pic3Match.TabIndex = 11;
            pic3Match.TabStop = false;
            // 
            // LblStatus
            // 
            LblStatus.AutoSize = true;
            LblStatus.FlatStyle = FlatStyle.Popup;
            LblStatus.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblStatus.Location = new Point(411, 283);
            LblStatus.Name = "LblStatus";
            LblStatus.Size = new Size(51, 21);
            LblStatus.TabIndex = 12;
            LblStatus.Text = "ready";
            // 
            // btnRemove
            // 
            btnRemove.FlatStyle = FlatStyle.Popup;
            btnRemove.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRemove.Location = new Point(608, 144);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(86, 36);
            btnRemove.TabIndex = 13;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // ColorMatching
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 192);
            ClientSize = new Size(884, 463);
            Controls.Add(btnRemove);
            Controls.Add(LblStatus);
            Controls.Add(pic3Match);
            Controls.Add(pic2Match);
            Controls.Add(pic1Match);
            Controls.Add(listSaved);
            Controls.Add(comboStyle);
            Controls.Add(btnSave);
            Controls.Add(btngenerate);
            Controls.Add(MainColor);
            Controls.Add(label1);
            Name = "ColorMatching";
            Text = "Form1";
            Load += ColorMatching_Load;
            ((System.ComponentModel.ISupportInitialize)MainColor).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic1Match).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic2Match).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic3Match).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox MainColor;
        private Button btngenerate;
        private Button btnSave;
        private ComboBox comboStyle;
        private ListBox listSaved;
        private PictureBox pic1Match;
        private PictureBox pic2Match;
        private PictureBox pic3Match;
        private Label LblStatus;
        private Button btnRemove;
    }
}
