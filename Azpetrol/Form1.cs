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
        FileHelper helper = new FileHelper();
        Timer timer = new Timer();
        static bool priceSelected = false;
        static bool literSelected = false;
        public Form1()
        {
            InitializeComponent();
            timer.Tick += Timer_Tick;
            timer.Interval = 100;
            timer.Start();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            label4.Text = $"Time:{DateTime.Now.ToString("hh:mm:ss")}";
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

            };
            PetrolCb.DisplayMember = "Name";
            PetrolCb.DataSource = petrols;
            PriceTxtBx2.FillColor = Color.LightGray;
            LiterTxtBx.FillColor = Color.LightGray;
            HotDogPriceTxtBx.Text = "1.00";
            HamburgerPriceTxtBx.Text = "1.90";
            FrenchFriesPriceTxtBx.Text = "2.10";
            CocaColaPriceTxtBx.Text = "1.40";
            FantaPriceTxtBx.Text = "1.40";
            label3.Text = $"Date:{DateTime.Now.ToString("dddd,MMM,dd,yyyy")}";
        }
        private void PriceRBtn_CheckedChanged(object sender, EventArgs e)
        {
            LiterTxtBx.FillColor = Color.LightGray;
            PriceTxtBx2.FillColor = Color.White;
            PriceTxtBx2.ReadOnly = false;
            LiterTxtBx.ReadOnly = true;
            LiterTxtBx.Text = "";
            priceSelected = true;
            literSelected = false;
        }
        private void LiterRBtn_CheckedChanged(object sender, EventArgs e)
        {
            PriceTxtBx2.FillColor = Color.LightGray;
            LiterTxtBx.FillColor = Color.White;
            PriceTxtBx2.Text = "";
            LiterTxtBx.ReadOnly = false;
            PriceTxtBx2.ReadOnly = true;
            literSelected = true;
            priceSelected = false;
        }
        private void LiterTxtBx_TextChanged(object sender, EventArgs e)
        {
            string liter = LiterTxtBx.Text;
            double litr = Convert.ToDouble(liter);
            string price = PriceTxtBoxRead.Text;
            double pricee = Convert.ToDouble(price);
            double sum = litr * pricee;
            string total = Convert.ToString(sum);
            TotalTxtBx.Text = total;
        }
        private void PetrolCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            PriceTxtBoxRead.Text = PetrolCb.SelectedItem.ToString();
        }
        private void PriceTxtBx2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar);
        }
        private void LiterTxtBx_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar);

        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (literSelected == true)
            {
                double liter = Double.Parse(LiterTxtBx.Text);
                double price = Double.Parse(PriceTxtBoxRead.Text);
                string total = Convert.ToString(liter * price);
                TotalTxtBx.Text = total;
            }
            if (priceSelected == true)
            {
                TotalTxtBx.Text = PriceTxtBx2.Text;
            }
        }
        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FrenchFriesRbtn_CheckedChanged(object sender, EventArgs e)
        {
            FrenchFriesPriceTxtBx.Text = "2.10";
        }
        private void CocaColaRbtn_CheckedChanged(object sender, EventArgs e)
        {
            CocaColaPriceTxtBx.Text = "1.40";
        }
        private void FantaRbtn_CheckedChanged(object sender, EventArgs e)
        {
            FantaPriceTxtBx.Text = "1.40";
        }
        private void TotalBtn_Click(object sender, EventArgs e)
        {
            double hotdogPiece;
            double.TryParse(HotDogPieceTxtBx.Text, out hotdogPiece);
            double hotDogResult = (hotdogPiece * Convert.ToDouble(HotDogPriceTxtBx.Text));

            double hamburgerPiece;
            double.TryParse(HamburgerPieceTxtBx.Text, out hamburgerPiece);
            double hamburgerResult = (hamburgerPiece * Convert.ToDouble(HamburgerPriceTxtBx.Text));

            double frenchFriesPiece;
            double.TryParse(FrenchFriesPieceTxtBx.Text, out frenchFriesPiece);
            double frenchFriesResult = (frenchFriesPiece * Convert.ToDouble(FrenchFriesPriceTxtBx.Text));

            double cocaColaPiece;
            double.TryParse(CocaColaPieceTxtBox.Text, out cocaColaPiece);
            double cocaColaResult = (cocaColaPiece * Convert.ToDouble(CocaColaPriceTxtBx.Text));

            double fantaPiece;
            double.TryParse(FantaPieceTxtBx.Text, out fantaPiece);
            double fantaResult = (fantaPiece * Convert.ToDouble(FantaPriceTxtBx.Text));
            TotalMiniCafeTxtBx.Text = Convert.ToString(hotDogResult + hamburgerResult + frenchFriesResult + cocaColaResult + fantaResult);
        }
        private void HotDogPieceTxtBx_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar);
        }
        private void HamburgerPieceTxtBx_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar);
        }
        private void FrenchFriesPieceTxtBx_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar);
        }
        private void CocaColaPieceTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar);
        }
        private void FantaPieceTxtBx_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar);
        }
        private void HotDogCb_CheckedChanged(object sender, EventArgs e)
        {
            if (HotDogCb.Checked == true)
            {
                HotDogPieceTxtBx.FillColor = Color.White;
                HotDogPieceTxtBx.ReadOnly = false;
            }
            if (HotDogCb.Checked == false)
            {
                HotDogPieceTxtBx.FillColor = Color.LightGray;
                HotDogPieceTxtBx.ReadOnly = true;
                HotDogPieceTxtBx.Text = "";
            }
        }
        private void HamburgerCb_CheckedChanged(object sender, EventArgs e)
        {
            if (HamburgerCb.Checked == true)
            {
                HamburgerPieceTxtBx.FillColor = Color.White;
                HamburgerPieceTxtBx.ReadOnly = false;
            }
            if (HamburgerCb.Checked == false)
            {
                HamburgerPieceTxtBx.FillColor = Color.LightGray;
                HamburgerPieceTxtBx.ReadOnly = true;
                HotDogPieceTxtBx.Text = "";
            }
        }
        private void FrenchFriesCb_CheckedChanged(object sender, EventArgs e)
        {
            if (FrenchFriesCb.Checked == true)
            {
                FrenchFriesPieceTxtBx.FillColor = Color.White;
                FrenchFriesPieceTxtBx.ReadOnly = false;
            }
            if (FrenchFriesCb.Checked == false)
            {
                FrenchFriesPieceTxtBx.FillColor = Color.LightGray;
                FrenchFriesPieceTxtBx.ReadOnly = true;
                FrenchFriesPieceTxtBx.Text = "";
            }

        }
        private void CocaColaCb_CheckedChanged(object sender, EventArgs e)
        {
            if (CocaColaCb.Checked == true)
            {
                CocaColaPieceTxtBox.FillColor = Color.White;
                CocaColaPieceTxtBox.ReadOnly = false;
            }
            if (CocaColaCb.Checked == false)
            {
                CocaColaPieceTxtBox.FillColor = Color.LightGray;
                CocaColaPieceTxtBox.ReadOnly = true;
                CocaColaPieceTxtBox.Text = "";
            }

        }
        private void FantaCb_CheckedChanged(object sender, EventArgs e)
        {
            if (FantaCb.Checked == true)
            {
                FantaPieceTxtBx.FillColor = Color.White;
                FantaPieceTxtBx.ReadOnly = false;
            }
            if (FantaCb.Checked == false)
            {
                FantaPieceTxtBx.FillColor = Color.LightGray;
                FantaPieceTxtBx.ReadOnly = true;
                FantaPieceTxtBx.Text = "";
            }

        }
        private void CalculateAllTotalBtn_Click(object sender, EventArgs e)
        {

            double hotdogPiece;
            double.TryParse(HotDogPieceTxtBx.Text, out hotdogPiece);
            double hotDogResult = (hotdogPiece * Convert.ToDouble(HotDogPriceTxtBx.Text));

            double hamburgerPiece;
            double.TryParse(HamburgerPieceTxtBx.Text, out hamburgerPiece);
            double hamburgerResult = (hamburgerPiece * Convert.ToDouble(HamburgerPriceTxtBx.Text));

            double frenchFriesPiece;
            double.TryParse(FrenchFriesPieceTxtBx.Text, out frenchFriesPiece);
            double frenchFriesResult = (frenchFriesPiece * Convert.ToDouble(FrenchFriesPriceTxtBx.Text));

            double cocaColaPiece;
            double.TryParse(CocaColaPieceTxtBox.Text, out cocaColaPiece);
            double cocaColaResult = (cocaColaPiece * Convert.ToDouble(CocaColaPriceTxtBx.Text));

            double fantaPiece;
            double.TryParse(FantaPieceTxtBx.Text, out fantaPiece);
            double fantaResult = (fantaPiece * Convert.ToDouble(FantaPriceTxtBx.Text));
            TotalMiniCafeTxtBx.Text = Convert.ToString(hotDogResult + hamburgerResult + frenchFriesResult + cocaColaResult + fantaResult);

            if (literSelected == true)
            {
                double liter = Double.Parse(LiterTxtBx.Text);
                double price = Double.Parse(PriceTxtBoxRead.Text);
                string total = Convert.ToString(liter * price);
                TotalTxtBx.Text = total;
            }
            if (priceSelected == true)
            {
                TotalTxtBx.Text = PriceTxtBx2.Text;
            }
            try
            {
                double a = Convert.ToDouble(TotalMiniCafeTxtBx.Text);
                double b = Convert.ToDouble(TotalTxtBx.Text);
                AllTotalTxtBx.Text = Convert.ToString(a + b);

            }
            catch (Exception)
            {
                AllTotalTxtBx.Text = "0";
            }
            Guid id = Guid.NewGuid();
            string ID = Convert.ToString(id);
            string time = DateTime.Now.ToString("MMM-dd-yyyy-hh-mm");
            string bill = $@"Station Name:Azpetrol Baki
Bill ID:{ID}
Date Time:{time}
All Amount:{AllTotalTxtBx.Text}
";
            helper.JsonSerialize(bill);

            CalculateAllTotalBtn.Enabled = false;
        }
    }
}
