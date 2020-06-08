
using RestuarantManagementSystemRepo;
using RestuarantManagementSystemClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Windows.Forms;




namespace RestuarantManagementSystemForm
{
    public partial class Manager : Form
    {

        //String ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\Projects\Restuara\RestuarantManagementSystem002 - Copy\RestuarantManagementSystemForm\RestuarantManagementSystemRepo\RMSDB.mdf;Integrated Security=True";
        public Manager()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void loadAccountBtn_Click(object sender, EventArgs e)
        {
            AccountRepository accRepo = new AccountRepository();
            List<Account> accList = accRepo.GetAllAccounts();
            this.accountGridView.DataSource = accList;
        }

        private void insertAccountBtn_Click(object sender, EventArgs e)
        {

            Account aa= new Account();
            aa.AccountId = this.textBox1.Text;  
            aa.Password =this.textBox3.Text;
            aa.Name = this.textBox2.Text;
            aa.AccountType = this.comboBox1.Text;

            AccountRepository re = new AccountRepository();

            if (re.Insert(aa))
            {
                // List<Account> accList = accRepo.GetAllAccounts();
                // this.accountGridView.DataSource = accList
                MessageBox.Show("Insert  Complete");

            }
            else
            {
                MessageBox.Show("Insert Not Complete", "Error");
            }
        }

        private void deleteAccountBtn_Click(object sender, EventArgs e)
        {
            Account aa = new Account();
            aa.AccountId = this.textBox1.Text;
            aa.Password = this.textBox3.Text;
            aa.Name = this.textBox2.Text;
            aa.AccountType = this.comboBox1.Text;

            AccountRepository re = new AccountRepository();

            if (re.Delete(aa.AccountId))
            {
                // List<Account> accList = accRepo.GetAllAccounts();
                // this.accountGridView.DataSource = accList
                MessageBox.Show("Delete  Complete");

            }

            else
           {
               MessageBox.Show("Delete Not Complete", "Error");
              }

        }

        private void updateAccountBtn_Click(object sender, EventArgs e)
        {
            Account aa = new Account();
            aa.AccountId = this.textBox1.Text;
            aa.Password = this.textBox3.Text;
            aa.Name = this.textBox2.Text;
            aa.AccountType = this.comboBox1.Text;
            AccountRepository re = new AccountRepository();


            if (re.Update(aa))
            {
                // List<Account> accList = accRepo.GetAllAccounts();
                // this.accountGridView.DataSource = accList
                MessageBox.Show("Update  Complete");

            }

            else
            {
                MessageBox.Show("Update Not Complete", "Error");
            }

        }
       

        private void button3_Click(object sender, EventArgs e)
        {
            string text = this.textBox5.Text;
           AccountRepository accRepo = new AccountRepository();
           List<Account> accList = accRepo.SearchAccounts(text);
            this.accountGridView.DataSource = accList;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           // this.panel1.Hide();
           
            FoodRepository f = new FoodRepository();
            this.dataGridView1.DataSource = f.GetAllFoods();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Login f = new Login();
            f.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.panel1.Show();
          
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.panel1.Hide();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            
            
            OrderRepository or = new OrderRepository();
            List<FoodOrder> accList = or.GetAllOrder();
            this.dataGridView2.DataSource = accList;
        }

        private void CloseApplication(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
