using Guna.UI2.WinForms;
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

namespace login.UI.User
{
    public partial class GiveFeedBack : Form
    {
        public GiveFeedBack()
        {
            InitializeComponent();
        }
        private void Clear()
        {
            ComplainTxtBox.Text = "";
        }
        private void Complainbtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(ComplainTxtBox.Text))
            {
                if (Validations.CheckCommaColon(ComplainTxtBox.Text))
                {
                    string feedback = ComplainTxtBox.Text;
                    List<Client> clients = ObjectHandler.GetClientDL().GetAllClients();
                    clients[Login.Index].SubmitFeedBack(feedback);
                    ObjectHandler.GetClientDL().UpdateFeedBack(clients[Login.Index].GetName(), feedback);
                    MessageBox.Show("Thanks for your precious Feedback.");
                    Clear();
                }
                else
                {
                    MessageBox.Show(", and ; is not allowed in any field.");
                }
            }
            else
                MessageBox.Show("Please fill in the required field.");
        }

        private void ComplainTxtBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
