using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        LINQdataDataContext db;
        public Form1()
        {
            InitializeComponent();
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {
            LINQdataDataContext db = new LINQdataDataContext();
            //1
            //dataGridView1.DataSource = db.products;

            //2
            Table<product> pro_tbl = db.products;
            dataGridView1.DataSource = pro_tbl;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            db = new LINQdataDataContext();
            product pro = new product();
            pro.Id = int.Parse(textBox1.Text);
            pro.pname = textBox2.Text;
            pro.category = textBox3.Text;

            db.products.InsertOnSubmit(pro);
            db.SubmitChanges();
            MessageBox.Show("data done", "suucess", MessageBoxButtons.OK,MessageBoxIcon.Information);

        }
    }
}
