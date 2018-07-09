using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Breeze.Views
{
    /// <summary>
    /// Логика взаимодействия для ProfileWindow.xaml
    /// </summary>
    public partial class ProfileWindow : Window
    {
        public ProfileWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ProfileImage.ImageSource = new BitmapImage(new Uri("http://localhost/radio/files/" + Properties.Settings.Default.UserImage, UriKind.RelativeOrAbsolute));

            LoginTextBlock.Text = Properties.Settings.Default.UserLogin;
            NameTextBlock.Text = Properties.Settings.Default.UserName;
            SurnameTextBlock.Text = Properties.Settings.Default.UserSurname;
            
        }

        private void UserLogOutButton_Click(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.UserLogin = "null";
            Properties.Settings.Default.UserPassword = "null";
            Properties.Settings.Default.UserName = "null";
            Properties.Settings.Default.UserSurname = "null";
            Properties.Settings.Default.UserToken = "null";
            Properties.Settings.Default.UserImage = "null";
            Properties.Settings.Default.Save();
            System.Windows.Forms.Application.Restart();
            Application.Current.Shutdown();
        }
    }
}
