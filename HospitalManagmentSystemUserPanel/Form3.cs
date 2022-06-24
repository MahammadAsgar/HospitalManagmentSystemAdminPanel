using HospitalManagmentSystemAdminPanel.Repository;
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
    public partial class Form3 : Form
    {
        private readonly UserDbContext _context;
        private readonly AppDbContext admincontext;
        public Form3()
        {
            InitializeComponent();
            _context = new UserDbContext();
            admincontext = new AppDbContext();
            foreach (var item in admincontext.Doctors)
            {
                listBox1.Items.Add(item);
            }            
        }

      
    }
}
