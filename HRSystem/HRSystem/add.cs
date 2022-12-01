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
    public partial class add : Form
    {
        public add()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            char[] HIRE = new char[emp.hiredate_Len];
            char[] DEP = new char[emp.depNum_Len];
            char[] NAME = new char[emp.name_Len];
            char[] ID= new char[emp.ID_Len];
            String id = idTB.Text;
            String name = nameTB.Text;
            String hire = hireTB.Text;
            String dep = depTB.Text;
            if (id.Length > emp.ID_Len ||name.Length > emp.name_Len ||hire.Length > emp.hiredate_Len||dep.Length > emp.depNum_Len )
            {
                MessageBox.Show("This  is too large! YOU HAVE EXCEEDED MAXIMUM LIMIT");
            }
            else
            {
                
                id.CopyTo(0, ID, 0, id.Length);
                for (int i = ID.Length; i < emp.ID_Len; i++)
                    ID[i] = ' ';
                name.CopyTo(0, NAME, 0, name.Length);
                for (int i = NAME.Length; i < emp.name_Len; i++)
                    NAME[i] = ' ';
                 hire.CopyTo(0, HIRE, 0, hire.Length);
                for (int i = HIRE.Length; i < emp.hiredate_Len; i++)
                    HIRE[i] = ' ';
                 
                dep.CopyTo(0, DEP, 0, dep.Length);
                for (int i = DEP.Length; i < emp.depNum_Len; i++)
                    DEP[i] = ' ';
                   emp.add(ID, NAME, HIRE, DEP);
            }
                        this.Close();

           
               
            }
          
             
            
            
        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void idTB_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void add_Load(object sender, EventArgs e)
        {

        }

        private void hireTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void depTB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
