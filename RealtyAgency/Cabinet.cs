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
    public partial class Cabinet : Form
    {
        private Form FormToBack;
        public Cabinet(User User)
        {
            InitializeComponent();
            FormToBack = User;
        }

        private void Cabinet_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void GoBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            FormToBack.Show();
        }

        private void Cabinet_Load(object sender, EventArgs e)
        {
            string GetUserSuggestions = "execute GetUserSuggestions " + "\'" + DB.AuthorizedUser + "\'";
            SuggestionsData.DataSource = DB.SearchValuesQuery(GetUserSuggestions);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(SuggNumInput.Text, out int SuggNum))
                {
                    string DeleteClientOffer = "delete from ClientsOffers where Offer = " + "\'" + SuggNum + "\'";
                    DB.Execute(DeleteClientOffer);

                    string DeleteOffer = "delete from RealtyOffers where OfferID = " + "\'" + SuggNum + "\'";
                    DB.Execute(DeleteOffer);

                    MessageBox.Show($@"Ваше предложение под номером {SuggNum} успешно удалено!");

                    string GetUserSuggestions = "execute GetUserSuggestions " + "\'" + DB.AuthorizedUser + "\'";
                    SuggestionsData.DataSource = DB.SearchValuesQuery(GetUserSuggestions);
                }
                else
                {
                    throw new Exception("Номер предложения может быть только целым числом!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void DeleteAccLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DeleteAccount delacc = new DeleteAccount();
            delacc.Show();
        }
    }
}
