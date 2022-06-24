using HospitalManagmentSystemUserPanel.Model;
using HospitalManagmentSystemUserPanel.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagmentSystemUserPanel
{
    public partial class Form1 : Form
    {
        private readonly UserDbContext _context;
        public Form1()
        {
            InitializeComponent();
            _context = new UserDbContext();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void signupBtn_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            this.Hide();
            form2.Show();
        }

        private void signinBtn_Click(object sender, EventArgs e)
        {
            Form3 form=new Form3();
            foreach (var item in _context.Users)
            {
                if (item.UserName.Equals(usnameText.Text) && (item.Password.Equals(passText.Text)))
                {
                    this.Hide();
                    form.Show();
                }
            }    
        }
    }
}
