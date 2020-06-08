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


namespace RestuarantManagementSystemForm
{
    public partial class Cook : Form
    {
        public Cook()
        {
            InitializeComponent();
        }

        private void loadAccountBtn_Click(object sender, EventArgs e)
        {
            FoodRepository accRepo = new FoodRepository();
            List<Food> accList = accRepo.GetAllFoods();
            this.FoodGridView.DataSource = accList;
        }

        private void insertAccountBtn_Click(object sender, EventArgs e)
        {
            Food aa = new Food();
            aa.FoodId = this.textBox1.Text;
            aa.FoodName = this.textBox2.Text;
            aa.FoodPrice = float.Parse(this.textBox4.Text);
            //aa.D
           

            FoodRepository re = new FoodRepository();

            if (re.Insert(aa))
            {
                // List<Account> accList = accRepo.GetAllAccounts();
                // this.accountGridView.DataSource = accList
                MessageBox.Show("Insert  Complete");
                textBox1.Text = " ";
                textBox2.Text = " ";
                textBox4.Text = " ";
            }
             else
            {
               MessageBox.Show("Insert Not Complete", "Error");
              }
        }

        private void deleteAccountBtn_Click(object sender, EventArgs e)
        {
            Food aa = new Food();
            aa.FoodId = this.textBox1.Text;
            //aa.FoodName = this.textBox2.Text;
           // aa.FoodPrice = Convert.ToDouble(this.textBox4.Text);

            FoodRepository re = new FoodRepository();

            if (re.Delete(aa.FoodId))
            {
                // List<Account> accList = accRepo.GetAllAccounts();
                // this.accountGridView.DataSource = accList
                MessageBox.Show("Delete  Complete");
                textBox1.Text = " ";
                textBox2.Text = " ";
                textBox4.Text = " ";
            }

            else
            {
                MessageBox.Show("Delete Not Complete", "Error");
            }

        }

        private void updateAccountBtn_Click(object sender, EventArgs e)
        {

            Food aa = new Food();
            aa.FoodId = this.textBox1.Text;
            aa.FoodName = this.textBox2.Text;
            aa.FoodPrice = float.Parse(this.textBox4.Text);

            FoodRepository re = new FoodRepository();


            if (re.Update(aa))
            {
                // List<Account> accList = accRepo.GetAllAccounts();
                // this.accountGridView.DataSource = accList
                MessageBox.Show("Update  Complete");
                textBox1.Text = " ";
                textBox2.Text = " ";
                textBox4.Text = " ";
            }

            else
            {
                MessageBox.Show("Update Not Complete", "Error");
            }
        }

        private void Search_Click(object sender, EventArgs e)
        {
            string text = this.textBox5.Text;
            FoodRepository accRepo = new FoodRepository();
            List<Food> accList = accRepo.SearchFood(text);
            this.FoodGridView.DataSource = accList;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login f = new Login();
            f.Show();
            this.Hide();

        }

        private void FoodGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void CloseApplication(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
