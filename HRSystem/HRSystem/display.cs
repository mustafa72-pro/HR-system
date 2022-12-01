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

namespace HRSystem
{
    public partial class display : Form
    {
        public display()
        {
            InitializeComponent();
        }

        private void depTB_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void displayButton_Click(object sender, EventArgs e)
        {
            Department d = new Department();
            display d1 = new display();
            char[] Id=d1.display(depTB.Text);
            string s = new string(Id);
            MessageBox.Show(s);
            
        }
    }
}
