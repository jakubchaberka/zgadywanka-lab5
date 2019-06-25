using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModelGry;
namespace GraGUI
{
    public partial class Form1 : Form
    {
        private Gra g;
        DateTime startTime;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonNowaGra_Click(object sender, EventArgs e)
        {
            groupBoxLosuj.Visible = true;
            buttonNowaGra.Enabled = false;
            gBLosowanie.Visible = false;
            gBPrzerwij.Visible = false;
            textBoxOd.Enabled = true;
            textBoxDo.Enabled = true;
            buttonLosuj.Enabled = true;
            button1.Enabled = true;
            odpowiedz.Text = "Odpowiedź";
            odpowiedz.ForeColor = Color.Black;
            wpisanaLiczba.Text = "";

            czas2.Text = "";
            liczbaRuchow2.Text = "";
            wylosowana2.Text = "";

        }

        private void buttonLosuj_Click(object sender, EventArgs e)
        {
            //wczytaj zakres do losowania
            int a = 0, b = 0;

            try
            {
                a = int.Parse(textBoxOd.Text);
                b = int.Parse(textBoxDo.Text);

                //uwtórz grę

                g = new Gra(a, b);
                textBoxOd.Enabled = false;
                textBoxDo.Enabled = false;
                buttonLosuj.Enabled = false;


                startTime = DateTime.Now;
                timer1.Tick += (s, ev) => { czas.Text = String.Format("{0:00}", (DateTime.Now - startTime).ToString()); };
                startTime = DateTime.Now;
                timer1.Interval = 100;
                timer1.Start();

                //wyswietl kolejne elementy formularza

                gBLosowanie.Visible = true;
            }
            catch (FormatException)
            {
                MessageBox.Show("Podaj zakres.");
            }

        }
        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void TextBoxOd_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            try
            {
                switch (g.Ocena(int.Parse(wpisanaLiczba.Text)))
                {
                    case Gra.Odpowiedz.ZaMalo:
                        odpowiedz.Text = "Za mało";
                        odpowiedz.ForeColor = Color.Red;
                        break;
                    case Gra.Odpowiedz.ZaDuzo:
                        odpowiedz.Text = "Za dużo";
                        odpowiedz.ForeColor = Color.Red;
                        break;
                    case Gra.Odpowiedz.Trafiono:
                        odpowiedz.Text = "Trafiłeś";
                        odpowiedz.ForeColor = Color.Green;
                        Button1_Click(sender, e);
                        timer1.Stop();
                        czas.Text = "";
                        break;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Podaj liczbe.");
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(g);
            form3.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            g.Poddaj();
            gBPrzerwij.Visible = true;
            czas2.Text = (DateTime.Now - startTime).ToString();
            liczbaRuchow2.Text = g.LicznikRuchow.ToString();
            wylosowana2.Text = g.Wylosowana.ToString();
            button1.Enabled = false;
            buttonNowaGra.Enabled = true;
        }
    }
}
