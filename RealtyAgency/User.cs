using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RealtyAgency
{
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
        }

        private void BuyButton_Click(object sender, EventArgs e)
        {
            BuyRealty buyrealty = new BuyRealty(this);
            Hide();
            buyrealty.Show();
        }

        private void CabinetButton_Click(object sender, EventArgs e)
        {
            Cabinet cab = new Cabinet(this);
            Hide();
            cab.Show();
        }

        private void LogoutLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DB.AuthorizedUser = null;
            Auth auth = new Auth();
            Hide();
            auth.Show();
        }

        private void User_Load(object sender, EventArgs e)
        {
            string GetAuthorizeUserData = "execute GetAuthorizedUserData " + "\'" + DB.AuthorizedUser + "\'";
            DB.SearchValuesQuery(GetAuthorizeUserData);
            GreetingsLabel.Text += Environment.NewLine + DB.ds.Tables[0].Rows[0][0].ToString() + " " + DB.ds.Tables[0].Rows[0][1].ToString();
        }

        private void User_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void SellButton_Click(object sender, EventArgs e)
        {
            SellRealty sr = new SellRealty(this);
            Hide();
            sr.Show();
        }
    }
}
