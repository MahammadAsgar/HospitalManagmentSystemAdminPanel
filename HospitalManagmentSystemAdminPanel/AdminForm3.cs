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
    public partial class AdminForm3 : Form
    {
        private readonly AppDbContext _context;

        public AdminForm3()
        {
            InitializeComponent();
            _context = new AppDbContext();
            foreach (var item in _context.Doctors)
            {
                listBox1.Items.Add(item.Name);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            AdminForm4 form4=new AdminForm4();
            this.Close();
            form4.ShowDialog();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var doctor = new Doctor();
            doctor = _context.Doctors.FirstOrDefault(x => x.Id == numericUpDown2.Value);
            _context.Doctors.Remove(doctor);
            _context.SaveChanges();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
