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
    public partial class AdminForm4 : Form
    {
        private readonly AppDbContext _context;
        public AdminForm4()
        {
            InitializeComponent();
            _context = new AppDbContext();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var doctor = new Doctor()
            {
                Name = nameText.Text,
                Surname = surnameText.Text,
                Age = Convert.ToInt32(ageText.Text),
                Duty = dutyText.Text,
                Exprience = Convert.ToInt32(exprienceText.Text)
            };
            _context.Doctors.Add(doctor);
            _context.SaveChanges();
            AdminForm3 form3=new AdminForm3();
            this.Hide();
            form3.Show();
        }
    }
}
