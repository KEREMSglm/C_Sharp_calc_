namespace CALCULATOR
{
    public partial class CalculatorForm : Form
    {

        double sayi1;
        double sayi2;
        string islem = "";
        Boolean esitFlag = false;
        public CalculatorForm()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor= System.Drawing.Color.FromArgb(((int)(byte)(61)), ((int)(byte)(63)), ((int)(byte)(67)));
            b1.BackColor= System.Drawing.Color.FromArgb(((int)(byte)(87)), ((int)(byte)(87)), ((int)(byte)(87)));
            b2.BackColor= System.Drawing.Color.FromArgb(((int)(byte)(87)), ((int)(byte)(87)), ((int)(byte)(87)));
            b3.BackColor= System.Drawing.Color.FromArgb(((int)(byte)(87)), ((int)(byte)(87)), ((int)(byte)(87)));
            b4.BackColor= System.Drawing.Color.FromArgb(((int)(byte)(87)), ((int)(byte)(87)), ((int)(byte)(87)));
            b5.BackColor= System.Drawing.Color.FromArgb(((int)(byte)(87)), ((int)(byte)(87)), ((int)(byte)(87)));
            b6.BackColor= System.Drawing.Color.FromArgb(((int)(byte)(87)), ((int)(byte)(87)), ((int)(byte)(87)));
            b7.BackColor= System.Drawing.Color.FromArgb(((int)(byte)(87)), ((int)(byte)(87)), ((int)(byte)(87)));
            b8.BackColor= System.Drawing.Color.FromArgb(((int)(byte)(87)), ((int)(byte)(87)), ((int)(byte)(87)));
            b9.BackColor= System.Drawing.Color.FromArgb(((int)(byte)(87)), ((int)(byte)(87)), ((int)(byte)(87)));
            b0.BackColor= System.Drawing.Color.FromArgb(((int)(byte)(87)), ((int)(byte)(87)), ((int)(byte)(87)));
            sum.BackColor= System.Drawing.Color.FromArgb(((int)(byte)(87)), ((int)(byte)(87)), ((int)(byte)(87)));
            ext.BackColor= System.Drawing.Color.FromArgb(((int)(byte)(87)), ((int)(byte)(87)), ((int)(byte)(87)));
            ply.BackColor= System.Drawing.Color.FromArgb(((int)(byte)(87)), ((int)(byte)(87)), ((int)(byte)(87)));
            div.BackColor= System.Drawing.Color.FromArgb(((int)(byte)(87)), ((int)(byte)(87)), ((int)(byte)(87)));
            c.BackColor= System.Drawing.Color.FromArgb(((int)(byte)(87)), ((int)(byte)(87)), ((int)(byte)(87)));

            
        }
        private void b1_Click(object sender,EventArgs e)
        {
            ekranaYaz("1");
            
        }
        private void b1_MouseHover(object sender,EventArgs e)
        {
            b1.BackColor= System.Drawing.Color.FromArgb(((int)(byte)(192)), ((int)(byte)(192)), ((int)(byte)(192)));
        }
        private void b1_MouseLeave(object sender ,EventArgs e)
        {
            b1.BackColor= System.Drawing.Color.FromArgb(((int)(byte)(87)), ((int)(byte)(87)), ((int)(byte)(87)));

        }
        private void b2_Click(object sender, EventArgs e)
        {
            ekranaYaz("2");
        }
        private void b2_MouseHover(object sender, EventArgs e)
        {
            b2.BackColor= System.Drawing.Color.FromArgb(((int)(byte)(192)), ((int)(byte)(192)), ((int)(byte)(192)));
        }
        private void b2_MouseLeave(object sender, EventArgs e)
        {
            b2.BackColor= System.Drawing.Color.FromArgb(((int)(byte)(87)), ((int)(byte)(87)), ((int)(byte)(87)));

        }
        private void b3_Click(object sender, EventArgs e)
        {
            ekranaYaz("3");
        }
        private void b3_MouseHover(object sender, EventArgs e)
        {
            b3.BackColor= System.Drawing.Color.FromArgb(((int)(byte)(192)), ((int)(byte)(192)), ((int)(byte)(192)));
        }
        private void b3_MouseLeave(object sender, EventArgs e)
        {
            b3.BackColor= System.Drawing.Color.FromArgb(((int)(byte)(87)), ((int)(byte)(87)), ((int)(byte)(87)));

        }
        private void b4_Click(object sender, EventArgs e)
        {
            ekranaYaz("4");
        }
        private void b4_MouseHover(object sender, EventArgs e)
        {
            b4.BackColor= System.Drawing.Color.FromArgb(((int)(byte)(192)), ((int)(byte)(192)), ((int)(byte)(192)));
        }
        private void b4_MouseLeave(object sender, EventArgs e)
        {
            b4.BackColor= System.Drawing.Color.FromArgb(((int)(byte)(87)), ((int)(byte)(87)), ((int)(byte)(87)));

        }
        private void b5_Click(object sender, EventArgs e)
        {
            ekranaYaz("5");
        }
        private void b5_MouseHover(object sender, EventArgs e)
        {
            b5.BackColor= System.Drawing.Color.FromArgb(((int)(byte)(192)), ((int)(byte)(192)), ((int)(byte)(192)));
        }
        private void b5_MouseLeave(object sender, EventArgs e)
        {
            b5.BackColor= System.Drawing.Color.FromArgb(((int)(byte)(87)), ((int)(byte)(87)), ((int)(byte)(87)));

        }
        private void b6_Click(object sender, EventArgs e)
        {
            ekranaYaz("6");
        }
        private void b6_MouseHover(object sender, EventArgs e)
        {
            b6.BackColor= System.Drawing.Color.FromArgb(((int)(byte)(192)), ((int)(byte)(192)), ((int)(byte)(192)));
        }
        private void b6_MouseLeave(object sender, EventArgs e)
        {
            b6.BackColor= System.Drawing.Color.FromArgb(((int)(byte)(87)), ((int)(byte)(87)), ((int)(byte)(87)));

        }
        private void b7_Click(object sender, EventArgs e)
        {
            ekranaYaz("7");
        }
        private void b7_MouseHover(object sender, EventArgs e)
        {
            b7.BackColor= System.Drawing.Color.FromArgb(((int)(byte)(192)), ((int)(byte)(192)), ((int)(byte)(192)));

        }
        private void b7_MouseLeave(object sender, EventArgs e)
        {
            b7.BackColor= System.Drawing.Color.FromArgb(((int)(byte)(87)), ((int)(byte)(87)), ((int)(byte)(87)));

        }
        private void b8_Click(object sender, EventArgs e)
        {
            ekranaYaz("8");
        }
        private void b8_MouseHover(object sender, EventArgs e)
        {
            b8.BackColor= System.Drawing.Color.FromArgb(((int)(byte)(192)), ((int)(byte)(192)), ((int)(byte)(192)));

        }
        private void b8_MouseLeave(object sender, EventArgs e)
        {
            b8.BackColor= System.Drawing.Color.FromArgb(((int)(byte)(87)), ((int)(byte)(87)), ((int)(byte)(87)));

        }
        private void b9_Click(object sender, EventArgs e)
        {
            ekranaYaz("9");
        }
        private void b9_MouseHover(object sender, EventArgs e)
        {
            b9.BackColor= System.Drawing.Color.FromArgb(((int)(byte)(192)), ((int)(byte)(192)), ((int)(byte)(192)));
        }
        private void b9_MouseLeave(object sender, EventArgs e)
        {
            b9.BackColor= System.Drawing.Color.FromArgb(((int)(byte)(87)), ((int)(byte)(87)), ((int)(byte)(87)));

        }
        private void b0_Click(object sender, EventArgs e)
        {
            ekranaYaz("0");
        }
        private void b0_MouseHover(object sender, EventArgs e)
        {
            b0.BackColor= System.Drawing.Color.FromArgb(((int)(byte)(192)), ((int)(byte)(192)), ((int)(byte)(192)));
        }
        private void b0_MouseLeave(object sender, EventArgs e)
        {
            b0.BackColor= System.Drawing.Color.FromArgb(((int)(byte)(87)), ((int)(byte)(87)), ((int)(byte)(87)));

        }
        private void sum_Click(object sender, EventArgs e)
        {
            islemSec("+");
        }
        private void sum_MouseHover(object sender,EventArgs e)
        {
            sum.BackColor= System.Drawing.Color.FromArgb(((int)(byte)(71)), ((int)(byte)(71)), ((int)(byte)(71)));
        }
        private void sum_MouseLeave(object sender, EventArgs e)
        {
            sum.BackColor= System.Drawing.Color.FromArgb(((int)(byte)(87)), ((int)(byte)(87)), ((int)(byte)(87)));

        }
        private void ext_Click(object sender, EventArgs e)
        {
            islemSec("-");
        }
        private void ext_MouseHover(object sender, EventArgs e)
        {
            ext.BackColor= System.Drawing.Color.FromArgb(((int)(byte)(71)), ((int)(byte)(71)), ((int)(byte)(71)));

        }
        private void ext_MouseLeave(object sender, EventArgs e)
        {
            ext.BackColor= System.Drawing.Color.FromArgb(((int)(byte)(87)), ((int)(byte)(87)), ((int)(byte)(87)));

        }
        private void ply_Click(object sender, EventArgs e)
        {
            islemSec("x");
        }
        private void ply_MouseHover(object sender, EventArgs e)
        {
            ply.BackColor= System.Drawing.Color.FromArgb(((int)(byte)(71)), ((int)(byte)(71)), ((int)(byte)(71)));
        }
        private void ply_MouseLeave(object sender, EventArgs e)
        {
            ply.BackColor= System.Drawing.Color.FromArgb(((int)(byte)(87)), ((int)(byte)(87)), ((int)(byte)(87)));

        }
        private void div_Click(object sender, EventArgs e)
        {
            islemSec("÷");
        }
        private void div_MouseHover(object sender, EventArgs e)
        {
            div.BackColor= System.Drawing.Color.FromArgb(((int)(byte)(71)), ((int)(byte)(71)), ((int)(byte)(71)));

        }
        private void div_MouseLeave(object sender, EventArgs e)
        {
            div.BackColor= System.Drawing.Color.FromArgb(((int)(byte)(87)), ((int)(byte)(87)), ((int)(byte)(87)));
        }
        private void c_Click(object sender, EventArgs e)
        {
            temizle();
        }
        private void c_MouseHover(object sender, EventArgs e)
        {
            c.BackColor= System.Drawing.Color.FromArgb(((int)(byte)(87)), ((int)(byte)(87)), ((int)(byte)(87)));

        }
        private void c_MouseLeave(object sender, EventArgs e)
        {
            c.BackColor= System.Drawing.Color.FromArgb(((int)(byte)(71)), ((int)(byte)(71)), ((int)(byte)(71)));

        }
        
        private void temizle()
        {
            ekran.Text="";
            ekran2.Text="";
            sayi1=0;
            sayi2=0;
            islem="";
            esitFlag=false;
        }

        private void ekranaYaz(string sayi)
        {
            if (esitFlag)
            {
                temizle();
            }
            ekran.Text= ekran.Text + sayi;
            if(islem == "")
            {
                sayi1=Convert.ToDouble(ekran.Text);
            }
            else
            {
                sayi2=Convert.ToDouble(ekran.Text);
            }
            ekran2Guncelle(); 
        }
        private void islemSec(string islemPrm)
        {
            islem=islemPrm;
            ekran.Text="";
            ekran2Guncelle();
        }
        private void ekran2Guncelle()
        {
            if (islem=="")
            {
                ekran2.Text = Convert.ToString(sayi1);
            }
            else 
            {
                ekran2.Text = sayi1 + islem + sayi2;
            }
            
        }
        private void Equals_Click(object sender, EventArgs e)
        {
            double answer=0;
            switch (islem)
            {
                case "+":
                    {
                        answer = sayi1+sayi2;
                        break;
                    }
                case "-":
                    {
                        answer=sayi1-sayi2;
                        break;
                    }
                case "x":
                    {
                        answer = sayi1*sayi2;
                        break;
                    }
                case "÷":
                    {
                        answer = sayi1/sayi2;
                        break;
                    }
            }
            //temizle();
            ekran.Text = Convert.ToString(answer);
            esitFlag=true;
        }

        
    }
}