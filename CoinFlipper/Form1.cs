using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace CoinFlipper
{
    public partial class Form1 : Form
    {
        int balance = 100;
        int bet = 0;
        int HighScore = 0;
        bool Landing;
        public Form1()
        {
            InitializeComponent();
        }
        private bool HeadsTails()
        {
            Random rand = new Random();
            int heads = rand.Next(0, 2);
            Debug.WriteLine(heads);
            if (heads == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void animationHeads()
        {
            coinPicture.Image = Properties.Resources.coinBest__2_;
            coinPicture.Refresh();
            System.Threading.Thread.Sleep(100);
            coinPicture.Image = Properties.Resources.coinBest__3_;
            coinPicture.Refresh();
            System.Threading.Thread.Sleep(100);
            coinPicture.Image = Properties.Resources.coinBest__4_;
            coinPicture.Refresh();
            System.Threading.Thread.Sleep(100);
            coinPicture.Image = Properties.Resources.coinBest__5_;
            coinPicture.Refresh();
            System.Threading.Thread.Sleep(100);
            coinPicture.Image = Properties.Resources.coinBest__6_;
            coinPicture.Refresh();
            System.Threading.Thread.Sleep(100);
            coinPicture.Image = Properties.Resources.coinBest__7_;
            coinPicture.Refresh();
            System.Threading.Thread.Sleep(100);
            coinPicture.Image = Properties.Resources.coinBest__8_;
            coinPicture.Refresh();
            System.Threading.Thread.Sleep(100);
            coinPicture.Image = Properties.Resources.coinBest__7_;
            coinPicture.Refresh();
            System.Threading.Thread.Sleep(100);
            coinPicture.Image = Properties.Resources.coinBest__6_;
            coinPicture.Refresh();
            System.Threading.Thread.Sleep(100);
            coinPicture.Image = Properties.Resources.coinBest__5_;
            coinPicture.Refresh();
            System.Threading.Thread.Sleep(100);
            coinPicture.Image = Properties.Resources.coinBest__4_;
            coinPicture.Refresh();
            System.Threading.Thread.Sleep(100);
            coinPicture.Image = Properties.Resources.coinBest__3_;
            coinPicture.Refresh();
            System.Threading.Thread.Sleep(100);
            coinPicture.Image = Properties.Resources.coinBest__2_;
            coinPicture.Refresh();
            System.Threading.Thread.Sleep(100);
            coinPicture.Image = Properties.Resources.coinBest__3_;
            coinPicture.Refresh();
            System.Threading.Thread.Sleep(100);
            coinPicture.Image = Properties.Resources.coinBest__4_;
            coinPicture.Refresh();
            System.Threading.Thread.Sleep(100);
            coinPicture.Image = Properties.Resources.coinBest__5_;
            coinPicture.Refresh();
            System.Threading.Thread.Sleep(100);
            coinPicture.Image = Properties.Resources.coinBest__6_;
            coinPicture.Refresh();
            System.Threading.Thread.Sleep(100);
            coinPicture.Image = Properties.Resources.coinBest__7_;
            coinPicture.Refresh();
            System.Threading.Thread.Sleep(100);
            coinPicture.Image = Properties.Resources.coinBest__8_;
            coinPicture.Refresh();
            System.Threading.Thread.Sleep(100);
            coinPicture.Image = Properties.Resources.coinBest__7_;
            coinPicture.Refresh();
            System.Threading.Thread.Sleep(100);
            coinPicture.Image = Properties.Resources.coinBest__6_;
            coinPicture.Refresh();
            System.Threading.Thread.Sleep(100);
            coinPicture.Image = Properties.Resources.coinBest__5_;
            coinPicture.Refresh();
            System.Threading.Thread.Sleep(100);
            coinPicture.Image = Properties.Resources.coinBest__4_;
            coinPicture.Refresh();
            System.Threading.Thread.Sleep(100);
            coinPicture.Image = Properties.Resources.coinBest__3_;
            coinPicture.Refresh();
            System.Threading.Thread.Sleep(100);
            coinPicture.Image = Properties.Resources.coinBest__2_;
            coinPicture.Refresh();
            System.Threading.Thread.Sleep(100);
            coinPicture.Image = Properties.Resources.coinBest__3_;
            coinPicture.Refresh();
            System.Threading.Thread.Sleep(100);
            coinPicture.Image = Properties.Resources.coinBest__4_;
            coinPicture.Refresh();
            System.Threading.Thread.Sleep(100);
            coinPicture.Image = Properties.Resources.coinBest__5_;
            coinPicture.Refresh();
            System.Threading.Thread.Sleep(100);
            coinPicture.Image = Properties.Resources.coinBest__6_;
            coinPicture.Refresh();
            System.Threading.Thread.Sleep(100);
            coinPicture.Image = Properties.Resources.coinBest__7_;
            coinPicture.Refresh();
            System.Threading.Thread.Sleep(100);
            coinPicture.Image = Properties.Resources.coinBest__8_;
            coinPicture.Refresh();
            System.Threading.Thread.Sleep(100);
            coinPicture.Image = Properties.Resources.coinBest__7_;
            coinPicture.Refresh();
            System.Threading.Thread.Sleep(100);
            coinPicture.Image = Properties.Resources.coinBest__6_;
            coinPicture.Refresh();
            System.Threading.Thread.Sleep(100);
            coinPicture.Image = Properties.Resources.coinBest__5_;
            coinPicture.Refresh();
            System.Threading.Thread.Sleep(100);
            coinPicture.Image = Properties.Resources.coinBest__4_;
            coinPicture.Refresh();
            System.Threading.Thread.Sleep(100);
            coinPicture.Image = Properties.Resources.coinBest__3_;
            coinPicture.Refresh();
            System.Threading.Thread.Sleep(100);
            coinPicture.Image = Properties.Resources.coinBest__2_;
            coinPicture.Refresh();
            System.Threading.Thread.Sleep(100);
            coinPicture.Image = Properties.Resources.coinBest__3_;
            coinPicture.Refresh();
            System.Threading.Thread.Sleep(100);
            coinPicture.Image = Properties.Resources.coinBest__4_;
            coinPicture.Refresh();
            System.Threading.Thread.Sleep(100);
            coinPicture.Image = Properties.Resources.coinBest__5_;
            coinPicture.Refresh();
            System.Threading.Thread.Sleep(100);
            coinPicture.Image = Properties.Resources.coinBest__6_;
            coinPicture.Refresh();
            System.Threading.Thread.Sleep(100);
            coinPicture.Image = Properties.Resources.coinBest__7_;
            coinPicture.Refresh();
            System.Threading.Thread.Sleep(100);
            coinPicture.Image = Properties.Resources.coinBest__8_;
            coinPicture.Refresh();

        }

        private void animationTails()
        {
            coinPicture.Image = Properties.Resources.coinBest__2_;
            coinPicture.Refresh();
            System.Threading.Thread.Sleep(100);
            coinPicture.Image = Properties.Resources.coinBest__3_;
            coinPicture.Refresh();
            System.Threading.Thread.Sleep(100);
            coinPicture.Image = Properties.Resources.coinBest__4_;
            coinPicture.Refresh();
            System.Threading.Thread.Sleep(100);
            coinPicture.Image = Properties.Resources.coinBest__5_;
            coinPicture.Refresh();
            System.Threading.Thread.Sleep(100);
            coinPicture.Image = Properties.Resources.coinBest__6_;
            coinPicture.Refresh();
            System.Threading.Thread.Sleep(100);
            coinPicture.Image = Properties.Resources.coinBest__7_;
            coinPicture.Refresh();
            System.Threading.Thread.Sleep(100);
            coinPicture.Image = Properties.Resources.coinBest__8_;
            coinPicture.Refresh();
            System.Threading.Thread.Sleep(100);
            coinPicture.Image = Properties.Resources.coinBest__7_;
            coinPicture.Refresh();
            System.Threading.Thread.Sleep(100);
            coinPicture.Image = Properties.Resources.coinBest__6_;
            coinPicture.Refresh();
            System.Threading.Thread.Sleep(100);
            coinPicture.Image = Properties.Resources.coinBest__5_;
            coinPicture.Refresh();
            System.Threading.Thread.Sleep(100);
            coinPicture.Image = Properties.Resources.coinBest__4_;
            coinPicture.Refresh();
            System.Threading.Thread.Sleep(100);
            coinPicture.Image = Properties.Resources.coinBest__3_;
            coinPicture.Refresh();
            System.Threading.Thread.Sleep(100);
            coinPicture.Image = Properties.Resources.coinBest__2_;
            coinPicture.Refresh();
            System.Threading.Thread.Sleep(100);
            coinPicture.Image = Properties.Resources.coinBest__3_;
            coinPicture.Refresh();
            System.Threading.Thread.Sleep(100);
            coinPicture.Image = Properties.Resources.coinBest__4_;
            coinPicture.Refresh();
            System.Threading.Thread.Sleep(100);
            coinPicture.Image = Properties.Resources.coinBest__5_;
            coinPicture.Refresh();
            System.Threading.Thread.Sleep(100);
            coinPicture.Image = Properties.Resources.coinBest__6_;
            coinPicture.Refresh();
            System.Threading.Thread.Sleep(100);
            coinPicture.Image = Properties.Resources.coinBest__7_;
            coinPicture.Refresh();
            System.Threading.Thread.Sleep(100);
            coinPicture.Image = Properties.Resources.coinBest__8_;
            coinPicture.Refresh();
            System.Threading.Thread.Sleep(100);
            coinPicture.Image = Properties.Resources.coinBest__7_;
            coinPicture.Refresh();
            System.Threading.Thread.Sleep(100);
            coinPicture.Image = Properties.Resources.coinBest__6_;
            coinPicture.Refresh();
            System.Threading.Thread.Sleep(100);
            coinPicture.Image = Properties.Resources.coinBest__5_;
            coinPicture.Refresh();
            System.Threading.Thread.Sleep(100);
            coinPicture.Image = Properties.Resources.coinBest__4_;
            coinPicture.Refresh();
            System.Threading.Thread.Sleep(100);
            coinPicture.Image = Properties.Resources.coinBest__3_;
            coinPicture.Refresh();
            System.Threading.Thread.Sleep(100);
            coinPicture.Image = Properties.Resources.coinBest__2_;
            coinPicture.Refresh();
            System.Threading.Thread.Sleep(100);
            coinPicture.Image = Properties.Resources.coinBest__3_;
            coinPicture.Refresh();
            System.Threading.Thread.Sleep(100);
            coinPicture.Image = Properties.Resources.coinBest__4_;
            coinPicture.Refresh();
            System.Threading.Thread.Sleep(100);
            coinPicture.Image = Properties.Resources.coinBest__5_;
            coinPicture.Refresh();
            System.Threading.Thread.Sleep(100);
            coinPicture.Image = Properties.Resources.coinBest__6_;
            coinPicture.Refresh();
            System.Threading.Thread.Sleep(100);
            coinPicture.Image = Properties.Resources.coinBest__7_;
            coinPicture.Refresh();
            System.Threading.Thread.Sleep(100);
            coinPicture.Image = Properties.Resources.coinBest__8_;
            coinPicture.Refresh();
            System.Threading.Thread.Sleep(100);
            coinPicture.Image = Properties.Resources.coinBest__7_;
            coinPicture.Refresh();
            System.Threading.Thread.Sleep(100);
            coinPicture.Image = Properties.Resources.coinBest__6_;
            coinPicture.Refresh();
            System.Threading.Thread.Sleep(100);
            coinPicture.Image = Properties.Resources.coinBest__5_;
            coinPicture.Refresh();
            System.Threading.Thread.Sleep(100);
            coinPicture.Image = Properties.Resources.coinBest__4_;
            coinPicture.Refresh();
            System.Threading.Thread.Sleep(100);
            coinPicture.Image = Properties.Resources.coinBest__3_;
            coinPicture.Refresh();
            System.Threading.Thread.Sleep(100);
            coinPicture.Image = Properties.Resources.coinBest__2_;
            coinPicture.Refresh();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FlipBTN_Click(object sender, EventArgs e)
        {
            if(headsTailsComboBox.Text != "Heads" && headsTailsComboBox.Text != "Tails")
            {
                MessageBox.Show("Which site do you think the coin will land on?");
            }
            else
            {
                try
                {
                    bet = int.Parse(BetBox.Text);
                }
                catch
                {
                    MessageBox.Show("Your bet should be a number");
                }
                if (balance - bet < 0)
                {
                    MessageBox.Show("You don't have that much money");
                }
                else if (bet <= 0)
                {
                    MessageBox.Show("Make a bet greater than 0");
                }
                else
                {
                    balance -= bet;
                    BalanceLabel.Text = "" + balance;
                    BalanceLabel.Refresh();
                    Landing = HeadsTails();
                    if (Landing == true)
                    {
                        animationHeads();
                    }
                    else if (Landing == false)
                    {
                        animationTails();
                    }

                    if (headsTailsComboBox.Text == "Heads" && Landing == true || headsTailsComboBox.Text == "Tails" && Landing == false)
                    {
                        MessageBox.Show("You won " + 2 * bet);
                        balance += 2 * bet;
                        BalanceLabel.Text = "" + balance;
                        if(HighScore < balance)
                        {
                            HighScore = balance;
                            HighScoreLabel.Text = "" + balance;
                        }
                    }
                    else
                    {
                        MessageBox.Show("You lost");
                    }
                    if(balance == 0)
                    {
                        MessageBox.Show("You're bankrupt. You can restart the game if you want to :)");
                    }
                }
            }
            
                 

        }

        private void RestartBTN_Click(object sender, EventArgs e)
        {
            balance = 100;
            BalanceLabel.Text = "" + balance;
            BetBox.Clear();
            bet = 0;
        }
    }
}
