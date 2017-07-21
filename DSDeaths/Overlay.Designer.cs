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
            this.components = new System.ComponentModel.Container();
            this.labTotal = new System.Windows.Forms.Label();
            this.labThisSeg = new System.Windows.Forms.Label();
            this.labBoss = new System.Windows.Forms.Label();
            this.labArea = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labFall = new System.Windows.Forms.Label();
            this.labSouls = new System.Windows.Forms.Label();
            this.tbxBossName = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnNewSeg = new System.Windows.Forms.Button();
            this.labUIBossName = new System.Windows.Forms.Label();
            this.labUIBossDeahts = new System.Windows.Forms.Label();
            this.tbxBossDeaths = new System.Windows.Forms.TextBox();
            this.labUIAreaDeaths = new System.Windows.Forms.Label();
            this.tbxAreaDeaths = new System.Windows.Forms.TextBox();
            this.bgwChat = new System.ComponentModel.BackgroundWorker();
            this.labUIFallDeaths = new System.Windows.Forms.Label();
            this.tbxFallDeaths = new System.Windows.Forms.TextBox();
            this.tbxTest = new System.Windows.Forms.TextBox();
            this.listMods = new System.Windows.Forms.ListView();
            this.btnAddMod = new System.Windows.Forms.Button();
            this.tbxMod = new System.Windows.Forms.TextBox();
            this.btnExpand = new System.Windows.Forms.Button();
            this.cntxtMenMod = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.removeModToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblChatTest = new System.Windows.Forms.Label();
            this.lblMod = new System.Windows.Forms.Label();
            this.labUISoulsLost = new System.Windows.Forms.Label();
            this.tbxSoulsLost = new System.Windows.Forms.TextBox();
            this.btnBGColor = new System.Windows.Forms.Button();
            this.labBGColor = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.imgSouls = new System.Windows.Forms.PictureBox();
            this.pbFalls = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFGColor = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.cntxtMenMod.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgSouls)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFalls)).BeginInit();
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
            this.labThisSeg.Location = new System.Drawing.Point(0, 68);
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
            this.labBoss.Location = new System.Drawing.Point(0, 114);
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
            this.labArea.Location = new System.Drawing.Point(0, 157);
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
            this.panel1.Controls.Add(this.imgSouls);
            this.panel1.Controls.Add(this.pbFalls);
            this.panel1.Controls.Add(this.labFall);
            this.panel1.Controls.Add(this.labBoss);
            this.panel1.Controls.Add(this.labThisSeg);
            this.panel1.Controls.Add(this.labArea);
            this.panel1.Controls.Add(this.labTotal);
            this.panel1.Controls.Add(this.labSouls);
            this.panel1.Location = new System.Drawing.Point(130, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(420, 290);
            this.panel1.TabIndex = 4;
            // 
            // labFall
            // 
            this.labFall.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labFall.BackColor = System.Drawing.Color.Transparent;
            this.labFall.Font = new System.Drawing.Font("OptimusPrincepsSemiBold", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labFall.ForeColor = System.Drawing.Color.White;
            this.labFall.Location = new System.Drawing.Point(348, 203);
            this.labFall.Name = "labFall";
            this.labFall.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labFall.Size = new System.Drawing.Size(69, 38);
            this.labFall.TabIndex = 5;
            this.labFall.Text = ": %s";
            this.labFall.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labSouls
            // 
            this.labSouls.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labSouls.Font = new System.Drawing.Font("OptimusPrincepsSemiBold", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSouls.ForeColor = System.Drawing.Color.White;
            this.labSouls.Location = new System.Drawing.Point(0, 235);
            this.labSouls.Name = "labSouls";
            this.labSouls.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labSouls.Size = new System.Drawing.Size(417, 55);
            this.labSouls.TabIndex = 7;
            this.labSouls.Text = "Lost: %s";
            this.labSouls.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(6, 300);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(335, 214);
            this.listView1.TabIndex = 9;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Boss Name";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Boss";
            this.columnHeader2.Width = 37;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Area";
            this.columnHeader3.Width = 35;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Falls";
            this.columnHeader4.Width = 34;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Souls";
            this.columnHeader5.Width = 40;
            // 
            // btnNewSeg
            // 
            this.btnNewSeg.Location = new System.Drawing.Point(13, 216);
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
            // tbxTest
            // 
            this.tbxTest.Location = new System.Drawing.Point(408, 301);
            this.tbxTest.Name = "tbxTest";
            this.tbxTest.Size = new System.Drawing.Size(133, 20);
            this.tbxTest.TabIndex = 18;
            this.tbxTest.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxTest_KeyDown);
            // 
            // listMods
            // 
            this.listMods.Location = new System.Drawing.Point(348, 328);
            this.listMods.Name = "listMods";
            this.listMods.Size = new System.Drawing.Size(193, 160);
            this.listMods.TabIndex = 19;
            this.listMods.UseCompatibleStateImageBehavior = false;
            this.listMods.View = System.Windows.Forms.View.List;
            this.listMods.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listMods_MouseClick);
            // 
            // btnAddMod
            // 
            this.btnAddMod.Location = new System.Drawing.Point(517, 493);
            this.btnAddMod.Name = "btnAddMod";
            this.btnAddMod.Size = new System.Drawing.Size(24, 23);
            this.btnAddMod.TabIndex = 20;
            this.btnAddMod.Text = "+";
            this.btnAddMod.UseVisualStyleBackColor = true;
            this.btnAddMod.Click += new System.EventHandler(this.btnAddMod_Click);
            // 
            // tbxMod
            // 
            this.tbxMod.Location = new System.Drawing.Point(406, 494);
            this.tbxMod.Name = "tbxMod";
            this.tbxMod.Size = new System.Drawing.Size(105, 20);
            this.tbxMod.TabIndex = 21;
            // 
            // btnExpand
            // 
            this.btnExpand.Location = new System.Drawing.Point(12, 265);
            this.btnExpand.Name = "btnExpand";
            this.btnExpand.Size = new System.Drawing.Size(99, 25);
            this.btnExpand.TabIndex = 22;
            this.btnExpand.Text = "v";
            this.btnExpand.UseVisualStyleBackColor = true;
            this.btnExpand.Click += new System.EventHandler(this.btnExpand_Click);
            // 
            // cntxtMenMod
            // 
            this.cntxtMenMod.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeModToolStripMenuItem});
            this.cntxtMenMod.Name = "cntxtMenMod";
            this.cntxtMenMod.Size = new System.Drawing.Size(146, 26);
            // 
            // removeModToolStripMenuItem
            // 
            this.removeModToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeToolStripMenuItem});
            this.removeModToolStripMenuItem.Name = "removeModToolStripMenuItem";
            this.removeModToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.removeModToolStripMenuItem.Text = "Remove Mod";
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // lblChatTest
            // 
            this.lblChatTest.AutoSize = true;
            this.lblChatTest.Location = new System.Drawing.Point(347, 304);
            this.lblChatTest.Name = "lblChatTest";
            this.lblChatTest.Size = new System.Drawing.Size(55, 13);
            this.lblChatTest.TabIndex = 24;
            this.lblChatTest.Text = "Test Cmd:";
            // 
            // lblMod
            // 
            this.lblMod.AutoSize = true;
            this.lblMod.Location = new System.Drawing.Point(347, 498);
            this.lblMod.Name = "lblMod";
            this.lblMod.Size = new System.Drawing.Size(53, 13);
            this.lblMod.TabIndex = 25;
            this.lblMod.Text = "Add Mod:";
            // 
            // labUISoulsLost
            // 
            this.labUISoulsLost.AutoSize = true;
            this.labUISoulsLost.Location = new System.Drawing.Point(9, 173);
            this.labUISoulsLost.Name = "labUISoulsLost";
            this.labUISoulsLost.Size = new System.Drawing.Size(56, 13);
            this.labUISoulsLost.TabIndex = 27;
            this.labUISoulsLost.Text = "Souls Lost";
            // 
            // tbxSoulsLost
            // 
            this.tbxSoulsLost.Location = new System.Drawing.Point(12, 189);
            this.tbxSoulsLost.Name = "tbxSoulsLost";
            this.tbxSoulsLost.Size = new System.Drawing.Size(100, 20);
            this.tbxSoulsLost.TabIndex = 26;
            // 
            // btnBGColor
            // 
            this.btnBGColor.BackColor = this.panel1.BackColor;
            this.btnBGColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBGColor.Location = new System.Drawing.Point(40, 521);
            this.btnBGColor.Name = "btnBGColor";
            this.btnBGColor.Size = new System.Drawing.Size(29, 28);
            this.btnBGColor.TabIndex = 28;
            this.btnBGColor.UseVisualStyleBackColor = false;
            this.btnBGColor.Click += new System.EventHandler(this.btnBGColor_Click);
            // 
            // labBGColor
            // 
            this.labBGColor.AutoSize = true;
            this.labBGColor.Location = new System.Drawing.Point(6, 521);
            this.labBGColor.Name = "labBGColor";
            this.labBGColor.Size = new System.Drawing.Size(31, 26);
            this.labBGColor.TabIndex = 29;
            this.labBGColor.Text = "BG\r\nColor";
            // 
            // imgSouls
            // 
            this.imgSouls.Image = global::DSDeaths.Properties.Resources.large_soul;
            this.imgSouls.Location = new System.Drawing.Point(235, 243);
            this.imgSouls.Name = "imgSouls";
            this.imgSouls.Size = new System.Drawing.Size(40, 45);
            this.imgSouls.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgSouls.TabIndex = 6;
            this.imgSouls.TabStop = false;
            // 
            // pbFalls
            // 
            this.pbFalls.BackgroundImage = global::DSDeaths.Properties.Resources.falling;
            this.pbFalls.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbFalls.Location = new System.Drawing.Point(329, 203);
            this.pbFalls.Name = "pbFalls";
            this.pbFalls.Size = new System.Drawing.Size(33, 35);
            this.pbFalls.TabIndex = 4;
            this.pbFalls.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 521);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 26);
            this.label1.TabIndex = 31;
            this.label1.Text = "Text\r\nColor";
            // 
            // btnFGColor
            // 
            this.btnFGColor.BackColor = this.panel1.BackColor;
            this.btnFGColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFGColor.Location = new System.Drawing.Point(114, 521);
            this.btnFGColor.Name = "btnFGColor";
            this.btnFGColor.Size = new System.Drawing.Size(29, 28);
            this.btnFGColor.TabIndex = 30;
            this.btnFGColor.UseVisualStyleBackColor = false;
            this.btnFGColor.Click += new System.EventHandler(this.btnFGColor_Click);
            // 
            // Overlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(550, 561);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFGColor);
            this.Controls.Add(this.labBGColor);
            this.Controls.Add(this.btnBGColor);
            this.Controls.Add(this.labUISoulsLost);
            this.Controls.Add(this.tbxSoulsLost);
            this.Controls.Add(this.lblMod);
            this.Controls.Add(this.lblChatTest);
            this.Controls.Add(this.btnExpand);
            this.Controls.Add(this.tbxMod);
            this.Controls.Add(this.btnAddMod);
            this.Controls.Add(this.listMods);
            this.Controls.Add(this.tbxTest);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Overlay";
            this.Text = "Dark Souls Deaths";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Overlay_FormClosing);
            this.panel1.ResumeLayout(false);
            this.cntxtMenMod.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgSouls)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFalls)).EndInit();
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
        private System.Windows.Forms.PictureBox pbFalls;
        private System.Windows.Forms.Label labFall;
        private System.Windows.Forms.Label labUIFallDeaths;
        private System.Windows.Forms.TextBox tbxFallDeaths;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TextBox tbxTest;
        private System.Windows.Forms.ListView listMods;
        private System.Windows.Forms.Button btnAddMod;
        private System.Windows.Forms.TextBox tbxMod;
        private System.Windows.Forms.Button btnExpand;
        private System.Windows.Forms.ContextMenuStrip cntxtMenMod;
        private System.Windows.Forms.ToolStripMenuItem removeModToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.Label lblChatTest;
        private System.Windows.Forms.Label lblMod;
        private System.Windows.Forms.PictureBox imgSouls;
        private System.Windows.Forms.Label labSouls;
        private System.Windows.Forms.Label labUISoulsLost;
        private System.Windows.Forms.TextBox tbxSoulsLost;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button btnBGColor;
        private System.Windows.Forms.Label labBGColor;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFGColor;
    }
}

