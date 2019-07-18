using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Client
{
    public partial class Index : System.Web.UI.Page
    {
        static string sConnectionString = "Persist Security Info=true; Integrated Security=TRUE; database=FishingDB; server=(local); ";
        SqlConnection connection = new SqlConnection(sConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!IsPostBack)
            {
                ZoneDrp.Items.Clear();
                ZoneDrp.Items.Add("--select zone--");

                speciesDrp.Items.Clear();
                speciesDrp.Items.Add("--select species--");
                

                catchCalendar.SelectedDate = DateTime.Today;
               
            }
            SqlCommand scCommand1 = new SqlCommand("SELECT FISH_ID, FISH_NAME FROM FISHING_SPECIES", connection);
            connection.Open();
            SqlDataReader reader1 = scCommand1.ExecuteReader();
            while (reader1.Read())
            {
                speciesDrp.Items.Add(new ListItem { Text = reader1[1].ToString(), Value = reader1[0].ToString() });
            }
            speciesDrp.DataValueField = "Value";
            speciesDrp.DataTextField = "Text";
            reader1.Close();
            connection.Close();
        }

        protected void OnCBox_CheckedChanged(object sender, EventArgs e)
        {
            provinceImg1.ImageUrl = null;
            provinceImg2.ImageUrl = null;
            ZoneDrp.Items.Clear();
            ZoneDrp.Items.Add("--select zone--");
            string province = null;
            if (OnCBox.Checked == true)
            {

                province = "1";
                provinceImg1.ImageUrl = "~/1.jpg";
                
            }
            if (QcCBox.Checked == true)
            {
                province = "2";
                provinceImg1.ImageUrl = "~/2.jpg";
            }
            if (OnCBox.Checked == true && QcCBox.Checked == true)
            {
                province = "1' or FISHING_ZONE.TICKET_ID = '2";
                provinceImg1.ImageUrl = "~/1.jpg"; provinceImg2.ImageUrl = "~/2.jpg";

            }
            SqlCommand scCommand = new SqlCommand("SELECT FISHING_ZONE.ZONE_ID, FISHING_ZONE.ZONE_NUMBER, TICKET.PROVINCE FROM FISHING_ZONE INNER JOIN TICKET ON FISHING_ZONE.TICKET_ID = TICKET.TICKET_ID where FISHING_ZONE.TICKET_ID = '" + province + "'", connection);
            connection.Open();
            SqlDataReader reader = scCommand.ExecuteReader();
            while (reader.Read())
            {
                ZoneDrp.Items.Add(new ListItem { Text = reader[2] + "--" +reader[1].ToString(), Value = reader[0].ToString() });
            }
            ZoneDrp.DataValueField = "Value";
            ZoneDrp.DataTextField = "Text";
            reader.Close();
            connection.Close();

        }

        protected void Inquerybtn_Click(object sender, EventArgs e)
        {
            specieswarning.Text = null; zonewarning.Text = null; provincewarning.Text = null; Label5.Text = null; Label6.Text = null; ResultLabel.Text = null;
              DateTime catchDate = catchCalendar.SelectedDate;
            if (speciesDrp.SelectedIndex == 0 )
            {
                specieswarning.Text = "Please select a fish";
            }
            if (ZoneDrp.SelectedIndex == 0)
            {
                zonewarning.Text = "Please select a zone";
            }
            if (QcCBox.Checked == false && OnCBox.Checked == false)
            {
                provincewarning.Text = "You need a vaild fishing ticket";
            }
            if (!(speciesDrp.SelectedIndex == 0) && !(ZoneDrp.SelectedIndex == 0))
            {
                string zoneID = ZoneDrp.SelectedValue;
                string fishID = speciesDrp.SelectedValue;
                connection.Open();
                //varify the legal date: 
                DateTime mindate = DateTime.MaxValue;
                DateTime maxdate = DateTime.MinValue;
                SqlCommand scCommand1 = new SqlCommand("SELECT LEGAL_DATE_MIN, LEGAL_DATE_MAX FROM FISHING_DATE where ZONE_ID = " + zoneID + "and FISH_ID = " + fishID + "", connection);
                SqlDataReader reader1 = scCommand1.ExecuteReader();
                while (reader1.Read())
                {
                    mindate = (DateTime)reader1[0];
                    maxdate = (DateTime)reader1[1];
                    
                }
                reader1.Close();
                
                if (catchCalendar.SelectedDate >= mindate && catchCalendar.SelectedDate <= maxdate)
                {
                    //if it is a valid date:
                    SqlCommand scCommand2 = new SqlCommand("SELECT NUMBER_LIMIT, LENGTH_LIMIT FROM ASSESSMENT where ZONE_ID = " + zoneID + "and FISH_ID = " + fishID + "", connection);
                    SqlDataReader reader2 = scCommand2.ExecuteReader();
                    while (reader2.Read())
                    {
                        Label5.Text = reader2[0].ToString();
                        Label6.Text = reader2[1].ToString();
                    }
                    reader2.Close();
                }
                else
                {
                    ResultLabel.Text = "It is ilegal to catch this fish on this day!";
                }
                
                connection.Close();
            }
        }

        protected void speciesDrp_SelectedIndexChanged(object sender, EventArgs e)
        {
            //fishImg.ImageUrl = "~/" + "Bass" + ".jpg";
            
            fishImg.ImageUrl = "~/" + speciesDrp.SelectedItem.Text.Replace(" ", "") + ".jpg";  
        }
    }
}