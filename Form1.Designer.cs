namespace RussianRouletteAssessment2020
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
            this.lblEnemy = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.pnlScore = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.lblScoreLose = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblBattleResult = new System.Windows.Forms.Label();
            this.pnlInstructions = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnUnsheathe = new System.Windows.Forms.Button();
            this.lblWeapMsg = new System.Windows.Forms.Label();
            this.btnWpn5 = new System.Windows.Forms.Button();
            this.btnWpn3 = new System.Windows.Forms.Button();
            this.btnWpn4 = new System.Windows.Forms.Button();
            this.btnWpn2 = new System.Windows.Forms.Button();
            this.btnWpn1 = new System.Windows.Forms.Button();
            this.btnWpn0 = new System.Windows.Forms.Button();
            this.pbxEnemy = new System.Windows.Forms.PictureBox();
            this.pnlWeapons = new System.Windows.Forms.Panel();
            this.pnlGame = new System.Windows.Forms.Panel();
            this.lblWins = new System.Windows.Forms.Label();
            this.lblHealth = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.pnlMenu.SuspendLayout();
            this.pnlScore.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlInstructions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEnemy)).BeginInit();
            this.pnlWeapons.SuspendLayout();
            this.pnlGame.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEnemy
            // 
            this.lblEnemy.AutoSize = true;
            this.lblEnemy.Font = new System.Drawing.Font("Viner Hand ITC", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnemy.Location = new System.Drawing.Point(519, 140);
            this.lblEnemy.Name = "lblEnemy";
            this.lblEnemy.Size = new System.Drawing.Size(116, 45);
            this.lblEnemy.TabIndex = 5;
            this.lblEnemy.Text = "Enemy";
            this.lblEnemy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblResult
            // 
            this.lblResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblResult.Font = new System.Drawing.Font("Viner Hand ITC", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(3, -3);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(1256, 59);
            this.lblResult.TabIndex = 2;
            this.lblResult.Text = "Result";
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblResult);
            this.panel1.Controls.Add(this.lblEnemy);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1262, 190);
            this.panel1.TabIndex = 3;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(1023, 240);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(151, 98);
            this.axWindowsMediaPlayer1.TabIndex = 6;
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.pnlScore);
            this.pnlMenu.Controls.Add(this.panel2);
            this.pnlMenu.Controls.Add(this.pnlInstructions);
            this.pnlMenu.Controls.Add(this.btnPlay);
            this.pnlMenu.Location = new System.Drawing.Point(302, 12);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(748, 609);
            this.pnlMenu.TabIndex = 13;
            // 
            // pnlScore
            // 
            this.pnlScore.Controls.Add(this.label6);
            this.pnlScore.Controls.Add(this.lblScoreLose);
            this.pnlScore.Location = new System.Drawing.Point(496, 505);
            this.pnlScore.Name = "pnlScore";
            this.pnlScore.Size = new System.Drawing.Size(224, 89);
            this.pnlScore.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Viner Hand ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 32);
            this.label6.TabIndex = 12;
            this.label6.Text = "HighScore:";
            // 
            // lblScoreLose
            // 
            this.lblScoreLose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblScoreLose.AutoSize = true;
            this.lblScoreLose.Font = new System.Drawing.Font("Viner Hand ITC", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreLose.ForeColor = System.Drawing.Color.Black;
            this.lblScoreLose.Location = new System.Drawing.Point(147, 15);
            this.lblScoreLose.Name = "lblScoreLose";
            this.lblScoreLose.Size = new System.Drawing.Size(50, 69);
            this.lblScoreLose.TabIndex = 13;
            this.lblScoreLose.Text = "0";
            this.lblScoreLose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblBattleResult);
            this.panel2.Location = new System.Drawing.Point(3, 299);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(732, 72);
            this.panel2.TabIndex = 3;
            // 
            // lblBattleResult
            // 
            this.lblBattleResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBattleResult.AutoSize = true;
            this.lblBattleResult.Font = new System.Drawing.Font("Viner Hand ITC", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBattleResult.Location = new System.Drawing.Point(52, 6);
            this.lblBattleResult.Name = "lblBattleResult";
            this.lblBattleResult.Size = new System.Drawing.Size(134, 61);
            this.lblBattleResult.TabIndex = 2;
            this.lblBattleResult.Text = "label1";
            this.lblBattleResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlInstructions
            // 
            this.pnlInstructions.Controls.Add(this.pictureBox2);
            this.pnlInstructions.Controls.Add(this.label3);
            this.pnlInstructions.Controls.Add(this.label1);
            this.pnlInstructions.Controls.Add(this.label2);
            this.pnlInstructions.Location = new System.Drawing.Point(28, 31);
            this.pnlInstructions.Name = "pnlInstructions";
            this.pnlInstructions.Size = new System.Drawing.Size(710, 468);
            this.pnlInstructions.TabIndex = 11;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::RussianRouletteAssessment2020.Properties.Resources.trollGame1;
            this.pictureBox2.Location = new System.Drawing.Point(58, 34);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(537, 223);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 416);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(644, 30);
            this.label3.TabIndex = 0;
            this.label3.Text = "Choose your weapon carefully. You have 3 tries each battle";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 380);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(447, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "only one of them can kill your opponent";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 343);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(551, 30);
            this.label2.TabIndex = 0;
            this.label2.Text = "You are given 6 weapons to eliminate your enemy";
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.Olive;
            this.btnPlay.Font = new System.Drawing.Font("Viner Hand ITC", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.Location = new System.Drawing.Point(213, 505);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(264, 76);
            this.btnPlay.TabIndex = 10;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnUnsheathe
            // 
            this.btnUnsheathe.Font = new System.Drawing.Font("Viner Hand ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnsheathe.Location = new System.Drawing.Point(27, 576);
            this.btnUnsheathe.Name = "btnUnsheathe";
            this.btnUnsheathe.Size = new System.Drawing.Size(256, 97);
            this.btnUnsheathe.TabIndex = 1;
            this.btnUnsheathe.Text = "Prepare your Weapons";
            this.btnUnsheathe.UseVisualStyleBackColor = true;
            this.btnUnsheathe.Click += new System.EventHandler(this.btnUnsheathe_Click);
            // 
            // lblWeapMsg
            // 
            this.lblWeapMsg.AutoSize = true;
            this.lblWeapMsg.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeapMsg.Location = new System.Drawing.Point(839, 395);
            this.lblWeapMsg.Name = "lblWeapMsg";
            this.lblWeapMsg.Size = new System.Drawing.Size(385, 21);
            this.lblWeapMsg.TabIndex = 9;
            this.lblWeapMsg.Text = "Weapons are assigned as numbers below:";
            // 
            // btnWpn5
            // 
            this.btnWpn5.Image = global::RussianRouletteAssessment2020.Properties.Resources.fire;
            this.btnWpn5.Location = new System.Drawing.Point(261, 174);
            this.btnWpn5.Name = "btnWpn5";
            this.btnWpn5.Size = new System.Drawing.Size(117, 55);
            this.btnWpn5.TabIndex = 8;
            this.btnWpn5.Text = "5";
            this.btnWpn5.UseVisualStyleBackColor = true;
            this.btnWpn5.Click += new System.EventHandler(this.btnWpnAll_Clicked);
            // 
            // btnWpn3
            // 
            this.btnWpn3.Image = global::RussianRouletteAssessment2020.Properties.Resources.crossbow2;
            this.btnWpn3.Location = new System.Drawing.Point(261, 113);
            this.btnWpn3.Name = "btnWpn3";
            this.btnWpn3.Size = new System.Drawing.Size(117, 55);
            this.btnWpn3.TabIndex = 8;
            this.btnWpn3.Text = "3";
            this.btnWpn3.UseVisualStyleBackColor = true;
            this.btnWpn3.Click += new System.EventHandler(this.btnWpnAll_Clicked);
            // 
            // btnWpn4
            // 
            this.btnWpn4.Image = global::RussianRouletteAssessment2020.Properties.Resources.monkey1;
            this.btnWpn4.Location = new System.Drawing.Point(41, 174);
            this.btnWpn4.Name = "btnWpn4";
            this.btnWpn4.Size = new System.Drawing.Size(117, 55);
            this.btnWpn4.TabIndex = 8;
            this.btnWpn4.Text = "4";
            this.btnWpn4.UseVisualStyleBackColor = true;
            this.btnWpn4.Click += new System.EventHandler(this.btnWpnAll_Clicked);
            // 
            // btnWpn2
            // 
            this.btnWpn2.Image = global::RussianRouletteAssessment2020.Properties.Resources.pickaxe2;
            this.btnWpn2.Location = new System.Drawing.Point(41, 113);
            this.btnWpn2.Name = "btnWpn2";
            this.btnWpn2.Size = new System.Drawing.Size(117, 55);
            this.btnWpn2.TabIndex = 8;
            this.btnWpn2.Text = "2";
            this.btnWpn2.UseVisualStyleBackColor = true;
            this.btnWpn2.Click += new System.EventHandler(this.btnWpnAll_Clicked);
            // 
            // btnWpn1
            // 
            this.btnWpn1.Image = ((System.Drawing.Image)(resources.GetObject("btnWpn1.Image")));
            this.btnWpn1.Location = new System.Drawing.Point(261, 52);
            this.btnWpn1.Name = "btnWpn1";
            this.btnWpn1.Size = new System.Drawing.Size(117, 55);
            this.btnWpn1.TabIndex = 8;
            this.btnWpn1.Text = "1";
            this.btnWpn1.UseVisualStyleBackColor = true;
            this.btnWpn1.Click += new System.EventHandler(this.btnWpnAll_Clicked);
            // 
            // btnWpn0
            // 
            this.btnWpn0.Image = global::RussianRouletteAssessment2020.Properties.Resources.sword;
            this.btnWpn0.Location = new System.Drawing.Point(41, 52);
            this.btnWpn0.Name = "btnWpn0";
            this.btnWpn0.Size = new System.Drawing.Size(117, 53);
            this.btnWpn0.TabIndex = 8;
            this.btnWpn0.Text = "0";
            this.btnWpn0.UseVisualStyleBackColor = true;
            this.btnWpn0.Click += new System.EventHandler(this.btnWpnAll_Clicked);
            // 
            // pbxEnemy
            // 
            this.pbxEnemy.Image = global::RussianRouletteAssessment2020.Properties.Resources.trollGame;
            this.pbxEnemy.Location = new System.Drawing.Point(444, 203);
            this.pbxEnemy.Name = "pbxEnemy";
            this.pbxEnemy.Size = new System.Drawing.Size(265, 327);
            this.pbxEnemy.TabIndex = 7;
            this.pbxEnemy.TabStop = false;
            // 
            // pnlWeapons
            // 
            this.pnlWeapons.Controls.Add(this.btnWpn0);
            this.pnlWeapons.Controls.Add(this.btnWpn5);
            this.pnlWeapons.Controls.Add(this.btnWpn1);
            this.pnlWeapons.Controls.Add(this.btnWpn4);
            this.pnlWeapons.Controls.Add(this.btnWpn3);
            this.pnlWeapons.Controls.Add(this.btnWpn2);
            this.pnlWeapons.Location = new System.Drawing.Point(821, 423);
            this.pnlWeapons.Name = "pnlWeapons";
            this.pnlWeapons.Size = new System.Drawing.Size(403, 264);
            this.pnlWeapons.TabIndex = 11;
            // 
            // pnlGame
            // 
            this.pnlGame.Controls.Add(this.axWindowsMediaPlayer1);
            this.pnlGame.Controls.Add(this.lblWins);
            this.pnlGame.Controls.Add(this.lblHealth);
            this.pnlGame.Controls.Add(this.label4);
            this.pnlGame.Controls.Add(this.label7);
            this.pnlGame.Controls.Add(this.lblWeapMsg);
            this.pnlGame.Controls.Add(this.pnlWeapons);
            this.pnlGame.Controls.Add(this.panel1);
            this.pnlGame.Controls.Add(this.pbxEnemy);
            this.pnlGame.Controls.Add(this.btnUnsheathe);
            this.pnlGame.Location = new System.Drawing.Point(1, 1);
            this.pnlGame.Name = "pnlGame";
            this.pnlGame.Size = new System.Drawing.Size(1268, 731);
            this.pnlGame.TabIndex = 12;
            // 
            // lblWins
            // 
            this.lblWins.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWins.AutoSize = true;
            this.lblWins.Font = new System.Drawing.Font("Viner Hand ITC", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWins.ForeColor = System.Drawing.Color.Black;
            this.lblWins.Location = new System.Drawing.Point(108, 214);
            this.lblWins.Name = "lblWins";
            this.lblWins.Size = new System.Drawing.Size(50, 69);
            this.lblWins.TabIndex = 13;
            this.lblWins.Text = "0";
            this.lblWins.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHealth
            // 
            this.lblHealth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHealth.AutoSize = true;
            this.lblHealth.Font = new System.Drawing.Font("Viner Hand ITC", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHealth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblHealth.Location = new System.Drawing.Point(116, 417);
            this.lblHealth.Name = "lblHealth";
            this.lblHealth.Size = new System.Drawing.Size(95, 129);
            this.lblHealth.TabIndex = 13;
            this.lblHealth.Text = "3";
            this.lblHealth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Viner Hand ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 40);
            this.label4.TabIndex = 12;
            this.label4.Text = "Score:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Viner Hand ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(21, 448);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 32);
            this.label7.TabIndex = 12;
            this.label7.Text = "Health:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 734);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlGame);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.pnlMenu.ResumeLayout(false);
            this.pnlScore.ResumeLayout(false);
            this.pnlScore.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlInstructions.ResumeLayout(false);
            this.pnlInstructions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEnemy)).EndInit();
            this.pnlWeapons.ResumeLayout(false);
            this.pnlGame.ResumeLayout(false);
            this.pnlGame.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label lblEnemy;
        private System.Windows.Forms.Button btnUnsheathe;
        private System.Windows.Forms.PictureBox pbxEnemy;
        private System.Windows.Forms.Label lblWeapMsg;
        private System.Windows.Forms.Button btnWpn1;
        private System.Windows.Forms.Button btnWpn3;
        private System.Windows.Forms.Button btnWpn5;
        private System.Windows.Forms.Button btnWpn4;
        private System.Windows.Forms.Button btnWpn2;
        private System.Windows.Forms.Button btnWpn0;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Panel pnlWeapons;
        private System.Windows.Forms.Panel pnlGame;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlInstructions;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblHealth;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblBattleResult;
        private System.Windows.Forms.Panel panel2;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblWins;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblScoreLose;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel pnlScore;
    }
}
