using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRSystem
{
    public partial class depart : Form
    {
        public depart()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void addButton_Click(object sender, EventArgs e)
        {
            Department d = new Department();
            char[] NAME = new char[d.name_len];
            char[] ID = new char[d.id_len];
            String id = idTB.Text;
            String name = nameTB.Text;
            
           
            if (id.Length > d.id_len || name.Length > d.name_len)
            {
                MessageBox.Show("This  is too large! YOU HAVE EXCEEDED MAXIMUM LIMIT");
            }
            else
            {
                id.CopyTo(0, ID, 0, id.Length);
                for (int i = ID.Length; i < d.id_len; i++)
                    ID[i] = ' ';
                name.CopyTo(0, NAME, 0, name.Length);
                for (int i = NAME.Length; i < d.name_len; i++)
                    NAME[i] = ' ';
             
                d.add(ID, NAME);
            }
            this.Close();

        }
    }
}
