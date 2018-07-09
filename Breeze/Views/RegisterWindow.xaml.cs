using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Imaging;
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
using Breeze.Classes;
using RadioAppAPI;

namespace Breeze.Views
{
    /// <summary>
    /// Логика взаимодействия для RegisterWindow.xaml
    /// </summary>
    public partial class RegisterWindow : Window
    {
        string login = "", pass = "", pass_again = "", name = "", surname = "", image = "null.jpg", eventString = "";
        bool fileChosen = false;

        public RegisterWindow()
        {
            InitializeComponent();
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private async void Registration_Click(object sender, RoutedEventArgs e)
        {
            MainError.Visibility = System.Windows.Visibility.Hidden;
            login = LoginTextbox.Text;
            pass = PasswordTextbox.Password;
            pass_again = PasswordTextboxAgain.Password;
            name = NameTextbox.Text;
            surname = SurnameTextbox.Text;

            if (CheckForValidity(login) || CheckForValidity(pass) || CheckForValidity(pass_again) || CheckForValidity(name) || CheckForValidity(surname))
            {
                if (CheckForValidity(login)) { Error1.Visibility = Visibility.Visible; } else { Error1.Visibility = Visibility.Hidden; }
                if (CheckForValidity(pass)) { Error2.Visibility = Visibility.Visible; } else { Error2.Visibility = Visibility.Hidden; }
                if (CheckForValidity(pass_again)) { Error3.Visibility = Visibility.Visible; } else { Error3.Visibility = Visibility.Hidden; }
                if (CheckForValidity(name)) { Error4.Visibility = Visibility.Visible; } else { Error4.Visibility = Visibility.Hidden; }
                if (CheckForValidity(surname)) { Error5.Visibility = Visibility.Visible; } else { Error5.Visibility = Visibility.Hidden; }
            }
            else
            {
                Error1.Visibility = Visibility.Hidden;
                Error2.Visibility = Visibility.Hidden;
                Error3.Visibility = Visibility.Hidden;
                Error4.Visibility = Visibility.Hidden;
                Error5.Visibility = Visibility.Hidden;
                if(pass != pass_again)
                { 
                    MainError.Visibility = System.Windows.Visibility.Visible;
                    MainError.Text = "Пароли не совпадают!";
                    Error2.Visibility = Visibility.Visible;
                    Error3.Visibility = Visibility.Visible;
                }
                else
                {
                    Cancel.IsEnabled = false;
                    Registration.IsEnabled = false;
                    
                    int i = await RadioAPI.UserRegister(login,pass,name,surname,image);
                    if (i == 1)
                    {
                        this.Close();
                    }
                    else if (i == 2)
                    {
                        MainError.Visibility = System.Windows.Visibility.Visible;
                        MainError.Text = "Произошла ошибка!";
                    }
                    else if (i == 3)
                    {
                        MainError.Visibility = System.Windows.Visibility.Visible;
                        MainError.Text = "Пользователь существует!";
                    }
                    else if (i == 0)
                    {
                        MainError.Visibility = System.Windows.Visibility.Visible;
                        MainError.Text = "Произошла ошибка!";
                    }
                    ProgressBarMain.Visibility = System.Windows.Visibility.Hidden;
                    Cancel.IsEnabled = true;
                    Registration.IsEnabled = true;

                    if (fileChosen) 
                    {
                        await RadioAppAPI.RadioAPI.UserUploadImage(login);
                    }
                }
            }
        }

        public bool CheckForValidity(string text)
        {
            if (text.Contains("\\") || text.Contains("(") || text.Contains(")") || text.Contains(",") || text.Contains(".") || text.Contains("[") || text.Contains("]") || text.Contains("[") || text.Contains("]") || text.Contains("/") || text.Contains(" ") || text.Contains("$") || text.Contains("&") || text.Contains("*") || text.Contains("?") || text.Contains("!") || text.Contains("@") || text.Contains("#") || text.Contains(" ") || text == "" || text == "^" || text == ";" || text == ":" || text.Length < 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void ImageChoose_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = false;
            ofd.Filter = "Png files (.png)|*.png|JPG files (.jpg)|*.jpg|JPEG files (.jpeg)|*.jpeg|All files (*.*)|*.*";
            if(ofd.ShowDialog() == true)
            {
                try
                {
                    ProfileImage.ImageSource = new BitmapImage(new Uri(ofd.FileName, UriKind.RelativeOrAbsolute));
                }
                catch { ProfileImage.ImageSource = new BitmapImage(new Uri("profile.png", UriKind.RelativeOrAbsolute));  }
                ImageChooseLabel.Text = ofd.SafeFileName;
                image = ofd.FileName;
                try
                {
                    SaveToFile();
                    fileChosen = true;
                }
                catch { fileChosen = false; }
            }
        }

        public void SaveToFile()
        {
            BitmapSource aa = (BitmapSource)ProfileImage.ImageSource;
            Image myImage2 = new Image();
            myImage2.Source = aa;
            myImage2.Stretch = Stretch.None;
            myImage2.Margin = new Thickness(20);
            using (FileStream stream = new FileStream("image.jpg", FileMode.Create))
            {
                JpegBitmapEncoder encoder = new JpegBitmapEncoder();
                encoder.QualityLevel = 40;
                encoder.Frames.Add(BitmapFrame.Create(aa));
                encoder.Save(stream);
            }
        }
    }
}
