using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using API = _102_Essentials.API;

namespace _102_Essentials
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private Form MainForm = new Main();
        private bool LoggingIn = true;

        private void SetProcessLabel(string Text, Color color)
        {
            Process.ForeColor = color;
            Process.Text = Text;
        }

        private void Launch_MainFrame()
        {
            MainForm.Show();
            this.Hide();
        }

        private class SettingsController
        {
            public static string GetAuthToken()
            {
                try
                {
                    return Settings.Default.auth;
                } catch
                {
                    return "";
                }
            }

            public static void SetAuthToken(string authData)
            {
                Settings.Default.auth = authData;
                Settings.Default.Save();
            }
        }

        private async void Login_Load(object sender, EventArgs e)
        {
            string authToken = SettingsController.GetAuthToken();
            PasswordBox.PasswordChar = '*'; // set password box

            if (authToken.Length == 0)
            {
                LoggingIn = false;
                return;
            }

            LoginButton.Text = "Вход..";

            var data = await API.GetAccountDataAsync(authToken);
            var isError = data.username == "APIDOWN" || data.username == "COOKIEFAIL";

            if (isError)
            {
                LoggingIn = false;
                LoginButton.Text = "Войти";
            }

            if (data.username == "APIDOWN")
            {
                SetProcessLabel("Не удалось подключиться к API", Color.Red);
            } else if (data.username == "COOKIEFAIL")
            {
                SetProcessLabel("Токен авторизации истёк", Color.Red);
            } else if (data.username == "BANNED")
            {
                SetProcessLabel("Данный аккаунт был отключён", Color.Red);
            } else
            {
                Launch_MainFrame();
            }
        }

        private async void LoginButton_Click(object sender, EventArgs e)
        {
            if (LoggingIn) return;
            if (LoginBox.TextLength == 0 || PasswordBox.TextLength == 0)
            {
                SetProcessLabel("Некорректно введены поля", Color.Red);
                return;
            }

            LoggingIn = true;
            LoginButton.Text = "Вход..";

            var data = await API.Login(LoginBox.Text, PasswordBox.Text);
            var isError = data.username == "APIDOWN" || data.username == "INCORRECT" || data.username == "N/A";

            if (isError)
            {
                LoggingIn = false;
                LoginButton.Text = "Войти";
                LoginBox.Text = "";
                PasswordBox.Text = "";
            }

            if (data.username == "APIDOWN")
            {
                SetProcessLabel("Не удалось подключиться к API", Color.Red);
            }
            else if (data.username == "INCORRECT")
            {
                SetProcessLabel("Неверные данные", Color.Red);
            }
            else if (data.username == "N/A")
            {
                SetProcessLabel("Аккаунт не существует", Color.Red);
            }
            else
            {
                SetProcessLabel("Успешная авторизация", Color.Green);
                SettingsController.SetAuthToken(data.authorization);

                Launch_MainFrame();
            }
        }

        private void CloseApplication_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
