namespace Meem_Pharma
{
    partial class Checkout
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
            this.label1 = new System.Windows.Forms.Label();
            this.List = new System.Windows.Forms.ListBox();
            this.MedicineList = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AddTextbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.AddMedicineButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.UpdateTextbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.Delete = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.SoldPrice = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.UpdatedSoldPrice = new System.Windows.Forms.TextBox();
            this.CheckoutButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(405, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(381, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "MS Meem Pharmacy";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // List
            // 
            this.List.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.List.FormattingEnabled = true;
            this.List.ItemHeight = 24;
            this.List.Location = new System.Drawing.Point(619, 90);
            this.List.Name = "List";
            this.List.Size = new System.Drawing.Size(597, 556);
            this.List.TabIndex = 1;
            this.List.SelectedIndexChanged += new System.EventHandler(this.List_SelectedIndexChanged);
            // 
            // MedicineList
            // 
            this.MedicineList.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.MedicineList.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.MedicineList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MedicineList.FormattingEnabled = true;
            this.MedicineList.Location = new System.Drawing.Point(12, 168);
            this.MedicineList.Name = "MedicineList";
            this.MedicineList.Size = new System.Drawing.Size(313, 32);
            this.MedicineList.TabIndex = 2;
            this.MedicineList.SelectedIndexChanged += new System.EventHandler(this.MedicineList_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(119, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Medicine";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteCustomSource.AddRange(new string[] {
            "Apple,",
            "Banana",
            "orange",
            "lebu",
            "grape",
            "goru",
            "olive",
            "olu",
            "gadha",
            "gaga",
            "ggg"});
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(342, 167);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(63, 32);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(349, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Strip";
            // 
            // AddTextbox
            // 
            this.AddTextbox.Enabled = false;
            this.AddTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddTextbox.Location = new System.Drawing.Point(444, 169);
            this.AddTextbox.Name = "AddTextbox";
            this.AddTextbox.Size = new System.Drawing.Size(64, 29);
            this.AddTextbox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(452, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "MRP";
            // 
            // AddMedicineButton
            // 
            this.AddMedicineButton.BackColor = System.Drawing.Color.LawnGreen;
            this.AddMedicineButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddMedicineButton.Location = new System.Drawing.Point(527, 236);
            this.AddMedicineButton.Name = "AddMedicineButton";
            this.AddMedicineButton.Size = new System.Drawing.Size(75, 34);
            this.AddMedicineButton.TabIndex = 8;
            this.AddMedicineButton.Text = "ADD";
            this.AddMedicineButton.UseVisualStyleBackColor = false;
            this.AddMedicineButton.Click += new System.EventHandler(this.AddMedicineButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(452, 341);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "MRP";
            // 
            // UpdateTextbox
            // 
            this.UpdateTextbox.Enabled = false;
            this.UpdateTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateTextbox.Location = new System.Drawing.Point(444, 376);
            this.UpdateTextbox.Name = "UpdateTextbox";
            this.UpdateTextbox.Size = new System.Drawing.Size(64, 29);
            this.UpdateTextbox.TabIndex = 13;
            this.UpdateTextbox.Text = "lll";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(349, 342);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Strip";
            // 
            // comboBox2
            // 
            this.comboBox2.AutoCompleteCustomSource.AddRange(new string[] {
            "Apple,",
            "Banana",
            "orange",
            "lebu",
            "grape",
            "goru",
            "olive",
            "olu",
            "gadha",
            "gaga",
            "ggg"});
            this.comboBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(342, 376);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(63, 32);
            this.comboBox2.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(119, 343);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Medicine";
            // 
            // comboBox3
            // 
            this.comboBox3.AutoCompleteCustomSource.AddRange(new string[] {
            "Apple,",
            "Banana",
            "orange",
            "lebu",
            "grape",
            "goru",
            "olive",
            "olu",
            "gadha",
            "gaga",
            "ggg"});
            this.comboBox3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.comboBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(12, 377);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(313, 32);
            this.comboBox3.TabIndex = 9;
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.Crimson;
            this.Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.Location = new System.Drawing.Point(433, 445);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 34);
            this.Delete.TabIndex = 15;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = false;
            // 
            // Update
            // 
            this.Update.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update.Location = new System.Drawing.Point(527, 445);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(75, 34);
            this.Update.TabIndex = 16;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(546, 132);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "Sold";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // SoldPrice
            // 
            this.SoldPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SoldPrice.Location = new System.Drawing.Point(538, 169);
            this.SoldPrice.Name = "SoldPrice";
            this.SoldPrice.Size = new System.Drawing.Size(64, 29);
            this.SoldPrice.TabIndex = 17;
            this.SoldPrice.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(546, 339);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 20);
            this.label9.TabIndex = 20;
            this.label9.Text = "Sold";
            // 
            // UpdatedSoldPrice
            // 
            this.UpdatedSoldPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdatedSoldPrice.Location = new System.Drawing.Point(538, 376);
            this.UpdatedSoldPrice.Name = "UpdatedSoldPrice";
            this.UpdatedSoldPrice.Size = new System.Drawing.Size(64, 29);
            this.UpdatedSoldPrice.TabIndex = 19;
            // 
            // CheckoutButton
            // 
            this.CheckoutButton.BackColor = System.Drawing.Color.LawnGreen;
            this.CheckoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckoutButton.Location = new System.Drawing.Point(200, 583);
            this.CheckoutButton.Name = "CheckoutButton";
            this.CheckoutButton.Size = new System.Drawing.Size(205, 47);
            this.CheckoutButton.TabIndex = 21;
            this.CheckoutButton.Text = "Checkout";
            this.CheckoutButton.UseVisualStyleBackColor = false;
            // 
            // Checkout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 668);
            this.Controls.Add(this.CheckoutButton);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.UpdatedSoldPrice);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.SoldPrice);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.UpdateTextbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.AddMedicineButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AddTextbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MedicineList);
            this.Controls.Add(this.List);
            this.Controls.Add(this.label1);
            this.Name = "Checkout";
            this.Text = "Checkout";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox List;
        private System.Windows.Forms.ComboBox MedicineList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AddTextbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button AddMedicineButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox UpdateTextbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox SoldPrice;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox UpdatedSoldPrice;
        private System.Windows.Forms.Button CheckoutButton;
    }
}

