using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project13_WeatherAppApi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static decimal FahrenheitToCelcius(decimal fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }

        private async void Form1_Load(object sender, EventArgs e)
        {

            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://open-weather13.p.rapidapi.com/city/istanbul/EN"),
                Headers =
    {
        { "x-rapidapi-key", "c8f319f3abmshefcbcef1c1e1e7bp10e3afjsn3b0fda048e2e" },
        { "x-rapidapi-host", "open-weather13.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                var json = JObject.Parse(body);
                var fahrenheit = json["main"]["feels_like"].ToString();
                var windSpeed = json["wind"]["speed"].ToString();
                var humidity = json["main"]["humidity"].ToString();
                var weatherCondition = json["weather"][0]["main"].ToString();
                decimal celcius = FahrenheitToCelcius(decimal.Parse(fahrenheit));
                lblWind.Text = windSpeed;
                lblHumidty.Text = humidity;
                lblFahrenheit.Text = fahrenheit;
                lblDerece.Text = celcius.ToString("0.00");

                SetWeatherIcon(weatherCondition);
            }
        }

        private void SetWeatherIcon(string weatherCondition)
        {
            switch (weatherCondition.ToLower())
            {
                case "clear":
                    pictureBox1.Image = Properties.Resources.sun; // Güneşli
                    break;
                case "clouds":
                    pictureBox1.Image = Properties.Resources.cloudy; // Bulutlu
                    break;
                case "rain":
                    pictureBox1.Image = Properties.Resources.rain; // Yağmurlu
                    break;
                case "snow":
                    pictureBox1.Image = Properties.Resources.snow; // Karlı
                    break;
                case "thunderstorm":
                    pictureBox1.Image = Properties.Resources.rain; // Fırtına
                    break;
                case "drizzle":
                    pictureBox1.Image = Properties.Resources.rain; // Çisenti
                    break;
                case "mist":
                case "fog":
                    pictureBox1.Image = Properties.Resources.cloudy; // Sisli
                    break;
                default:
                    pictureBox1.Image = Properties.Resources.sun; // Varsayılan ikon
                    break;
            }
        }
    }
}
