using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Meem_Pharma
{
    public partial class Checkout : Form
    {
        private List<Product> products = new List<Product>();
        public Checkout()
        {
            InitializeComponent();
            LoadBrandNamesFromCSV();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void List_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddMedicineButton_Click(object sender, EventArgs e)
        {
            
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void LoadBrandNamesFromCSV()
        {
            try
            {
                // Create an instance of Product
                Product product = new Product();

                // Read the CSV file and get the list of products
                products = product.ReadCsvFile("C:\\Users\\alamd\\OneDrive\\Desktop\\Dokan\\Medicine.csv");

                // Clear existing items in the ComboBox
                MedicineList.Items.Clear();

                // Add each product to the ComboBox
                foreach (var p in products)
                {
                    string displayText = $"{p.BrandName} ({p.Strength}) {p.DosageForm}";

                    // Add the display text to the ComboBox
                    MedicineList.Items.Add(displayText);
                }
                MedicineList.SelectedIndexChanged += MedicineList_SelectedIndexChanged;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reading the CSV file: " + ex.Message);
            }
        }



        private void MedicineList_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the selected index
            int selectedIndex = MedicineList.SelectedIndex;

            // Ensure a valid selection
            if (selectedIndex >= 0 && selectedIndex < products.Count)
            {
                // Get the selected product
                Product selectedProduct = products[selectedIndex];

                // Update the AddTextbox with the price of the selected product
                AddTextbox.Text = selectedProduct.Price.ToString("F2");
            }
        }



    }
}
