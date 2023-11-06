namespace MatematikOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        String oyuncu;
        bool oyunBasladiMi = false;
        int adim = 0;
        int puan;
        int dogru;
        int yanlis;
        int pas;
        int seviye = 0;
        int sure;


        private int sayiUretInt()
        {
            Random rnd = new Random();

            int sayi = rnd.Next(1, seviye * 10);
            return sayi;
        }


        private void button1_Click(object sender, EventArgs e)
        {


            oyuncu = textBox1.Text;
            oyunBasladiMi = true;
            tabControl1.SelectedTab = oyunEkrani1;
            label2.Text += " " + oyuncu;
            adim = 1;
            sure = 60;

            timer1.Start();
            timer1.Interval = 1000;

            seviye = 1;
            label18.Text = "Adým : " + adim.ToString();
            label17.Text = "Seviye : " + seviye.ToString();

            yenile();

        }

        private void yenile()
        {



            int num1 = sayiUretInt();
            int num2 = sayiUretInt();
            int num3 = sayiUretInt();
            int num4 = sayiUretInt();
            int num5 = sayiUretInt();
            int num6 = sayiUretInt();
            int num7 = sayiUretInt();
            int num8 = sayiUretInt();
            int num9 = sayiUretInt();
            int num10 = sayiUretInt();



            if (adim == 1 || adim == 4)
            {
                label8.Text = num1 + " + " + num2;
                label9.Text = num3 + " - " + num4;
                label10.Text = num5 + " x " + num6;
                label11.Text = num7 + " / " + num8;
                label12.Text = num9 + " + " + num10;

                radioButton1.Text = Convert.ToString(sayiUretInt());
                radioButton2.Text = Convert.ToString(sayiUretInt());
                radioButton3.Text = Convert.ToString(sayiUretInt());
                radioButton4.Text = Convert.ToString(num1 + num2);

                radioButton5.Text = Convert.ToString(sayiUretInt());
                radioButton6.Text = Convert.ToString(num3 - num4);
                radioButton7.Text = Convert.ToString(sayiUretInt());
                radioButton8.Text = Convert.ToString(sayiUretInt());

                radioButton9.Text = Convert.ToString(sayiUretInt());
                radioButton10.Text = Convert.ToString(sayiUretInt());
                radioButton11.Text = Convert.ToString(num5 * num6);
                radioButton12.Text = Convert.ToString(sayiUretInt());

                radioButton13.Text = Convert.ToString(num7 / num8);
                radioButton14.Text = Convert.ToString(sayiUretInt());
                radioButton15.Text = Convert.ToString(sayiUretInt());
                radioButton16.Text = Convert.ToString(sayiUretInt());

                radioButton17.Text = Convert.ToString(sayiUretInt());
                radioButton18.Text = Convert.ToString(sayiUretInt());
                radioButton19.Text = Convert.ToString(sayiUretInt());
                radioButton20.Text = Convert.ToString(num9 + num10);
            }
            else if (adim == 2)
            {
                label8.Text = num1 + " * " + num2;
                label9.Text = num3 + " + " + num4;
                label10.Text = num5 + " - " + num6;
                label11.Text = num7 + " / " + num8;
                label12.Text = num9 + " * " + num10;

                radioButton1.Text = Convert.ToString(sayiUretInt());
                radioButton2.Text = Convert.ToString(num1 * num2);
                radioButton3.Text = Convert.ToString(sayiUretInt());
                radioButton4.Text = Convert.ToString(sayiUretInt());

                radioButton5.Text = Convert.ToString(sayiUretInt());
                radioButton6.Text = Convert.ToString(sayiUretInt());
                radioButton7.Text = Convert.ToString(sayiUretInt());
                radioButton8.Text = Convert.ToString(num3 + num4);

                radioButton9.Text = Convert.ToString(num5 - num6);
                radioButton10.Text = Convert.ToString(sayiUretInt());
                radioButton11.Text = Convert.ToString(sayiUretInt());
                radioButton12.Text = Convert.ToString(sayiUretInt());

                radioButton13.Text = Convert.ToString(sayiUretInt());
                radioButton14.Text = Convert.ToString(sayiUretInt());
                radioButton15.Text = Convert.ToString(num7 / num8);
                radioButton16.Text = Convert.ToString(sayiUretInt());

                radioButton17.Text = Convert.ToString(sayiUretInt());
                radioButton18.Text = Convert.ToString(num9 * num10);
                radioButton19.Text = Convert.ToString(sayiUretInt());
                radioButton20.Text = Convert.ToString(sayiUretInt());
            }
            else if (adim == 3)
            {
                label8.Text = num1 + " / " + num2;
                label9.Text = num3 + " - " + num4;
                label10.Text = num5 + " + " + num6;
                label11.Text = num7 + " x " + num8;
                label12.Text = num9 + " x " + num10;

                radioButton1.Text = Convert.ToString(sayiUretInt());
                radioButton2.Text = Convert.ToString(sayiUretInt());
                radioButton3.Text = Convert.ToString(sayiUretInt());
                radioButton4.Text = Convert.ToString(num1 / num2);

                radioButton5.Text = Convert.ToString(num3 - num4);
                radioButton6.Text = Convert.ToString(sayiUretInt());
                radioButton7.Text = Convert.ToString(sayiUretInt());
                radioButton8.Text = Convert.ToString(sayiUretInt());

                radioButton9.Text = Convert.ToString(sayiUretInt());
                radioButton10.Text = Convert.ToString(sayiUretInt());
                radioButton11.Text = Convert.ToString(num5 + num6);
                radioButton12.Text = Convert.ToString(sayiUretInt());

                radioButton13.Text = Convert.ToString(sayiUretInt());
                radioButton14.Text = Convert.ToString(sayiUretInt());
                radioButton15.Text = Convert.ToString(num7 * num8);
                radioButton16.Text = Convert.ToString(sayiUretInt());

                radioButton17.Text = Convert.ToString(sayiUretInt());
                radioButton18.Text = Convert.ToString(sayiUretInt());
                radioButton19.Text = Convert.ToString(sayiUretInt());
                radioButton20.Text = Convert.ToString(num9 * num10);
            }

        }



        private void check()
        {

            if (radioButton21.Checked)
            {
                pas++;
            }

            if (radioButton22.Checked)
            {
                pas++;
            }

            if (radioButton23.Checked)
            {
                pas++;
            }

            if (radioButton24.Checked)
            {
                pas++;
            }

            if (radioButton25.Checked)
            {
                pas++;
            }

            if (adim == 1 || adim == 4)
            {
                if (radioButton4.Checked)
                {
                    dogru++;
                }
                if (radioButton6.Checked)
                {
                    dogru++;
                }
                if (radioButton11.Checked)
                {
                    dogru++;
                }
                if (radioButton13.Checked)
                {
                    dogru++;
                }
                if (radioButton20.Checked)
                {
                    dogru++;
                }
            }

            if (adim == 2)
            {
                if (radioButton2.Checked)
                {
                    dogru++;
                }
                if (radioButton8.Checked)
                {
                    dogru++;
                }
                if (radioButton9.Checked)
                {
                    dogru++;
                }
                if (radioButton15.Checked)
                {
                    dogru++;
                }
                if (radioButton18.Checked)
                {
                    dogru++;
                }
            }

            if (adim == 3)
            {
                if (radioButton4.Checked)
                {
                    dogru++;
                }
                if (radioButton5.Checked)
                {
                    dogru++;
                }
                if (radioButton11.Checked)
                {
                    dogru++;
                }
                if (radioButton15.Checked)
                {
                    dogru++;
                }
                if (radioButton20.Checked)
                {
                    dogru++;
                }
            }

            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;

            radioButton5.Checked = false;
            radioButton6.Checked = false; ;
            radioButton7.Checked = false;
            radioButton8.Checked = false; ;

            radioButton9.Checked = false;
            radioButton10.Checked = false;
            radioButton11.Checked = false;
            radioButton12.Checked = false;

            radioButton13.Checked = false;
            radioButton14.Checked = false;
            radioButton15.Checked = false;
            radioButton16.Checked = false;

            radioButton17.Checked = false;
            radioButton18.Checked = false;
            radioButton19.Checked = false;
            radioButton20.Checked = false;
            radioButton24.Checked = false;
            radioButton25.Checked = false;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            check();

            adim++;


            label18.Text = "Adým : " + adim.ToString();
            if (adim == 5)
            {
                label14.Text += " " + dogru;
                label15.Text += " " + (20 - dogru - pas);
                label16.Text += " " + pas;
                adim = 1;
                label18.Text = "Adým : " + adim.ToString();

                if (dogru >= 11 && dogru <= 15)
                {
                    label19.Text = "*";
                    seviye++;
                    button4.Visible = true;

                }
                else if (dogru >= 16 && dogru <= 18)
                {
                    label19.Text = "**";
                    seviye++;
                    button4.Visible = true;

                }
                else if (dogru >= 19 && dogru <= 20)
                {
                    label19.Text = "***";
                    seviye++;
                    button4.Visible = true;

                }
                else
                {
                    label19.Text = ":(";
                    button4.Visible = false;

                }
                tabControl1.SelectedTab = sonuc;
            }

            yenile();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            if (seviye == 1)
            {
                sure = 60;
            }
            else if (seviye == 2)
            {
                sure = 120;
            }else if(seviye == 3)
            {
                sure = 240;
            }

            dogru = 0;
            yanlis = 0;
            pas = 0;

            label14.Text = "Doðru: ";
            label15.Text = "Yanlýþ: ";
            label16.Text = "Pas: ";

            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;

            radioButton5.Checked = false;
            radioButton6.Checked = false;
            radioButton7.Checked = false;
            radioButton8.Checked = false;

            radioButton9.Checked = false;
            radioButton10.Checked = false;
            radioButton11.Checked = false;
            radioButton12.Checked = false;

            radioButton13.Checked = false;
            radioButton14.Checked = false;
            radioButton15.Checked = false;
            radioButton16.Checked = false;

            radioButton17.Checked = false;
            radioButton18.Checked = false;
            radioButton19.Checked = false;
            radioButton20.Checked = false;

            radioButton21.Checked = false;
            radioButton22.Checked = false;
            radioButton23.Checked = false;
            radioButton24.Checked = false;
            radioButton25.Checked = false;

            yenile();
            timer1.Start();
            tabControl1.SelectedTab = oyunEkrani1;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Stop();

            dogru = 0;
            yanlis = 0;
            pas = 0;

            label17.Text = "Seviye : " + seviye.ToString();
            label14.Text = "Doðru: ";
            label15.Text = "Yanlýþ: ";
            label16.Text = "Pas: ";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;

            radioButton5.Checked = false;
            radioButton6.Checked = false;
            radioButton7.Checked = false;
            radioButton8.Checked = false;

            radioButton9.Checked = false;
            radioButton10.Checked = false;
            radioButton11.Checked = false;
            radioButton12.Checked = false;

            radioButton13.Checked = false;
            radioButton14.Checked = false;
            radioButton15.Checked = false;
            radioButton16.Checked = false;

            radioButton17.Checked = false;
            radioButton18.Checked = false;
            radioButton19.Checked = false;
            radioButton20.Checked = false;

            radioButton21.Checked = false;
            radioButton22.Checked = false;
            radioButton23.Checked = false;
            radioButton24.Checked = false;
            radioButton25.Checked = false;

            if(seviye == 2)
            {
                sure = 120;
            }else if(seviye == 3)
            {
                sure = 240;
            }
            timer1.Start();
            tabControl1.SelectedTab = oyunEkrani1;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sure--;
            label20.Text = "Kalan Süre : " + sure.ToString();

            if (sure == 0)
            {
                timer1.Stop();
                MessageBox.Show("Süre doldu!", "Oyun Bitti");
                dogru = 0;
                yanlis = 0;
                adim = 1;
                seviye = 1;
                pas = 0;
                label17.Text = "Seviye : " + seviye.ToString();
                label14.Text = "Doðru: ";
                label15.Text = "Yanlýþ: ";
                label16.Text = "Pas: ";

            }
        }
    }
}