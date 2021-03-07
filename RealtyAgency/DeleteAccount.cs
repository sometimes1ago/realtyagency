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
    public partial class DeleteAccount : Form
    {
        public DeleteAccount()
        {
            InitializeComponent();
        }

        private void ShowTipLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Секретный ключ - уникальная последовательность символов, выданная вам при регистрации");
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (SecretKeyInput.Text != "")
                {
                    string GetSecretKeys = "select SecretKey from Users where UserLogin =" + "\'" + DB.AuthorizedUser + "\'";
                    DB.SearchValuesQuery(GetSecretKeys);
                    string UserKey = DB.ds.Tables[0].Rows[0][0].ToString();

                    if (SecretKeyInput.Text == UserKey)
                    {
                        string GetClientIDByAuthedUser = "select UserID from Users where SecretKey = " + "\'" + UserKey + "\'";
                        DB.SearchValuesQuery(GetClientIDByAuthedUser);
                        string ClientID = DB.ds.Tables[0].Rows[0][0].ToString();

                        string DeleteClientOffer = "delete from ClientsOffers where Client = " + "\'" + ClientID + "\'";
                        DB.Execute(DeleteClientOffer);

                        string DeleteClient = "delete from Clients where ClientID = " + "\'" + ClientID + "\'";
                        DB.Execute(DeleteClient);

                        string DeleteUser = "delete from Users where UserLogin = " + "\'" + DB.AuthorizedUser + "\'";
                        DB.Execute(DeleteUser);

                        MessageBox.Show("Вы успешно удалили свой аккаунт!");
                        DB.AuthorizedUser = null;
                        Hide();

                        Auth auth = new Auth();
                        auth.Show();
                    }
                    else
                    {
                        throw new Exception("Данного секретного ключа не существует или он вам не принадлежит!");
                    }
                }
                else
                {
                    throw new Exception("Для удаления учетной записи введите секретный ключ!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
