using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherApp
{
    public partial class Form : System.Windows.Forms.Form
    {
        RESTManager manager = new RESTManager();
        public Form()
        {
            InitializeComponent();
        }

        private void Search_Button_Click(object sender, EventArgs e)
        {
            RootObject root = manager.GetWeatherInfo(City_TextBox.Text);
            City_Label.Text = root.name + ", " + root.sys.country;
            Temperature_Label.Text = root.main.temp + " \u00B0" + "C";
            Pressure_Label.Text = root.main.pressure.ToString();
            Cloudiness_Label.Text = root.clouds.all + " %";
            CurrentWeather_PictureBox.Image = manager.GetImage(root.weather[0].icon);
        }
    }
}
