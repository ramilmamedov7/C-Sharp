using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkCinema
{
    public partial class Form1 : Form
    {
        public List<Button> list_btn = new List<Button>();

        public Form1()
        {
            InitializeComponent();

            list_btn.Add(button1);
            list_btn.Add(button2);
            list_btn.Add(button3);
            list_btn.Add(button4);
            list_btn.Add(button5);
            list_btn.Add(button6);
            list_btn.Add(button7);
            list_btn.Add(button8);
            list_btn.Add(button9);
            list_btn.Add(button11);
            list_btn.Add(button12);
            list_btn.Add(button13);

            button1.Click += new EventHandler(btn_click);
            button2.Click += new EventHandler(btn_click);
            button3.Click += new EventHandler(btn_click);
            button4.Click += new EventHandler(btn_click);
            button5.Click += new EventHandler(btn_click);
            button6.Click += new EventHandler(btn_click);
            button7.Click += new EventHandler(btn_click);
            button8.Click += new EventHandler(btn_click);
            button9.Click += new EventHandler(btn_click);
            button11.Click += new EventHandler(btn_click);
            button12.Click += new EventHandler(btn_click);
            button13.Click += new EventHandler(btn_click);

        }
        Button btn;
        public void btn_click(object sender, EventArgs e)
        {
            btn = sender as Button;
            if (btn.BackColor == SystemColors.Control)
            {
                btn.BackColor = Color.Green;
                btn.ForeColor = Color.White;
            }
            else if (btn.BackColor == Color.Green)
            {
                btn.BackColor = SystemColors.Control;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.button10.BackColor = Color.Yellow;
            this.button10.ForeColor = Color.Black;
            string bron_places = "";
            List<Button> broned = new List<Button>();
            foreach (Button b in list_btn)
            {
                if (b.BackColor == Color.Green)
                {
                    b.BackColor = Color.Red;
                    broned.Add(b);
                }
            }
            int say = 0;
            foreach (Button a in broned)
            {
                say++;
                if (say < broned.Count - 1)
                {
                    bron_places += a.Text + ",";
                }
                else if (say == broned.Count - 1)
                {
                    bron_places += a.Text;
                }
                else
                {
                    bron_places += " ve " + a.Text + "ci yerler bron edildi.";
                }
            }
            if (say == 1)
            {
                foreach (Button i in broned)
                {
                    bron_places = i.Text + "ci yer bron edildi.";
                }
            }
            MessageBox.Show(bron_places + "...!");
        }
    }
}
