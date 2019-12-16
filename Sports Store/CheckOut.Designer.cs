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
            this.rtbCheckOutBasket.Size = new System.Drawing.Size(333, 277);
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
            // CheckOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 450);
            this.Controls.Add(this.btnEditOrder);
            this.Controls.Add(this.btnGoBack);
            this.Controls.Add(this.txtTotalAmount);
            this.Controls.Add(this.txtItemCount);
            this.Controls.Add(this.rtbCheckOutBasket);
            this.Controls.Add(this.label1);
            this.Name = "CheckOut";
            this.Text = "CheckOut";
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
    }
}