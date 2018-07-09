using Breeze.Classes;
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
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Breeze.Views
{
    /// <summary>
    /// Логика взаимодействия для LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        BackgroundWorker loginUser;
        string login = "", password = "", eventString = "";
        bool trySuccess = false;
        DispatcherTimer timer = new DispatcherTimer();
        public LoginWindow()
        {
            InitializeComponent();
            loginUser = new BackgroundWorker();
            loginUser.DoWork+=loginUser_DoWork;
            loginUser.RunWorkerCompleted += loginUser_RunWorkerCompleted;
            timer.Interval = new TimeSpan(0,0,6);
            if(Properties.Settings.Default.UserLogin != "null")
            {
                LoginTextbox.Text = Properties.Settings.Default.UserLogin;
                Login.IsEnabled = false;
                Cancel.IsEnabled = false;
                Registration.IsEnabled = false;
                ProgressBarMain.Visibility = System.Windows.Visibility.Visible;
                login = Properties.Settings.Default.UserLogin;
                password = Properties.Settings.Default.UserPassword;
                timer.Start();
                timer.Tick += timer_Tick;
            }
        }

        void timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();
            loginUser.RunWorkerAsync();
        }

        void loginUser_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (trySuccess) 
            {
                if(eventString == "password_incorrect")
                {
                    MainError.Text = "Пароль не верный!";
                    Login.IsEnabled = true;
                    Cancel.IsEnabled = true;
                    Registration.IsEnabled = true;
                    ProgressBarMain.Visibility = System.Windows.Visibility.Hidden;
                    MainError.Visibility = System.Windows.Visibility.Visible;
                }
                else if (eventString == "login_error2")
                {
                    MainError.Text = "Нет такого пользователя!";
                    Login.IsEnabled = true;
                    Cancel.IsEnabled = true;
                    Registration.IsEnabled = true;
                    ProgressBarMain.Visibility = System.Windows.Visibility.Hidden;
                    MainError.Visibility = System.Windows.Visibility.Visible;
                }
                else 
                {
                    string words = eventString;
                    string[] split = words.Split(new Char[] {','});
                    Properties.Settings.Default.UserLogin = split[0];
                    Properties.Settings.Default.UserName = split[1];
                    Properties.Settings.Default.UserSurname = split[2];
                    Properties.Settings.Default.UserImage = split[3];
                    Properties.Settings.Default.UserToken = split[4];
                    Properties.Settings.Default.UserPassword = password;
                    Properties.Settings.Default.Save();
                    MessageBox.Show(GetUtf8(split[1]));
                    MainWindow mw = new MainWindow();
                    mw.Show();
                    mw.UserNameSurname.Text = split[1] + " " + split[2];
                    mw.UserCurrentStation.Text = "";

                    this.Close();
                }
            }
        }

        private void loginUser_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                ProgressBarMain.Dispatcher.BeginInvoke(new Action(delegate()
                {
                    ProgressBarMain.Visibility = System.Windows.Visibility.Visible;
                }));
                WebRequest addNewUser = WebRequest.Create("http://avinstudios.mcdir.ru/login.php?login=" + login + "&password=" + password);
                WebResponse response = addNewUser.GetResponse();
                Stream stream = response.GetResponseStream();
                StreamReader sr = new StreamReader(stream);
                eventString = sr.ReadToEnd();
                trySuccess = true;
            }
            catch
            {
                MainError.Dispatcher.BeginInvoke(new Action(delegate()
                {
                    MainError.Visibility = System.Windows.Visibility.Visible;
                    MainError.Text = "Произошла ошибка!";
                }));
                ProgressBarMain.Dispatcher.BeginInvoke(new Action(delegate()
                {
                    ProgressBarMain.Visibility = System.Windows.Visibility.Hidden;
                }));
                Cancel.Dispatcher.BeginInvoke(new Action(delegate()
                {
                    Cancel.IsEnabled = true;
                }));
                Registration.Dispatcher.BeginInvoke(new Action(delegate()
                {
                    Registration.IsEnabled = true;
                }));
                Login.Dispatcher.BeginInvoke(new Action(delegate()
                {
                    Login.IsEnabled = true;
                }));

                trySuccess = false;
            }
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            MainError.Visibility = System.Windows.Visibility.Hidden;
            login = LoginTextbox.Text;
            password = PasswordTextbox.Password;
            if(CheckForValidity(login) || CheckForValidity(password))
            {
                if (CheckForValidity(login)) { Error1.Visibility = Visibility.Visible; } else { Error1.Visibility = Visibility.Hidden; }
                if (CheckForValidity(password)) { Error2.Visibility = Visibility.Visible; } else { Error2.Visibility = Visibility.Hidden; }
            }
            else
            {
                Login.IsEnabled = false;
                Cancel.IsEnabled = false;
                Registration.IsEnabled = false;
                Error1.Visibility = Visibility.Hidden;
                Error2.Visibility = Visibility.Hidden;
                MainError.Visibility = Visibility.Hidden;
                loginUser.RunWorkerAsync();
            }
        }

        private void Registration_Click(object sender, RoutedEventArgs e)
        {
            RegisterWindow regWin = new RegisterWindow();
            regWin.ShowDialog();
        }

        public bool CheckForValidity(string text)
        {
            if (text == "" || text.Contains(" ") || text.Length < 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string GetUtf8(string value)
        {
            UnicodeEncoding unicode = new UnicodeEncoding();
            Byte[] encodedBytes = unicode.GetBytes(value);
            String decodedString = unicode.GetString(encodedBytes);

            return decodedString;
        }
    }
}
