using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Phidgets;
using Phidgets.Events;
using System.Windows.Forms;
using Microsoft.AspNet.SignalR.Client;
using RepoWL;
using WeatherLogger.Properties;

namespace WeatherLogger
{
    public partial class WeatherLogger : Form
    {

        public int Serialnumber { get; set; }
        private InterfaceKit ifKit;
        private int vindTick;
        private int rainTick;

        public WeatherLogger()
        {
            InitializeComponent();

            Serialnumber = 79995;
            vindTick = 0;
            rainTick = 0;


        }



        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                GroupBox1.Text = "Weather station: " + Serialnumber;

                ifKit = new InterfaceKit();

                //Hook the basica event handlers
                ifKit.Attach += new AttachEventHandler(ifKit_Attach);
                ifKit.Detach += new DetachEventHandler(ifKit_Detach);
                ifKit.Error += new ErrorEventHandler(ifKit_Error);

                //Hook the phidget spcific event handlers
                ifKit.InputChange += new InputChangeEventHandler(ifKit_InputChange);
                //ifKit.OutputChange += new OutputChangeEventHandler(ifKit_OutputChange);
                ifKit.SensorChange += new SensorChangeEventHandler(ifKit_SensorChange);
                ifKit.open(Serialnumber);

                //PictureBox1.Image = Resources.EngineHeedOn;

                UpdateCard();
            }
            catch (Exception ex)
            {

                PictureBox1.Image = Resources.EngineHeedOFF;
                MessageBox.Show(ex.Message);
                //Errors err = new Errors();
                //err.Card = Serialnumber;
                //err.Date = DateTime.Now.ToString();
                //err.From = System.Environment.MachineName;
                //err.Message = ex.Message;
                //err.Method = "Form1_Load";

                //objErr.AddErrors(err);
            }
        }






        #region Events
        void ifKit_Attach(object sender, AttachEventArgs e)
        {
            //lblMsg.Text = "SN: " + ifKit.SerialNumber.ToString();
            PictureBox1.Image = Resources.EngineHeedOn;
        }

        void ifKit_Error(object sender, ErrorEventArgs e)
        {
            //MessageBox.Show(e.Description);
            //Errors err = new Errors();
            //err.Card = Serialnumber;
            //err.Date = DateTime.Now.ToString();
            //err.From = System.Environment.MachineName;
            //err.Message = e.Description;
            //err.Method = "ifKit_Error";
            //objErr.AddErrors(err);


        }

        void ifKit_InputChange(object sender, InputChangeEventArgs e)
        {
            if (e.Index == 1)
            {
                vindTick = vindTick + 1;
            }

            if (e.Index == 2)
            {
                rainTick = rainTick + 1;
            }

            //try
            //{
            //    _888IfKitRep obj = new _888IfKitRep();
            //    obj.SetInput(e.Index, ifKit.inputs[e.Index], Serialnumber);

            //    //MessageBox.Show(ifKit.inputs[e.Index].ToString());
            //}
            //catch (Exception ex)
            //{

            //    //Errors err = new Errors();
            //    //err.Card = Serialnumber;
            //    //err.Date = DateTime.Now.ToString();
            //    //err.From = System.Environment.MachineName;
            //    //err.Message = ex.Message;
            //    //err.Method = "ifKit_InputChange";

            //    //objErr.AddErrors(err);
            //}
        }

        //    void ifKit_OutputChange(object sender, OutputChangeEventArgs e)
        //{
        //    // try
        //    // {   _888IfKitRep obj = new _888IfKitRep();
        //    //     obj.SetOutputs(e.Index, ifKit.outputs[e.Index], Serialnumber);
        //    // }
        //    //catch (Exception ex)
        //    //{

        //    //    Errors err = new Errors();
        //    //    err.Card = Serialnumber;
        //    //    err.Date = DateTime.Now.ToString();
        //    //    err.From = System.Environment.MachineName;
        //    //    err.Message = ex.Message;
        //    //    err.Method = "ifKit_OutputChange";

        //    //objErr.AddErrors(err);
        //    //}
        //}



        void ifKit_SensorChange(object sender, SensorChangeEventArgs e)
        {


            SensorerFac sf = new SensorerFac();
            sf.SetSensor(e.Index, ifKit.sensors[e.Index].Value, Serialnumber);

           
            try
            {

            }
            catch (Exception ex)
            {

                //Errors err = new Errors();
                //err.Card = Serialnumber;
                //err.Date = DateTime.Now.ToString();
                //err.From = System.Environment.MachineName;
                //err.Message = ex.Message;
                //err.Method = "ifKit_SensorChange";

                //objErr.AddErrors(err);
            }
        }


        #endregion

        public DateTime ConvertDate(DateTime datDato)
        {


            string strTime = datDato.ToLongTimeString();
            int day = datDato.Day;
            int month = datDato.Month;
            int year = datDato.Year;

            return DateTime.Parse(month + "-" + day + "-" + year + " " + strTime);
        }



        void UpdateCard()
        {
            //try
            //{
            //    _888IfKitRep objIfKit = new _888IfKitRep();
            //    BookingRep objFac = new BookingRep();

            //    DateTime datDB;
            //    DateTime datNow;

            //    datDB = DateTime.Parse(objFac.Get(Bookingnumber).Dato);

            //    datNow = DateTime.Now;


            //    if (datDB > datNow)
            //    {

            //    }
            //    else
            //    {
            //        for (int i = 0; i < 3; i++)
            //        {
            //           objIfKit.SetOutputs(i, false, Serialnumber); 
            //        }
            //    }

            //    //Update Output
            //    for (int j = 0; j < 7; j++)
            //    {
            //        ifKit.outputs[j] = objIfKit.GetIOutput(j, Serialnumber);
            //    }

            //}
            //catch (Exception ex)
            //{
            //   // MessageBox.Show(ex.Message);
            //    //Errors err = new Errors();
            //    //err.Card = Serialnumber;
            //    //err.Date = DateTime.Now.ToString();
            //    //err.From = System.Environment.MachineName;
            //    //err.Message = ex.Message;
            //    //err.Method = "UpdateCard";

            //    //objErr.AddErrors(err);
            //}
        }


        void ifKit_Detach(object sender, DetachEventArgs e)
        {

            PictureBox1.Image = Resources.EngineHeedOFF;
        }


        #region Interface
        private void Timer1_Tick_1(object sender, EventArgs e)
        {
            UpdateCard();
           
        }




        private void inputTrk_Scroll(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < ifKit.sensors.Count - 1; i++)
                {
                    ifKit.sensors[i].Sensitivity = inputTrk.Value;
                }
                sensitivityTxt.Text = inputTrk.Value.ToString();
            }
            catch (Exception ex)
            {


            }
        }

        private void ratioChk_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                ifKit.ratiometric = ratioChk.Checked;
            }
            catch (Exception ex)
            {

            }
        }
        #endregion

        #region Timers

        private void VindTimer_Tick(object sender, EventArgs e)
        {

            SensorerFac sf = new SensorerFac();
            sf.SetSensor(5, vindTick, Serialnumber);
            vindTick = 0;
        }

        private void RainTimer_Tick(object sender, EventArgs e)
        {
            SensorerFac sf = new SensorerFac();
            sf.SetSensor(6, rainTick, Serialnumber);
            rainTick = 0;
        }
        #endregion

        private void UpdateClients()
        {
            IHubProxy _hub;
            string url = @"http://www.duser.net/";
            var connection = new HubConnection(url);
            _hub = connection.CreateHubProxy("WeatherHub");
            connection.Start().Wait();
            _hub.Invoke("GetData").Wait();
            connection.Dispose();
        }

        private void Updater_Tick(object sender, EventArgs e)
        {
            UpdateClients();
        }
    }

   
}
