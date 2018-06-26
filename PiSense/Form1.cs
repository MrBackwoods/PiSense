using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Web.Script.Serialization;
using System.Threading;
using System.IO;
using System.Diagnostics;

namespace PiSense
{
    public partial class PiS : Form
    {
        public PiS()
        {
            InitializeComponent();
        }

        // Variables to store sensor and webcam data
        public SensorData data;
        public Image image;

        // Raspberry PI's API's user credentials
        public string username = "Test";
        public string password = "Pass";

        // Starts updating data to form at form load
        private void Form1_Load(object sender, EventArgs e)
        {
            GetPiData();
        }

        // Gets new data from Raspberry Pi every 10 seconds
        void GetPiData()
        {
            try
            {
                var client = new WebClient();
                client.Encoding = Encoding.UTF8;
                JavaScriptSerializer serializer = new JavaScriptSerializer();
                string credentials = Convert.ToBase64String(Encoding.ASCII.GetBytes(username + ":" + password));
                client.Headers[HttpRequestHeader.Authorization] = "Basic " + credentials;

                var timer = new System.Threading.Timer((e) =>
                {
                    Stream imgStream = client.OpenRead("http://10.0.0.2:8001/webcam");
                    string sensorJson = client.DownloadString("http://10.0.0.2:8001/hometemp");
                    data = serializer.Deserialize<SensorData>(sensorJson);
                    image = Image.FromStream(imgStream);

                    if (InvokeRequired)
                    {
                        Invoke(new MethodInvoker(SetFormData));
                    }
                    else
                    {
                        SetFormData();
                    }

                }, null, TimeSpan.Zero, TimeSpan.FromSeconds(30));
            }
            catch (Exception e)
            {
                EventLog.WriteEntry("PiSense", e.Message + "Trace" + e.StackTrace, EventLogEntryType.Error, 121, short.MaxValue);
                Application.Exit();
            }
        }

        // Updates form with new data
        void SetFormData()
        {
            TemperatureBox.Text = "Temparature: " + data.Temperature.ToString();
            HumidityBox.Text =  "Humidity: " + data.Humidity.ToString();
            PictureBox.Image = image;
        }

        // Helper class to contain temperature and humidity
        public class SensorData
        {
            public string Temperature
            {
                get; set;
            }

            public string Humidity
            {
                get; set;
            }
        }
    }
}
