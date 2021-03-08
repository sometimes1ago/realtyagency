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
                case "Стоимости":
                    Parameter = "Price";
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
            string GetRieltors = "select * from GetRieltorsData where Status = 'Не занят'";
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
            AreasOrderOptions.SelectedItem = "Возрастанию";

            try
            {
                //Сортировка домов по умолчанию
                string SortHousesBy = CheckSortParameter(SortOptions.SelectedItem.ToString());
                string OrderHousesBy = DB.GetOrderBy(OrderOptions.SelectedItem.ToString());
                string GetHousesData = "select * from GetRealtyData where OfferType = 'Дома' order by " + "\'" + SortHousesBy + "\'" + " " + OrderHousesBy;
                HousesData.DataSource = DB.SearchValuesQuery(GetHousesData);

                //Сортировка квартир по умолчанию
                string SortAprtBy = CheckSortParameter(ArptSortByOpt.SelectedItem.ToString());
                string OrderAprtBy = DB.GetOrderBy(ArptOrderByOptions.SelectedItem.ToString());
                string GetAprtData = "select * from GetRealtyData where OfferType = 'Квартиры' order by " + "\'" + SortAprtBy + "\'" + " " + OrderAprtBy;
                ApartamentsData.DataSource = DB.SearchValuesQuery(GetAprtData);

                //Сортировка квартир по умолчанию
                string SortAreasBy = CheckSortParameter(AreasSortOptions.SelectedItem.ToString());
                string OrderAreasBy = DB.GetOrderBy(AreasOrderOptions.SelectedItem.ToString());
                string GetAreasData = "select * from GetRealtyData where OfferType = 'Земля' order by " + "\'" + SortAreasBy + "\'" + " " + OrderAreasBy;
                AreasData.DataSource = DB.SearchValuesQuery(GetAreasData);

                //Заполнение комбобоксов списками с соответвующим типом недвижимости
                List<string> HousesList = FillAddressOpt("Дома");
                List<string> AprtList = FillAddressOpt("Квартиры");
                List<string> AreasList = FillAddressOpt("Земля");

                foreach (string hAdr in HousesList)
                {
                    AdrOpt.Items.Add(hAdr);
                }

                foreach (string aptAdr in AprtList)
                {
                    AprtOptions.Items.Add(aptAdr);
                }

                foreach (string areasAdr in AreasList)
                {
                    AreasOptions.Items.Add(areasAdr);
                }

                //Получение списка риелторов и последующее заполнение комбобоксов везде, где есть список риелторов
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

        private string GetRealtyIDBySplitter(string SplitableString, char Splitter)
        {
            string SelectedRealty = SplitableString;
            string[] SplStrArr = SelectedRealty.Split(Splitter);

            string GetRealtyID = "select OfferID from RealtyOffers where City = " + "\'" + SplStrArr[0] + "\'" +
                " and Street = " + "\'" + SplStrArr[1] + "\'" + " and House = " + "\'" + SplStrArr[2] + "\'" + " and Number = " + "\'" + SplStrArr[3] + "\'";
            DB.SearchValuesQuery(GetRealtyID);
            string RealtyID = DB.ds.Tables[0].Rows[0][0].ToString();

            return RealtyID;
        }

        private string GetRieltorIDBySplitter(string SplitableString, char Splitter)
        {
            string SelectedRieltor = SplitableString;
            string[] SplStrArr = SelectedRieltor.Split(Splitter);

            string GetRieltorID = "select RieltorID from Rieltors where FirstName = " + "\'" + SplStrArr[0] + "\'" +
                " and MiddleName = " + "\'" + SplStrArr[1] + "\'" + " and LastName = " + "\'" + SplStrArr[2] + "\'";
            DB.SearchValuesQuery(GetRieltorID);
            string RieltorID = DB.ds.Tables[0].Rows[0][0].ToString();

            return RieltorID;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Добавление новой потребности клиента
                string CreateNewNeeds = "insert into ClientsWishes(Offer, Client, Rieltor) values(" +
                    "\'" + DB.GetRealtyIDBySplitter(AdrOpt.SelectedItem.ToString(), ',') + "\'" + "," +
                    "\'" + DB.GetClientIDByAuthedUser() + "\'" + "," + "\'" + GetRieltorIDBySplitter(HousesRieltorOpt.SelectedItem.ToString(), ' ') + "\'" + ")";
                DB.Execute(CreateNewNeeds);

                MessageBox.Show("Заявка на покупку дома успешно создана и появится в личном кабинете!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AreasShowButton_Click(object sender, EventArgs e)
        {
            string SortAreasBy = CheckSortParameter(AreasSortOptions.SelectedItem.ToString());
            string OrderAreasBy = DB.GetOrderBy(AreasOrderOptions.SelectedItem.ToString());
            string GetAreasData = "select * from GetRealtyData where OfferType = 'Земля' order by " + "\'" + SortAreasBy + "\'" + " " + OrderAreasBy;
            AreasData.DataSource = DB.SearchValuesQuery(GetAreasData);
        }

        private void AreasBuyButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Добавление новой потребности клиента
                string CreateNewNeeds = "insert into ClientsWishes(Offer, Client, Rieltor) values(" +
                    "\'" + GetRealtyIDBySplitter(AreasOptions.SelectedItem.ToString(), ',') + "\'" + "," +
                    "\'" + DB.GetClientIDByAuthedUser() + "\'" + "," + "\'" + GetRieltorIDBySplitter(AreasRieltorOptions.SelectedItem.ToString(), ' ') + "\'" + ")";
                DB.Execute(CreateNewNeeds);

                MessageBox.Show("Заявка на покупку земли успешно создана и появится в личном кабинете!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BuyAprtButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Добавление новой потребности клиента
                string CreateNewNeeds = "insert into ClientsWishes(Offer, Client, Rieltor) values(" +
                    "\'" + GetRealtyIDBySplitter(AprtOptions.SelectedItem.ToString(), ',') + "\'" + "," +
                    "\'" + DB.GetClientIDByAuthedUser() + "\'" + "," + "\'" + GetRieltorIDBySplitter(AprtRieltorOptions.SelectedItem.ToString(), ' ') + "\'" + ")";
                DB.Execute(CreateNewNeeds);

                MessageBox.Show("Заявка на покупку земли успешно создана и появится в личном кабинете!");
            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
