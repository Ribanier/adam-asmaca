using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
namespace WindowsFormsApplication2
{
    public partial class adamasmaca : Form
    {
        public adamasmaca()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        string cevir;
        private void button1_Click(object sender, EventArgs e)
        {
            Pen mPen = new Pen(Color.Black);
            Graphics g = this.CreateGraphics();
            g.DrawLine(mPen, 65, 65, 65, 500);
            g.DrawLine(mPen, 65, 65, 300, 65);
            g.DrawLine(mPen, 150, 65, 150, 100);
            button3.Enabled = true;
            button2.Enabled = true;
            textBox1.Enabled = true;
            int harfsayisi = 0;
            string[] dizi = { "ahmet", "sadık", "ilkan", "muhammet", "mustafa", "barış", "dolap", "monitör", "spiderman", "klavye", "mother", "board" };
            cevir = dizi[rnd.Next(6)];
            char[] harfdizi = cevir.ToCharArray();
            for (int i = 0; i < harfdizi.Length; i++)
            {
                //  MessageBox.Show(harfdizi[i].ToString());       
                harfsayisi++;
            }
            if (harfsayisi == 5)
            {
                label1.Visible = true; label2.Visible = true; label3.Visible = true; label4.Visible = true; label5.Visible = true;
            }
            if (harfsayisi == 6)
            {
                label1.Visible = true; label2.Visible = true; label3.Visible = true; label4.Visible = true; label5.Visible = true;
                label6.Visible = true;
            }
            if (harfsayisi == 7)
            {
                label1.Visible = true; label2.Visible = true; label3.Visible = true; label4.Visible = true; label5.Visible = true;
                label6.Visible = true; label7.Visible = true;
            }
            if (harfsayisi == 8)
            {
                label1.Visible = true; label2.Visible = true; label3.Visible = true; label4.Visible = true; label5.Visible = true;
                label6.Visible = true; label7.Visible = true; label8.Visible = true;
            }
            if (harfsayisi == 9)
            {
                label1.Visible = true; label2.Visible = true; label3.Visible = true; label4.Visible = true; label5.Visible = true;
                label6.Visible = true; label7.Visible = true; label8.Visible = true; label9.Visible = true;
            } if (harfsayisi == 10)
            {
                label1.Visible = true; label2.Visible = true; label3.Visible = true; label4.Visible = true; label5.Visible = true;
                label6.Visible = true; label7.Visible = true; label8.Visible = true; label9.Visible = true; label10.Visible = true;
            }
            //MessageBox.Show("harf sayısı ="+toplam.ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            button3.Enabled = false;
            button2.Enabled = false;
        }

        int harf_hakki = 6;
        int cizgi = 1;
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Pen mPen = new Pen(Color.Black);
                Graphics g = this.CreateGraphics();
                char[] ayrilmiş = cevir.ToCharArray();
                if (harf_hakki <= 6 && harf_hakki > 0)
                {
                    char deneme = char.Parse(textBox1.Text);
                    if (Array.IndexOf(ayrilmiş, deneme) == -1)
                    //başlangıç noktası   bitiş noktası
                    {//                   x  y    x  y
                        // g.DrawLine(mPen, 65, 65, 65, 500);
                        //  g.DrawLine(mPen, 65, 65, 300, 65);
                        //  g.DrawLine(mPen, 150, 65, 150, 100);//ip
                        if (cizgi == 1) g.DrawEllipse(mPen, 100, 100, 100, 50);//kafa
                        else if (cizgi == 2) g.DrawLine(mPen, 150, 150, 150, 300);//vücut
                        else if (cizgi == 3) g.DrawLine(mPen, 150, 200, 111, 280);//sol kol
                        else if (cizgi == 4) g.DrawLine(mPen, 150, 200, 190, 280);//sağ kol
                        else if (cizgi == 5) g.DrawLine(mPen, 150, 300, 194, 418);//sag bacak  
                        else g.DrawLine(mPen, 150, 300, 108, 420);//solbacak

                        if (cizgi > 5)
                        {
                            MessageBox.Show("adamı öldürdünüz bravo");
                        }
                        cizgi++;
                    }
                    else
                    {
                        harf_hakki += 1;
                        int a = Array.IndexOf(ayrilmiş, deneme);// harfin hangi sırada olduğunu bulduk
                        for (int i = 0; i < ayrilmiş.Length; i++)
                        {
                            if (ayrilmiş[i] == deneme && a == 0) label1.Text = deneme.ToString();
                            else if (ayrilmiş[i] == deneme && a == 1) label2.Text = deneme.ToString();
                            else if (ayrilmiş[i] == deneme && a == 2) label3.Text = deneme.ToString();
                            else if (ayrilmiş[i] == deneme && a == 3) label4.Text = deneme.ToString();
                            else if (ayrilmiş[i] == deneme && a == 4) label5.Text = deneme.ToString();
                            else if (ayrilmiş[i] == deneme && a == 5) label6.Text = deneme.ToString();
                            else if (ayrilmiş[i] == deneme && a == 6) label7.Text = deneme.ToString();
                            else if (ayrilmiş[i] == deneme && a == 7) label8.Text = deneme.ToString();
                            else if (ayrilmiş[i] == deneme && a == 8) label9.Text = deneme.ToString();
                            else if (ayrilmiş[i] == deneme && a == 9) { label10.Text = deneme.ToString(); }
                        }
                    }
                    harf_hakki--;
                    if (harf_hakki == 0)
                    { button3.Enabled = false; textBox1.Enabled = false; }
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
        }


        private void button4_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            harf_hakki = 5;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            button3.Enabled = false;
            button2.Enabled = false;
            label1.Text = "_";
            label2.Text = "_";
            label3.Text = "_";
            label4.Text = "_";
            label5.Text = "_";
            label6.Text = "_";
            label7.Text = "_";
            label8.Text = "_";
            label9.Text = "_";
            label10.Text = "_";
            cizgi = 1;
            textBox1.Enabled = false;
            Pen mPen = new Pen(Color.White);
            Graphics g = this.CreateGraphics();
            g.DrawEllipse(mPen, 100, 100, 100, 50);//kafa
            g.DrawLine(mPen, 150, 150, 150, 300);//vücut
            g.DrawLine(mPen, 150, 200, 111, 280);//sol kol
            g.DrawLine(mPen, 150, 200, 190, 280);//sağ kol
            g.DrawLine(mPen, 150, 300, 194, 418);//sag bacak  
            g.DrawLine(mPen, 150, 300, 108, 420);//solbacak
            g.DrawLine(mPen, 65, 65, 65, 500);
            g.DrawLine(mPen, 65, 65, 300, 65);
            g.DrawLine(mPen, 150, 65, 150, 100);
            textBox1.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string tahmin = Interaction.InputBox("Tahmininizi Giriniz ", "TAHMİN");
            for (; ; )
            {
                if (tahmin == "")
                {
                    MessageBox.Show("bu alanı boş geçemezsiniz ");

                    tahmin = Interaction.InputBox("Tahmininizi Giriniz ", "TAHMİN");
                }
                else
                    break;
            }
            if (tahmin == cevir)
            {
                MessageBox.Show("Tebrikler... Kazandınız :)");
                button2.Enabled = false;
                button3.Enabled = false;
                textBox1.Enabled = false;
                button1.Enabled = false;
            }
            else
            {
                MessageBox.Show("Tahmininiz Yanlış :(");
                button2.Enabled = false;
                button3.Enabled = false;
                textBox1.Enabled = false;
                Pen mPen = new Pen(Color.Black);
                Graphics g = this.CreateGraphics();
                g.DrawEllipse(mPen, 100, 100, 100, 50);//kafa
                g.DrawLine(mPen, 150, 150, 150, 300);//vücut
                g.DrawLine(mPen, 150, 200, 111, 280);//sol kol
                g.DrawLine(mPen, 150, 200, 190, 280);//sağ kol
                g.DrawLine(mPen, 150, 300, 194, 418);//sag bacak  
                g.DrawLine(mPen, 150, 300, 108, 420);//solbacak
                g.DrawLine(mPen, 65, 65, 65, 500);
                g.DrawLine(mPen, 65, 65, 300, 65);
                g.DrawLine(mPen, 150, 65, 150, 100);
                button1.Enabled = false;
            }
        }
    }
}
