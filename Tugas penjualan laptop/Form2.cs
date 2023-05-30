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

namespace Tugas_penjualan_laptop
{
    public partial class frmweather : Form
    {
        public frmweather()
        {
            InitializeComponent();
        }

        private void Formweather_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        string APIKEY = "db1643100422f35f13dc28dc0d440a24";

        private void btnsearch_Click(object sender, EventArgs e)
        {
            getWeather();
        }
        private void getWeather()
        {
            using (WebClient web = new WebClient())
            {
                string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&units=metric&appid={1}", txtboxkota.Text, APIKEY);
                var json = web.DownloadString(url);
                WeatherInfo.root Info = JsonConvert.DeserializeObject<WeatherInfo.root>(json);
                picticon.ImageLocation = "https://openweathermap.org/img/w/" + Info.weather[0].icon + ".png";
                lblkondisi.Text = Info.weather[0].main;
                lbldetail.Text = Info.weather[0].description;
                lblsunset.Text = convertDateTime(Info.sys.sunset).ToString();
                lblsunrise.Text = convertDateTime(Info.sys.sunrise).ToString();
                lblwindspeed.Text = Info.wind.speed.ToString();
                lblpressure.Text = Info.main.pressure.ToString();
                lbltemp.Text = Info.main.temp.ToString();

            }
        }
        DateTime convertDateTime(long millisec)
        {
            DateTime day = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            day = day.AddSeconds(millisec).ToLocalTime();
            return day;
        }
    }
}
