using Studio_Audio.Context;
using Studio_Audio.Views.Pages.AdminPage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Studio_Audio.Views.Pages.Home
{
    /// <summary>
    /// Логика взаимодействия для LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void buttonChacel_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void buttonLogin_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var currentUser = ConnectContext.db.SignIn.FirstOrDefault(Item => Item.Username == txbUsername.Text &&
                Item.Password == psbPassword.Password);
                if (currentUser == null)
                    MessageBox.Show("Вы ввели неверные данные авторизации! Пожалуйста, повторите попытку...", "Не верно", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                else
                {
                    switch (currentUser.IDRole)
                    {
                        case "A":
                            MessageBox.Show("Привет Администратор" +  "   " + currentUser.Username);
                            NavigationService.Navigate(new AdminViewData() );
                            break;
                        case "U":
                            MessageBox.Show("Привет пользователь" +  "   " +  currentUser.Username);
                            break;
                            
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source + "Выдал исключение", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
