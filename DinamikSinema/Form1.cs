using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DinamikSinema
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            
        }
        int toplam = 0;
        private void Form1_Load(object sender, EventArgs e)
        {

            int locY = 15;
            int locX = 0;
            gbKoltuklar.Enabled = true;
            string[] koltuklar = { "A", "B", "C","D" };
            int[] sayi = { 1, 2, 3, 4, 5};
            int j = 0;
            int a = 0;
            for (int i = 0; i < 15; i++)
            {
                Button b = new Button();             
                b.Height = 50;
                b.Width = 50;
                b.Click += MasaTiklama;
               
                //----------------------
                
                if (i != 0)
                {
                    locX += 50;
                }
                if (i % 5 == 0)//5 tane masa eklendikten sonra - yani i 5 e bölünebiliyorsa
                {
                    if (i != 0)
                    {
                        
                        locY += 50; // yi 50 arttır 
                        locX = 0;
                        j = j + 1;
                        a = 0;

                    }
                    b.Location = new Point(0, locY);//x lokasyonuna 0(sıfır değerini ver )                   
                }
                b.Text = $"{koltuklar[j]}{sayi[a]}";
                
                string mydocpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                StreamReader sr = new StreamReader(mydocpath + @"\WriteFile.txt");
                string line;
                line = sr.ReadLine();
                string[] koltukno= new string[150];
                int n=0;
                while (line != null)
                {
                    line = sr.ReadLine();
                    koltukno[n] = line;
                    n++;                  
                }
                sr.Close();
                
                if (Array.IndexOf(koltukno,b.Text)==-1)
                {
                    b.BackColor = Color.White;
                    b.ForeColor = Color.Green;
                }
                else
                {
                    
                    b.BackColor = Color.Red;
                    b.Enabled = false;
                }
                b.Location = new Point(locX, locY);
                a = a + 1;
                gbKoltuklar.Controls.Add(b);
            }
        }
        private void MasaTiklama(object sender,EventArgs e)
        {                    
            Button button = (Button)sender;
            button.BackColor = Color.Violet;
            string mydocpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string[] kayit = { button.Text.ToString() };
            File.AppendAllLines(mydocpath + @"\WriteFile.txt", kayit);
            toplam += 1;         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmSatis satis = new frmSatis(this,toplam);
            satis.ShowDialog();
            toplam = 0;
            
        }
        private void gbKoltuklar_enter(object sender, EventArgs e)
        {
            
        }
    }
}
