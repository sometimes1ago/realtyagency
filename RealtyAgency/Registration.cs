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
    public partial class Registration : Form
    {
        private Form FormToBack;
        public Registration(Auth auth)
        {
            InitializeComponent();
            FormToBack = auth;
        }

        private void ClearAllFields()
        {
            SurnameInput.Text = "";
            NameInput.Text = "";
            LastNameInput.Text = "";
            EmailInput.Text = "";
            PhoneInput.Text = "";
            LoginInput.Text = "";
            PasswordInput.Text = "";
            PassConfirmInput.Text = "";
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (SurnameInput.Text != "" && NameInput.Text != "" && LastNameInput.Text != "" && EmailInput.Text != ""
                    && PhoneInput.Text != "" && LoginInput.Text != "" && PasswordInput.Text != "" && PassConfirmInput.Text != "")
                {
                    if (LoginInput.Text.Length > 5 && PasswordInput.Text.Length > 5)
                    {
                        if (PasswordInput.Text == PassConfirmInput.Text)
                        {
                            //Добавляем нового пользователя
                            string SecretKey = DB.GenerateSecretKey(10);
                            string NewUser = "execute CreateNewUser " + "\'" + LoginInput.Text + "\'" + "," + "\'" + PasswordInput.Text + "\'" +
                                "," + "\'" + SecretKey + "\'";
                            DB.Execute(NewUser);

                            //Получаем ID нового пользователя
                            string GetNewUserID = "select * from GetLastUserID";
                            DB.SearchValuesQuery(GetNewUserID);
                            string UserID = DB.ds.Tables[0].Rows[0][0].ToString();

                            //Добавление нового клиента с последующей привзякой его данных для авторизации
                            string CreateNewClient = "execute CreateNewClient " + "\'" + SurnameInput.Text + "\'" + "," + "\'" + NameInput.Text + "\'" +
                                "," + "\'" + LastNameInput.Text + "\'" + "," + "\'" + EmailInput.Text + "\'" + "," + "\'" + PhoneInput.Text + "\'" +
                                "," + "\'" + UserID + "\'";
                            DB.Execute(CreateNewClient);

                            MessageBox.Show($@"Вы успешно зарегистрировались! Ваш секретный ключ - {SecretKey}. Пожалуйста, запишите его!");
                            Hide();
                            ClearAllFields();
                            FormToBack.Show();
                        }
                        else
                        {
                            throw new Exception("Пароли не совпадают!");
                        }
                    }
                    else
                    {
                        throw new Exception("Логин и пароль не могут быть короче 5 символов!");
                    }
                }
                else
                {
                    throw new Exception("Все поля обязательны для заполнения! Проверьте правильность ввода!");
                }
            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BackLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            FormToBack.Show();
        }
    }
}
