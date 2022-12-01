using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
public class Employee
{
    public char [] ID;
    public char [] Name;
    public char[] hireDate;
    public char[] depNum;
    public int ID_Len;
    public int name_Len;
    public int hiredate_Len;
    public int depNum_Len;

  public  Employee()
    {
        ID_Len = 5;
        name_Len = 20;
        hiredate_Len = 10;
        depNum_Len = 5;
        ID = new char[ID_Len];
        Name = new char[name_Len];
        hireDate = new char[hiredate_Len];
        depNum = new char[depNum_Len];

    }

  public void add(char[] id, char[] name, char[] hire_date, char[] dep_num)
    {

        FileStream fs = new FileStream("employee.txt", FileMode.Append);
        StreamWriter sr = new StreamWriter(fs);
        
        sr.Write(id, 0, ID_Len);
        sr.Write(name, 0, name_Len);
        sr.Write(hire_date, 0, hiredate_Len);
        sr.Write(dep_num, 0,depNum_Len);
        sr.WriteLine("");
        sr.Close();


    }
    public void Display()
    {

    }
    public bool Search(String id)
    {
        return true;
    }
    public void Update(String id)
    {

    }

}
public class Department
{
    public char[] name;
    public char[] id;
    public int name_len;
    public int id_len;
   public Department()
    {
        name_len = 20;
        id_len = 5;
        name = new char[name_len];
        id = new char[id_len];
    }
   public void add(char[] id, char[] name)
   {

       FileStream fs = new FileStream("department.txt", FileMode.Append);
       StreamWriter sr = new StreamWriter(fs);

       sr.Write(id, 0, id_len);
       sr.Write(name, 0, name_len);
       sr.WriteLine("");
       sr.Close();


   }
   //public char[] display(string x)
   //{
      
   //}

    public String readData()
    {
        String x = "Hi";
        return x;
    }
}
namespace HRSystem
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
