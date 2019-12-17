namespace Sports_Store
{
    partial class Payment
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
            this.txtThanks = new System.Windows.Forms.Label();
            this.txtDetails = new System.Windows.Forms.Label();
            this.rtbItemList = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtAddress = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtThankYou = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnOpenReceipt = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtThanks
            // 
            this.txtThanks.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThanks.ForeColor = System.Drawing.Color.Green;
            this.txtThanks.Location = new System.Drawing.Point(66, 34);
            this.txtThanks.MaximumSize = new System.Drawing.Size(500, 0);
            this.txtThanks.Name = "txtThanks";
            this.txtThanks.Size = new System.Drawing.Size(478, 0);
            this.txtThanks.TabIndex = 0;
            this.txtThanks.Text = "label1";
            this.txtThanks.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtThanks.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtDetails
            // 
            this.txtDetails.AutoSize = true;
            this.txtDetails.Location = new System.Drawing.Point(68, 110);
            this.txtDetails.MaximumSize = new System.Drawing.Size(500, 0);
            this.txtDetails.Name = "txtDetails";
            this.txtDetails.Size = new System.Drawing.Size(46, 17);
            this.txtDetails.TabIndex = 1;
            this.txtDetails.Text = "label1";
            // 
            // rtbItemList
            // 
            this.rtbItemList.BackColor = System.Drawing.Color.White;
            this.rtbItemList.Location = new System.Drawing.Point(72, 322);
            this.rtbItemList.Name = "rtbItemList";
            this.rtbItemList.ReadOnly = true;
            this.rtbItemList.Size = new System.Drawing.Size(473, 169);
            this.rtbItemList.TabIndex = 2;
            this.rtbItemList.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(248, 293);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Order Resume";
            // 
            // txtTotal
            // 
            this.txtTotal.AutoSize = true;
            this.txtTotal.Location = new System.Drawing.Point(438, 503);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(48, 17);
            this.txtTotal.TabIndex = 4;
            this.txtTotal.Text = "Total: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Location = new System.Drawing.Point(71, 167);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(302, 100);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Address";
            // 
            // txtAddress
            // 
            this.txtAddress.AutoSize = true;
            this.txtAddress.Location = new System.Drawing.Point(28, 34);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(46, 17);
            this.txtAddress.TabIndex = 0;
            this.txtAddress.Text = "label2";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(400, 167);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(144, 100);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Payment method";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Credit Card";
            // 
            // txtThankYou
            // 
            this.txtThankYou.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThankYou.ForeColor = System.Drawing.Color.DarkRed;
            this.txtThankYou.Location = new System.Drawing.Point(71, 34);
            this.txtThankYou.Name = "txtThankYou";
            this.txtThankYou.Size = new System.Drawing.Size(474, 23);
            this.txtThankYou.TabIndex = 7;
            this.txtThankYou.Text = "label3";
            this.txtThankYou.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Black;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(70, 533);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(165, 46);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Go Back to Store";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnOpenReceipt
            // 
            this.btnOpenReceipt.BackColor = System.Drawing.Color.DarkRed;
            this.btnOpenReceipt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenReceipt.ForeColor = System.Drawing.Color.White;
            this.btnOpenReceipt.Location = new System.Drawing.Point(251, 533);
            this.btnOpenReceipt.Name = "btnOpenReceipt";
            this.btnOpenReceipt.Size = new System.Drawing.Size(114, 46);
            this.btnOpenReceipt.TabIndex = 9;
            this.btnOpenReceipt.Text = "Open Receipt";
            this.btnOpenReceipt.UseVisualStyleBackColor = false;
            this.btnOpenReceipt.Click += new System.EventHandler(this.btnOpenReceipt_Click);
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(621, 603);
            this.Controls.Add(this.btnOpenReceipt);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtThankYou);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtbItemList);
            this.Controls.Add(this.txtDetails);
            this.Controls.Add(this.txtThanks);
            this.Name = "Payment";
            this.Text = "Payment";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtThanks;
        private System.Windows.Forms.Label txtDetails;
        private System.Windows.Forms.RichTextBox rtbItemList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtTotal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label txtAddress;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txtThankYou;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnOpenReceipt;
    }
}