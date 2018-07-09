using Breeze.Classes;
using Breeze.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using RadioAppAPI;
using System.Threading.Tasks;

namespace Breeze
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string login = "", token = "";
        bool isPlaying = false;

        public MainWindow()
        {
            InitializeComponent();
            login = Properties.Settings.Default.UserLogin;
            token = Properties.Settings.Default.UserToken;
        }

        
        private async void Window_Loaded(object sender, RoutedEventArgs e)
        {
            await RadioAPI.LoadUserStations(login, token, UserStationsList);
            string version = await RadioAPI.GetNewVersion();
            if (version == "1")
            {
                
            }
            else
            {
                MessageBox.Show("Вышла новая версия. Желательно обновиться. Это сообщение будет показываться каждый раз при запуске до тех пор пока вы не обновите программу. Обновить можно зайдя по адресу avinstudio.ru.");
            }
            ProfileImage.ImageSource = new BitmapImage(new Uri("http://avinstudios.mcdir.ru/files/" + Properties.Settings.Default.UserImage, UriKind.RelativeOrAbsolute));
        }

        private void UserStationsList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                UserCurrentStation.Text = (UserStationsList.SelectedItem as StationParse).UserStationName.ToString();
            }
            catch { UserCurrentStation.Text = ""; }
            
            MainMediaPlayer.Source = new Uri((UserStationsList.SelectedItem as StationParse).Ip.ToString(), UriKind.RelativeOrAbsolute);
            MainMediaPlayer.Play();
            PlayPauseButton.IsChecked = true;
            isPlaying = true;
        }

        private async void RemoveStationButton_Click(object sender, RoutedEventArgs e)
        {
            Button cmd = (Button)sender;
            if (cmd.DataContext is StationParse)
            {
                StationParse deleteme = (StationParse)cmd.DataContext;
                await RadioAPI.UserRemoveStation(login, token, deleteme.Ip.ToString());
                await RadioAPI.LoadUserStations(login, token, UserStationsList);
            }
        }

        private void PlayPauseButton_Click(object sender, RoutedEventArgs e)
        {
            if (isPlaying)
            {
                isPlaying = false;
                MainMediaPlayer.Pause();
            }
            else if (!isPlaying)
            {
                isPlaying = true;
                MainMediaPlayer.Play();
            }
        }

        private async void FindStationsTypes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            await RadioAPI.UserFindStationByCategory(FindStationsTypes.SelectedIndex.ToString(), FindStationsNames);
        }

        private async void AddStationButton_Click(object sender, RoutedEventArgs e)
        {
            Button cmd = (Button)sender;
            if (cmd.DataContext is FindStationByCategory)
            {
                FindStationByCategory addme = (FindStationByCategory)cmd.DataContext;
                await RadioAPI.UserAddNewStation(login, token, addme.Ip.ToString());
                await RadioAPI.LoadUserStations(login, token, UserStationsList);
            }
        }

        private void ProfileContainer_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            ProfileWindow pw = new ProfileWindow();
            pw.ShowDialog();
        }
    }
}
