namespace Sports_Store
{
    partial class CheckOut
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
            this.rtbCheckOutBasket = new System.Windows.Forms.RichTextBox();
            this.txtItemCount = new System.Windows.Forms.Label();
            this.txtTotalAmount = new System.Windows.Forms.Label();
            this.btnGoBack = new System.Windows.Forms.Button();
            this.btnEditOrder = new System.Windows.Forms.Button();
            this.rbtnHomeDelivery = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.rbtnInShopDelivery = new System.Windows.Forms.RadioButton();
            this.gbHomeDelivery = new System.Windows.Forms.GroupBox();
            this.gbInShop = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFirstNameInShop = new System.Windows.Forms.TextBox();
            this.txtLastNameInShop = new System.Windows.Forms.TextBox();
            this.btnPayInShop = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFirstNameDelivery = new System.Windows.Forms.TextBox();
            this.txtLastNameDelivery = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpDeliveryDate = new System.Windows.Forms.DateTimePicker();
            this.btnPayDelivery = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAddressDelivery = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCityDelivery = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPCDelivery = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbHomeDelivery.SuspendLayout();
            this.gbInShop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Order Summary";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // rtbCheckOutBasket
            // 
            this.rtbCheckOutBasket.Location = new System.Drawing.Point(39, 124);
            this.rtbCheckOutBasket.Name = "rtbCheckOutBasket";
            this.rtbCheckOutBasket.ReadOnly = true;
            this.rtbCheckOutBasket.Size = new System.Drawing.Size(333, 417);
            this.rtbCheckOutBasket.TabIndex = 1;
            this.rtbCheckOutBasket.Text = "";
            // 
            // txtItemCount
            // 
            this.txtItemCount.AutoSize = true;
            this.txtItemCount.Location = new System.Drawing.Point(391, 124);
            this.txtItemCount.Name = "txtItemCount";
            this.txtItemCount.Size = new System.Drawing.Size(140, 17);
            this.txtItemCount.TabIndex = 2;
            this.txtItemCount.Text = "Your Order contains ";
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.AutoSize = true;
            this.txtTotalAmount.Location = new System.Drawing.Point(391, 153);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.Size = new System.Drawing.Size(84, 17);
            this.txtTotalAmount.TabIndex = 3;
            this.txtTotalAmount.Text = "Total Price: ";
            // 
            // btnGoBack
            // 
            this.btnGoBack.Location = new System.Drawing.Point(39, 82);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(130, 36);
            this.btnGoBack.TabIndex = 4;
            this.btnGoBack.Text = "Go back";
            this.btnGoBack.UseVisualStyleBackColor = true;
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
            // 
            // btnEditOrder
            // 
            this.btnEditOrder.Location = new System.Drawing.Point(175, 82);
            this.btnEditOrder.Name = "btnEditOrder";
            this.btnEditOrder.Size = new System.Drawing.Size(138, 35);
            this.btnEditOrder.TabIndex = 5;
            this.btnEditOrder.Text = "Edit my Order";
            this.btnEditOrder.UseVisualStyleBackColor = true;
            this.btnEditOrder.Click += new System.EventHandler(this.btnEditOrder_Click);
            // 
            // rbtnHomeDelivery
            // 
            this.rbtnHomeDelivery.AutoSize = true;
            this.rbtnHomeDelivery.Location = new System.Drawing.Point(559, 224);
            this.rbtnHomeDelivery.Name = "rbtnHomeDelivery";
            this.rbtnHomeDelivery.Size = new System.Drawing.Size(121, 21);
            this.rbtnHomeDelivery.TabIndex = 6;
            this.rbtnHomeDelivery.TabStop = true;
            this.rbtnHomeDelivery.Text = "Home Delivery";
            this.rbtnHomeDelivery.UseVisualStyleBackColor = true;
            this.rbtnHomeDelivery.CheckedChanged += new System.EventHandler(this.rbtnHomeDelivery_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(394, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Choose how to get your order:";
            // 
            // rbtnInShopDelivery
            // 
            this.rbtnInShopDelivery.AutoSize = true;
            this.rbtnInShopDelivery.Location = new System.Drawing.Point(394, 224);
            this.rbtnInShopDelivery.Name = "rbtnInShopDelivery";
            this.rbtnInShopDelivery.Size = new System.Drawing.Size(132, 21);
            this.rbtnInShopDelivery.TabIndex = 9;
            this.rbtnInShopDelivery.TabStop = true;
            this.rbtnInShopDelivery.Text = "Retrieve in shop";
            this.rbtnInShopDelivery.UseVisualStyleBackColor = true;
            this.rbtnInShopDelivery.CheckedChanged += new System.EventHandler(this.rbtnInShopDelivery_CheckedChanged);
            // 
            // gbHomeDelivery
            // 
            this.gbHomeDelivery.Controls.Add(this.txtPCDelivery);
            this.gbHomeDelivery.Controls.Add(this.label10);
            this.gbHomeDelivery.Controls.Add(this.txtCityDelivery);
            this.gbHomeDelivery.Controls.Add(this.label9);
            this.gbHomeDelivery.Controls.Add(this.txtAddressDelivery);
            this.gbHomeDelivery.Controls.Add(this.label8);
            this.gbHomeDelivery.Controls.Add(this.btnPayDelivery);
            this.gbHomeDelivery.Controls.Add(this.dtpDeliveryDate);
            this.gbHomeDelivery.Controls.Add(this.label7);
            this.gbHomeDelivery.Controls.Add(this.txtLastNameDelivery);
            this.gbHomeDelivery.Controls.Add(this.txtFirstNameDelivery);
            this.gbHomeDelivery.Controls.Add(this.label6);
            this.gbHomeDelivery.Controls.Add(this.label5);
            this.gbHomeDelivery.Location = new System.Drawing.Point(394, 267);
            this.gbHomeDelivery.Name = "gbHomeDelivery";
            this.gbHomeDelivery.Size = new System.Drawing.Size(537, 274);
            this.gbHomeDelivery.TabIndex = 10;
            this.gbHomeDelivery.TabStop = false;
            this.gbHomeDelivery.Text = "Home Delivery";
            this.gbHomeDelivery.Visible = false;
            // 
            // gbInShop
            // 
            this.gbInShop.Controls.Add(this.btnPayInShop);
            this.gbInShop.Controls.Add(this.txtLastNameInShop);
            this.gbInShop.Controls.Add(this.txtFirstNameInShop);
            this.gbInShop.Controls.Add(this.label4);
            this.gbInShop.Controls.Add(this.label3);
            this.gbInShop.Location = new System.Drawing.Point(393, 267);
            this.gbInShop.Name = "gbInShop";
            this.gbInShop.Size = new System.Drawing.Size(287, 203);
            this.gbInShop.TabIndex = 11;
            this.gbInShop.TabStop = false;
            this.gbInShop.Text = "In shop";
            this.gbInShop.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "First Name:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Last Name:";
            // 
            // txtFirstNameInShop
            // 
            this.txtFirstNameInShop.Location = new System.Drawing.Point(126, 42);
            this.txtFirstNameInShop.Name = "txtFirstNameInShop";
            this.txtFirstNameInShop.Size = new System.Drawing.Size(130, 22);
            this.txtFirstNameInShop.TabIndex = 2;
            // 
            // txtLastNameInShop
            // 
            this.txtLastNameInShop.Location = new System.Drawing.Point(126, 73);
            this.txtLastNameInShop.Name = "txtLastNameInShop";
            this.txtLastNameInShop.Size = new System.Drawing.Size(130, 22);
            this.txtLastNameInShop.TabIndex = 3;
            // 
            // btnPayInShop
            // 
            this.btnPayInShop.Location = new System.Drawing.Point(86, 126);
            this.btnPayInShop.Name = "btnPayInShop";
            this.btnPayInShop.Size = new System.Drawing.Size(127, 51);
            this.btnPayInShop.TabIndex = 4;
            this.btnPayInShop.Text = "Proceed to payment";
            this.btnPayInShop.UseVisualStyleBackColor = true;
            this.btnPayInShop.Click += new System.EventHandler(this.btnPayInShop_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "First Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Last Name:";
            // 
            // txtFirstNameDelivery
            // 
            this.txtFirstNameDelivery.Location = new System.Drawing.Point(130, 42);
            this.txtFirstNameDelivery.Name = "txtFirstNameDelivery";
            this.txtFirstNameDelivery.Size = new System.Drawing.Size(130, 22);
            this.txtFirstNameDelivery.TabIndex = 5;
            // 
            // txtLastNameDelivery
            // 
            this.txtLastNameDelivery.Location = new System.Drawing.Point(130, 73);
            this.txtLastNameDelivery.Name = "txtLastNameDelivery";
            this.txtLastNameDelivery.Size = new System.Drawing.Size(130, 22);
            this.txtLastNameDelivery.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(168, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Requested delivery Date:";
            // 
            // dtpDeliveryDate
            // 
            this.dtpDeliveryDate.Location = new System.Drawing.Point(25, 145);
            this.dtpDeliveryDate.Name = "dtpDeliveryDate";
            this.dtpDeliveryDate.Size = new System.Drawing.Size(200, 22);
            this.dtpDeliveryDate.TabIndex = 7;
            // 
            // btnPayDelivery
            // 
            this.btnPayDelivery.Location = new System.Drawing.Point(216, 195);
            this.btnPayDelivery.Name = "btnPayDelivery";
            this.btnPayDelivery.Size = new System.Drawing.Size(127, 51);
            this.btnPayDelivery.TabIndex = 5;
            this.btnPayDelivery.Text = "Proceed to payment";
            this.btnPayDelivery.UseVisualStyleBackColor = true;
            this.btnPayDelivery.Click += new System.EventHandler(this.btnPayDelivery_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(279, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 17);
            this.label8.TabIndex = 8;
            this.label8.Text = "Address:";
            // 
            // txtAddressDelivery
            // 
            this.txtAddressDelivery.Location = new System.Drawing.Point(356, 39);
            this.txtAddressDelivery.Name = "txtAddressDelivery";
            this.txtAddressDelivery.Size = new System.Drawing.Size(161, 22);
            this.txtAddressDelivery.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(279, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 17);
            this.label9.TabIndex = 10;
            this.label9.Text = "City:";
            // 
            // txtCityDelivery
            // 
            this.txtCityDelivery.Location = new System.Drawing.Point(356, 76);
            this.txtCityDelivery.Name = "txtCityDelivery";
            this.txtCityDelivery.Size = new System.Drawing.Size(161, 22);
            this.txtCityDelivery.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(279, 114);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 17);
            this.label10.TabIndex = 12;
            this.label10.Text = "Post Code:";
            // 
            // txtPCDelivery
            // 
            this.txtPCDelivery.Location = new System.Drawing.Point(387, 111);
            this.txtPCDelivery.Name = "txtPCDelivery";
            this.txtPCDelivery.Size = new System.Drawing.Size(130, 22);
            this.txtPCDelivery.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label11.CausesValidation = false;
            this.label11.Location = new System.Drawing.Point(394, 187);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(537, 2);
            this.label11.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Sports_Store.Properties.Resources.Sport_2000_logo;
            this.pictureBox1.Location = new System.Drawing.Point(667, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(369, 73);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // CheckOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 563);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.gbInShop);
            this.Controls.Add(this.gbHomeDelivery);
            this.Controls.Add(this.rbtnInShopDelivery);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rbtnHomeDelivery);
            this.Controls.Add(this.btnEditOrder);
            this.Controls.Add(this.btnGoBack);
            this.Controls.Add(this.txtTotalAmount);
            this.Controls.Add(this.txtItemCount);
            this.Controls.Add(this.rtbCheckOutBasket);
            this.Controls.Add(this.label1);
            this.Name = "CheckOut";
            this.Text = "CheckOut";
            this.gbHomeDelivery.ResumeLayout(false);
            this.gbHomeDelivery.PerformLayout();
            this.gbInShop.ResumeLayout(false);
            this.gbInShop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtbCheckOutBasket;
        private System.Windows.Forms.Label txtItemCount;
        private System.Windows.Forms.Label txtTotalAmount;
        private System.Windows.Forms.Button btnGoBack;
        private System.Windows.Forms.Button btnEditOrder;
        private System.Windows.Forms.RadioButton rbtnHomeDelivery;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbtnInShopDelivery;
        private System.Windows.Forms.GroupBox gbHomeDelivery;
        private System.Windows.Forms.GroupBox gbInShop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPayInShop;
        private System.Windows.Forms.TextBox txtLastNameInShop;
        private System.Windows.Forms.TextBox txtFirstNameInShop;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnPayDelivery;
        private System.Windows.Forms.DateTimePicker dtpDeliveryDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtLastNameDelivery;
        private System.Windows.Forms.TextBox txtFirstNameDelivery;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPCDelivery;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCityDelivery;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtAddressDelivery;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}