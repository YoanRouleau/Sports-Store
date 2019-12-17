namespace Sports_Store
{
    partial class Shop
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgvItemList = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.Label();
            this.cbFilterByCategory = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClearBasket = new System.Windows.Forms.Button();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.dgvBasket = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.itemBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBasket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvItemList
            // 
            this.dgvItemList.AutoGenerateColumns = false;
            this.dgvItemList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItemList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.dgvItemList.DataSource = this.itemBindingSource;
            this.dgvItemList.Location = new System.Drawing.Point(187, 182);
            this.dgvItemList.Name = "dgvItemList";
            this.dgvItemList.ReadOnly = true;
            this.dgvItemList.RowHeadersVisible = false;
            this.dgvItemList.RowTemplate.Height = 35;
            this.dgvItemList.Size = new System.Drawing.Size(707, 378);
            this.dgvItemList.TabIndex = 3;
            this.dgvItemList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItemList_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(1176, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Basket";
            // 
            // txtAmount
            // 
            this.txtAmount.AutoSize = true;
            this.txtAmount.Location = new System.Drawing.Point(1349, 425);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(48, 17);
            this.txtAmount.TabIndex = 7;
            this.txtAmount.Text = "Total: ";
            // 
            // cbFilterByCategory
            // 
            this.cbFilterByCategory.FormattingEnabled = true;
            this.cbFilterByCategory.Items.AddRange(new object[] {
            "All",
            "Sports Clothing",
            "Foot Wear",
            "Gym Equipment",
            "Accessories"});
            this.cbFilterByCategory.Location = new System.Drawing.Point(30, 212);
            this.cbFilterByCategory.Name = "cbFilterByCategory";
            this.cbFilterByCategory.Size = new System.Drawing.Size(127, 24);
            this.cbFilterByCategory.TabIndex = 8;
            this.cbFilterByCategory.Text = "Category";
            this.cbFilterByCategory.SelectedIndexChanged += new System.EventHandler(this.cbFilterByCategory_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Filter By:";
            // 
            // btnClearBasket
            // 
            this.btnClearBasket.BackColor = System.Drawing.Color.Black;
            this.btnClearBasket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearBasket.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearBasket.ForeColor = System.Drawing.Color.White;
            this.btnClearBasket.Location = new System.Drawing.Point(1176, 458);
            this.btnClearBasket.Name = "btnClearBasket";
            this.btnClearBasket.Size = new System.Drawing.Size(132, 64);
            this.btnClearBasket.TabIndex = 10;
            this.btnClearBasket.Text = "Clear Basket";
            this.btnClearBasket.UseVisualStyleBackColor = false;
            this.btnClearBasket.Click += new System.EventHandler(this.btnClearBasket_Click);
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.BackColor = System.Drawing.Color.DarkRed;
            this.btnCheckOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckOut.ForeColor = System.Drawing.Color.White;
            this.btnCheckOut.Location = new System.Drawing.Point(1330, 458);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(121, 64);
            this.btnCheckOut.TabIndex = 11;
            this.btnCheckOut.Text = "Check-out";
            this.btnCheckOut.UseVisualStyleBackColor = false;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // dgvBasket
            // 
            this.dgvBasket.AutoGenerateColumns = false;
            this.dgvBasket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBasket.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn1,
            this.priceDataGridViewTextBoxColumn1});
            this.dgvBasket.DataSource = this.itemBindingSource3;
            this.dgvBasket.Location = new System.Drawing.Point(965, 182);
            this.dgvBasket.Name = "dgvBasket";
            this.dgvBasket.RowHeadersVisible = false;
            this.dgvBasket.RowTemplate.Height = 24;
            this.dgvBasket.Size = new System.Drawing.Size(486, 231);
            this.dgvBasket.TabIndex = 12;
            this.dgvBasket.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBasket_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(436, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 29);
            this.label2.TabIndex = 13;
            this.label2.Text = "Season\'s collection";
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(36, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(1415, 2);
            this.label5.TabIndex = 15;
            this.label5.Text = "label5";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Sports_Store.Properties.Resources.test2_sport20001;
            this.pictureBox3.Location = new System.Drawing.Point(460, -9);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(1102, 165);
            this.pictureBox3.TabIndex = 18;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Sports_Store.Properties.Resources.Sport_2000_logo;
            this.pictureBox1.Location = new System.Drawing.Point(640, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(369, 73);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Sports_Store.Properties.Resources.test_sport20001;
            this.pictureBox2.Location = new System.Drawing.Point(-4, 230);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(576, 385);
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.Width = 200;
            // 
            // priceDataGridViewTextBoxColumn1
            // 
            this.priceDataGridViewTextBoxColumn1.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn1.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn1.Name = "priceDataGridViewTextBoxColumn1";
            this.priceDataGridViewTextBoxColumn1.Width = 60;
            // 
            // itemBindingSource3
            // 
            this.itemBindingSource3.DataSource = typeof(Sports_Store.Item);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 2;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 40;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 280;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            this.priceDataGridViewTextBoxColumn.Width = 90;
            // 
            // itemBindingSource
            // 
            this.itemBindingSource.DataSource = typeof(Sports_Store.Item);
            // 
            // itemBindingSource2
            // 
            this.itemBindingSource2.DataSource = typeof(Sports_Store.Item);
            // 
            // itemBindingSource1
            // 
            this.itemBindingSource1.DataSource = typeof(Sports_Store.Item);
            // 
            // Shop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1488, 616);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvBasket);
            this.Controls.Add(this.btnCheckOut);
            this.Controls.Add(this.btnClearBasket);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbFilterByCategory);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvItemList);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Name = "Shop";
            this.Text = "Total: ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBasket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvItemList;
        private System.Windows.Forms.BindingSource itemBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txtAmount;
        private System.Windows.Forms.ComboBox cbFilterByCategory;
        private System.Windows.Forms.BindingSource itemBindingSource2;
        private System.Windows.Forms.BindingSource itemBindingSource1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClearBasket;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.DataGridView dgvBasket;
        private System.Windows.Forms.BindingSource itemBindingSource3;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

