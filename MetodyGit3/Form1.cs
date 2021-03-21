using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetodyGit3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        TimeSpan Kolik(DateTime dt1, DateTime dt2, TimeSpan interval)
        {
            interval = dt2 - dt1;
            return interval;
        }


        DateTime Metoda3(DateTime datum)  //Pridavam Metodu3 a to na aktualni datum.
        {
            return datum = DateTime.Now;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dt1 = DateTime.Parse(textBox1.Text);
            DateTime dt2 = DateTime.Parse(textBox2.Text);

            TimeSpan casovyInterval = dt2 - dt1;

            MessageBox.Show("Počet dní, které uplynuly mezi těmito daty: " + Kolik(dt1, dt2, casovyInterval).TotalDays);

            //Funguje to bez problemu.


            //Aktualni datum 
            DateTime datum = DateTime.Now;
            MessageBox.Show("Aktualni datum je: " + Metoda3(datum).ToShortDateString());  //Funguje tak, jak má
        }

    }
}
