using System;
using System.Windows.Forms;
using WMPLib;

namespace RussianRouletteAssessment2020
{
    public partial class Form1 : Form
    {
        private Battle battle = new Battle();
        WindowsMediaPlayer player = new WindowsMediaPlayer();

        public Form1()
        {
            InitializeComponent();
            pnlGame.Visible = false;
            pnlMenu.Visible = true;
            pnlScore.Visible = true;
            lblBattleResult.Visible = false;
            player.URL = "menu.wav";
            player.controls.play();
        }

        private void btnUnsheathe_Click(object sender, EventArgs e)
        {
            System.IO.Stream btnClick = Properties.Resources.unsheathe;
            System.Media.SoundPlayer btnClickSnd = new System.Media.SoundPlayer(btnClick);
            btnClickSnd.Play();
            EnabledPanelContents(pnlWeapons, pnlWeapons.Enabled);
            lblWeapMsg.ForeColor = System.Drawing.Color.Green;
            lblWeapMsg.Text = "Your weapons are prepared, choose wisely";
            btnUnsheathe.Enabled = false;
            battle.Prepare();

        }

        private void btnWpnAll_Clicked(object sender, EventArgs e)
        {
            Button tmpBtn = (Button)sender;
            tmpBtn.Enabled = false;
            lblResult.Text = battle.Attack(tmpBtn.Text);
            lblHealth.Text = battle.Score(lblResult.Text, lblHealth.Text);
            lblScoreLose.Text = battle.HighScore(lblWins.Text, lblScoreLose.Text);

            if (lblHealth.Text == "0")
            {
                System.IO.Stream btnClick = Properties.Resources.lose;
                System.Media.SoundPlayer btnClickSnd = new System.Media.SoundPlayer(btnClick);
                btnClickSnd.Play();
                pnlGame.Visible = false;
                pnlMenu.Visible = true;
                pnlScore.Visible = true;
                btnPlay.Text = "Play Again";
                lblBattleResult.Visible = true;
                lblBattleResult.ForeColor = System.Drawing.Color.Red;
                lblResult.Text = "Lose";
                lblBattleResult.Text = "Your Enemy has killed you...";
                lblWins.Text = "0";
            }
            else if (lblResult.Text == "You have enliminated your enemy")
            {
                System.IO.Stream btnClick = Properties.Resources.win;
                System.Media.SoundPlayer btnClickSnd = new System.Media.SoundPlayer(btnClick);
                btnClickSnd.Play();
                pnlGame.Visible = false;
                pnlMenu.Visible = true;
                pnlScore.Visible = false;
                btnPlay.Text = "Next Battle";
                lblWins.Text = battle.Score(lblResult.Text, lblWins.Text);
                lblBattleResult.Visible = true;
                lblBattleResult.ForeColor = System.Drawing.Color.Green;
                lblBattleResult.Text = "You live to fight another day...";
            }
            else if (lblResult.Text == "Your attack failed")
            {
                lblResult.ForeColor = System.Drawing.Color.Red;
                System.IO.Stream btnClick = Properties.Resources.failed;
                System.Media.SoundPlayer btnClickSnd = new System.Media.SoundPlayer(btnClick);
                btnClickSnd.Play();
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            pnlGame.Visible = true;
            pnlMenu.Visible = false;
            btnUnsheathe.Enabled = true;
            lblHealth.Text = "3";
            lblWeapMsg.ForeColor = System.Drawing.Color.Red;
            lblWeapMsg.Text = "Please prepare your weapons...";
            DisabledPanelContents(pnlWeapons, pnlWeapons.Enabled);
            lblResult.Text = "";
            System.IO.Stream btnClick = Properties.Resources.start;
            System.Media.SoundPlayer btnClickSnd = new System.Media.SoundPlayer(btnClick);
            btnClickSnd.Play();

            //Generate Random Enemy
            lblEnemy.Text = battle.Enemy();

            if (lblEnemy.Text == "Troll")
            {
                pbxEnemy.Image = Properties.Resources.trollGame;
            }
            else if (lblEnemy.Text == "Wraith")
            {
                pbxEnemy.Image = Properties.Resources.wraith;
            }
            else if (lblEnemy.Text == "Dwarf")
            {
                pbxEnemy.Image = Properties.Resources.dwarf;
            }
            else if (lblEnemy.Text == "Undead")
            {
                pbxEnemy.Image = Properties.Resources.undead;
            }
            else if (lblEnemy.Text == "Devil")
            {
                pbxEnemy.Image = Properties.Resources.devil;
            }
        }

        private void DisabledPanelContents(Panel panel, bool enabled)
        {
            foreach (Control ctrl in panel.Controls)
            {
                ctrl.Enabled = false;
            }
        }

        private void EnabledPanelContents(Panel panel, bool enabled)
        {
            foreach (Control ctrl in panel.Controls)
            {
                ctrl.Enabled = true;
            }
        }
    }
}
