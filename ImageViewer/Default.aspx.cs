using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ImageViewer
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String imagepath = WebConfigurationManager.AppSettings["imagefolder"];
            String stationid = Request["stationid"] as String;
            String sensorid = Request["sensorid"] as String;
            String filename = imagepath + "missing.png";
            String title = "Númer mælistöðvar eða skynjara vantar";

            if (!String.IsNullOrEmpty(stationid) && !String.IsNullOrEmpty(sensorid))
            {
                filename = imagepath + "Sensor_" + stationid + "_" + sensorid + ".png";
                title = "Spá byggð á skynjara númer " + sensorid + " fyrir mælistöð númer " + stationid ;
            }
            chart_img.Src = filename;
            Title_Label.Text = title;


        }
    }
}