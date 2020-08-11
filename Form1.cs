using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YelpPlatform1._1 {
    public partial class Form1 : Form {
        public SqlConnection SqlCon = new SqlConnection(ConfigurationManager.ConnectionStrings["YelpDB"].ToString());
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            //SqlCon.ConnectionString = ConfigurationManager.ConnectionStrings["YelpBD"].ToString();
            SqlCon.Open();
        }

        private DataTable RunStoredProcedure(string procedureName, Dictionary<string, object> parameters) {
            DataTable table = new DataTable();
            SqlCommand cmd = new SqlCommand(procedureName, SqlCon);
            foreach (var p in parameters) cmd.Parameters.AddWithValue(p.Key, p.Value);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(table);
            return table;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e) {
            SqlCon.Dispose();
        }

        private void button1_Click(object sender, EventArgs e) {
            Dictionary<string, object> p = new Dictionary<string, object>();
            //TODO: reinsert textbox to the form
            //p.Add("@city", textBox1.Text);
            DataTable businesses = RunStoredProcedure("BusinessesByCity", p);
            dataGridView1.DataSource = businesses;
        }
    }
}
