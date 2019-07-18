using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop
{
    public partial class Form1 : Form
    {
        static string sConnectionString = "Persist Security Info=true; Integrated Security=TRUE; database=FishingDB; server=(local); ";
        SqlConnection connection = new SqlConnection(sConnectionString);
        public Form1()
        {
            InitializeComponent();

        }

        private void ProvinceBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
            FishingZoneBox.Items.Clear();
            FishingZoneBox.Text = "--select zone--";

            //this.tICKETTableAdapter.Fill(this.fishingDBDataSet.TICKET);
            string province = ProvinceBox.SelectedValue.ToString();
            SqlCommand scCommand = new SqlCommand("SELECT ZONE_ID, ZONE_NUMBER FROM FISHING_ZONE where TICKET_ID = " + province + "", connection);
            connection.Open();
            SqlDataReader reader = scCommand.ExecuteReader();
                while (reader.Read())
            {
                FishingZoneBox.Items.Add(new { ZONE_nUMBER = reader[1], ZONE_iD = reader[0] });
            }
            FishingZoneBox.DisplayMember = "ZONE_nUMBER";
            FishingZoneBox.ValueMember = "ZONE_iD";
            reader.Close();
            connection.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fishingDBDataSet2.FISHING_ZONE' table. You can move, or remove it, as needed.
           // this.fISHING_ZONETableAdapter1.Fill(this.fishingDBDataSet2.FISHING_ZONE);
            // TODO: This line of code loads data into the 'fishingDBDataSet1.FISHING_ZONE' table. You can move, or remove it, as needed.
            this.tICKETTableAdapter.Fill(this.fishingDBDataSet.TICKET);
            // TODO: This line of code loads data into the 'fishingDBDataSet.TICKET' table. You can move, or remove it, as needed.
            FishingZoneBox.SelectedIndex = -1;
            FishingZoneBox.SelectedText = "--select zone--";
            ProvinceBox.SelectedIndex = -1;
            ProvinceBox.SelectedText = "--select province--";
            
        }

        private void GeneralInfoSavebtn_Click(object sender, EventArgs e)
        {
            string zoneGeneralInfo = GeneralInfoBox.Text;
            dynamic item1 = FishingZoneBox.SelectedItem;
            int zoneID = item1.ZONE_iD;
            SqlCommand scCommand = new SqlCommand("update FISHING_ZONE set GENERAL_INFORMATION = @fzginfo " + "where ZONE_ID = " + zoneID + "", connection);
            scCommand.Parameters.Add("@fzginfo", SqlDbType.NVarChar).Value = zoneGeneralInfo;
            connection.Open();
            scCommand.ExecuteNonQuery();
            connection.Close();
        }

        private void FishingZoneBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FishBox.Items.Clear();
            FishBox.Text = "--select fish--";
            dynamic item = FishingZoneBox.SelectedItem;
            int zoneID = item.ZONE_iD;
            string zoneNumber = item.ZONE_nUMBER;
            SqlCommand scCommand1 = new SqlCommand("SELECT GENERAL_INFORMATION FROM FISHING_ZONE where ZONE_ID = " + zoneID + "", connection);
            SqlCommand scCommand2 = new SqlCommand("SELECT FISH_ID, FISH_NAME FROM FISHING_SPECIES", connection);
            connection.Open();
            SqlDataReader reader1 = scCommand1.ExecuteReader();
            
            while (reader1.Read())
            {
                GeneralInfoBox.Text = (reader1.GetString(0));
            }
            
            reader1.Close();
            SqlDataReader reader2 = scCommand2.ExecuteReader();
            while (reader2.Read())
            {
                FishBox.Items.Add(new { FISH_nUMBER = reader2[1], FISH_iD = reader2[0] });
            }
            FishBox.DisplayMember = "FISH_nUMBER";
            FishBox.ValueMember = "FISH_iD";
            reader2.Close();
            connection.Close();
           
        }

        private void FishBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            dynamic item1 = FishingZoneBox.SelectedItem;
            int zoneID = item1.ZONE_iD;

            dynamic item2 = FishBox.SelectedItem;
            int fishID = item2.FISH_iD;
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
            ilegalWarningTXT.Text = "";
            numberTXT.Text = "";
            LengthTXT.Text = "";

            connection.Open();
            SqlCommand scCommand1 = new SqlCommand("SELECT LEGAL_DATE_MIN, LEGAL_DATE_MAX FROM FISHING_DATE where ZONE_ID = " + zoneID + "and FISH_ID = " + fishID + "", connection);
            SqlDataReader reader1 = scCommand1.ExecuteReader();
            while (reader1.Read())
            {
                dateTimePicker1.Value = ((DateTime)reader1.GetDateTime(0));
                dateTimePicker2.Value = ((DateTime)reader1.GetDateTime(1));
            }
            reader1.Close();
            if (dateTimePicker2.Value.Subtract(dateTimePicker1.Value).TotalDays==0)
            {
                ilegalWarningTXT.Text = "It is ileagal to fish this fish on this day!";
            }

            SqlCommand scCommand2 = new SqlCommand("SELECT NUMBER_LIMIT, LENGTH_LIMIT FROM ASSESSMENT where ZONE_ID = " + zoneID + "and FISH_ID = " + fishID + "", connection);
            SqlDataReader reader2 = scCommand2.ExecuteReader();
            while (reader2.Read())
            {
                numberTXT.Text = reader2.GetString(0);
                LengthTXT.Text = reader2.GetString(1);
            }
            reader2.Close();
            
            
            connection.Close();
        }

        private void FishInfoSavebtn_Click(object sender, EventArgs e)
        {
            dynamic item1 = FishingZoneBox.SelectedItem;
            int zoneID = item1.ZONE_iD;

            dynamic item2 = FishBox.SelectedItem;
            int fishID = item2.FISH_iD;

            SqlCommand scCommand1 = new SqlCommand("update ASSESSMENT set NUMBER_LIMIT = @nunLimit, LENGTH_LIMIT = @LenLimit where ZONE_ID = "+ zoneID + "and FISH_ID = " +fishID+ "", connection);
            scCommand1.Parameters.Add("@nunLimit", SqlDbType.VarChar).Value = numberTXT.Text;
            scCommand1.Parameters.Add("@LenLimit", SqlDbType.VarChar).Value = LengthTXT.Text;
            connection.Open();
            scCommand1.ExecuteNonQuery();
            try
            {
                if (dateTimePicker2.Value > dateTimePicker1.Value)
                {
                    SqlCommand scCommand2 = new SqlCommand("update FISHING_DATE set LEGAL_DATE_MIN = @dateMin, LEGAL_DATE_MAX = @dateMax where ZONE_ID = " + zoneID + "and FISH_ID = " + fishID + "", connection);
                    scCommand2.Parameters.Add("@dateMin", SqlDbType.DateTime).Value = dateTimePicker1.Value;
                    scCommand2.Parameters.Add("@dateMax", SqlDbType.DateTime).Value = dateTimePicker2.Value;
                    scCommand2.ExecuteNonQuery();
                }
                else
                {
                    MessageBox.Show("The Legal starte date must before the end date!");
                    return;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("The Legal starte date must before the end date!");
            }
            connection.Close();
        }
    }
}
