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
    public partial class Rieltor : Form
    {
        public Rieltor()
        {
            InitializeComponent();
        }

        private void Rieltor_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Rieltor_Load(object sender, EventArgs e)
        {
            string GetUsersWishes = "execute GetClientsWishes " + "\'" + DB.AuthorizedUser + "\'";
            UsersQueriesData.DataSource = DB.SearchValuesQuery(GetUsersWishes);
            IncomeLabel.Visible = false;

            List<string> ClientWishList = new List<string>();
            DB.SearchValuesQuery(GetUsersWishes);

            for (int i = 0; i < DB.ds.Tables[0].Rows.Count; i++)
            {
                string ConcatinatedQuery = DB.ds.Tables[0].Rows[i][2].ToString() + "," +
                    DB.ds.Tables[0].Rows[i][3].ToString() + "," + DB.ds.Tables[0].Rows[i][4].ToString() + "," +
                    DB.ds.Tables[0].Rows[i][5].ToString();
                ClientWishList.Add(ConcatinatedQuery);
            }

            foreach (string clw in ClientWishList)
            {
                UsersQueriesOpt.Items.Add(clw);
            }
        }

        

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            string OfferID = DB.GetRealtyIDBySplitter(UsersQueriesOpt.SelectedItem.ToString(), ',');
            string UpdateWishStatus = "update ClientsWishes set Status = 'Принят' where Offer = " + "\'" + OfferID + "\'";
            DB.Execute(UpdateWishStatus);

            string GetRieltorID = "execute GetRieltorIDByAuthedUser " + "\'" + DB.AuthorizedUser + "\'";
            DB.SearchValuesQuery(GetRieltorID);
            string RieltorID = DB.ds.Tables[0].Rows[0][0].ToString();

            string UpdateRieltorStatus = "update Rieltors set Status = 'В сделке' where RieltorID = " + "\'" + RieltorID + "\'";
            DB.Execute(UpdateRieltorStatus);

            MessageBox.Show($@"Заявка под номером {OfferID} успешно принята");
        }

        private void UsersQueriesOpt_SelectedIndexChanged(object sender, EventArgs e)
        {
            string OfferID = DB.GetRealtyIDBySplitter(UsersQueriesOpt.SelectedItem.ToString(), ',');
            string GetOfferPrice = "select Price from RealtyOffers where OfferID = " + "\'" + OfferID + "\'";
            DB.SearchValuesQuery(GetOfferPrice);
            double OfferPrice = Convert.ToDouble(DB.ds.Tables[0].Rows[0][0].ToString());

            string GetRieltorID = "execute GetRieltorIDByAuthedUser " + "\'" + DB.AuthorizedUser + "\'";
            DB.SearchValuesQuery(GetRieltorID);
            string RieltorID = DB.ds.Tables[0].Rows[0][0].ToString();

            string GetRieltorDealShare = "select DealShare from Rieltors where RieltorID = " + "\'" + RieltorID + "\'";
            DB.SearchValuesQuery(GetRieltorDealShare);
            double DealShare = Convert.ToDouble(DB.ds.Tables[0].Rows[0][0].ToString()) / 100;
            double RieltorIncome = OfferPrice * DealShare;

            IncomeLabel.Visible = true;
            IncomeLabel.Text += Convert.ToString(RieltorIncome);
        }

        private void LogoutLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DB.AuthorizedUser = null;
            Hide();
            Auth auth = new Auth();
            auth.Show();
        }
    }
}
