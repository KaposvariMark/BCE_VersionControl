using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserMaintenance.Entities;
using System.IO;

namespace UserMaintenance
{
    public partial class Form1 : Form
    {

        BindingList<User> users = new BindingList<User>();

        public Form1()
        {
            InitializeComponent();
            lblFullName.Text = Resource1.FullName;
            btnAdd.Text = Resource1.Add;
            btnWriteCsv.Text = Resource1.WriteCsv;

            listUsers.DataSource = users;
            listUsers.ValueMember = "ID";
            listUsers.DisplayMember = "FullName";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var u = new User()
            {
                FullName = txtFullName.Text
            };
            users.Add(u);
        }

        private void btnWriteCsv_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.InitialDirectory = Application.StartupPath;
            sfd.Filter = "CSV|*.csv";
            sfd.DefaultExt = "csv";
            sfd.AddExtension = true;
            sfd.Title = "Save a Csv File";

            if (sfd.ShowDialog() != DialogResult.OK) return;

            using (StreamWriter sw = new StreamWriter(sfd.FileName, false, Encoding.UTF8))
            {
                foreach (var user in users)
                {
                    sw.Write(user.FullName);
                    sw.Write(";");
                    sw.Write(user.ID);
                    sw.Write("\n");
                }
            }
        }
    }
}
