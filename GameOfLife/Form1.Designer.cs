namespace GameOfLife
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.pic = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.cbTypeOfGrid = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbWidth = new System.Windows.Forms.ComboBox();
            this.cbHeight = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnResizeGrid = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // pic
            // 
            this.pic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(60)))));
            this.pic.Location = new System.Drawing.Point(365, 50);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(592, 592);
            this.pic.TabIndex = 1;
            this.pic.TabStop = false;
            this.pic.Click += new System.EventHandler(this.pic_Click);
            this.pic.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pic_MouseClick);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnStart.Location = new System.Drawing.Point(28, 91);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(163, 119);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.button1_Click);
            this.btnStart.Enter += new System.EventHandler(this.btnStart_Enter);
            // 
            // cbTypeOfGrid
            // 
            this.cbTypeOfGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbTypeOfGrid.FormattingEnabled = true;
            this.cbTypeOfGrid.Items.AddRange(new object[] {
            "Custom",
            "niezmienne",
            "oscylator",
            "glider",
            "random"});
            this.cbTypeOfGrid.Location = new System.Drawing.Point(28, 243);
            this.cbTypeOfGrid.Name = "cbTypeOfGrid";
            this.cbTypeOfGrid.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbTypeOfGrid.Size = new System.Drawing.Size(322, 21);
            this.cbTypeOfGrid.TabIndex = 4;
            this.cbTypeOfGrid.SelectedValueChanged += new System.EventHandler(this.cbTypeOfGrid_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(25)))), ((int)(((byte)(48)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(28, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "                  Tryb początkowy                  ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(25)))), ((int)(((byte)(48)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(28, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "      Grid Size      ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cbWidth
            // 
            this.cbWidth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbWidth.FormattingEnabled = true;
            this.cbWidth.Items.AddRange(new object[] {
            "74",
            "37",
            "16",
            "8"});
            this.cbWidth.Location = new System.Drawing.Point(28, 296);
            this.cbWidth.Name = "cbWidth";
            this.cbWidth.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbWidth.Size = new System.Drawing.Size(55, 21);
            this.cbWidth.TabIndex = 14;
            // 
            // cbHeight
            // 
            this.cbHeight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbHeight.FormattingEnabled = true;
            this.cbHeight.Items.AddRange(new object[] {
            "74",
            "37",
            "16",
            "8"});
            this.cbHeight.Location = new System.Drawing.Point(113, 296);
            this.cbHeight.Name = "cbHeight";
            this.cbHeight.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbHeight.Size = new System.Drawing.Size(58, 21);
            this.cbHeight.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(90, 299);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 18);
            this.label5.TabIndex = 17;
            this.label5.Text = "X";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.DarkGray;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnClose.Location = new System.Drawing.Point(952, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 37);
            this.btnClose.TabIndex = 18;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnResizeGrid
            // 
            this.btnResizeGrid.BackColor = System.Drawing.Color.Black;
            this.btnResizeGrid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnResizeGrid.FlatAppearance.BorderSize = 0;
            this.btnResizeGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResizeGrid.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResizeGrid.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnResizeGrid.Location = new System.Drawing.Point(179, 273);
            this.btnResizeGrid.Name = "btnResizeGrid";
            this.btnResizeGrid.Size = new System.Drawing.Size(171, 46);
            this.btnResizeGrid.TabIndex = 19;
            this.btnResizeGrid.Text = "Apply";
            this.btnResizeGrid.UseVisualStyleBackColor = false;
            this.btnResizeGrid.Click += new System.EventHandler(this.btnResizeGrid_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(60)))));
            this.panel1.Location = new System.Drawing.Point(29, 348);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(107, 194);
            this.panel1.TabIndex = 21;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel2.Location = new System.Drawing.Point(136, 348);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(107, 194);
            this.panel2.TabIndex = 22;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(25)))), ((int)(((byte)(48)))));
            this.panel3.Location = new System.Drawing.Point(242, 348);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(107, 194);
            this.panel3.TabIndex = 23;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Black;
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Adobe Heiti Std R", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRefresh.Location = new System.Drawing.Point(197, 91);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(152, 119);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Refresh Grid";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(985, 693);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.pic);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnResizeGrid);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbHeight);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbWidth);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbTypeOfGrid);
            this.Controls.Add(this.btnStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ComboBox cbTypeOfGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbWidth;
        private System.Windows.Forms.ComboBox cbHeight;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnResizeGrid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnRefresh;
    }
}

