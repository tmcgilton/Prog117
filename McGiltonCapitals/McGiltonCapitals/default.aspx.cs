using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace McGiltonCapitals
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection conn;
            SqlCommand comm;
            SqlDataReader reader;
            string connectionString = ConfigurationManager.ConnectionStrings["CapitalCS"].ConnectionString;
            conn = new SqlConnection(connectionString);
            comm = new SqlCommand("SELECT CountryID, Country, Capital FROM CapitalsTable", conn);

            conn.Open();
            reader = comm.ExecuteReader();
            countryRepeater.DataSource = reader;
            countryRepeater.DataBind();
            reader.Close();
            conn.Close();
        }

        protected void ButtonDelete_Click(object sender, EventArgs e)
        {
            SqlConnection conn;
            SqlCommand comm;
            string connectionString = ConfigurationManager.ConnectionStrings["CapitalCS"].ConnectionString;
            conn = new SqlConnection(connectionString);
            comm = new SqlCommand("DELETE FROM CapitalsTable WHERE CountryID = @CountryID", conn);
            comm.Parameters.Add("@CountryID", System.Data.SqlDbType.Int);
            comm.Parameters["@CountryID"].Value = TextBoxCountry.Text;

            conn.Open();
            comm.ExecuteNonQuery();
            conn.Close();
            Response.Redirect("default.aspx");

        }
    }
}