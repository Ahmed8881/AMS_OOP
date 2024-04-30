using login.UI.User;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login.UI.Admin
{
    public partial class UserPanel : Form
    {
        public UserPanel()
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

        private void BuyTicket_Click(object sender, EventArgs e)
        {
            loadForm(new BuyTicket());
        }

        private void SearchFlight_Click(object sender, EventArgs e)
        {
            loadForm(new SearchFlight());
        }

        private void AddComplains_Click(object sender, EventArgs e)
        {
            loadForm(new GiveFeedBack());
        }

        private void CancelTicket_Click(object sender, EventArgs e)
        {
            loadForm(new CancelReservedFlight());
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
