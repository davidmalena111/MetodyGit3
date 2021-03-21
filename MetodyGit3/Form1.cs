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

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dt1 = DateTime.Parse(textBox1.Text);
            DateTime dt2 = DateTime.Parse(textBox2.Text);

            TimeSpan casovyInterval = dt2 - dt1;
            MessageBox.Show("Počet dní, které uplynuly mezi těmito daty: " + casovyInterval.TotalDays);
        }
    }
}
