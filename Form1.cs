using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassaParola
{
    public partial class FindTrue : Form
    {
        public FindTrue()
        {
            InitializeComponent();

        }
  

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        int soruno= 0,dogru = 0, yanlis = 0;
        
        public void arttir()
        {
            dogru++;
            label2.Text = dogru.ToString();

        }
        public void azalt()
        {
            yanlis++;
            label6.Text = yanlis.ToString();

        }




        public void send_Click(object sender, EventArgs e)
        {
            

            send.Text = "Sonraki";
            soruno++;
            this.Text = "Soru:" + soruno.ToString();


            switch (soruno)
            {
                case 1:
                    richTextBox1.Text = "ELMA";
                    button1.BackColor = Color.Yellow;
                    break;
                case 2:
                    richTextBox1.Text = "YARASA";
                    B.BackColor = Color.Yellow;
                    textBox1.Text = "";
                    break;
                case 3:
                    richTextBox1.Text = "TIKLAMA";
                    c.BackColor = Color.Yellow;
                    textBox1.Text = "";
                    break;
                case 4:
                    richTextBox1.Text = "Çift";
                    textBox1.Text = "";
                    d.BackColor = Color.Yellow;
                    break;
                case 5:
                    richTextBox1.Text = "motor";
                    textBox1.Text = "";
                    ebtn.BackColor = Color.Yellow;
                    break;
                case 6:
                    richTextBox1.Text = "parmak";
                    textBox1.Text = "";
                    f.BackColor = Color.Yellow;
                    break;
                case 7:
                    richTextBox1.Text = "Acı";
                    textBox1.Text = "";
                    G.BackColor = Color.Yellow;
                    break;
                case 8:
                    richTextBox1.Text = "sıcaklık";
                    textBox1.Text = "";
                    H.BackColor = Color.Yellow;
                    break;
                case 9:
                    richTextBox1.Text = "böcek";
                    textBox1.Text = "";
                    button24.BackColor = Color.Yellow;
                    break;
                case 10:
                    richTextBox1.Text = "şaka";
                    textBox1.Text = "";
                    button10.BackColor = Color.Yellow;
                    break;
                case 11:
                    richTextBox1.Text = "anahtar";
                    textBox1.Text = "";
                    button11.BackColor = Color.Yellow;
                    break;
                case 12:
                    richTextBox1.Text = "göl";
                    textBox1.Text = "";
                    button12.BackColor = Color.Yellow;
                    break;
                case 13:
                    richTextBox1.Text = "Anakara";
                    textBox1.Text = "";
                    button13.BackColor = Color.Yellow;
                    break;
                case 14:
                    richTextBox1.Text = "doğal";
                    textBox1.Text = "";
                    button14.BackColor = Color.Yellow;
                    break;
                case 15:
                    richTextBox1.Text = "turuncu";
                    textBox1.Text = "";
                    button15.BackColor = Color.Yellow;
                    break;
                case 16:
                    richTextBox1.Text = "domuz";
                    textBox1.Text = "";
                    button16.BackColor = Color.Yellow;
                    break;
                case 17:
                    richTextBox1.Text = "Nadir";
                    textBox1.Text = "";
                    button17.BackColor = Color.Yellow;
                    break;
                case 18:
                    richTextBox1.Text = "hassasiyet";
                    textBox1.Text = "";
                    button18.BackColor = Color.Yellow;
                    break;
                case 19:
                    richTextBox1.Text = "Değiş-Tokuş";
                    textBox1.Text = "";
                    button19.BackColor = Color.Yellow;
                    break;
                case 20:
                    richTextBox1.Text = "Versiyon Yükseltmek";
                    textBox1.Text = "";
                    button21.BackColor = Color.Yellow;
                    break;
                case 21:
                    richTextBox1.Text = "Görüş";
                    textBox1.Text = "";
                    button20.BackColor = Color.Yellow;
                    break;
                case 22:
                    richTextBox1.Text = "kendin";
                    textBox1.Text = "";
                    button22.BackColor = Color.Yellow;
                    break;
                case 23:
                    richTextBox1.Text = "fermuar";
                    textBox1.Text = "";
                    button23.BackColor = Color.Yellow;
                    break;
                

            }
        }
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                switch (soruno)
                {
                    case 1:
                        if (textBox1.Text == "apple")
                        {
                            arttir();
                            button1.BackColor = Color.Green;
                        }
                        else
                        {
                            azalt();
                            button1.BackColor = Color.Red;
                        }
                        break;
                    case 2:

                        if (textBox1.Text == "bat")
                        {
                            arttir();
                            B.BackColor = Color.Green;
                        }
                        else
                        {
                            azalt();
                            B.BackColor = Color.Red;
                        }
                        break;
                    case 3:
                        if (textBox1.Text == "click")
                        {
                            arttir();
                            c.BackColor = Color.Green;
                        }
                        else
                        {
                            azalt();
                            c.BackColor = Color.Red;
                        }
                        break;
                    case 4:
                        if (textBox1.Text == "double")
                        {
                            arttir();
                            d.BackColor = Color.Green;
                        }
                        else
                        {
                            azalt();
                            d.BackColor = Color.Red;
                        }
                        break;
                    case 5:
                        if (textBox1.Text == "engine")
                        {
                            arttir();
                            ebtn.BackColor = Color.Green;
                        }
                        else
                        {
                            azalt();
                            ebtn.BackColor = Color.Red;
                        }
                        break;
                    case 6:
                        if (textBox1.Text == "finger")
                        {
                            arttir();
                            f.BackColor = Color.Green;
                        }
                        else
                        {
                            azalt();
                            f.BackColor = Color.Red;
                        }
                        break;
                    case 7:
                        if (textBox1.Text == "gain")
                        {
                            arttir();
                            G.BackColor = Color.Green;
                        }
                        else
                        {
                            azalt();
                            G.BackColor = Color.Red;
                        }
                        break;
                    case 8:
                        if (textBox1.Text == "heat")
                        {
                            arttir();
                            H.BackColor = Color.Green;
                        }
                        else
                        {
                            azalt();
                            H.BackColor = Color.Red;
                        }
                        break;

                    case 9:
                        if (textBox1.Text == "insect")
                        {
                            arttir();
                            H.BackColor = Color.Green;
                        }
                        else
                        {
                            azalt();
                            H.BackColor = Color.Red;
                        }
                        break;
                    case 10:
                        if (textBox1.Text == "joke")
                        {
                            arttir();
                            H.BackColor = Color.Green;
                        }
                        else
                        {
                            azalt();
                            H.BackColor = Color.Red;
                        }
                        break;
                    case 11:
                        if (textBox1.Text == "key")
                        {
                            arttir();
                            H.BackColor = Color.Green;
                        }
                        else
                        {
                            azalt();
                            H.BackColor = Color.Red;
                        }
                        break;
                    case 12:
                        if (textBox1.Text == "lake")
                        {
                            arttir();
                            H.BackColor = Color.Green;
                        }
                        else
                        {
                            azalt();
                            H.BackColor = Color.Red;
                        }
                        break;
                    case 13:
                        if (textBox1.Text == "mainland")
                        {
                            arttir();
                            H.BackColor = Color.Green;
                        }
                        else
                        {
                            azalt();
                            H.BackColor = Color.Red;
                        }
                        break;
                    case 14:
                        if (textBox1.Text == "natural")
                        {
                            arttir();
                            H.BackColor = Color.Green;
                        }
                        else
                        {
                            azalt();
                            H.BackColor = Color.Red;
                        }
                        break;
                    case 15:
                        if (textBox1.Text == "orange")
                        {
                            arttir();
                            H.BackColor = Color.Green;
                        }
                        else
                        {
                            azalt();
                            H.BackColor = Color.Red;
                        }
                        break;
                    case 16:
                        if (textBox1.Text == "pig")
                        {
                            arttir();
                            H.BackColor = Color.Green;
                        }
                        else
                        {
                            azalt();
                            H.BackColor = Color.Red;
                        }
                        break;
                    case 17:
                        if (textBox1.Text == "rare")
                        {
                            arttir();
                            H.BackColor = Color.Green;
                        }
                        else
                        {
                            azalt();
                            H.BackColor = Color.Red;
                        }
                        break;
                    case 18:
                        if (textBox1.Text == "sensivity")
                        {
                            arttir();
                            H.BackColor = Color.Green;
                        }
                        else
                        {
                            azalt();
                            H.BackColor = Color.Red;
                        }
                        break;
                    case 19:
                        if (textBox1.Text == "trade")
                        {
                            arttir();
                            H.BackColor = Color.Green;
                        }
                        else
                        {
                            azalt();
                            H.BackColor = Color.Red;
                        }
                        break;
                    case 20:
                        if (textBox1.Text == "upgrade")
                        {
                            arttir();
                            H.BackColor = Color.Green;
                        }
                        else
                        {
                            azalt();
                            H.BackColor = Color.Red;
                        }
                        break;
                    case 21:
                        if (textBox1.Text == "vision")
                        {
                            arttir();
                            H.BackColor = Color.Green;
                        }
                        else
                        {
                            azalt();
                            H.BackColor = Color.Red;
                        }
                        break;
                    case 22:
                        if (textBox1.Text == "yourself")
                        {
                            arttir();
                            H.BackColor = Color.Green;
                        }
                        else
                        {
                            azalt();
                            H.BackColor = Color.Red;
                        }
                        break;
                    case 23:
                        if (textBox1.Text == "zipper")
                        {
                            arttir();
                            H.BackColor = Color.Green;
                        }
                        else
                        {
                            azalt();
                            H.BackColor = Color.Red;
                        }
                        break;



                }

            }
        }
    }
}
