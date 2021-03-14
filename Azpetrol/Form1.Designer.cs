namespace Azpetrol
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.oilLbl = new System.Windows.Forms.Label();
            this.PetrolCb = new System.Windows.Forms.ComboBox();
            this.PriceLbl = new System.Windows.Forms.Label();
            this.PriceHandlerLbl = new System.Windows.Forms.Label();
            this.PriceTxtBoxReadOnly = new System.Windows.Forms.TextBox();
            this.PriceRBtn = new System.Windows.Forms.RadioButton();
            this.LiterRBtn = new System.Windows.Forms.RadioButton();
            this.PriceLiterGB = new System.Windows.Forms.GroupBox();
            this.LiterTxtBx = new System.Windows.Forms.TextBox();
            this.PriceTxtBx = new System.Windows.Forms.TextBox();
            this.GasStationGB = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TotalTxtBx = new System.Windows.Forms.TextBox();
            this.PriceLiterGB.SuspendLayout();
            this.GasStationGB.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // oilLbl
            // 
            this.oilLbl.AutoSize = true;
            this.oilLbl.Font = new System.Drawing.Font("Yu Gothic Light", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oilLbl.Location = new System.Drawing.Point(4, 28);
            this.oilLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.oilLbl.Name = "oilLbl";
            this.oilLbl.Size = new System.Drawing.Size(54, 23);
            this.oilLbl.TabIndex = 1;
            this.oilLbl.Text = "Petrol";
            // 
            // PetrolCb
            // 
            this.PetrolCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PetrolCb.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PetrolCb.FormattingEnabled = true;
            this.PetrolCb.Location = new System.Drawing.Point(78, 28);
            this.PetrolCb.Name = "PetrolCb";
            this.PetrolCb.Size = new System.Drawing.Size(179, 25);
            this.PetrolCb.TabIndex = 2;
            this.PetrolCb.SelectedIndexChanged += new System.EventHandler(this.PetrolCb_SelectedIndexChanged);
            // 
            // PriceLbl
            // 
            this.PriceLbl.AutoSize = true;
            this.PriceLbl.Font = new System.Drawing.Font("Yu Gothic Light", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceLbl.Location = new System.Drawing.Point(5, 79);
            this.PriceLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PriceLbl.Name = "PriceLbl";
            this.PriceLbl.Size = new System.Drawing.Size(49, 23);
            this.PriceLbl.TabIndex = 3;
            this.PriceLbl.Text = "Price";
            // 
            // PriceHandlerLbl
            // 
            this.PriceHandlerLbl.AutoSize = true;
            this.PriceHandlerLbl.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 13F);
            this.PriceHandlerLbl.Location = new System.Drawing.Point(438, 319);
            this.PriceHandlerLbl.Name = "PriceHandlerLbl";
            this.PriceHandlerLbl.Size = new System.Drawing.Size(13, 18);
            this.PriceHandlerLbl.TabIndex = 4;
            this.PriceHandlerLbl.Text = " \r\n";
            // 
            // PriceTxtBoxReadOnly
            // 
            this.PriceTxtBoxReadOnly.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 13F);
            this.PriceTxtBoxReadOnly.Location = new System.Drawing.Point(78, 82);
            this.PriceTxtBoxReadOnly.Name = "PriceTxtBoxReadOnly";
            this.PriceTxtBoxReadOnly.ReadOnly = true;
            this.PriceTxtBoxReadOnly.Size = new System.Drawing.Size(179, 25);
            this.PriceTxtBoxReadOnly.TabIndex = 5;
            // 
            // PriceRBtn
            // 
            this.PriceRBtn.AutoSize = true;
            this.PriceRBtn.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 13F);
            this.PriceRBtn.Location = new System.Drawing.Point(6, 19);
            this.PriceRBtn.Name = "PriceRBtn";
            this.PriceRBtn.Size = new System.Drawing.Size(57, 22);
            this.PriceRBtn.TabIndex = 6;
            this.PriceRBtn.TabStop = true;
            this.PriceRBtn.Text = "Price";
            this.PriceRBtn.UseVisualStyleBackColor = true;
            this.PriceRBtn.CheckedChanged += new System.EventHandler(this.PriceRBtn_CheckedChanged);
            // 
            // LiterRBtn
            // 
            this.LiterRBtn.AutoSize = true;
            this.LiterRBtn.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 13F);
            this.LiterRBtn.Location = new System.Drawing.Point(6, 47);
            this.LiterRBtn.Name = "LiterRBtn";
            this.LiterRBtn.Size = new System.Drawing.Size(51, 22);
            this.LiterRBtn.TabIndex = 7;
            this.LiterRBtn.TabStop = true;
            this.LiterRBtn.Text = "Liter";
            this.LiterRBtn.UseVisualStyleBackColor = true;
            this.LiterRBtn.CheckedChanged += new System.EventHandler(this.LiterRBtn_CheckedChanged);
            // 
            // PriceLiterGB
            // 
            this.PriceLiterGB.Controls.Add(this.LiterTxtBx);
            this.PriceLiterGB.Controls.Add(this.PriceTxtBx);
            this.PriceLiterGB.Controls.Add(this.PriceRBtn);
            this.PriceLiterGB.Controls.Add(this.LiterRBtn);
            this.PriceLiterGB.Font = new System.Drawing.Font("Gourmet Hearth", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceLiterGB.Location = new System.Drawing.Point(8, 130);
            this.PriceLiterGB.Name = "PriceLiterGB";
            this.PriceLiterGB.Size = new System.Drawing.Size(200, 100);
            this.PriceLiterGB.TabIndex = 8;
            this.PriceLiterGB.TabStop = false;
            // 
            // LiterTxtBx
            // 
            this.LiterTxtBx.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 13F);
            this.LiterTxtBx.Location = new System.Drawing.Point(87, 46);
            this.LiterTxtBx.Name = "LiterTxtBx";
            this.LiterTxtBx.ReadOnly = true;
            this.LiterTxtBx.Size = new System.Drawing.Size(100, 25);
            this.LiterTxtBx.TabIndex = 9;
            this.LiterTxtBx.TextChanged += new System.EventHandler(this.LiterTxtBx_TextChanged);
            this.LiterTxtBx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LiterTxtBx_KeyPress);
            // 
            // PriceTxtBx
            // 
            this.PriceTxtBx.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 13F);
            this.PriceTxtBx.Location = new System.Drawing.Point(87, 20);
            this.PriceTxtBx.Name = "PriceTxtBx";
            this.PriceTxtBx.ReadOnly = true;
            this.PriceTxtBx.Size = new System.Drawing.Size(100, 25);
            this.PriceTxtBx.TabIndex = 8;
            this.PriceTxtBx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PriceTxtBx_KeyPress);
            // 
            // GasStationGB
            // 
            this.GasStationGB.Controls.Add(this.groupBox1);
            this.GasStationGB.Controls.Add(this.oilLbl);
            this.GasStationGB.Controls.Add(this.PriceLiterGB);
            this.GasStationGB.Controls.Add(this.PetrolCb);
            this.GasStationGB.Controls.Add(this.PriceTxtBoxReadOnly);
            this.GasStationGB.Controls.Add(this.PriceLbl);
            this.GasStationGB.Font = new System.Drawing.Font("Gourmet Hearth", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GasStationGB.Location = new System.Drawing.Point(12, 12);
            this.GasStationGB.Name = "GasStationGB";
            this.GasStationGB.Size = new System.Drawing.Size(309, 338);
            this.GasStationGB.TabIndex = 9;
            this.GasStationGB.TabStop = false;
            this.GasStationGB.Text = "GAS STATION";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TotalTxtBx);
            this.groupBox1.Location = new System.Drawing.Point(14, 236);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(136, 89);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Total";
            // 
            // TotalTxtBx
            // 
            this.TotalTxtBx.Location = new System.Drawing.Point(6, 28);
            this.TotalTxtBx.Name = "TotalTxtBx";
            this.TotalTxtBx.ReadOnly = true;
            this.TotalTxtBx.Size = new System.Drawing.Size(83, 29);
            this.TotalTxtBx.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 11F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 381);
            this.Controls.Add(this.GasStationGB);
            this.Controls.Add(this.PriceHandlerLbl);
            this.Font = new System.Drawing.Font("Gourmet Hearth", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Azpetrol ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PriceLiterGB.ResumeLayout(false);
            this.PriceLiterGB.PerformLayout();
            this.GasStationGB.ResumeLayout(false);
            this.GasStationGB.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label oilLbl;
        private System.Windows.Forms.ComboBox PetrolCb;
        private System.Windows.Forms.Label PriceLbl;
        private System.Windows.Forms.Label PriceHandlerLbl;
        private System.Windows.Forms.TextBox PriceTxtBoxReadOnly;
        private System.Windows.Forms.RadioButton PriceRBtn;
        private System.Windows.Forms.RadioButton LiterRBtn;
        private System.Windows.Forms.GroupBox PriceLiterGB;
        private System.Windows.Forms.GroupBox GasStationGB;
        private System.Windows.Forms.TextBox LiterTxtBx;
        private System.Windows.Forms.TextBox PriceTxtBx;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TotalTxtBx;
    }
}

