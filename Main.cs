using System;
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
    public partial class Main : Form
    {
        Point lastClick;

        public Main()
        {
            InitializeComponent();
        }

        private class SettingsController
        {
            public static string GetAuthToken()
            {
                try
                {
                    return Settings.Default.auth;
                }
                catch
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

        private void Main_Load(object sender, EventArgs e)
        {
            
        }

        private void TopPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastClick.X;
                this.Top += e.Y - lastClick.Y;
            }
        }

        private void TopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastClick = new Point(e.X, e.Y);
        }

        private void CloseApplication_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Logout_click(object sender, EventArgs e)
        {
            var Result = MessageBox.Show("Вы уверены, что хотите выйти из аккаунта?", "Выход", MessageBoxButtons.YesNo);

            if (Result == DialogResult.Yes)
            {
                API.Logout(SettingsController.GetAuthToken());
                SettingsController.SetAuthToken("");
                Application.Exit();
            }
        }
    }
}