using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealtyAgency
{
    /// <summary>
    /// Класс для работы с базой данных
    /// </summary>
    class DB
    {
        private static string ConnStr = @"Data Source=localhost; Initial Catalog = RealtyAgency; Integrated Security=true";
        public static DataSet ds;
        public static string AuthorizedUser;

        private static SqlDataAdapter sqlad;
        private static SqlCommand comnd;

        /// <summary>
        /// Метод устанвливающий какой именно пользователь авторизовался
        /// </summary>
        /// <param name="UserLogin">Логин пользователя</param>
        public static void SetAuthorizedUser(string UserLogin)
        {
            AuthorizedUser = UserLogin;
        }

        /// <summary>
        /// Метод генерирующий секретный ключ используемый при регистрации или добавлении пользователей
        /// </summary>
        /// <param name="length">Длина генерируемой строки</param>
        /// <returns></returns>
        public static string GenerateSecretKey(int length)
        {
            string alphabet = "QWERTYUIOPASDFGHJKLZXCVBNMqwertyuiopasdfghjklzxcvbnm0123456789";
            int position;
            Random rnd = new Random();
            StringBuilder sb = new StringBuilder(length - 1);

            for (int i = 0; i < length; i++)
            {
                position = rnd.Next(0, alphabet.Length - 1);
                sb.Append(alphabet[position]);
            }

            return sb.ToString();
        }

        /// <summary>
        /// Метод получающий порядок сортировки
        /// </summary>
        /// <param name="orderby">Порядок сортировки</param>
        /// <returns></returns>
        public static string GetOrderBy(string orderBy)
        {
            switch (orderBy)
            {
                case "Убыванию":
                    orderBy = "desc";
                    break;
                case "Возрастанию":
                    orderBy = "asc";
                    break;
            }

            return orderBy;
        }

        public static object GetAuthorizedUserID()
        {
            string Query = "select UserID from Users where UserLogin = " + "\'" + AuthorizedUser + "\'";
            return SearchValuesQuery(Query);
        }

        public static string GetClientIDByAuthedUser()
        {
            string GetClientID = "execute GetClientIDByAuthedUser " + "\'" + AuthorizedUser + "\'";
            DB.SearchValuesQuery(GetClientID);
            string ClientID = ds.Tables[0].Rows[0][0].ToString();

            return ClientID;
        }

        /// <summary>
        /// Метод выполняющий запрос к базе данных
        /// </summary>
        /// <param name="QueryString">Строка запроса к БД</param>
        public static void Execute(string QueryString)
        {
            using (SqlConnection sqlconn = new SqlConnection(ConnStr))
            {
                sqlconn.Open();
                sqlad = new SqlDataAdapter(QueryString, ConnStr);
                ds = new DataSet();
                comnd = new SqlCommand(QueryString, sqlconn);
                comnd.ExecuteNonQuery();
                sqlconn.Close();
            }
        }

        /// <summary>
        /// Модифицированный метод выполнения запроса к БД, возвращающий результат в виде таблицы
        /// </summary>
        /// <param name="QueryString">Строка запроса к БД</param>
        /// <returns>Результат выполнения запроса</returns>
        public static object SearchValuesQuery(string QueryString)
        {
            Execute(QueryString);
            sqlad.Fill(ds);
            return ds.Tables[0];
        }

    }
}
