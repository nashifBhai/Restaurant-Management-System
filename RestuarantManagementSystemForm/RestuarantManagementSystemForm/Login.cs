using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestuarantManagementSystemClass;
using RestuarantManagementSystemRepo;

namespace RestuarantManagementSystemForm
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Account user = new Account();
            user.AccountId = this.textBox1.Text;
            user.Password = this.textBox2.Text;

            AccountRepository aRepo = new AccountRepository();
            
            if (aRepo.UserLoginVerification(user) == "Manager")
            {
                Manager h = new Manager();
                h.Show();
                this.Hide();
            }
            else if (aRepo.UserLoginVerification(user) == "Customer")
            {
                Customer h = new Customer(this.textBox1.Text);
                h.Show();
                this.Hide();
            }

            else if (aRepo.UserLoginVerification(user) == "Cashier")
            {
                Cashier h1 = new Cashier();
                h1.Show();
                this.Hide();
            }

            else if (aRepo.UserLoginVerification(user) == "Cook")
            {
                Cook h1 = new Cook();
                h1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid ID or Password", "Login Failed");
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void DOrder_Click(object sender, EventArgs e)
        {
            Account user = new Account();
            user.AccountId = "000";
            user.Password = "000";

            AccountRepository aRepo = new AccountRepository();

            if (aRepo.UserLoginVerification(user) == "Customer")
            {
                Customer h = new Customer(this.textBox1.Text);
                h.Show();
                this.Hide();
            }


        }

        private void CloseApplication(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            MessageBox.Show("0173232544522");
        }
    }
}
