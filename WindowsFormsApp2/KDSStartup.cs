using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;
using MetroFramework;
using System.Configuration;
using System.IO;
using System.Data.SqlClient;
using System.Threading;

namespace MCKDS
{
    public partial class KDSStartup : MetroFramework.Forms.MetroForm
    {

        private FryingStation fmFryingStation;
        private CustomerStationCtl fmCustomerStation;
        private OrderGridForm fmPreparingStation;
        private OrderGridForm fmExpediteStation;
        string FryingStation;
        String PreparingStation;
        string ExpediteStation;
        string CustomerStation;
        Thread t = new Thread(StartForm);

        public KDSStartup()
        {
            InitializeComponent();
        }
        public static void StartForm()
        {
            Application.Run(new SplashScreen());
        }

        private void KDSStartup_Load(object sender, EventArgs e)
        {
           
            t.Start();
            InitializeTiles();
            t.Abort();
            
            //this.Activate();
            //GetStations();
        }


        private void GetStations()
        {
            try
            {
                timer1.Enabled = false;
                lblError.Visible = false;
                FryingStation = ConfigurationManager.AppSettings["Frying"];
                PreparingStation = ConfigurationManager.AppSettings["Preparing"];
                ExpediteStation = ConfigurationManager.AppSettings["Expedite"];
                CustomerStation = ConfigurationManager.AppSettings["Customer"];

                if (FryingStation == null)
                { tlFryingStation.Visible = false; }
                if (PreparingStation == null)
                { tlPreparingStation.Visible = false; }
                if (ExpediteStation == null)
                { tlExpediteStation.Visible = false; }
                if (CustomerStation == null)
                { tlCustomerStation.Visible = false; }

                tlExpediteStation.Enabled = false;
                tlCustomerStation.Enabled = false;

                dbClass dbcls = new dbClass();
                string values = dbcls.GetConfiguration(3);

                char[] spearator = { ',' };

                String[] stationslist = values.Split(spearator);

                foreach (string station in stationslist)
                {
                    if (station == "2")
                    {
                        tlExpediteStation.Enabled = true;
                    }
                    else if (station == "3")
                    {
                        tlCustomerStation.Enabled = true;
                    }
                }

                string filepath = @"Settings.txt";
                if (File.Exists(filepath))
                {
                    string[] lines = File.ReadAllLines(filepath);
                    string line = lines[1].Substring(2, lines[1].Length - 2);

                    if (line == "Frying Station")
                    {
                        tlFryingStation_Click(tlFryingStation, EventArgs.Empty);
                    }
                    else if (line == "Preparing Station")
                    {
                        tlPreparingStation_Click(tlPreparingStation, new EventArgs());
                    }
                    else if (line == "Expedite Station")
                    {
                         tlExpediteStation_Click(tlExpediteStation, new EventArgs());
                    }
                    else if (line == "Customer Station")
                    {
                        tlCustomerStation_Click(tlCustomerStation, EventArgs.Empty);
                    }
                }
            }
            catch (Exception ex)
            {
                if (ex.Message == "Object reference not set to an instance of an object.")
                {
                    t.Abort();
                    SqlConnection cnn = new SqlConnection();

                    dbClass dbcls = new dbClass();
                    cnn = dbcls.Sql_Connection();
                    var server = cnn.DataSource;

                    if (server == "")
                    {
                        Connection f2 = new Connection();
                        f2.ShowDialog();
                        KDSStartup_Load(this, EventArgs.Empty);
                    }
                    else
                    {
                        lblError.Text = "Unable To Connect KDS Server.";
                        lblError.Visible = true;
                    }
                }
            }
        }
        public void InitializeTiles()
        {

            tlCustomerStation.UseCustomBackColor = true;
            tlCustomerStation.BackColor = Color.FromArgb(163, 8, 12);
            tlExpediteStation.UseCustomBackColor = true;
            tlExpediteStation.BackColor = Color.FromArgb(163, 8, 12);
            tlFryingStation.UseCustomBackColor = true;
            tlFryingStation.BackColor = Color.FromArgb(163, 8, 12);
            tlPreparingStation.UseCustomBackColor = true;
            tlPreparingStation.BackColor = Color.FromArgb(163, 8, 12);
            tlMasterDataSync.UseCustomBackColor = true;
            tlMasterDataSync.BackColor = Color.FromArgb(163, 8, 12);
            tlSettings.UseCustomBackColor = true;
            tlSettings.BackColor = Color.FromArgb(163, 8, 12); ;


            tlCustomerStation.TileTextFontSize = MetroTileTextSize.Medium;
            tlCustomerStation.TileTextFontWeight = MetroTileTextWeight.Bold;
            tlExpediteStation.TileTextFontSize = MetroTileTextSize.Medium;
            tlExpediteStation.TileTextFontWeight = MetroTileTextWeight.Bold;
            tlFryingStation.TileTextFontSize = MetroTileTextSize.Medium;
            tlFryingStation.TileTextFontWeight = MetroTileTextWeight.Bold;
            tlPreparingStation.TileTextFontSize = MetroTileTextSize.Medium;
            tlPreparingStation.TileTextFontWeight = MetroTileTextWeight.Bold;
            tlMasterDataSync.TileTextFontSize = MetroTileTextSize.Medium;
            tlMasterDataSync.TileTextFontWeight = MetroTileTextWeight.Bold;
            tlSettings.TileTextFontSize = MetroTileTextSize.Medium;
            tlSettings.TileTextFontWeight = MetroTileTextWeight.Bold;

        }

        private void tlFryingStation_Click(object sender, EventArgs e)
        {

            if ((fmFryingStation == null) || (fmFryingStation.IsDisposed == true))
            {
                fmFryingStation = new FryingStation();
                fmFryingStation.WindowState = FormWindowState.Maximized;
                fmFryingStation.ShowDialog();
              
                //fmFryingStation.Focus();
            }

            else
            {
                fmFryingStation.WindowState = FormWindowState.Maximized;
                fmFryingStation.Focus();
            }

        }

        private void tlCustomerStation_Click(object sender, EventArgs e)
        {

            if ((fmCustomerStation == null) || (fmCustomerStation.IsDisposed == true))
            {
                fmCustomerStation = new CustomerStationCtl();
                
                fmCustomerStation.WindowState = FormWindowState.Maximized;
                fmCustomerStation.ShowDialog();
                //fmCustomerStation.Focus();

            }

            else
            {
                fmCustomerStation.WindowState = FormWindowState.Maximized;
                fmCustomerStation.Focus();
            }

        }

        private void tlPreparingStation_Click(object sender, EventArgs e)
        {

            if ((fmPreparingStation == null) || (fmPreparingStation.IsDisposed == true))
            {
                fmPreparingStation = new OrderGridForm("Middle of House (MOH)"); // Preparing Station
               fmPreparingStation.WindowState = FormWindowState.Maximized;
                fmPreparingStation.ShowDialog();
                //fmPreparingStation.Focus();
                
            }

            else
            {
                fmPreparingStation.WindowState = FormWindowState.Maximized;
                fmPreparingStation.Focus();
            }

        }

        private void tlExpediteStation_Click(object sender, EventArgs e)
        {
            CallExpidite();


        }
        private void CallExpidite()
        {
            if ((fmExpediteStation == null) || (fmExpediteStation.IsDisposed == true))
            {
                fmExpediteStation = new OrderGridForm("Front of House (FOH)"); // Expedite Station
                fmExpediteStation.WindowState = FormWindowState.Maximized;
                fmExpediteStation.ShowDialog();

                //fmExpediteStation.Focus();//
                //fmExpediteStation.TopMost = true;

            }

            else
            {
                fmExpediteStation.WindowState = FormWindowState.Maximized;
                fmExpediteStation.Focus();
            }
        }
        //public void OpenDefaultSetStation(String StationName, Form defaultStationForm)
        //{
        //    if ((defaultStationForm == null) || (defaultStationForm.IsDisposed == true))
        //    {
        //        defaultStationForm = new OrderGridForm(StationName);
        //        defaultStationForm.Show();
        //        defaultStationForm.WindowState = FormWindowState.Maximized;
        //        defaultStationForm.Focus();

        //    }

        //    else
        //    {
        //        defaultStationForm.WindowState = FormWindowState.Maximized;
        //        defaultStationForm.Focus();
        //    }
        //}

        private void tlMasterDataSync_Click(object sender, EventArgs e)
        {
            dbClass dbcls = new dbClass();
            if (dbcls.SetMasterSyncOn())
                MessageBox.Show("Master Data Sync Started");
            else
                MessageBox.Show("Unable to Master Data Sync Started");

        }

        private void settings_Click(object sender, EventArgs e)
        {
            KDSSystemSettings form = new KDSSystemSettings();
            form.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            GetStations();
            //lblError.Visible = false;
        }

    }
}
