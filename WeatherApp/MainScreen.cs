using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net;

namespace WeatherApp
{
    public partial class MainScreen : Form
    {
        private string apiKey = "ee563f104d2a69ea60ce5f1d3a30904a";
        string location = "default";
        public MainScreen()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            location = txbLocationData.Text;
            getWeather();
        }

        public void getWeather()
        {
            using (WebClient web = new WebClient())
            {
                string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}", location, apiKey);

                var json = web.DownloadString(url);
                WeatherInfo.root info = JsonConvert.DeserializeObject<WeatherInfo.root>(json);


                lblDetails.Text = info.weather[0].main;
                lblPressure.Text = info.main.pressure.ToString();
                lblSunrise.Text = info.sys.sunrise.ToString();
                lblWind.Text = info.wind.speed.ToString();
                lblSunsetTime.Text = info.sys.sunset.ToString();
            }
        }

        public void getCustomWeather()
        {

            using (WebClient web = new WebClient())
            {
                string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}", location, apiKey);

                var json = web.DownloadString(url);
                WeatherInfo.root info = JsonConvert.DeserializeObject<WeatherInfo.root>(json);


                lblDetails.Text = info.weather[0].main;
                lblPressure.Text = info.main.pressure.ToString();
                lblSunrise.Text = info.sys.sunrise.ToString();
                lblWind.Text = info.wind.speed.ToString();
                lblSunsetTime.Text = info.sys.sunset.ToString();
            }
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {
            InitializeComponent();
        }

        private void txtbLocation_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLondon_Click(object sender, EventArgs e)
        {
            location = "London";
            getCustomWeather();
        }

        private void btnMadrid_Click(object sender, EventArgs e)
        {
            location = "Madrid";
            getCustomWeather();
        }

        private void btnWashington_Click(object sender, EventArgs e)
        {
            location = "Washington";
            getCustomWeather();
        }

        private void btnParis_Click(object sender, EventArgs e)
        {
            location = "Paris";
            getCustomWeather();
        }
    }
}
