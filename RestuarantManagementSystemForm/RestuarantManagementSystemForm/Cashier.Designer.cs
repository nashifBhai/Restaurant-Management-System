namespace RestuarantManagementSystemForm
{
    partial class Cashier
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.foodTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.foodTableDataSet = new RestuarantManagementSystemForm.FoodTableDataSet();
            this.foodTableTableAdapter = new RestuarantManagementSystemForm.FoodTableDataSetTableAdapters.FoodTableTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.paidB = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.unpaidbutton = new System.Windows.Forms.Button();
            this.paidbutton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.idtextBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.totallabel = new System.Windows.Forms.Label();
            this.totalText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Changetext = new System.Windows.Forms.TextBox();
            this.EnterB = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.payB = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.foodTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodTableDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Crimson;
            this.panel2.Location = new System.Drawing.Point(581, 36);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 410);
            this.panel2.TabIndex = 125;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Crimson;
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(962, 18);
            this.panel1.TabIndex = 123;
            // 
            // foodTableBindingSource
            // 
            this.foodTableBindingSource.DataMember = "FoodTable";
            this.foodTableBindingSource.DataSource = this.foodTableDataSet;
            // 
            // foodTableDataSet
            // 
            this.foodTableDataSet.DataSetName = "FoodTableDataSet";
            this.foodTableDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // foodTableTableAdapter
            // 
            this.foodTableTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Coral;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Cornsilk;
            this.button1.Location = new System.Drawing.Point(3, 151);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 126;
            this.button1.Text = "10";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.cashbutton_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Coral;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Cornsilk;
            this.button2.Location = new System.Drawing.Point(3, 186);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 29);
            this.button2.TabIndex = 127;
            this.button2.Text = "20";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.cashbutton_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Coral;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Cornsilk;
            this.button3.Location = new System.Drawing.Point(3, 221);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 29);
            this.button3.TabIndex = 128;
            this.button3.Text = "50";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.cashbutton_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Coral;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Cornsilk;
            this.button4.Location = new System.Drawing.Point(3, 256);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(94, 29);
            this.button4.TabIndex = 129;
            this.button4.Text = "100";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.cashbutton_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Coral;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Cornsilk;
            this.button5.Location = new System.Drawing.Point(3, 291);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(94, 29);
            this.button5.TabIndex = 130;
            this.button5.Text = "500";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.cashbutton_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Coral;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.Cornsilk;
            this.button6.Location = new System.Drawing.Point(3, 327);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(94, 29);
            this.button6.TabIndex = 131;
            this.button6.Text = "1000";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.cashbutton_Click);
            // 
            // paidB
            // 
            this.paidB.BackColor = System.Drawing.Color.LimeGreen;
            this.paidB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paidB.ForeColor = System.Drawing.Color.FloralWhite;
            this.paidB.Location = new System.Drawing.Point(766, 240);
            this.paidB.Name = "paidB";
            this.paidB.Size = new System.Drawing.Size(180, 34);
            this.paidB.TabIndex = 132;
            this.paidB.Text = "Paid";
            this.paidB.UseVisualStyleBackColor = false;
            this.paidB.Click += new System.EventHandler(this.paid_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(137, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 137;
            this.label2.Text = " Order ID :";
            // 
            // unpaidbutton
            // 
            this.unpaidbutton.BackColor = System.Drawing.Color.Coral;
            this.unpaidbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unpaidbutton.Location = new System.Drawing.Point(64, 150);
            this.unpaidbutton.Name = "unpaidbutton";
            this.unpaidbutton.Size = new System.Drawing.Size(178, 36);
            this.unpaidbutton.TabIndex = 140;
            this.unpaidbutton.Text = "Unpaid Order";
            this.unpaidbutton.UseVisualStyleBackColor = false;
            this.unpaidbutton.Click += new System.EventHandler(this.unpaidbutton_Click);
            // 
            // paidbutton
            // 
            this.paidbutton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.paidbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paidbutton.ForeColor = System.Drawing.Color.Cornsilk;
            this.paidbutton.Location = new System.Drawing.Point(335, 150);
            this.paidbutton.Name = "paidbutton";
            this.paidbutton.Size = new System.Drawing.Size(178, 36);
            this.paidbutton.TabIndex = 141;
            this.paidbutton.Text = "Paid Order";
            this.paidbutton.UseVisualStyleBackColor = false;
            this.paidbutton.Click += new System.EventHandler(this.paidbutton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(842, 79);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 142;
            // 
            // idtextBox
            // 
            this.idtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idtextBox.Location = new System.Drawing.Point(217, 69);
            this.idtextBox.Name = "idtextBox";
            this.idtextBox.Size = new System.Drawing.Size(100, 23);
            this.idtextBox.TabIndex = 143;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 204);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(527, 209);
            this.dataGridView1.TabIndex = 145;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(763, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 146;
            this.label3.Text = "Cash :";
            // 
            // totallabel
            // 
            this.totallabel.AutoSize = true;
            this.totallabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totallabel.Location = new System.Drawing.Point(763, 41);
            this.totallabel.Name = "totallabel";
            this.totallabel.Size = new System.Drawing.Size(55, 17);
            this.totallabel.TabIndex = 147;
            this.totallabel.Text = "Total :";
            // 
            // totalText
            // 
            this.totalText.Location = new System.Drawing.Point(841, 38);
            this.totalText.Name = "totalText";
            this.totalText.ReadOnly = true;
            this.totalText.Size = new System.Drawing.Size(100, 20);
            this.totalText.TabIndex = 148;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(761, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 150;
            this.label4.Text = "Change :";
            // 
            // Changetext
            // 
            this.Changetext.Location = new System.Drawing.Point(843, 184);
            this.Changetext.Name = "Changetext";
            this.Changetext.ReadOnly = true;
            this.Changetext.Size = new System.Drawing.Size(100, 20);
            this.Changetext.TabIndex = 149;
            // 
            // EnterB
            // 
            this.EnterB.BackColor = System.Drawing.Color.Crimson;
            this.EnterB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterB.ForeColor = System.Drawing.Color.Cornsilk;
            this.EnterB.Location = new System.Drawing.Point(335, 61);
            this.EnterB.Name = "EnterB";
            this.EnterB.Size = new System.Drawing.Size(91, 38);
            this.EnterB.TabIndex = 151;
            this.EnterB.Text = "Enter";
            this.EnterB.UseVisualStyleBackColor = false;
            this.EnterB.Click += new System.EventHandler(this.EnterB_Click);
            // 
            // payB
            // 
            this.payB.BackColor = System.Drawing.Color.PaleGreen;
            this.payB.Enabled = false;
            this.payB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payB.ForeColor = System.Drawing.Color.DarkBlue;
            this.payB.Location = new System.Drawing.Point(766, 118);
            this.payB.Name = "payB";
            this.payB.Size = new System.Drawing.Size(177, 32);
            this.payB.TabIndex = 152;
            this.payB.Text = "Pay";
            this.payB.UseVisualStyleBackColor = false;
            this.payB.Click += new System.EventHandler(this.payB_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Coral;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.Cornsilk;
            this.button7.Location = new System.Drawing.Point(3, 81);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(94, 29);
            this.button7.TabIndex = 153;
            this.button7.Text = "2";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.cashbutton_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Coral;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.Cornsilk;
            this.button8.Location = new System.Drawing.Point(3, 116);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(94, 29);
            this.button8.TabIndex = 154;
            this.button8.Text = "5";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.cashbutton_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Coral;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.Cornsilk;
            this.button9.Location = new System.Drawing.Point(3, 46);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(94, 29);
            this.button9.TabIndex = 155;
            this.button9.Text = "1";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.cashbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 156;
            this.label1.Text = "Pay In";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel3.Controls.Add(this.button11);
            this.panel3.Controls.Add(this.button5);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.button9);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.button8);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.button7);
            this.panel3.Controls.Add(this.button4);
            this.panel3.Controls.Add(this.button6);
            this.panel3.Location = new System.Drawing.Point(625, 37);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(100, 409);
            this.panel3.TabIndex = 157;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.Crimson;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.Color.Cornsilk;
            this.button10.Location = new System.Drawing.Point(847, 391);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(99, 37);
            this.button10.TabIndex = 158;
            this.button10.Text = "Log Out";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.button11.Location = new System.Drawing.Point(3, 362);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(94, 29);
            this.button11.TabIndex = 157;
            this.button11.Text = "C";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.LimeGreen;
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.ForeColor = System.Drawing.Color.FloralWhite;
            this.button12.Location = new System.Drawing.Point(761, 288);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(180, 34);
            this.button12.TabIndex = 159;
            this.button12.Text = "Paid";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // Cashier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 452);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.payB);
            this.Controls.Add(this.EnterB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Changetext);
            this.Controls.Add(this.totalText);
            this.Controls.Add(this.totallabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.idtextBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.paidbutton);
            this.Controls.Add(this.unpaidbutton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.paidB);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Cashier";
            this.Text = "Cashier";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CloseApplication);
            this.Load += new System.EventHandler(this.Cashier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.foodTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodTableDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource foodTableBindingSource;
        private FoodTableDataSet foodTableDataSet;
        private FoodTableDataSetTableAdapters.FoodTableTableAdapter foodTableTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button paidB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button unpaidbutton;
        private System.Windows.Forms.Button paidbutton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox idtextBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label totallabel;
        private System.Windows.Forms.TextBox totalText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Changetext;
        private System.Windows.Forms.Button EnterB;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button payB;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
    }
}