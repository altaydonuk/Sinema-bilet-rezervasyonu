using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Proje
{
    public partial class Form2 : Form
    {
        int bilet=0;
        public Form2()
        {
            InitializeComponent();
           
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Button buton = new Button
            {
                Name = "Deneme",
                Text = "1",
                Height =75,
                Width =75
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 24; i++)
            {
                Button btn = new Button();

                btn.Name = "a";
                btn.Text = (i + 1).ToString();
                btn.Size = new Size(60, 60);
                btn.Margin = new Padding(0);
                btn.BackColor = Color.Yellow;
                flowLayoutPanel1.Controls.Add(btn);
                btn.Click += Btn_Click;

            }
        }
        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn.BackColor == Color.Yellow)
            {
                btn.BackColor = Color.Green;
                listBox1.Items.Add(btn.Text);
                bilet++;
            }
            else if (btn.BackColor == Color.Red)
            {
                MessageBox.Show("Koltuk Satılmış");
            }
            else
            {
                btn.BackColor = Color.Yellow;
                listBox1.Items.Remove(btn.Text);
                bilet--;
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (Button koltuk in flowLayoutPanel1.Controls)
            {
                if (koltuk.BackColor == Color.Green)
                {
                    koltuk.BackColor = Color.Yellow;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (Button koltuk in flowLayoutPanel1.Controls)
            {
                if (koltuk.BackColor == Color.Green)
                {
                    koltuk.BackColor = Color.Red;
                   
                   
                }

            }

            MessageBox.Show("Interstellar 14.30"+"\n"+"Bilet Sayısı:" + bilet+"\n" + "Ücret:" + bilet * 20 + " TL"+"\n"+"İyi Seyirler","İşlem Özeti");

        }
       


    }
}
