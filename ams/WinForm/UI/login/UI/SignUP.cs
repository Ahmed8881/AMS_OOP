
using SkyLinesLibrary;
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
    public partial class SignUP : Form
    {
        public SignUP()
        {
            InitializeComponent();
        }

        private void SignUP_Load(object sender, EventArgs e)
        {
           
           

        }
        

       
       
        public bool FillAllFields()
        {
            if (Username.Text == "" || password.Text == "" || role.Text == "")
            {
                return false;
            }
            else
            {
                return true;
            }

        }
        public void ClearFields() { 
        Username.Text= "";
        password.Text = "";
            role.Text = "";
        }

        

        private bool IsUsernameValid(string username)
        {
            return ObjectHandler.GetAdminDL().CheckValidAdminName(username) && ObjectHandler.GetClientDL().CheckValidClientName(username);
        }

        private bool AreFieldsFilled(string username, string password, string role)
        {
            return !string.IsNullOrWhiteSpace(username) && !string.IsNullOrWhiteSpace(password) && !string.IsNullOrWhiteSpace(role) && Validations.CheckCommaColon(username) && Validations.CheckCommaColon(password);
        }

        private bool IsValidRole(string role)
        {
            return role.ToLower() == "admin" || role.ToLower() == "user";
        }

        private void CreateUser(string username, string password, string role)
        {
            if (role.ToLower() == "admin")
            {
            Admins newAdmin = new Admins(username, password, role);
            ObjectHandler.GetAdminDL().AddAdmin(newAdmin);
            }
            if (role.ToLower() == "user")
            {
            Client newClient = new Client(username, password, role);
            ObjectHandler.GetClientDL().AddClient(newClient);
            }
        }

        private void ShowSuccessMessage()
        {
            MessageBox.Show("Successfully Signed Up..");
        }

        private void NavigateToLogin()
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void ShowInvalidRoleMessage()
        {
            MessageBox.Show("Invalid Role..");
        }

        private void ShowUsernameExistsMessage()
        {
            MessageBox.Show("Username Already Exists. Try any other Username.");
        }
        public void test(){}

        private void SignU_Click(object sender, EventArgs e)
        {
            string username = Username.Text;
            string Password = password.Text;
            string Role = role.Text;

            if (IsUsernameValid(username) && AreFieldsFilled(username, Password, Role))
            {
                if (IsValidRole(Role))
                {
                    CreateUser(username, Password, Role);
                    ShowSuccessMessage();
                    ClearFields();
                    NavigateToLogin();
                }
                else
                {
                    ShowInvalidRoleMessage();
                }
            }
            else
            {
                ShowUsernameExistsMessage();
                ClearFields();
            }

        }

        private void BackToLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login f = new Login();
            f.Show();
        }
    }
}
