
using login.UI.Admin;
using login.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SkyLinesLibrary;

namespace login
{
    public partial class Login : Form
    {
        public static int Index;
        private static IClientDL clientDL= ObjectHandler.GetClientDL();
        private static IAdminDL adminDL = ObjectHandler.GetAdminDL();
        public Login()
        {
            InitializeComponent();
            

        }

        public void loadForm(object form)
        {
            if (this.guna2Panel2.Controls.Count > 0)
            {
                this.guna2Panel2.Controls.RemoveAt(0);
            }
            Form f = form as Form;
            f.FormBorderStyle = FormBorderStyle.None;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.guna2Panel2.Controls.Add(f);
            this.guna2Panel2.Tag = f;
            f.Show();


        }
        private void guna2ToggleSwitch1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            UI.SignUP FORM= new UI.SignUP();
            FORM.Show();

           
        }
        public void Clear()
        {
            Username.Text = "";
            Password.Text = "";
        }

       
        private void Username_TextChanged(object sender, EventArgs e)
        {


        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string name = Username.Text;
            string password = Password.Text;
            if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(password))
            {
                string userType = GetUserType(name, password);
                if (!string.IsNullOrEmpty(userType))
                {
                    MessageBox.Show($"{name}! successfully Signed In.");
                    OpenPanel(userType);
                }
                else
                {
                    MessageBox.Show("No Such Person Exist.");
                }
            }
            else
            {
                MessageBox.Show("Please Fill In all the required fields.");
            }
            Clear();
        }

        private string GetUserType(string name, string password)
        {
             if (clientDL.IsClientExist(name, password))
            {
                Index = clientDL.FindClient(name, password);
                return "User";
            }
            else if (adminDL.IsAdminExist(name, password))
            {
                return "admin";
            }
            return "";
        }

        private void OpenPanel(string userType)
        {
            this.Hide();
            if (userType.ToLower() == "admin")
            {
                Admin_Panel adminPanel = new Admin_Panel();
                adminPanel.Show();
            }
            else if (userType.ToLower() == "user")
            {
                UserPanel userPanel = new UserPanel();
                userPanel.Show();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Test test = new Test();
            test.Show();
                  }
    }
 }

