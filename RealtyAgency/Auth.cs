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
    public partial class Auth : Form
    {
        public Auth()
        {
            InitializeComponent();
        }

        private bool IsCorrect = false;

        private void AuthButton_Click(object sender, EventArgs e)
        {
            string GetAuthData = "select * from GetAuthData";

            try
            {
                DB.SearchValuesQuery(GetAuthData);

                for (int i = 0; i < DB.ds.Tables[0].Rows.Count; i++)
                {
                    if (LoginInput.Text == DB.ds.Tables[0].Rows[i][0].ToString() && PasswordInput.Text == DB.ds.Tables[0].Rows[i][1].ToString())
                    {
                        string UserRole = DB.ds.Tables[0].Rows[i][2].ToString();
                        IsCorrect = true;
                        DB.SetAuthorizedUser(DB.ds.Tables[0].Rows[i][0].ToString());


                        switch (UserRole)
                        {
                            case "Клиент":
                                User user = new User();
                                Hide();
                                user.Show();
                                break;
                            case "Риелтор":
                                Rieltor rl = new Rieltor();
                                Hide();
                                rl.Show();
                                break;
                        }
                    }
                }
                if (!IsCorrect)
                {
                    throw new Exception("Неправильный логин или пароль!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Auth_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Метод показывающий и скрывающий пароль в зависимости от чекбокса Показать пароль
        /// </summary>
        private void ShowPass()
        {
            if (ShowPassword.Checked)
            {
                PasswordInput.UseSystemPasswordChar = false;
            }
            else
            {
                PasswordInput.UseSystemPasswordChar = true;
            }
        }


        private void ShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            ShowPass();
        }

        private void DataRecoverLink_Click(object sender, EventArgs e)
        {
            DataRecover dr = new DataRecover();
            dr.Show();
        }

        private void RegisterLink_Click(object sender, EventArgs e)
        {
            Registration reg = new Registration(this);
            Hide();
            reg.Show();
        }
    }
}
