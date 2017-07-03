using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    /// <summary>
    /// Description of MainForm.
    /// </summary>
    public partial class Form1 : Form
    {
        int turn = 1;
        int click1 = 0, click2 = 0, click3 = 0, click4 = 0, click5 = 0, click6 = 0, click7 = 0, click8 = 0, click9 = 0;
        int player1 = 0, player2 = 0;
        static String firstPlayer, secondPlayer;
        public Form1()
        {
            InitializeComponent();
        }
        
        public static void setPlayerNames(String name1, String name2)
        {
            firstPlayer = name1;
            secondPlayer = name2;
        }

        void Button1Click(object sender, EventArgs e)
        {
            if (click1 == 0)
            {
                if (turn % 2 != 0)
                {
                    button1.Text = "X";
                    click1++;
                }
                else
                {
                    button1.Text = "O";
                    click1++;
                }
                turn++;
            }
            else
            {
                button1.Text = button1.Text;
            }
            display();
            checkit();

        }

        void Button2Click(object sender, EventArgs e)
        {
            if (click2 == 0)
            {
                if (turn % 2 != 0)
                {
                    button2.Text = "X";
                    click2++;
                }
                else
                {
                    button2.Text = "O";
                    click2++;
                }
                turn++;
            }
            else
            {
                button2.Text = button2.Text;
            }
            display();
            checkit();
        }

        void Button3Click(object sender, EventArgs e)
        {
            if (click3 == 0)
            {
                if (turn % 2 != 0)
                {
                    button3.Text = "X";
                    click3++;
                }
                else
                {
                    button3.Text = "O";
                    click3++;
                }
                turn++;
            }
            else
            {
                button3.Text = button3.Text;
            }
            display();
            checkit();
        }

        void Button4Click(object sender, EventArgs e)
        {
            if (click4 == 0)
            {
                if (turn % 2 != 0)
                {
                    button4.Text = "X";
                    click4++;
                }
                else
                {
                    button4.Text = "O";
                    click4++;
                }
                turn++;
            }
            else
            {
                button4.Text = button4.Text;
            }
            display();
            checkit();
        }

        void Button5Click(object sender, EventArgs e)
        {
            if (click5 == 0)
            {
                if (turn % 2 != 0)
                {
                    button5.Text = "X";
                    click5++;
                }
                else
                {
                    button5.Text = "O";
                    click5++;
                }
                turn++;
            }
            else
            {
                button5.Text = button5.Text;
            }
            display();
            checkit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("By Ramil Mamedov", "Tic Tac Toe About");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cleargame();
        }

        private void rulesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Player one = 'X'\nPlayer two = 'O'", "Tic Tac Toe Rules");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
            label2.Text = firstPlayer;
            label3.Text = secondPlayer;
        }

        void Button6Click(object sender, EventArgs e)
        {
            if (click6 == 0)
            {
                if (turn % 2 != 0)
                {
                    button6.Text = "X";
                    click6++;
                }
                else
                {
                    button6.Text = "O";
                    click6++;
                }
                turn++;
            }
            else
            {
                button6.Text = button6.Text;
            }
            display();
            checkit();
        }

        void Button7Click(object sender, EventArgs e)
        {
            if (click7 == 0)
            {
                if (turn % 2 != 0)
                {
                    button7.Text = "X";
                    click7++;
                }
                else
                {
                    button7.Text = "O";
                    click7++;
                }
                turn++;
            }
            else
            {
                button7.Text = button7.Text;
            }
            display();
            checkit();
        }

        void Button8Click(object sender, EventArgs e)
        {
            if (click8 == 0)
            {
                if (turn % 2 != 0)
                {
                    button8.Text = "X";
                    click8++;
                }
                else
                {
                    button8.Text = "O";
                    click8++;
                }
                turn++;
            }
            else
            {
                button8.Text = button8.Text;
            }
            display();
            checkit();
        }

        void Button9Click(object sender, EventArgs e)
        {
            if (click9 == 0)
            {
                if (turn % 2 != 0)
                {
                    button9.Text = "X";
                    click9++;
                }
                else
                {
                    button9.Text = "O";
                    click9++;
                }
                turn++;
            }
            else
            {
                button9.Text = button9.Text;
            }
            display();
            checkit();
        }
        public void display()
        {
            if (turn % 2 != 0)
            {
                displayturn.Text = firstPlayer + "'s";
            }
            else
            {
                displayturn.Text = secondPlayer + "'s";
            }
        }
        public void checkit()
        {
            if (button1.Text != "" && button2.Text != "" && button3.Text != "")
            {
                if (button1.Text == button2.Text && button1.Text == button3.Text)
                {
                    button1.BackColor = Color.Green;
                    button1.ForeColor = Color.White;
                    button2.BackColor = Color.Green;
                    button2.ForeColor = Color.White;
                    button3.BackColor = Color.Green;
                    button3.ForeColor = Color.White;
                    if (button1.Text == "X")
                    {
                        MessageBox.Show(firstPlayer + " wins!");
                        player1++;
                        player1score.Text = player1.ToString();
                    }
                    else
                    {
                        MessageBox.Show(secondPlayer + " wins!");
                        player2++;
                        player2score.Text = player2.ToString();
                    }
                    cleargame();

                }
            }
            if (button4.Text != "" && button5.Text != "" && button6.Text != "")
            {
                if (button4.Text == button5.Text && button4.Text == button6.Text)
                {
                    button4.BackColor = Color.Green;
                    button4.ForeColor = Color.White;
                    button5.BackColor = Color.Green;
                    button5.ForeColor = Color.White;
                    button6.BackColor = Color.Green;
                    button6.ForeColor = Color.White;
                    if (button4.Text == "X")
                    {
                        MessageBox.Show(firstPlayer + " wins!");
                        player1++;
                        player1score.Text = player1.ToString();

                    }
                    else
                    {
                        MessageBox.Show(secondPlayer + " wins!");
                        player2++;
                        player2score.Text = player2.ToString();

                    }
                    cleargame();
                }
            }
            if (button7.Text != "" && button8.Text != "" && button9.Text != "")
            {
                if (button7.Text == button8.Text && button7.Text == button9.Text)
                {
                    button7.BackColor = Color.Green;
                    button7.ForeColor = Color.White;
                    button8.BackColor = Color.Green;
                    button8.ForeColor = Color.White;
                    button9.BackColor = Color.Green;
                    button9.ForeColor = Color.White;
                    if (button7.Text == "X")
                    {
                        MessageBox.Show(firstPlayer + " wins!");
                        player1++;
                        player1score.Text = player1.ToString();

                    }
                    else
                    {
                        MessageBox.Show(secondPlayer + " wins!");
                        player2++;
                        player2score.Text = player2.ToString();

                    }
                    cleargame();
                }
            }
            if (button1.Text != "" && button4.Text != "" && button7.Text != "")
            {
                if (button1.Text == button4.Text && button1.Text == button7.Text)
                {
                    button1.BackColor = Color.Green;
                    button1.ForeColor = Color.White;
                    button4.BackColor = Color.Green;
                    button4.ForeColor = Color.White;
                    button7.BackColor = Color.Green;
                    button7.ForeColor = Color.White;
                    if (button1.Text == "X")
                    {
                        MessageBox.Show(firstPlayer + " wins!");
                        player1++;
                        player1score.Text = player1.ToString();

                    }
                    else
                    {
                        MessageBox.Show(secondPlayer + " wins!");
                        player2++;
                        player2score.Text = player2.ToString();

                    }
                    cleargame();
                }
            }
            if (button2.Text != "" && button5.Text != "" && button8.Text != "")
            {
                if (button2.Text == button5.Text && button2.Text == button8.Text)
                {
                    button2.BackColor = Color.Green;
                    button2.ForeColor = Color.White;
                    button5.BackColor = Color.Green;
                    button5.ForeColor = Color.White;
                    button8.BackColor = Color.Green;
                    button8.ForeColor = Color.White;
                    if (button2.Text == "X")
                    {
                        MessageBox.Show(firstPlayer + " wins!");
                        player1++;
                        player1score.Text = player1.ToString();

                    }
                    else
                    {
                        MessageBox.Show(secondPlayer + " wins!");
                        player2++;
                        player2score.Text = player2.ToString();

                    }
                    cleargame();
                }
            }
            if (button3.Text != "" && button6.Text != "" && button9.Text != "")
            {
                if (button3.Text == button6.Text && button3.Text == button9.Text)
                {
                    button3.BackColor = Color.Green;
                    button3.ForeColor = Color.White;
                    button6.BackColor = Color.Green;
                    button6.ForeColor = Color.White;
                    button9.BackColor = Color.Green;
                    button9.ForeColor = Color.White;
                    if (button3.Text == "X")
                    {
                        MessageBox.Show(firstPlayer + " wins!");
                        player1++;
                        player1score.Text = player1.ToString();

                    }
                    else
                    {
                        MessageBox.Show(secondPlayer + " wins!");
                        player2++;
                        player2score.Text = player2.ToString();

                    }
                    cleargame();
                }
            }
            if (button1.Text != "" && button5.Text != "" && button9.Text != "")
            {
                if (button1.Text == button5.Text && button1.Text == button9.Text)
                {
                    button1.BackColor = Color.Green;
                    button1.ForeColor = Color.White;
                    button5.BackColor = Color.Green;
                    button5.ForeColor = Color.White;
                    button9.BackColor = Color.Green;
                    button9.ForeColor = Color.White;
                    if (button1.Text == "X")
                    {
                        MessageBox.Show(firstPlayer + " wins!");
                        player1++;
                        player1score.Text = player1.ToString();

                    }
                    else
                    {
                        MessageBox.Show(secondPlayer + " wins!");
                        player2++;
                        player2score.Text = player2.ToString();

                    }
                    cleargame();
                }
            }
            if (button3.Text != "" && button5.Text != "" && button7.Text != "")
            {
                if (button3.Text == button5.Text && button3.Text == button7.Text)
                {
                    button3.BackColor = Color.Green;
                    button3.ForeColor = Color.White;
                    button5.BackColor = Color.Green;
                    button5.ForeColor = Color.White;
                    button7.BackColor = Color.Green;
                    button7.ForeColor = Color.White;
                    if (button3.Text == "X")
                    {
                        MessageBox.Show(firstPlayer + " wins!");
                        player1++;
                        player1score.Text = player1.ToString();

                    }
                    else
                    {
                        MessageBox.Show(secondPlayer + " wins!");
                        player2++;
                        player2score.Text = player2.ToString();

                    }
                    cleargame();
                }
            }
            //if (button1.Text != "" && button2.Text != "" && button3.Text != "" && button4.Text != "" && button5.Text != "" && button6.Text != "" && button7.Text != "" && button8.Text != "" && button9.Text != "")
            //{
            //    if (button1.Text == button2.Text  && button3.Text == button4.Text && button5.Text == button9.Text && button7.Text == button8.Text)
            //    MessageBox.Show("Draw!");
            //}
        }
        public void cleargame()
        {
            displayturn.Text = "";
            turn = 1;
            click1 = 0; click2 = 0; click3 = 0; click4 = 0; click5 = 0; click6 = 0; click7 = 0; click8 = 0; click9 = 0;
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            button1.BackColor = Color.Empty;
            button1.ForeColor = Color.Black;
            button1.UseVisualStyleBackColor = true;
            button2.BackColor = Color.Empty;
            button2.ForeColor = Color.Black;
            button2.UseVisualStyleBackColor = true;
            button3.BackColor = Color.Empty;
            button3.ForeColor = Color.Black;
            button3.UseVisualStyleBackColor = true;
            button4.BackColor = Color.Empty;
            button4.ForeColor = Color.Black;
            button4.UseVisualStyleBackColor = true;
            button5.BackColor = Color.Empty;
            button5.ForeColor = Color.Black;
            button5.UseVisualStyleBackColor = true;
            button6.BackColor = Color.Empty;
            button6.ForeColor = Color.Black;
            button6.UseVisualStyleBackColor = true;
            button7.BackColor = Color.Empty;
            button7.ForeColor = Color.Black;
            button7.UseVisualStyleBackColor = true;
            button8.BackColor = Color.Empty;
            button8.ForeColor = Color.Black;
            button8.UseVisualStyleBackColor = true;
            button9.BackColor = Color.Empty;
            button9.ForeColor = Color.Black;
            button9.UseVisualStyleBackColor = true;
        }

        void PlayagainClick(object sender, EventArgs e)
        {
            cleargame();
        }

        void ResetClick(object sender, EventArgs e)
        {
            player1score.Text = "";
            player2score.Text = "";
            player1 = 0;
            player2 = 0;
            cleargame();
        }
    }
}
