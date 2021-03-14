using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Azpetrol
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Petrol> petrols = new List<Petrol>
            {
                new Petrol
                {
                    Name = "AI-92",
                    Price = 1.00
                },
                new Petrol
                {
                    Name  = "AI-95",
                    Price = 1.25
                },
                new Petrol
                {
                    Name = "Diesel",
                    Price = 0.80
                },
                new Petrol
                {
                    Name = "Energy for Electric Vehicles",
                    Price = 3.00
                }
            };
            PetrolCb.DisplayMember = "Name";
            PetrolCb.DataSource = petrols;
            PriceTxtBx.BackColor = Color.LightGray;
            LiterTxtBx.BackColor = Color.LightGray;
        }

        private void PetrolCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            PriceTxtBoxReadOnly.Text = PetrolCb.SelectedItem.ToString();
        }

        private void PriceRBtn_CheckedChanged(object sender, EventArgs e)
        {
            LiterTxtBx.BackColor = Color.LightGray;
            PriceTxtBx.BackColor = Color.White;
            PriceTxtBx.ReadOnly = false;
            LiterTxtBx.ReadOnly = true;
            LiterTxtBx.Text = "";
        }

        private void LiterRBtn_CheckedChanged(object sender, EventArgs e)
        {
            PriceTxtBx.BackColor = Color.LightGray;
            LiterTxtBx.BackColor = Color.White;
            PriceTxtBx.Text = "";
            LiterTxtBx.ReadOnly = false;
            PriceTxtBx.ReadOnly = true;
        }

        private void PriceTxtBx_KeyPress(object sender, KeyPressEventArgs e)
        {

            e.Handled = !char.IsDigit(e.KeyChar);
        }

        private void LiterTxtBx_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar);
        }

        private void LiterTxtBx_TextChanged(object sender, EventArgs e)
        {
            string liter = LiterTxtBx.Text;
            double litr = Convert.ToDouble(liter);
            string price = PriceTxtBoxReadOnly.Text;
            double pricee = Convert.ToDouble(price);
            double sum = litr * pricee;
            string total = Convert.ToString(sum);
            TotalTxtBx.Text = total;
        }
    }
}
