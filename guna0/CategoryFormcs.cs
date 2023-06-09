﻿using System;
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
    public partial class CategoryFormcs : Form
    {
        public CategoryFormcs()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\Documents\s_market.db.mdf;Integrated Security=True;Connect Timeout=30");

        private void gunaButton5_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                string query = "insert into CategoryTable values(" + CatIdTb.Text + ", '"+CatNameTb.Text+"', '" + CatDesTb.Text + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Category added successfully!");
                Con.Close();
                populate();
                CatDesTb.Text = "";
                CatNameTb.Text = "";
                CatIdTb.Text = "";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void populate()
        {
            Con.Open();
            string query = "select * from CategoryTable";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            CatDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void CategoryFormcs_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void CatDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CatIdTb.Text = CatDGV.SelectedRows[0].Cells[0].Value.ToString();
            CatNameTb.Text = CatDGV.SelectedRows[0].Cells[1].Value.ToString();
            CatDesTb.Text = CatDGV.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void gunaButton6_Click(object sender, EventArgs e)
        {
            try
            {
                if(CatIdTb.Text == "")
                {
                    MessageBox.Show("Select The Product to Delete");
                }
                else
                {
                    Con.Open();
                    string query = "delete from CategoryTable where CatId = " + CatIdTb.Text + "";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category Deleted");
                    Con.Close();
                    populate();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void gunaButton4_Click(object sender, EventArgs e)
        {
            try
            {
                if(CatIdTb.Text == "" || CatNameTb.Text == "" || CatDesTb.Text == "")
                {
                    MessageBox.Show("Missing information.");
                }
                else
                {
                Con.Open();
                string query = "update CategoryTable set CatName ='" + CatNameTb.Text + "', CatDes = '" + CatDesTb.Text + "' where CatId = " + CatIdTb.Text + "";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Category successfully updated.");
                Con.Close();
                 populate();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            ProductsForm products = new ProductsForm();
            products.Show();
            this.Hide();
        }
    }
}
