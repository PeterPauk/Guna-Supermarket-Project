using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace guna0
{
    public partial class ProductsForm : Form
    {
        public ProductsForm()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\Documents\s_market.db.mdf;Integrated Security=True;Connect Timeout=30");

        private void fillCombo()
        {
            //The entries from the CategoryTable from the database will show up in this combo button
            Con.Open();
            SqlCommand cmd = new SqlCommand("select CatName from CategoryTable", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("CatName",typeof(string));
            dt.Load(rdr);
            CatBtn.ValueMember = "catName";
            CatBtn.DataSource = dt;
            Con.Close();
        }

        private void populate()
        {
            Con.Open();
            string query = "select * from ProductTable";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ProdDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void ProductsForm_Load(object sender, EventArgs e)
        {
            fillCombo();
            populate();
        }

       

        private void gunaLineTextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Username_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel2_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel3_Click(object sender, EventArgs e)
        {

        }

        private void gunaComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillCombo();
        }

        private void gunaButton7_Click(object sender, EventArgs e)
        {

        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            CategoryFormcs cat = new CategoryFormcs();
            cat.Show();
            this.Hide();
        }

        private void gunaButton5_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                string query = "insert into ProductTable values(" + ProdId.Text + ", '" + ProdName.Text + "', " + ProdQty.Text + ", " + ProdPrice.Text + ", '" + ProdDes.Text + "', '" + CatBtn.SelectedValue.ToString()+"' )"; 
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product added successfully!");
                Con.Close();
                populate();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ProdDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ProdId.Text = ProdDGV.SelectedRows[0].Cells[0].Value.ToString();
            ProdName.Text = ProdDGV.SelectedRows[0].Cells[1].Value.ToString();
            ProdQty.Text = ProdDGV.SelectedRows[0].Cells[2].Value.ToString();
            ProdPrice.Text = ProdDGV.SelectedRows[0].Cells[3].Value.ToString();
            ProdDes.Text = ProdDGV.SelectedRows[0].Cells[4].Value.ToString();
            CatBtn.SelectedValue = ProdDGV.SelectedRows[0].Cells[5].Value.ToString();
            
            
        }
    }
}
