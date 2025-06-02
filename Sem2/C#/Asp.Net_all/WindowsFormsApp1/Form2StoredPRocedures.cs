using System;
using System.CodeDom.Compiler;
using System.Data.Linq;
using System.Windows.Forms;
using Mysqlx.Prepare;

namespace WindowsFormsApp1
{
    public partial class Form2StoredPRocedures : Form
    {
        LINQdataDataContext db;
        public Form2StoredPRocedures()
        {
            InitializeComponent();
        }

        private void Form2StoredPRocedures_Load(object sender, EventArgs e)
        {
            db = new LINQdataDataContext();
            ISingleResult<ProdocumentResult> obj = db.Prodocument | ();
            dataGridView1.DataSource = obj;
        }
    }
}
//CREATE PROCEDURE Prodocument
//AS
//SELECT id, pname from product;

//execute Prodocument;