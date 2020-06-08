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
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;


namespace RestuarantManagementSystemForm
{
    public partial class Cashier : Form
    {
        float cash=0;
        Double pay = 0, pi = 0,pp =0;
        int p = 0;
        string id, user;

        public Cashier()
        {
            InitializeComponent();
            
        }

        private void Cashier_Load(object sender, EventArgs e)
        {
            
        }

        public void CashLoad(object sender, EventArgs e)
        {

        }
        private void cashbutton_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string s = btn.Text;
            cash = float.Parse(s) + cash;
            textBox1.Text = cash.ToString();
            
            pi = float.Parse((textBox1.Text).ToString());
            if (pay <= pi)
            {
                payB.Enabled = true;
            }
        }

        private void paidbutton_Click(object sender, EventArgs e)
        {
            OrderRepository o = new OrderRepository();
            this.dataGridView1.DataSource = o.GetStatusOrder("Paid");
        }

        private void unpaidbutton_Click(object sender, EventArgs e)
        {
            OrderRepository o = new OrderRepository();
            this.dataGridView1.DataSource = o.GetStatusOrder("Unpaid");
        }

        private void paid_Click(object sender, EventArgs e)
        {
            OrderRepository o = new OrderRepository();
            o.Update("Paid",Convert.ToInt16(this.idtextBox.Text));
            












            Changetext.Text = "";
            totalText.Text = "";
            textBox1.Text = "";
            idtextBox.Text = "";
            payB.Enabled = false;
            pay = 0;
            p = 0;
            pi = 0;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Login f = new Login();
            f.Show();
            this.Hide();
        }

        private void CloseApplication(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            pi = 0;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            OrderRepository o = new OrderRepository();
            FileStream fs = new FileStream("OrderId" + id.ToString() + ".pdf", FileMode.Create, FileAccess.Write, FileShare.None);
            Document doc = new Document();
            PdfWriter writer = PdfWriter.GetInstance(doc, fs);
            doc.Open();
           // Paragraph p = new Paragraph(o.GetPay(Convert.ToInt32( this.idtextBox.Text).TotalPrice.ToString()));
            //p.Alignment = Element.ALIGN_LEFT;
          //  doc.Add(p);
          //  doc.Close();
            MessageBox.Show("PDF of your Registration has been generated.", "Done");
        }

        private void EnterB_Click(object sender, EventArgs e)
        {
            OrderRepository o = new OrderRepository();
             p = (int.Parse(idtextBox.Text));
            pay = o.GetPay(p).TotalPrice;
            totalText.Text = Convert.ToString(this.pay);

            
           

        }

        private void payB_Click(object sender, EventArgs e)
        {
            //pi = float.Parse((textBox1.Text).ToString());
            

            pp = ( pi- pay);
            if(pp<0)
            {
                pp = pp * (-1);  Changetext.Text = Convert.ToString(this.pp);
            }
            else
                {
                Changetext.Text = Convert.ToString(this.pp);
            }

          
        }
    }
}
