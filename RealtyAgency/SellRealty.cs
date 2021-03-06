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
    public partial class SellRealty : Form
    {
        private Form FormToBack;
        public SellRealty(User user)
        {
            InitializeComponent();
            FormToBack = user;
        }

        private void SellButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (CityInput.Text != "" && SteetInput.Text != "" && HNumInput.Text != "" && AptNumLabel.Text !=""
                    && LatitudeInput.Text != "" && LongitudeInput.Text != "" && FloorInput.Text != "" && RoomsInput.Text != "" && TotalAreaInput.Text !="")
                {
                    string GetSelectedTypeID = "select ID from OfferType where TypeName = " + "\'" + RealtyType.SelectedItem.ToString() + "\'";
                    DB.SearchValuesQuery(GetSelectedTypeID);
                    string SelectedTypeID = DB.ds.Tables[0].Rows[0][0].ToString();

                    if (int.TryParse(FloorInput.Text, out int floor) && int.TryParse(RoomsInput.Text, out int rooms))
                    {
                        //Вставка нового предложения
                        string CreateNewOffer = "insert into RealtyOffers(OfferType, City, Street, House, Number, Latitude, Longitude, RFloor, Rooms, TotalArea)" +
                        "values(" + "\'" + SelectedTypeID + "\'" + "," + "\'" + CityInput.Text + "\'" + "," + "\'" + SteetInput.Text + "\'" + "," + "\'" +
                        HNumInput.Text + "\'" + "," + "\'" + AptNumLabel.Text + "\'" + "," + "\'" + LatitudeInput.Text + "\'" + "," + "\'" + LongitudeInput.Text + "\'" +
                        "," + "\'" + floor + "\'" + "," + "\'" + rooms + "\'" + "," + "\'" + TotalAreaInput.Text + "\'" + ")";
                        DB.Execute(CreateNewOffer);

                        string GetMaxOfferID = "select max(OfferID) from RealtyOffers";
                        DB.SearchValuesQuery(GetMaxOfferID);
                        string NewOfferID = DB.ds.Tables[0].Rows[0][0].ToString();

                        string Query = "select UserID from Users where UserLogin = " + "\'" + DB.AuthorizedUser + "\'";
                        DB.SearchValuesQuery(Query);
                        string ClientID = DB.ds.Tables[0].Rows[0][0].ToString();

                        string ConnectOfferWithUser = "insert into ClientsOffers(Offer, Client) values(" +
                            "\'" + NewOfferID + "\'" + "," + "\'" + ClientID + "\'" + ")";
                        DB.Execute(ConnectOfferWithUser);

                        MessageBox.Show("Вы успешно выставили вашу недвижимость на продажу");
                    }
                    else
                    {
                        throw new Exception("Этаж и количество комнат могут быть только целыми значениями!");
                    }
                }
                else
                {
                    throw new Exception("Все текстовые поля обязательны для заполнения!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SellRealty_Load(object sender, EventArgs e)
        {
            RealtyType.SelectedItem = "Дом";
        }

        private void GoBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            FormToBack.Show();
        }
    }
}
