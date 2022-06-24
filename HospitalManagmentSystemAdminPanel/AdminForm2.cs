using HospitalManagmentSystemAdminPanel.Model;
using HospitalManagmentSystemAdminPanel.Repository;
using HospitalManagmentSystemAdminPanel.Service;
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
    public partial class SignUpForm : Form
    {
        readonly AppDbContext _context;
        public SignUpForm()
        {
            InitializeComponent();
            _context = new AppDbContext();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void signUpBtn_Click(object sender, EventArgs e)
        {
            var admin = new Admin()
            {
                UserName = usnameText.Text,
                Password = pasText.Text,
            };
            _context.Admin.Add(admin);
            _context.SaveChanges();
            AdminForm1 form=new AdminForm1();
            this.Hide();
            form.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
