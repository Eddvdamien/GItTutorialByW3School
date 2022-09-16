using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tictactoe2
{
    public partial class Form1 : Form
    {
        Boolean Checker;
        void SettingToFalse()
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;

        }
        void WinningStrategy()
        {
            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
            {
                button1.BackColor = Color.Red;
                button2.BackColor = Color.Red;
                button3.BackColor = Color.Red;
                MessageBox.Show("The Player X is winner", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SettingToFalse();

                //onsole.WriteLine("the Player X is winner");
            }
            if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
            {
                button1.BackColor = Color.Red;
                button2.BackColor = Color.Red;
                button3.BackColor = Color.Red;
                MessageBox.Show("The Player O is winner", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SettingToFalse();
            }

            if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
            {
                button1.BackColor = Color.Red;
                button4.BackColor = Color.Red;
                button7.BackColor = Color.Red;
                MessageBox.Show("The Player X is winner", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SettingToFalse();

                //onsole.WriteLine("the Player X is winner");
            }
            if (button1.Text == "O" && button4.Text == "O" && button7.Text == "O")
            {
                button1.BackColor = Color.Red;
                button4.BackColor = Color.Red;
                button7.BackColor = Color.Red;
                MessageBox.Show("The Player O is winner", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SettingToFalse();
            }
            if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
            {
                button1.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button9.BackColor = Color.Red;
                MessageBox.Show("The Player X is winner", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SettingToFalse();

                //onsole.WriteLine("the Player X is winner");
            }
            if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O")
            {
                button1.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button9.BackColor = Color.Red;
                MessageBox.Show("The Player O is winner", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SettingToFalse();
            }
            //if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
            //{
            //    button1.BackColor = Color.Red;
            //    button5.BackColor = Color.Red;
            //    button9.BackColor = Color.Red;
            //    MessageBox.Show("The Player X is winner", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    SettingToFalse()

            //    //onsole.WriteLine("the Player X is winner");
            //}
            if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
            {
                button2.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button8.BackColor = Color.Red;
                MessageBox.Show("The Player X is winner", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SettingToFalse();

                //onsole.WriteLine("the Player X is winner");
            }
            if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O")
            {
                button2.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button8.BackColor = Color.Red;
                MessageBox.Show("The Player O is winner", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SettingToFalse();
            }
            if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
            {
                button3.BackColor = Color.Red;
                button6.BackColor = Color.Red;
                button9.BackColor = Color.Red;
                MessageBox.Show("The Player X is winner", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SettingToFalse();

                //onsole.WriteLine("the Player X is winner");
            }
            if (button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
            {
                button3.BackColor = Color.Red;
                button6.BackColor = Color.Red;
                button9.BackColor = Color.Red;
                MessageBox.Show("The Player O is winner", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SettingToFalse();
            }
            if (button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
            {
                button3.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button7.BackColor = Color.Red;
                MessageBox.Show("The Player X is winner", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SettingToFalse();

                //onsole.WriteLine("the Player X is winner");
            }
            if (button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
            {
                button3.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button7.BackColor = Color.Red;
                MessageBox.Show("The Player O is winner", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SettingToFalse();
            }
            if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
            {
                button4.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button6.BackColor = Color.Red;
                MessageBox.Show("The Player X is winner", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SettingToFalse();

                //onsole.WriteLine("the Player X is winner");
            }
            if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
            {
                button4.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button6.BackColor = Color.Red;
                MessageBox.Show("The Player O is winner", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SettingToFalse();
            }
            if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
            {
                button7.BackColor = Color.Red;
                button8.BackColor = Color.Red;
                button9.BackColor = Color.Red;
                MessageBox.Show("The Player X is winner", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SettingToFalse();

                //onsole.WriteLine("the Player X is winner");
            }
            if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
            {
                button7.BackColor = Color.Red;
                button8.BackColor = Color.Red;
                button9.BackColor = Color.Red;
                MessageBox.Show("The Player O is winner", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SettingToFalse();
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                if (Checker == false)
                {
                    button1.Text = "X";
                    Checker = true;
                }
                else
                {
                    button1.Text = "O";
                    Checker = false;
                }
                WinningStrategy();
                button1.Enabled = false;

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Checker == false)
            {
                button2.Text = "X";
                Checker = true;
            }
            else
            {
                button2.Text = "O";
                Checker = false;
            }
            WinningStrategy();
            button2.Enabled = false;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Checker == false)
            {
                button3.Text = "X";
                Checker = true;
            }
            else
            {
                button3.Text = "O";
                Checker = false;
            }
            WinningStrategy();
            button3.Enabled = false;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Checker == false)
            {
                button4.Text = "X";
                Checker = true;
            }
            else
            {
                button4.Text = "O";
                Checker = false;
            }
            WinningStrategy();
            button4.Enabled = false;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (Checker == false)
            {
                button5.Text = "X";
                Checker = true;
            }
            else
            {
                button5.Text = "O";
                Checker = false;
            }
            WinningStrategy();
            button5.Enabled = false;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (Checker == false)
            {
                button6.Text = "X";
                Checker = true;
            }
            else
            {
                button6.Text = "O";
                Checker = false;
            }
            WinningStrategy();
            button6.Enabled = false;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (Checker == false)
            {
                button7.Text = "X";
                Checker = true;
            }
            else
            {
                button7.Text = "O";
                Checker = false;
            }
            WinningStrategy();
            button7.Enabled = false;

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (Checker == false)
            {
                button8.Text = "X";
                Checker = true;
            }
            else
            {
                button8.Text = "O";
                Checker = false;
            }
            WinningStrategy();
            button8.Enabled = false;

        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (Checker == false)
            {
                button9.Text = "X";
                Checker = true;
            }
            else
            {
                button9.Text = "O";
                Checker = false;
            }
            WinningStrategy();
            button9.Enabled = false;

        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = true;
                button8.Enabled = true;
                button9.Enabled = true;

                button1.Text = "";
                button2.Text = "";
                button3.Text = "";
                button4.Text = "";
                button5.Text = "";
                button6.Text = "";
                button7.Text = "";
                button8.Text = "";
                button9.Text = "";

               

                button7.BackColor = Color.WhiteSmoke;
                button8.BackColor = Color.WhiteSmoke;
                button9.BackColor = Color.WhiteSmoke;
                button4.BackColor = Color.WhiteSmoke;
                button2.BackColor = Color.WhiteSmoke;
                button3.BackColor = Color.WhiteSmoke;
                button1.BackColor = Color.WhiteSmoke;
                button5.BackColor = Color.WhiteSmoke;
                button6.BackColor = Color.WhiteSmoke;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult iExit;
                iExit = MessageBox.Show("confirm you really want to exit", "TicTacToe", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (iExit == DialogResult.Yes)
                {
                    button10.Enabled = true;
                    Application.Exit();
                }
                else
                {
                    //button10_Click(tr);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}

