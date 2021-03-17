using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorsDB
{
    public partial class Form1 : Form
    {
        string connectionString;
        SqlConnection connection;
        public Form1()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["ColorsDB.Properties.Settings.ColorsConnectionString"].ConnectionString;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PopulateColorsTable();
        }

        private void PopulateColorsTable()
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM PrimaryColor", connection))
            {
                DataTable colorTable = new DataTable();
                adapter.Fill(colorTable);

                listColors.DisplayMember = "PrimaryColorName";
                listColors.ValueMember = "Id";
                listColors.DataSource = colorTable;

            }
        }

        private void listColors_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateShades();
        }

        private void PopulateShades()
        {
            string query = "SELECT Shade.Colorname FROM PrimaryColor INNER JOIN Shade ON Shade.PrimaryColorID = PrimaryColor.Id WHERE PrimaryColor.Id = @ColorId";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.Parameters.AddWithValue("@ColorID", listColors.SelectedValue);
                DataTable shadeTable = new DataTable();
                adapter.Fill(shadeTable);

                listShades.DisplayMember = "ColorName";
                listShades.ValueMember = "Id";
                listShades.DataSource = shadeTable;
            }
        }
    }
}
