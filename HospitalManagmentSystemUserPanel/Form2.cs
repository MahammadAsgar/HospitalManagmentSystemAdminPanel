using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HospitalManagmentSystemUserPanel.Model;
using HospitalManagmentSystemUserPanel.Repository;

namespace HospitalManagmentSystemUserPanel
{
    public partial class Form2 : Form
    {
        private readonly UserDbContext _context;

        public Form2()
        {
            InitializeComponent();
            _context=new UserDbContext();
        }

        private void signUpBtn_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            var user = new User()
            {
                Name = nameText.Text,
                Surname = surnameText.Text,
                UserName = usernameText.Text,
                Password = passwordText.Text
            };
            _context.Users.Add(user);
            _context.SaveChanges();
            this.Hide();
            form.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
