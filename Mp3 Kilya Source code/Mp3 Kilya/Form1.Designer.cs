namespace Mp3_Kilya
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Start = new System.Windows.Forms.Button();
            this.restart = new System.Windows.Forms.Button();
            this.play = new System.Windows.Forms.Button();
            this.pausse = new System.Windows.Forms.Button();
            this.stop = new System.Windows.Forms.Button();
            this.load = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox_path = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.totaletemp = new System.Windows.Forms.Label();
            this.slach = new System.Windows.Forms.Label();
            this.ambiance_Button_21 = new Ambiance.Ambiance_Button_2();
            this.ambiance_LinkLabel1 = new Ambiance.Ambiance_LinkLabel();
            this.ambiance_TrackBar2 = new Ambiance.Ambiance_TrackBar();
            this.ambiance_TrackBar1 = new Ambiance.Ambiance_TrackBar();
            this.ambiance_Button_22 = new Ambiance.Ambiance_Button_2();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(0);
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.menuStrip1.Location = new System.Drawing.Point(1, 1);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(35, 17);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 17);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.aboutToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Start
            // 
            this.Start.BackgroundImage = global::Mp3_Kilya.Properties.Resources.start1;
            this.Start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Start.Location = new System.Drawing.Point(10, 333);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(26, 27);
            this.Start.TabIndex = 1;
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // restart
            // 
            this.restart.BackgroundImage = global::Mp3_Kilya.Properties.Resources.restart;
            this.restart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.restart.Location = new System.Drawing.Point(10, 333);
            this.restart.Name = "restart";
            this.restart.Size = new System.Drawing.Size(26, 27);
            this.restart.TabIndex = 2;
            this.restart.UseVisualStyleBackColor = true;
            this.restart.Visible = false;
            this.restart.Click += new System.EventHandler(this.restart_Click);
            // 
            // play
            // 
            this.play.BackgroundImage = global::Mp3_Kilya.Properties.Resources.play;
            this.play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.play.Location = new System.Drawing.Point(42, 333);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(26, 27);
            this.play.TabIndex = 3;
            this.play.UseVisualStyleBackColor = true;
            this.play.Click += new System.EventHandler(this.play_Click);
            // 
            // pausse
            // 
            this.pausse.BackgroundImage = global::Mp3_Kilya.Properties.Resources.Pause;
            this.pausse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pausse.Location = new System.Drawing.Point(42, 333);
            this.pausse.Name = "pausse";
            this.pausse.Size = new System.Drawing.Size(26, 27);
            this.pausse.TabIndex = 4;
            this.pausse.UseVisualStyleBackColor = true;
            this.pausse.Visible = false;
            this.pausse.Click += new System.EventHandler(this.pausse_Click);
            // 
            // stop
            // 
            this.stop.BackgroundImage = global::Mp3_Kilya.Properties.Resources.stop;
            this.stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stop.Location = new System.Drawing.Point(74, 333);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(26, 27);
            this.stop.TabIndex = 5;
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // load
            // 
            this.load.BackgroundImage = global::Mp3_Kilya.Properties.Resources.load;
            this.load.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.load.Location = new System.Drawing.Point(491, 307);
            this.load.Name = "load";
            this.load.Size = new System.Drawing.Size(47, 19);
            this.load.TabIndex = 6;
            this.load.UseVisualStyleBackColor = true;
            this.load.Click += new System.EventHandler(this.load_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(345, 308);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Choisir un File .mp3 :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Mp3_Kilya.Properties.Resources.A_Kilya;
            this.pictureBox1.Location = new System.Drawing.Point(401, 240);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 120);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // textBox_path
            // 
            this.textBox_path.Location = new System.Drawing.Point(393, 214);
            this.textBox_path.Name = "textBox_path";
            this.textBox_path.Size = new System.Drawing.Size(154, 20);
            this.textBox_path.TabIndex = 9;
            this.textBox_path.Visible = false;
            this.textBox_path.TextChanged += new System.EventHandler(this.textBox_path_TextChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Mp3_Kilya.Properties.Resources.Logo;
            this.pictureBox2.Location = new System.Drawing.Point(221, 32);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(245, 259);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::Mp3_Kilya.Properties.Resources.Me_1;
            this.pictureBox3.Location = new System.Drawing.Point(0, 27);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(193, 182);
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(370, 376);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 18);
            this.label2.TabIndex = 12;
            this.label2.Text = "Copyright @                 2015.";
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(302, 119);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(137, 23);
            this.axWindowsMediaPlayer1.TabIndex = 13;
            this.axWindowsMediaPlayer1.Enter += new System.EventHandler(this.axWindowsMediaPlayer1_Enter);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = global::Mp3_Kilya.Properties.Resources.tumblr_mwekviYiEG1rqsb0so1_250;
            this.pictureBox4.Location = new System.Drawing.Point(37, 230);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(154, 94);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 14;
            this.pictureBox4.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(8, 370);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "....";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // totaletemp
            // 
            this.totaletemp.AutoSize = true;
            this.totaletemp.BackColor = System.Drawing.Color.Transparent;
            this.totaletemp.Location = new System.Drawing.Point(46, 370);
            this.totaletemp.MaximumSize = new System.Drawing.Size(100, 20);
            this.totaletemp.Name = "totaletemp";
            this.totaletemp.Size = new System.Drawing.Size(19, 13);
            this.totaletemp.TabIndex = 21;
            this.totaletemp.Text = "....";
            this.totaletemp.Click += new System.EventHandler(this.totaletemp_Click);
            // 
            // slach
            // 
            this.slach.AutoSize = true;
            this.slach.BackColor = System.Drawing.Color.Transparent;
            this.slach.Location = new System.Drawing.Point(30, 370);
            this.slach.Name = "slach";
            this.slach.Size = new System.Drawing.Size(12, 13);
            this.slach.TabIndex = 21;
            this.slach.Text = "/";
            this.slach.Visible = false;
            // 
            // ambiance_Button_21
            // 
            this.ambiance_Button_21.BackColor = System.Drawing.Color.Transparent;
            this.ambiance_Button_21.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.ambiance_Button_21.Image = null;
            this.ambiance_Button_21.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ambiance_Button_21.Location = new System.Drawing.Point(198, 333);
            this.ambiance_Button_21.Name = "ambiance_Button_21";
            this.ambiance_Button_21.Size = new System.Drawing.Size(46, 26);
            this.ambiance_Button_21.TabIndex = 22;
            this.ambiance_Button_21.Text = "Muet";
            this.ambiance_Button_21.TextAlignment = System.Drawing.StringAlignment.Center;
            this.ambiance_Button_21.Click += new System.EventHandler(this.ambiance_Button_21_Click);
            // 
            // ambiance_LinkLabel1
            // 
            this.ambiance_LinkLabel1.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(72)))), ((int)(((byte)(20)))));
            this.ambiance_LinkLabel1.AutoSize = true;
            this.ambiance_LinkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.ambiance_LinkLabel1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.ambiance_LinkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.ambiance_LinkLabel1.LinkColor = System.Drawing.Color.WhiteSmoke;
            this.ambiance_LinkLabel1.Location = new System.Drawing.Point(453, 374);
            this.ambiance_LinkLabel1.Name = "ambiance_LinkLabel1";
            this.ambiance_LinkLabel1.Size = new System.Drawing.Size(54, 20);
            this.ambiance_LinkLabel1.TabIndex = 19;
            this.ambiance_LinkLabel1.TabStop = true;
            this.ambiance_LinkLabel1.Text = "A.Kilya";
            this.ambiance_LinkLabel1.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(119)))), ((int)(((byte)(70)))));
            this.ambiance_LinkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ambiance_LinkLabel1_LinkClicked);
            // 
            // ambiance_TrackBar2
            // 
            this.ambiance_TrackBar2.DrawValueString = false;
            this.ambiance_TrackBar2.JumpToMouse = false;
            this.ambiance_TrackBar2.Location = new System.Drawing.Point(8, 202);
            this.ambiance_TrackBar2.Maximum = 10;
            this.ambiance_TrackBar2.Minimum = 0;
            this.ambiance_TrackBar2.MinimumSize = new System.Drawing.Size(47, 22);
            this.ambiance_TrackBar2.Name = "ambiance_TrackBar2";
            this.ambiance_TrackBar2.Size = new System.Drawing.Size(179, 22);
            this.ambiance_TrackBar2.TabIndex = 18;
            this.ambiance_TrackBar2.Text = "ambiance_TrackBar2";
            this.ambiance_TrackBar2.Value = 0;
            this.ambiance_TrackBar2.ValueDivison = Ambiance.Ambiance_TrackBar.ValueDivisor.By1;
            this.ambiance_TrackBar2.ValueToSet = 0F;
            this.ambiance_TrackBar2.Visible = false;
            this.ambiance_TrackBar2.ValueChanged += new Ambiance.Ambiance_TrackBar.ValueChangedEventHandler(this.ambiance_TrackBar2_ValueChanged);
            // 
            // ambiance_TrackBar1
            // 
            this.ambiance_TrackBar1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ambiance_TrackBar1.DrawValueString = false;
            this.ambiance_TrackBar1.JumpToMouse = false;
            this.ambiance_TrackBar1.Location = new System.Drawing.Point(106, 337);
            this.ambiance_TrackBar1.Maximum = 100;
            this.ambiance_TrackBar1.Minimum = 0;
            this.ambiance_TrackBar1.MinimumSize = new System.Drawing.Size(47, 22);
            this.ambiance_TrackBar1.Name = "ambiance_TrackBar1";
            this.ambiance_TrackBar1.Size = new System.Drawing.Size(86, 22);
            this.ambiance_TrackBar1.TabIndex = 17;
            this.ambiance_TrackBar1.Text = "ambiance_TrackBar1";
            this.ambiance_TrackBar1.Value = 20;
            this.ambiance_TrackBar1.ValueDivison = Ambiance.Ambiance_TrackBar.ValueDivisor.By1;
            this.ambiance_TrackBar1.ValueToSet = 20F;
            this.ambiance_TrackBar1.ValueChanged += new Ambiance.Ambiance_TrackBar.ValueChangedEventHandler(this.ambiance_TrackBar1_ValueChanged);
            // 
            // ambiance_Button_22
            // 
            this.ambiance_Button_22.BackColor = System.Drawing.Color.Transparent;
            this.ambiance_Button_22.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.ambiance_Button_22.Image = null;
            this.ambiance_Button_22.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ambiance_Button_22.Location = new System.Drawing.Point(198, 333);
            this.ambiance_Button_22.Name = "ambiance_Button_22";
            this.ambiance_Button_22.Size = new System.Drawing.Size(46, 26);
            this.ambiance_Button_22.TabIndex = 23;
            this.ambiance_Button_22.Text = "Son";
            this.ambiance_Button_22.TextAlignment = System.Drawing.StringAlignment.Center;
            this.ambiance_Button_22.Visible = false;
            this.ambiance_Button_22.Click += new System.EventHandler(this.ambiance_Button_22_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Mp3_Kilya.Properties.Resources.Bg;
            this.ClientSize = new System.Drawing.Size(550, 395);
            this.Controls.Add(this.ambiance_Button_21);
            this.Controls.Add(this.slach);
            this.Controls.Add(this.totaletemp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ambiance_LinkLabel1);
            this.Controls.Add(this.ambiance_TrackBar2);
            this.Controls.Add(this.ambiance_TrackBar1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.textBox_path);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.load);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.restart);
            this.Controls.Add(this.pausse);
            this.Controls.Add(this.play);
            this.Controls.Add(this.ambiance_Button_22);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "  MP3 == Kilya";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button restart;
        private System.Windows.Forms.Button play;
        private System.Windows.Forms.Button pausse;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.Button load;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox_path;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label2;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox4;
        private Ambiance.Ambiance_TrackBar ambiance_TrackBar1;
        private Ambiance.Ambiance_TrackBar ambiance_TrackBar2;
        private Ambiance.Ambiance_LinkLabel ambiance_LinkLabel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label totaletemp;
        private System.Windows.Forms.Label slach;
        private Ambiance.Ambiance_Button_2 ambiance_Button_21;
        private Ambiance.Ambiance_Button_2 ambiance_Button_22;
    }
}

