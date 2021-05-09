using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MegaDesk_Krohn
{
    public partial class AddQuote : Form
    {
        public AddQuote()
        {
            InitializeComponent();
        }

        private void AddQuote_Load(object sender, EventArgs e)
        {

            shippingDays.DisplayMember = "Text";
            shippingDays.ValueMember = "Value";

            var shipping = new[] {
                new { Text = "Standard Shipping", Value = 0 },
                new { Text = "3 Day Rush Shipping", Value = 3 },
                new { Text = "5 Day Rush Shipping", Value = 5 },
                new { Text = "7 Day Rush Shipping", Value = 7 },
            };

            shippingDays.DataSource = shipping;

            surfaceMaterial.Items.Add("Oak");
            surfaceMaterial.Items.Add("Laminate");
            surfaceMaterial.Items.Add("Pine");
            surfaceMaterial.Items.Add("Rosewood");
            surfaceMaterial.Items.Add("Veneer");

            deskWidth.Value = 24;
            deskDepth.Value = 12;
        }

        private void nameInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void deskDepth_ValueChanged(object sender, EventArgs e)
        {
            if (deskDepth.Value < 12)
            {
                deskDepth.Value = 12;
            }
            else if (deskDepth.Value > 48)
            {
                deskDepth.Value = 48;
            }
        }

        private void deskWidth_ValueChanged(object sender, EventArgs e)
        {
            if (deskWidth.Value < 24)
            {
                deskWidth.Value = 24;
            }
            else if (deskWidth.Value > 96)
            {
                deskWidth.Value = 96;
            }
        }

        private void deskDrawers_ValueChanged(object sender, EventArgs e)
        {
            if (deskDrawers.Value < 0)
            {
                deskDrawers.Value = 0;
            }
            else if (deskDrawers.Value > 7)
            {
                deskDrawers.Value = 7;
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void submitNewQuote_Click(object sender, EventArgs e)
        {
            Desk desk = new Desk((int)deskWidth.Value, (int)deskDepth.Value, (int)deskDrawers.Value, surfaceMaterial.GetItemText(surfaceMaterial.SelectedItem));
            DeskQuote deskQuote = new DeskQuote(nameInput.Text, (int)shippingDays.SelectedValue, desk);
            System.Windows.Forms.MessageBox.Show(deskQuote.CustomerName + ", your estimated cost will be: $" + deskQuote.createQuote().ToString() + ".00", "Order #" + deskQuote.Id);
            this.Hide();
        }

        #region
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        #endregion

        private void label5_Click_1(object sender, EventArgs e)
        {

        }
    }
}
