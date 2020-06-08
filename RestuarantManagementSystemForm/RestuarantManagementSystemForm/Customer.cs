using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestuarantManagementSystemRepo;
using RestuarantManagementSystemClass;
using System.Data.SqlClient;

namespace RestuarantManagementSystemForm
{
    public partial class Customer : Form
    {
        private string id;
        float total = 0;
        public Customer(string AccountId)
        {
            InitializeComponent();
            id = AccountId;

        }

        private void Form4_Load(object sender, EventArgs e)
        {


            listView1.View = View.Details;

            listView1.Columns.Add("Name", 150);
            listView1.Columns.Add("Quantity", 150);
            //  listView1.Columns.Add("price", 150);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FoodRepository accRepo = new FoodRepository();
            List<Food> accList = accRepo.GetAllFoods();
            this.dataGridView1.DataSource = accList;
            SqlConnection cs = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename =C:\Users\ra_sh\OneDrive\C#\Pro\pro v2\RestuarantManagementSystemForm\RestuarantManagementSystemRepo\RMSDB.mdf; Integrated Security = True");
            SqlDataAdapter da = new SqlDataAdapter("SELECT  * FROM FoodTable", cs);

            DataTable dt = new DataTable();
            da.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                comboBox1.Items.Add(dt.Rows[i]["FoodName"]);
            }
        }



        private void button5_Click(object sender, EventArgs e)
        {
            Login f = new Login();
            f.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection cs = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename =C:\Users\ra_sh\OneDrive\C#\Pro\pro v2\RestuarantManagementSystemForm\RestuarantManagementSystemRepo\RMSDB.mdf; Integrated Security = True");
            SqlDataAdapter da = new SqlDataAdapter("SELECT  * FROM FoodTable", cs);

            DataTable dt = new DataTable();
            da.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                comboBox1.Items.Add(dt.Rows[i]["FoodName"]);
            }


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void add(String name, String qu)

        {

            string[] row = { name, qu };

            ListViewItem item = new ListViewItem(row);

            listView1.Items.Add(item);

        }


        private void Entry_Click(object sender, EventArgs e)
        {
            add(comboBox1.SelectedItem.ToString(), qtext.Text);
            FoodRepository f = new FoodRepository();
            total = f.GetFoods(comboBox1.Text).FoodPrice * (float.Parse(qtext.Text)) + total;


        }

        private void qtext_TextChanged(object sender, EventArgs e)
        {
            Entry.Enabled = true;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            totaltextBox.Text = total.ToString();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            total = 0;
            totaltextBox.Text = "";
            listView1.Clear();
            comboBox1.Text = "";
            qtext.Text = "";
            textBox1.Text = "";
            listView1.View = View.Details;

            listView1.Columns.Add("Name", 150);
            listView1.Columns.Add("Quantity", 150);
            //listView1.Columns.Add("price", 150);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            int a = 0;
            Random r = new Random();
            OrderRepository occ = new OrderRepository();
            FoodOrder f = new FoodOrder();
            AccountRepository ar = new AccountRepository();
            f.AccountId = this.id;
            a = f.OrderId = r.Next(10000);
            f.TotalPrice = total;
            f.Status = "Unpaid";
            textBox1.Text = a.ToString();


            if (occ.Insert(f))
            {
                MessageBox.Show("Insert Complete");

                Cashier c = new Cashier();

            }
            else
            {
                MessageBox.Show("Insert Not Complete", "Error");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CloseApplication(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
