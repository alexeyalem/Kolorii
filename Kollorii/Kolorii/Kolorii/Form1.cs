using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kolorii
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox2.Enabled = false;
            if (comboBox1.Text=="грибы")
            {
                comboBox2.Enabled = true;
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
