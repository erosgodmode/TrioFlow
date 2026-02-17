using System;
using System.Windows.Forms;

namespace TrioFlow
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        // Set the selected service from Form1
        public void SetService(string service)
        {
            lblService.Text = "Selected Service: " + service;
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string address = txtAddress.Text;
            string service = lblService.Text.Replace("Selected Service: ", "");
            int gallons;

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(address) || !int.TryParse(txtGallons.Text, out gallons))
            {
                MessageBox.Show("Please fill all fields correctly.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int pricePerGallon = 30; // Example price
            int total = gallons * pricePerGallon;

            lblResult.Text = $"Service: {service}\n" +
                             $"Name: {name}\n" +
                             $"Address: {address}\n" +
                             $"Gallons: {gallons}\n" +
                             $"Total Price: ₱{total}";
        }
    }
}
