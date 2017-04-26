namespace DSDeaths
{
    partial class Overlay
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labTotal = new System.Windows.Forms.Label();
            this.labThisSeg = new System.Windows.Forms.Label();
            this.labBoss = new System.Windows.Forms.Label();
            this.labArea = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labFall = new System.Windows.Forms.Label();
            this.tbxBossName = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnNewSeg = new System.Windows.Forms.Button();
            this.labUIBossName = new System.Windows.Forms.Label();
            this.labUIBossDeahts = new System.Windows.Forms.Label();
            this.tbxBossDeaths = new System.Windows.Forms.TextBox();
            this.labUIAreaDeaths = new System.Windows.Forms.Label();
            this.tbxAreaDeaths = new System.Windows.Forms.TextBox();
            this.bgwChat = new System.ComponentModel.BackgroundWorker();
            this.labUIFallDeaths = new System.Windows.Forms.Label();
            this.tbxFallDeaths = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labTotal
            // 
            this.labTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labTotal.Font = new System.Drawing.Font("OptimusPrincepsSemiBold", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTotal.ForeColor = System.Drawing.Color.White;
            this.labTotal.Location = new System.Drawing.Point(3, 8);
            this.labTotal.Name = "labTotal";
            this.labTotal.Size = new System.Drawing.Size(414, 73);
            this.labTotal.TabIndex = 0;
            this.labTotal.Text = "Deaths: %s";
            this.labTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labThisSeg
            // 
            this.labThisSeg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labThisSeg.Font = new System.Drawing.Font("OptimusPrincepsSemiBold", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labThisSeg.ForeColor = System.Drawing.Color.White;
            this.labThisSeg.Location = new System.Drawing.Point(0, 76);
            this.labThisSeg.Name = "labThisSeg";
            this.labThisSeg.Size = new System.Drawing.Size(420, 55);
            this.labThisSeg.TabIndex = 0;
            this.labThisSeg.Text = "             This Segment";
            this.labThisSeg.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labBoss
            // 
            this.labBoss.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labBoss.Font = new System.Drawing.Font("OptimusPrincepsSemiBold", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labBoss.ForeColor = System.Drawing.Color.White;
            this.labBoss.Location = new System.Drawing.Point(0, 122);
            this.labBoss.Name = "labBoss";
            this.labBoss.Size = new System.Drawing.Size(417, 55);
            this.labBoss.TabIndex = 2;
            this.labBoss.Text = "Boss (%s): %s";
            this.labBoss.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labArea
            // 
            this.labArea.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labArea.Font = new System.Drawing.Font("OptimusPrincepsSemiBold", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labArea.ForeColor = System.Drawing.Color.White;
            this.labArea.Location = new System.Drawing.Point(0, 166);
            this.labArea.Name = "labArea";
            this.labArea.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labArea.Size = new System.Drawing.Size(417, 55);
            this.labArea.TabIndex = 3;
            this.labArea.Text = "Area: %s";
            this.labArea.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.labFall);
            this.panel1.Controls.Add(this.labBoss);
            this.panel1.Controls.Add(this.labThisSeg);
            this.panel1.Controls.Add(this.labArea);
            this.panel1.Controls.Add(this.labTotal);
            this.panel1.Location = new System.Drawing.Point(130, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(420, 250);
            this.panel1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::WindowsFormsApplication6.Properties.Resources.falling;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(329, 212);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 35);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // labFall
            // 
            this.labFall.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labFall.BackColor = System.Drawing.Color.Transparent;
            this.labFall.Font = new System.Drawing.Font("OptimusPrincepsSemiBold", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labFall.ForeColor = System.Drawing.Color.White;
            this.labFall.Location = new System.Drawing.Point(348, 212);
            this.labFall.Name = "labFall";
            this.labFall.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labFall.Size = new System.Drawing.Size(69, 38);
            this.labFall.TabIndex = 5;
            this.labFall.Text = ": %s";
            this.labFall.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbxBossName
            // 
            this.tbxBossName.Location = new System.Drawing.Point(12, 24);
            this.tbxBossName.Name = "tbxBossName";
            this.tbxBossName.Size = new System.Drawing.Size(100, 20);
            this.tbxBossName.TabIndex = 5;
            this.tbxBossName.TextChanged += new System.EventHandler(this.tbxBossName_TextChanged);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(12, 256);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(335, 214);
            this.listView1.TabIndex = 9;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Boss Name";
            this.columnHeader1.Width = 108;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Boss Deaths";
            this.columnHeader2.Width = 72;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Area Deaths";
            this.columnHeader3.Width = 71;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Fall Deaths";
            this.columnHeader4.Width = 80;
            // 
            // btnNewSeg
            // 
            this.btnNewSeg.Location = new System.Drawing.Point(12, 198);
            this.btnNewSeg.Name = "btnNewSeg";
            this.btnNewSeg.Size = new System.Drawing.Size(99, 43);
            this.btnNewSeg.TabIndex = 10;
            this.btnNewSeg.Text = "New Segment";
            this.btnNewSeg.UseVisualStyleBackColor = true;
            this.btnNewSeg.Click += new System.EventHandler(this.btnNewSeg_Click);
            // 
            // labUIBossName
            // 
            this.labUIBossName.AutoSize = true;
            this.labUIBossName.Location = new System.Drawing.Point(9, 8);
            this.labUIBossName.Name = "labUIBossName";
            this.labUIBossName.Size = new System.Drawing.Size(61, 13);
            this.labUIBossName.TabIndex = 11;
            this.labUIBossName.Text = "Boss Name";
            // 
            // labUIBossDeahts
            // 
            this.labUIBossDeahts.AutoSize = true;
            this.labUIBossDeahts.Location = new System.Drawing.Point(9, 47);
            this.labUIBossDeahts.Name = "labUIBossDeahts";
            this.labUIBossDeahts.Size = new System.Drawing.Size(67, 13);
            this.labUIBossDeahts.TabIndex = 13;
            this.labUIBossDeahts.Text = "Boss Deaths";
            // 
            // tbxBossDeaths
            // 
            this.tbxBossDeaths.Location = new System.Drawing.Point(12, 63);
            this.tbxBossDeaths.Name = "tbxBossDeaths";
            this.tbxBossDeaths.Size = new System.Drawing.Size(100, 20);
            this.tbxBossDeaths.TabIndex = 12;
            this.tbxBossDeaths.TextChanged += new System.EventHandler(this.tbxBossDeaths_TextChanged);
            // 
            // labUIAreaDeaths
            // 
            this.labUIAreaDeaths.AutoSize = true;
            this.labUIAreaDeaths.Location = new System.Drawing.Point(9, 86);
            this.labUIAreaDeaths.Name = "labUIAreaDeaths";
            this.labUIAreaDeaths.Size = new System.Drawing.Size(66, 13);
            this.labUIAreaDeaths.TabIndex = 15;
            this.labUIAreaDeaths.Text = "Area Deaths";
            // 
            // tbxAreaDeaths
            // 
            this.tbxAreaDeaths.Location = new System.Drawing.Point(12, 102);
            this.tbxAreaDeaths.Name = "tbxAreaDeaths";
            this.tbxAreaDeaths.Size = new System.Drawing.Size(100, 20);
            this.tbxAreaDeaths.TabIndex = 14;
            this.tbxAreaDeaths.TextChanged += new System.EventHandler(this.tbxAreaDeaths_TextChanged);
            // 
            // bgwChat
            // 
            this.bgwChat.WorkerReportsProgress = true;
            this.bgwChat.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwChat_DoWork);
            // 
            // labUIFallDeaths
            // 
            this.labUIFallDeaths.AutoSize = true;
            this.labUIFallDeaths.Location = new System.Drawing.Point(9, 130);
            this.labUIFallDeaths.Name = "labUIFallDeaths";
            this.labUIFallDeaths.Size = new System.Drawing.Size(60, 13);
            this.labUIFallDeaths.TabIndex = 17;
            this.labUIFallDeaths.Text = "Fall Deaths";
            // 
            // tbxFallDeaths
            // 
            this.tbxFallDeaths.Location = new System.Drawing.Point(12, 146);
            this.tbxFallDeaths.Name = "tbxFallDeaths";
            this.tbxFallDeaths.Size = new System.Drawing.Size(100, 20);
            this.tbxFallDeaths.TabIndex = 16;
            this.tbxFallDeaths.TextChanged += new System.EventHandler(this.tbxFallDeaths_TextChanged);
            // 
            // Overlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(550, 251);
            this.Controls.Add(this.labUIFallDeaths);
            this.Controls.Add(this.tbxFallDeaths);
            this.Controls.Add(this.labUIAreaDeaths);
            this.Controls.Add(this.tbxAreaDeaths);
            this.Controls.Add(this.labUIBossDeahts);
            this.Controls.Add(this.tbxBossDeaths);
            this.Controls.Add(this.labUIBossName);
            this.Controls.Add(this.btnNewSeg);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.tbxBossName);
            this.Controls.Add(this.panel1);
            this.Name = "Overlay";
            this.Text = "Dark Souls Deaths";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Overlay_FormClosing);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labTotal;
        private System.Windows.Forms.Label labThisSeg;
        private System.Windows.Forms.Label labBoss;
        private System.Windows.Forms.Label labArea;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbxBossName;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btnNewSeg;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label labUIBossName;
        private System.Windows.Forms.Label labUIBossDeahts;
        private System.Windows.Forms.TextBox tbxBossDeaths;
        private System.Windows.Forms.Label labUIAreaDeaths;
        private System.Windows.Forms.TextBox tbxAreaDeaths;
        private System.ComponentModel.BackgroundWorker bgwChat;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labFall;
        private System.Windows.Forms.Label labUIFallDeaths;
        private System.Windows.Forms.TextBox tbxFallDeaths;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}

