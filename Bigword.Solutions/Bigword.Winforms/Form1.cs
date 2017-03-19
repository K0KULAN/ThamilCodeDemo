using Bigword.BLL;
using Bigword.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bigword.Winforms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Greeter obj = new Greeter();
            MessageBox.Show(obj.GetGreetingWords(txtName.Text));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GetRecordFromDB obj = new GetRecordFromDB();
            lblDBRecord.Text = obj.GetEmployeeRecord(1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lblCompanyname.Text = "Company name is : " + System.Configuration.ConfigurationManager.AppSettings["CompanyName"];
        }
    }
}
