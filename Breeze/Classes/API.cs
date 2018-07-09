using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using Breeze.Classes;

namespace RadioAppAPI
{
    public class RadioAPI
    {
        public static async Task LoadUserStations(string login, string token, ListBox listBox)
        {
            try
            {
                listBox.Items.Clear();
                WebRequest loadUserStation = WebRequest.Create("http://avinstudios.mcdir.ru/load_stations.php?login=" + login + "&token=" + token);
                WebResponse response = await loadUserStation.GetResponseAsync();
                Stream stream = response.GetResponseStream();
                StreamReader sr = new StreamReader(stream);
                string words = sr.ReadToEnd();
                string[] split = words.Split(new Char[] { ',' });
                for (int i = 0; i < split.Length; i += 1)
                {
                    if (((i % 10) & 1) == 1) { }
                    else
                    {
                        string ip = split[i];
                        string name = split[i + 1];
                        listBox.Items.Add(new StationParse(ip, name));
                    }
                }
            }
            catch { }
        }

        public static async Task UserAddNewStation(string login, string token, string newstation_ip)
        {
            try
            {
                WebRequest addNewStation = WebRequest.Create("http://avinstudios.mcdir.ru/add_station.php?login=" + login + "&token=" + token + "&ip=" + newstation_ip);
                await addNewStation.GetResponseAsync();
            }
            catch { }
        }

        public static async Task UserFindStationByCategory(string category, ListBox FindStationsNames)
        {
            try
            {
                FindStationsNames.Items.Clear();
                WebRequest findStationCategory = WebRequest.Create("http://avinstudios.mcdir.ru/load_stations_category.php?category=" + category);
                WebResponse response = await findStationCategory.GetResponseAsync();
                Stream stream = response.GetResponseStream();
                StreamReader sr = new StreamReader(stream);
                string words = sr.ReadToEnd();
                string[] split = words.Split(new Char[] { ',' });
                for (int i = 0; i < split.Length; i += 2)
                {
                    string ip = split[i];
                    string name = split[i + 1];
                    FindStationsNames.Items.Add(new FindStationByCategory(ip, name));
                }
            }
            catch { }
        }

        public static async Task UserRemoveStation(string login, string token, string station_ip)
        {
            try
            {
                WebRequest addNewUser = WebRequest.Create("http://avinstudios.mcdir.ru/remove_station.php?login=" + login + "&token=" + token + "&ip=" + station_ip);
                await addNewUser.GetResponseAsync();
            }
            catch
            {

            }
        }

        public static async Task UserUploadImage(string login)
        {
            try
            {
                WebClient client = new WebClient();
                client.Headers.Add("Content-Type", "binary/octet-stream");
                client.UploadFileAsync(new Uri("http://avinstudios.mcdir.ru/upload.php?login=" + login, UriKind.RelativeOrAbsolute), "POST", @"image.jpg");

                //byte[] result = Client.UploadFile("http://localhost/radio/upload.php", "POST", @"C:\autobuy.txt");
            }
            catch
            {

            }
        }

        public static async Task<int> UserRegister(string login, string pass, string name, string surname, string image)
        {
            int i = 0;
            try
            {
                WebRequest addNewUser = WebRequest.Create("http://avinstudios.mcdir.ru/register.php?login=" + login + "&password=" + pass + "&name=" + name + "&surname=" + surname + "&image=" + image);
                WebResponse response = await addNewUser.GetResponseAsync();
                Stream stream = response.GetResponseStream();
                StreamReader sr = new StreamReader(stream);
                string eventString = sr.ReadToEnd();
                if (eventString == "success_user_add")
                {
                    i = 1;
                }
                else if (eventString == "error_add_user")
                {
                    i = 2;
                }
                else if (eventString == "error_user_exist")
                {
                    i = 3;
                }
            }
            catch 
            {
                i = 0;
            }

            return i;
        }

        public static async Task<int> UserLogin(string login, string pass)
        {
            int i = 0;
            try
            {
                WebRequest userLogin = WebRequest.Create("http://avinstudios.mcdir.ru/login.php?login=" + login + "&password=" + pass);
                WebResponse response = await userLogin.GetResponseAsync();
                Stream stream = response.GetResponseStream();
                StreamReader sr = new StreamReader(stream);
                string eventString = sr.ReadToEnd();

                if (eventString == "password_incorrect")
                {
                    i = 1;
                }
                else if (eventString == "login_error2")
                {
                    i = 2;
                }
                else
                {
                    i = 3;
                }
            }
            catch
            {
                i = 0;
            }

            return i;
        }

        public static async Task<string> GetNewVersion()
        {
            string eventString = "1";
            try
            {
                WebRequest getVersion = WebRequest.Create("http://avinstudios.mcdir.ru/get_version.php");
                WebResponse response = await getVersion.GetResponseAsync();
                Stream stream = response.GetResponseStream();
                StreamReader sr = new StreamReader(stream);
                eventString = sr.ReadToEnd();
            }
            catch { eventString = "1"; }

            return eventString;
        }
    }
}
