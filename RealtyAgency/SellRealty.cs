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

        private void ClearAllFields()
        {
            CityInput.Text = "";
            SteetInput.Text = "";
            HNumInput.Text = "";
            AptNumLabel.Text = "";
            LatitudeInput.Text = "";
            LongitudeInput.Text = "";
            FloorInput.Text = "";
            RoomsInput.Text = "";
            TotalAreaInput.Text = "";
            PriceInput.Text = "";
        }

        private void SellButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (CityInput.Text != "" && SteetInput.Text != "" && HNumInput.Text != "" && AptNumLabel.Text !=""
                    && LatitudeInput.Text != "" && LongitudeInput.Text != "" && FloorInput.Text != "" && RoomsInput.Text != "" 
                    && TotalAreaInput.Text != "" && PriceInput.Text != "")
                {
                    string GetSelectedTypeID = "select ID from OfferType where TypeName = " + "\'" + RealtyType.SelectedItem.ToString() + "\'";
                    DB.SearchValuesQuery(GetSelectedTypeID);
                    string SelectedTypeID = DB.ds.Tables[0].Rows[0][0].ToString();

                    if (int.TryParse(FloorInput.Text, out int floor) && int.TryParse(RoomsInput.Text, out int rooms) && int.TryParse(PriceInput.Text, out int price))
                    {
                        //Вставка нового предложения
                        string CreateNewOffer = "insert into RealtyOffers(OfferType, City, Street, House, Number, Latitude, Longitude, RFloor, Rooms, TotalArea, Price)" +
                        "values(" + "\'" + SelectedTypeID + "\'" + "," + "\'" + CityInput.Text + "\'" + "," + "\'" + SteetInput.Text + "\'" + "," + "\'" +
                        HNumInput.Text + "\'" + "," + "\'" + AptNumLabel.Text + "\'" + "," + "Convert(float," + LatitudeInput.Text + ")" + "," + "Convert(float," + LongitudeInput.Text + ")" +
                        "," + "\'" + floor + "\'" + "," + "\'" + rooms + "\'" + "," + "\'" + TotalAreaInput.Text + "\'" + "," + "\'" + price + "\'" + ")";
                        DB.Execute(CreateNewOffer);

                        //Получение ID только что добавленного предложения
                        string GetMaxOfferID = "select max(OfferID) from RealtyOffers";
                        DB.SearchValuesQuery(GetMaxOfferID);
                        string NewOfferID = DB.ds.Tables[0].Rows[0][0].ToString();

                        //Получение ID авторизованного пользователя
                        string Query = "select UserID from Users where UserLogin = " + "\'" + DB.AuthorizedUser + "\'";
                        DB.SearchValuesQuery(Query);
                        string UserID = DB.ds.Tables[0].Rows[0][0].ToString();

                        //Получение ID клиента согласно его данным авторизации
                        string GetClientID = "select ClientID from Clients where AuthData = " + "\'" + UserID + "\'";
                        DB.SearchValuesQuery(GetClientID);
                        string ClientID = DB.ds.Tables[0].Rows[0][0].ToString();

                        //Связка предложения и клиента
                        string ConnectOfferWithUser = "insert into ClientsOffers(Offer, Client) values(" +
                            "\'" + NewOfferID + "\'" + "," + "\'" + ClientID + "\'" + ")";
                        DB.Execute(ConnectOfferWithUser);

                        MessageBox.Show("Вы успешно выставили вашу недвижимость на продажу");
                        ClearAllFields();
                    }
                    else
                    {
                        throw new Exception("Этаж, количество комнат и цена могут быть только целыми значениями!");
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
            RealtyType.SelectedItem = "Дома";
        }

        private void GoBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            FormToBack.Show();
        }

        private void SellRealty_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
