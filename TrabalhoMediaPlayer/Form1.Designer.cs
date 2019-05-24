namespace TrabalhoMediaPlayer
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


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonUltimo = new System.Windows.Forms.Button();
            this.buttonPrimeiro = new System.Windows.Forms.Button();
            this.textBoxAleatorio = new System.Windows.Forms.TextBox();
            this.buttonAleatorio = new System.Windows.Forms.Button();
            this.buttonDEL = new System.Windows.Forms.Button();
            this.buttonbusca = new System.Windows.Forms.Button();
            this.buttonplay = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonfoward = new System.Windows.Forms.Button();
            this.buttonback = new System.Windows.Forms.Button();
            this.buttonstop = new System.Windows.Forms.Button();
            this.buttonpause = new System.Windows.Forms.Button();
            this.treeViewMusic = new System.Windows.Forms.TreeView();
            this.listaimagens = new System.Windows.Forms.ImageList(this.components);
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.verticalProgressBar5 = new TrabalhoMediaPlayer.VerticalProgressBar();
            this.verticalProgressBar4 = new TrabalhoMediaPlayer.VerticalProgressBar();
            this.verticalProgressBar3 = new TrabalhoMediaPlayer.VerticalProgressBar();
            this.verticalProgressBar2 = new TrabalhoMediaPlayer.VerticalProgressBar();
            this.verticalProgressBar1 = new TrabalhoMediaPlayer.VerticalProgressBar();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.buttonUltimo);
            this.panel1.Controls.Add(this.buttonPrimeiro);
            this.panel1.Controls.Add(this.textBoxAleatorio);
            this.panel1.Controls.Add(this.buttonAleatorio);
            this.panel1.Controls.Add(this.buttonDEL);
            this.panel1.Controls.Add(this.buttonbusca);
            this.panel1.Controls.Add(this.buttonplay);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.buttonfoward);
            this.panel1.Controls.Add(this.buttonback);
            this.panel1.Controls.Add(this.buttonstop);
            this.panel1.Controls.Add(this.buttonpause);
            this.panel1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(772, 115);
            this.panel1.TabIndex = 1;
            // 
            // buttonUltimo
            // 
            this.buttonUltimo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonUltimo.BackgroundImage")));
            this.buttonUltimo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonUltimo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUltimo.Location = new System.Drawing.Point(707, 26);
            this.buttonUltimo.Name = "buttonUltimo";
            this.buttonUltimo.Size = new System.Drawing.Size(58, 71);
            this.buttonUltimo.TabIndex = 13;
            this.buttonUltimo.UseVisualStyleBackColor = true;
            this.buttonUltimo.Click += new System.EventHandler(this.buttonUltimo_Click);
            // 
            // buttonPrimeiro
            // 
            this.buttonPrimeiro.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonPrimeiro.BackgroundImage")));
            this.buttonPrimeiro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonPrimeiro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPrimeiro.Location = new System.Drawing.Point(624, 26);
            this.buttonPrimeiro.Name = "buttonPrimeiro";
            this.buttonPrimeiro.Size = new System.Drawing.Size(77, 72);
            this.buttonPrimeiro.TabIndex = 12;
            this.buttonPrimeiro.Text = "button1";
            this.buttonPrimeiro.UseVisualStyleBackColor = true;
            this.buttonPrimeiro.Click += new System.EventHandler(this.buttonPrimeiro_Click);
            // 
            // textBoxAleatorio
            // 
            this.textBoxAleatorio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxAleatorio.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBoxAleatorio.Location = new System.Drawing.Point(554, 88);
            this.textBoxAleatorio.Name = "textBoxAleatorio";
            this.textBoxAleatorio.Size = new System.Drawing.Size(51, 20);
            this.textBoxAleatorio.TabIndex = 11;
            // 
            // buttonAleatorio
            // 
            this.buttonAleatorio.BackColor = System.Drawing.SystemColors.Desktop;
            this.buttonAleatorio.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonAleatorio.BackgroundImage")));
            this.buttonAleatorio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonAleatorio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAleatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAleatorio.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonAleatorio.Location = new System.Drawing.Point(534, 26);
            this.buttonAleatorio.Name = "buttonAleatorio";
            this.buttonAleatorio.Size = new System.Drawing.Size(84, 71);
            this.buttonAleatorio.TabIndex = 10;
            this.buttonAleatorio.UseVisualStyleBackColor = false;
            this.buttonAleatorio.Click += new System.EventHandler(this.buttonAleatorio_Click);
            // 
            // buttonDEL
            // 
            this.buttonDEL.BackColor = System.Drawing.SystemColors.Desktop;
            this.buttonDEL.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonDEL.BackgroundImage")));
            this.buttonDEL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonDEL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDEL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDEL.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonDEL.Location = new System.Drawing.Point(459, 20);
            this.buttonDEL.Name = "buttonDEL";
            this.buttonDEL.Size = new System.Drawing.Size(69, 84);
            this.buttonDEL.TabIndex = 9;
            this.buttonDEL.UseVisualStyleBackColor = false;
            this.buttonDEL.Click += new System.EventHandler(this.buttonDEL_Click);
            // 
            // buttonbusca
            // 
            this.buttonbusca.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonbusca.BackgroundImage")));
            this.buttonbusca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonbusca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonbusca.FlatAppearance.BorderSize = 0;
            this.buttonbusca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonbusca.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonbusca.Location = new System.Drawing.Point(3, 25);
            this.buttonbusca.Name = "buttonbusca";
            this.buttonbusca.Size = new System.Drawing.Size(80, 73);
            this.buttonbusca.TabIndex = 8;
            this.buttonbusca.UseVisualStyleBackColor = true;
            this.buttonbusca.Click += new System.EventHandler(this.buttonbusca_Click);
            // 
            // buttonplay
            // 
            this.buttonplay.BackColor = System.Drawing.SystemColors.InfoText;
            this.buttonplay.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonplay.BackgroundImage")));
            this.buttonplay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonplay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonplay.FlatAppearance.BorderSize = 0;
            this.buttonplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonplay.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonplay.Location = new System.Drawing.Point(86, 26);
            this.buttonplay.Name = "buttonplay";
            this.buttonplay.Size = new System.Drawing.Size(62, 72);
            this.buttonplay.TabIndex = 7;
            this.buttonplay.UseVisualStyleBackColor = false;
            this.buttonplay.Click += new System.EventHandler(this.buttonplay_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.MenuText;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(641, -2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // buttonfoward
            // 
            this.buttonfoward.BackColor = System.Drawing.SystemColors.InfoText;
            this.buttonfoward.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonfoward.BackgroundImage")));
            this.buttonfoward.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonfoward.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonfoward.FlatAppearance.BorderSize = 0;
            this.buttonfoward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonfoward.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonfoward.Location = new System.Drawing.Point(387, 26);
            this.buttonfoward.Margin = new System.Windows.Forms.Padding(0);
            this.buttonfoward.Name = "buttonfoward";
            this.buttonfoward.Size = new System.Drawing.Size(65, 72);
            this.buttonfoward.TabIndex = 5;
            this.buttonfoward.UseVisualStyleBackColor = false;
            this.buttonfoward.Click += new System.EventHandler(this.buttonfoward_Click_1);
            // 
            // buttonback
            // 
            this.buttonback.BackColor = System.Drawing.SystemColors.InfoText;
            this.buttonback.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonback.BackgroundImage")));
            this.buttonback.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonback.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonback.FlatAppearance.BorderSize = 0;
            this.buttonback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonback.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonback.Location = new System.Drawing.Point(313, 26);
            this.buttonback.Name = "buttonback";
            this.buttonback.Size = new System.Drawing.Size(65, 72);
            this.buttonback.TabIndex = 6;
            this.buttonback.UseVisualStyleBackColor = false;
            this.buttonback.Click += new System.EventHandler(this.buttonback_Click_1);
            // 
            // buttonstop
            // 
            this.buttonstop.BackColor = System.Drawing.SystemColors.InfoText;
            this.buttonstop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonstop.BackgroundImage")));
            this.buttonstop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonstop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonstop.FlatAppearance.BorderSize = 0;
            this.buttonstop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonstop.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonstop.Location = new System.Drawing.Point(234, 26);
            this.buttonstop.Name = "buttonstop";
            this.buttonstop.Size = new System.Drawing.Size(63, 72);
            this.buttonstop.TabIndex = 3;
            this.buttonstop.UseVisualStyleBackColor = false;
            this.buttonstop.Click += new System.EventHandler(this.buttonstop_Click_1);
            // 
            // buttonpause
            // 
            this.buttonpause.BackColor = System.Drawing.SystemColors.InfoText;
            this.buttonpause.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonpause.BackgroundImage")));
            this.buttonpause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonpause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonpause.FlatAppearance.BorderSize = 0;
            this.buttonpause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonpause.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonpause.Location = new System.Drawing.Point(160, 25);
            this.buttonpause.Name = "buttonpause";
            this.buttonpause.Size = new System.Drawing.Size(62, 72);
            this.buttonpause.TabIndex = 4;
            this.buttonpause.UseVisualStyleBackColor = false;
            this.buttonpause.Click += new System.EventHandler(this.buttonpause_Click);
            // 
            // treeViewMusic
            // 
            this.treeViewMusic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.treeViewMusic.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeViewMusic.ImageIndex = 0;
            this.treeViewMusic.ImageList = this.listaimagens;
            this.treeViewMusic.Location = new System.Drawing.Point(2, 121);
            this.treeViewMusic.Name = "treeViewMusic";
            this.treeViewMusic.SelectedImageIndex = 2;
            this.treeViewMusic.Size = new System.Drawing.Size(652, 277);
            this.treeViewMusic.TabIndex = 2;
            // 
            // listaimagens
            // 
            this.listaimagens.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("listaimagens.ImageStream")));
            this.listaimagens.TransparentColor = System.Drawing.Color.Transparent;
            this.listaimagens.Images.SetKeyName(0, "music");
            this.listaimagens.Images.SetKeyName(1, "harddisk");
            this.listaimagens.Images.SetKeyName(2, "Time");
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 10;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // verticalProgressBar5
            // 
            this.verticalProgressBar5.BackColor = System.Drawing.Color.DimGray;
            this.verticalProgressBar5.Location = new System.Drawing.Point(684, 121);
            this.verticalProgressBar5.Name = "verticalProgressBar5";
            this.verticalProgressBar5.Size = new System.Drawing.Size(18, 277);
            this.verticalProgressBar5.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.verticalProgressBar5.TabIndex = 13;
            // 
            // verticalProgressBar4
            // 
            this.verticalProgressBar4.BackColor = System.Drawing.Color.DimGray;
            this.verticalProgressBar4.Location = new System.Drawing.Point(708, 121);
            this.verticalProgressBar4.Name = "verticalProgressBar4";
            this.verticalProgressBar4.Size = new System.Drawing.Size(18, 277);
            this.verticalProgressBar4.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.verticalProgressBar4.TabIndex = 12;
            // 
            // verticalProgressBar3
            // 
            this.verticalProgressBar3.BackColor = System.Drawing.Color.DimGray;
            this.verticalProgressBar3.Location = new System.Drawing.Point(732, 121);
            this.verticalProgressBar3.Name = "verticalProgressBar3";
            this.verticalProgressBar3.Size = new System.Drawing.Size(18, 277);
            this.verticalProgressBar3.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.verticalProgressBar3.TabIndex = 11;
            // 
            // verticalProgressBar2
            // 
            this.verticalProgressBar2.BackColor = System.Drawing.Color.DimGray;
            this.verticalProgressBar2.Location = new System.Drawing.Point(756, 121);
            this.verticalProgressBar2.Name = "verticalProgressBar2";
            this.verticalProgressBar2.Size = new System.Drawing.Size(18, 277);
            this.verticalProgressBar2.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.verticalProgressBar2.TabIndex = 10;
            // 
            // verticalProgressBar1
            // 
            this.verticalProgressBar1.BackColor = System.Drawing.Color.DimGray;
            this.verticalProgressBar1.Location = new System.Drawing.Point(660, 121);
            this.verticalProgressBar1.Name = "verticalProgressBar1";
            this.verticalProgressBar1.Size = new System.Drawing.Size(18, 277);
            this.verticalProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.verticalProgressBar1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(778, 401);
            this.Controls.Add(this.verticalProgressBar5);
            this.Controls.Add(this.verticalProgressBar4);
            this.Controls.Add(this.verticalProgressBar3);
            this.Controls.Add(this.verticalProgressBar2);
            this.Controls.Add(this.verticalProgressBar1);
            this.Controls.Add(this.treeViewMusic);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Player";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonbusca;
        private System.Windows.Forms.Button buttonplay;
        private System.Windows.Forms.Button buttonfoward;
        private System.Windows.Forms.Button buttonback;
        private System.Windows.Forms.Button buttonstop;
        private System.Windows.Forms.Button buttonpause;
        private System.Windows.Forms.TreeView treeViewMusic;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ImageList listaimagens;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ComboBox comboBox1;
        private VerticalProgressBar verticalProgressBar1;
        private VerticalProgressBar verticalProgressBar2;
        private VerticalProgressBar verticalProgressBar3;
        private VerticalProgressBar verticalProgressBar4;
        private VerticalProgressBar verticalProgressBar5;
        private System.Windows.Forms.Button buttonDEL;
        private System.Windows.Forms.Button buttonAleatorio;
        private System.Windows.Forms.TextBox textBoxAleatorio;
        private System.Windows.Forms.Button buttonPrimeiro;
        private System.Windows.Forms.Button buttonUltimo;
    }
}

