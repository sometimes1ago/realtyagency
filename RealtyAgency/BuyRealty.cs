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
    public partial class BuyRealty : Form
    {
        private Form FormToBack;
        public BuyRealty(User User)
        {
            InitializeComponent();
            FormToBack = User;
        }

        private void BuyRealty_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void GoBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            FormToBack.Show();
        }

        /// <summary>
        /// Метод, проверяющий параметры сортировки параметры сортировки
        /// </summary>
        /// <param name="Parameter"></param>
        /// <returns></returns>
        private string CheckSortParameter(string Parameter)
        {
            switch (Parameter)
            {
                case "Городу":
                    Parameter = "City";
                    break;
                case "Улице":
                    Parameter = "Street";
                    break;
                case "Дому":
                    Parameter = "House";
                    break;
                case "Комнатам":
                    Parameter = "Rooms";
                    break;
                case "Этажам":
                    Parameter = "RFloor";
                    break;
            }

            return Parameter;
        }

        private List<string> FillAddressOpt(string RealtyType)
        {
            //Конкатенация адресов
            List<string> houseAddresses = new List<string>();
            string GetAddressQuery = "execute GetAddresses " + "\'" + RealtyType + "\'";
            DB.SearchValuesQuery(GetAddressQuery);

            for (int i = 0; i < DB.ds.Tables[0].Rows.Count; i++)
            {
                string ConcatinatedAddress = DB.ds.Tables[0].Rows[i][0].ToString() + "," +
                    DB.ds.Tables[0].Rows[i][1].ToString() + "," + DB.ds.Tables[0].Rows[i][2].ToString() + "," +
                    DB.ds.Tables[0].Rows[i][3].ToString();
                houseAddresses.Add(ConcatinatedAddress);
            }

            return houseAddresses;

        }

        private List<string> FillRieltorsOpt()
        {
            List<string> rieltors = new List<string>();
            string GetRieltors = "select * from GetRieltorsData";
            DB.SearchValuesQuery(GetRieltors);

            for (int i = 0; i < DB.ds.Tables[0].Rows.Count; i++)
            {
                string ConcatinatedRieltors = DB.ds.Tables[0].Rows[i][0].ToString() + " " +
                   DB.ds.Tables[0].Rows[i][1].ToString() + " " + DB.ds.Tables[0].Rows[i][2].ToString();
                rieltors.Add(ConcatinatedRieltors);
            }

            return rieltors;
        }

        private void BuyRealty_Load(object sender, EventArgs e)
        {
            SortOptions.SelectedItem = "Городу";
            OrderOptions.SelectedItem = "Возрастанию";
            ArptSortByOpt.SelectedItem = "Городу";
            ArptOrderByOptions.SelectedItem = "Возрастанию";
            AreasSortOptions.SelectedItem = "Городу";


            try
            {
                //Сортировка по умолчанию
                string SortHousesBy = CheckSortParameter(SortOptions.SelectedItem.ToString());
                string OrderHousesBy = DB.GetOrderBy(OrderOptions.SelectedItem.ToString());
                string GetHousesData = "select * from GetRealtyData where OfferType = 'Дома' order by " + "\'" + SortHousesBy + "\'" + " " + OrderHousesBy;
                HousesData.DataSource = DB.SearchValuesQuery(GetHousesData);

                string SortAprtBy = CheckSortParameter(ArptSortByOpt.SelectedItem.ToString());
                string OrderAprtBy = DB.GetOrderBy(ArptOrderByOptions.SelectedItem.ToString());
                string GetAprtData = "select * from GetRealtyData where OfferType = 'Квартиры' order by " + "\'" + SortAprtBy + "\'" + " " + OrderAprtBy;
                ApartamentsData.DataSource = DB.SearchValuesQuery(GetAprtData);

                List<string> HousesList = FillAddressOpt("Дома");
                List<string> AprtList = FillAddressOpt("Квартиры");
                List<string> AreasList = FillAddressOpt("Земли");

                foreach (string hAdr in HousesList)
                {
                    AdrOpt.Items.Add(hAdr);
                }

                List<string> RieltorsList = FillRieltorsOpt();

                foreach (string HRieltors in RieltorsList)
                {
                    HousesRieltorOpt.Items.Add(HRieltors);
                    AprtRieltorOptions.Items.Add(HRieltors);
                    AreasRieltorOptions.Items.Add(HRieltors);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ShowSortedButton_Click(object sender, EventArgs e)
        {
            string SortHousesBy = CheckSortParameter(SortOptions.SelectedItem.ToString());
            string OrderHousesBy = DB.GetOrderBy(OrderOptions.SelectedItem.ToString());
            string GetHousesData = "select * from GetRealtyData where OfferType = 'Дома' order by " + "\'" + SortHousesBy + "\'" + " " + OrderHousesBy;
            HousesData.DataSource = DB.SearchValuesQuery(GetHousesData);
        }

        private void ArptShowButton_Click(object sender, EventArgs e)
        {
            string SortAprtBy = CheckSortParameter(ArptSortByOpt.SelectedItem.ToString());
            string OrderAprtBy = DB.GetOrderBy(ArptOrderByOptions.SelectedItem.ToString());
            string GetAprtData = "select * from GetRealtyData where OfferType = 'Квартиры' order by " + "\'" + SortAprtBy + "\'" + " " + OrderAprtBy;
            ApartamentsData.DataSource = DB.SearchValuesQuery(GetAprtData);
        }

        private void CreateNewNeeds(string SelectedOffer, string SelectedRieltor)
        {
            
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}
