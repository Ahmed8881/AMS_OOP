using Guna.UI2.WinForms;
using login.UI.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 

namespace login.UI
{
    public partial class Admin_Panel : Form
    {
        public Admin_Panel()
        {
            InitializeComponent();
           
        }

        public void loadForm(object form)
        {
            if (this.LoadingPanel.Controls.Count > 0)
            {
                this.LoadingPanel.Controls.RemoveAt(0);
            }

            Form f = form as Form;
            f.FormBorderStyle = FormBorderStyle.None;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.LoadingPanel.Controls.Add(f);
            this.LoadingPanel.Tag = f;
            f.Show();
        }


       

        private void btn_show_Click(object sender, EventArgs e)
        {
            icon.Visible = true;
            show_btn.Visible = false;
            hide_btn.Visible = true;
            sidebar.Visible = false;
            sidebar.Width = 264;
            guna2Transition1.ShowSync(sidebar);


        }

        private void btn_hide_Click(object sender, EventArgs e)
        {
            icon.Visible = false;
            sidebar.Visible = false;
            hide_btn.Visible = false;
            show_btn.Visible = true;
            sidebar.Width = 47;
            guna2Transition1.ShowSync(sidebar);
        }

        private void AddFlight_Click(object sender, EventArgs e)
        {
            loadForm(new Add_Flight());
        }

        private void RemoveFlight_Click(object sender, EventArgs e)
        {
            loadForm(new RemoveFlight());
        }

        private void ViewFlight_Click(object sender, EventArgs e)
        {
            loadForm(new ViewFlights());
        }

        private void UpdateFlight_Click(object sender, EventArgs e)
        {
            loadForm(new UpdateFlight());

        }

        private void AddEmp_Click(object sender, EventArgs e)
        {
            loadForm(new AddStaff());
        }

        private void RemoveEmp_Click(object sender, EventArgs e)
        {
            loadForm(new RemoveStaff());
        }

        private void Admin_Panel_Load(object sender, EventArgs e)
        {

        }

        private void LoadingPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2GradientButton6_Click(object sender, EventArgs e)
        {
            this.Close();
            Login login = new Login();
            login.Show();
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
