using HospitalManagmentSystemAdminPanel.Model;
using HospitalManagmentSystemAdminPanel.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagmentSystemAdminPanel
{
    public partial class AdminForm1 : Form
    {
        readonly AppDbContext _context;
        public AdminForm1()
        {
            InitializeComponent();
            _context = new AppDbContext();
            
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void signBtn_Click(object sender, EventArgs e)
        {
            var admin = new Admin();
            admin=_context.Admin.First();
            if (admin.UserName.Equals(usnameText.Text)&&admin.Password.Equals(passText.Text))
            {
                AdminForm3 form3 = new AdminForm3();
                //this.Hide();
                this.Hide();
                form3.Show();
            }
        }

        private void signupBtn_Click(object sender, EventArgs e)
        {
            SignUpForm signUpForm = new SignUpForm();
            this.Hide();
            signUpForm.Show();
        }
    }
}
