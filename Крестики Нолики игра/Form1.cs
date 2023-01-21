using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Крестики_Нолики_игра
{
    public partial class Form1 : Form
    {
        string Tick = "";
        int[] board = new int[9];
        Button[] btn = new Button[9];
        Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();

            if (rnd.Next(1, 10) < 5)
            {
                Tick = "X";
                label1.Text = "Turn O";
            }
            else
            {
                Tick = "O";
                label1.Text = "Turn X";
            }
            btn[0] = button1;
            btn[1] = button2;
            btn[2] = button3;
            btn[3] = button4;
            btn[4] = button5;
            btn[5] = button6;
            btn[6] = button7;
            btn[7] = button8;
            btn[8] = button9;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Tick == "X")
            {
                for (int i = 0; i < btn.Length; i++)
                {
                    if (sender == btn[i])
                    {
                        btn[i].Text = "X";
                        label1.Text = "Turn O";
                        Tick = "O";
                        board[i] = 1;
                        
                        break;
                    }
                }
            }
            else
            {
                for (int i = 0; i < btn.Length; i++)
                {
                    if (sender == btn[i])
                    {
                        btn[i].Text = "O";
                        label1.Text = "Turn X";
                        Tick = "X";
                        board[i] = 2;
                        break;
                    }
                }
            }
            if (board[0] == 1 && board[1] == 1 && board[2] == 1 || board[0] == 2 && board[1] == 2 && board[2] == 2)
            {
                btn[0].BackColor = System.Drawing.Color.Green;
                btn[1].BackColor = System.Drawing.Color.Green;
                btn[2].BackColor = System.Drawing.Color.Green;

                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].Enabled = false;
                    }
                button10.Enabled = true;
                label1.Text = "YOU WON";

            }
            else if (board[3] == 1 && board[4] == 1 && board[5] == 1 || board[3] == 2 && board[4] == 2 && board[5] == 2)
            {
                btn[3].BackColor = System.Drawing.Color.Green;
                btn[4].BackColor = System.Drawing.Color.Green;
                btn[5].BackColor = System.Drawing.Color.Green;

                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].Enabled = false;
                }
                button10.Enabled = true;
                label1.Text = "YOU WON";

            }
            else if (board[6] == 1 && board[7] == 1 && board[8] == 1 || board[6] == 2 && board[7] == 2 && board[8] == 2)
            {
                btn[6].BackColor = System.Drawing.Color.Green;
                btn[7].BackColor = System.Drawing.Color.Green;
                btn[8].BackColor = System.Drawing.Color.Green;

                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].Enabled = false;
                }
                button10.Enabled = true;
                label1.Text = "YOU WON";

            }
            else if (board[2] == 1 && board[4] == 1 && board[8] == 1 || board[2] == 2 && board[4] == 2 && board[8] == 2)
            {
                btn[2].BackColor = System.Drawing.Color.Green;
                btn[4].BackColor = System.Drawing.Color.Green;
                btn[8].BackColor = System.Drawing.Color.Green;

                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].Enabled = false;
                }
                button10.Enabled = true;
                label1.Text = "YOU WON";

            }
            else if (board[0] == 1 && board[4] == 1 && board[6] == 1 || board[0] == 2 && board[4] == 2 && board[6] == 2)
            {
                btn[0].BackColor = System.Drawing.Color.Green;
                btn[4].BackColor = System.Drawing.Color.Green;
                btn[6].BackColor = System.Drawing.Color.Green;

                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].Enabled = false;
                }
                button10.Enabled = true;
                label1.Text = "YOU WON";

            }
            else if (board[2] == 1 && board[3] == 1 && board[6] == 1 || board[2] == 2 && board[3] == 2 && board[6] == 2)
            {
                btn[2].BackColor = System.Drawing.Color.Green;
                btn[3].BackColor = System.Drawing.Color.Green;
                btn[6].BackColor = System.Drawing.Color.Green;

                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].Enabled = false;
                }
                button10.Enabled = true;
                label1.Text = "YOU WON";

            }
            else if (board[1] == 1 && board[4] == 1 && board[7] == 1 || board[1] == 2 && board[4] == 2 && board[7] == 2)
            {
                btn[1].BackColor = System.Drawing.Color.Green;
                btn[4].BackColor = System.Drawing.Color.Green;
                btn[7].BackColor = System.Drawing.Color.Green;

                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].Enabled = false;
                }
                button10.Enabled = true;
                label1.Text = "YOU WON";

            }
            else if (board[0] == 1 && board[5] == 1 && board[8] == 1 || board[0] == 2 && board[5] == 2 && board[8] == 2)
            {
                btn[0].BackColor = System.Drawing.Color.Green;
                btn[5].BackColor = System.Drawing.Color.Green;
                btn[8].BackColor = System.Drawing.Color.Green;

                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].Enabled = false;
                }
                button10.Enabled = true;
                label1.Text = "YOU WON";

            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < btn.Length; i++)
            {
                board[i] = 0;
                btn[i].Text = "";

                if (rnd.Next(1, 10) < 5)
                {
                    Tick = "X";
                    label1.Text = "Turn O";
                }
                else
                {
                    Tick = "O";
                    label1.Text = "Turn X";
                }
                btn[i].Enabled = true;
                    btn[i].BackColor = System.Drawing.Color.LightGray;
                }
            }
        }
    }

