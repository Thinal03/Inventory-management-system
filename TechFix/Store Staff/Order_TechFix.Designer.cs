
namespace TechFix.Store_Staff
{
    partial class Order_TechFix
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
            this.components = new System.ComponentModel.Container();
            this.tblquotationsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.techFixDBDataSet1 = new TechFix.TechFixDBDataSet1();
            this.tblquotationsTableAdapter = new TechFix.TechFixDBDataSet1TableAdapters.tblquotationsTableAdapter();
            this.tblquotationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_orders = new System.Windows.Forms.DataGridView();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_new = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.wel_supp = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Supp_nam_Quo = new System.Windows.Forms.Label();
            this.btn_edit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Quotation_id = new System.Windows.Forms.Label();
            this.techFixDBDataSet2 = new TechFix.TechFixDBDataSet2();
            this.tblorderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblorderTableAdapter = new TechFix.TechFixDBDataSet2TableAdapters.tblorderTableAdapter();
            this.tblorderBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tblorderBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tblorderBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.tblorderBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.tblorderBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.tblorderBindingSource6 = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quotationidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suppliernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productandquantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblorderBindingSource7 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tblquotationsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.techFixDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblquotationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_orders)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.techFixDBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblorderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblorderBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblorderBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblorderBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblorderBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblorderBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblorderBindingSource6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblorderBindingSource7)).BeginInit();
            this.SuspendLayout();
            // 
            // tblquotationsBindingSource1
            // 
            this.tblquotationsBindingSource1.DataMember = "tblquotations";
            this.tblquotationsBindingSource1.DataSource = this.techFixDBDataSet1;
            // 
            // techFixDBDataSet1
            // 
            this.techFixDBDataSet1.DataSetName = "TechFixDBDataSet1";
            this.techFixDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblquotationsTableAdapter
            // 
            this.tblquotationsTableAdapter.ClearBeforeFill = true;
            // 
            // tblquotationsBindingSource
            // 
            this.tblquotationsBindingSource.DataMember = "tblquotations";
            this.tblquotationsBindingSource.DataSource = this.techFixDBDataSet1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.MintCream;
            this.label2.Font = new System.Drawing.Font("PanRoman", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(245, 314);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 39);
            this.label2.TabIndex = 56;
            this.label2.Text = "Oder History";
            // 
            // dgv_orders
            // 
            this.dgv_orders.AutoGenerateColumns = false;
            this.dgv_orders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_orders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.quotationidDataGridViewTextBoxColumn,
            this.suppliernameDataGridViewTextBoxColumn,
            this.productandquantityDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.dgv_orders.DataSource = this.tblorderBindingSource6;
            this.dgv_orders.Location = new System.Drawing.Point(40, 356);
            this.dgv_orders.Name = "dgv_orders";
            this.dgv_orders.RowHeadersWidth = 51;
            this.dgv_orders.RowTemplate.Height = 24;
            this.dgv_orders.Size = new System.Drawing.Size(941, 256);
            this.dgv_orders.TabIndex = 54;
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.SystemColors.Info;
            this.btn_cancel.Location = new System.Drawing.Point(816, 97);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(125, 41);
            this.btn_cancel.TabIndex = 52;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(878, 640);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 41);
            this.button1.TabIndex = 53;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_new
            // 
            this.btn_new.BackColor = System.Drawing.Color.Yellow;
            this.btn_new.Location = new System.Drawing.Point(478, 97);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(125, 41);
            this.btn_new.TabIndex = 48;
            this.btn_new.Text = "New";
            this.btn_new.UseVisualStyleBackColor = false;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.Lime;
            this.btn_save.Location = new System.Drawing.Point(553, 178);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(125, 41);
            this.btn_save.TabIndex = 50;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Red;
            this.btn_delete.Location = new System.Drawing.Point(735, 178);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(125, 41);
            this.btn_delete.TabIndex = 51;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.wel_supp);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.Supp_nam_Quo);
            this.panel1.Location = new System.Drawing.Point(-1, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1027, 303);
            this.panel1.TabIndex = 55;
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblorderBindingSource2, "suppliername", true));
            this.textBox3.Location = new System.Drawing.Point(190, 163);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(233, 22);
            this.textBox3.TabIndex = 59;
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblorderBindingSource3, "productandquantity", true));
            this.textBox4.Location = new System.Drawing.Point(190, 204);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(233, 22);
            this.textBox4.TabIndex = 60;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblorderBindingSource1, "quotationid", true));
            this.textBox2.Location = new System.Drawing.Point(190, 119);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(233, 22);
            this.textBox2.TabIndex = 61;
            // 
            // textBox5
            // 
            this.textBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblorderBindingSource4, "price", true));
            this.textBox5.Location = new System.Drawing.Point(190, 241);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(233, 22);
            this.textBox5.TabIndex = 58;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(36, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 17);
            this.label3.TabIndex = 57;
            this.label3.Text = "Quotation_id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(38, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 25;
            this.label1.Text = "Price";
            // 
            // wel_supp
            // 
            this.wel_supp.AutoSize = true;
            this.wel_supp.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.wel_supp.Font = new System.Drawing.Font("PanRoman", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.wel_supp.ForeColor = System.Drawing.Color.Red;
            this.wel_supp.Location = new System.Drawing.Point(34, 20);
            this.wel_supp.Name = "wel_supp";
            this.wel_supp.Size = new System.Drawing.Size(224, 39);
            this.wel_supp.TabIndex = 19;
            this.wel_supp.Text = "Make a Oder";
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblorderBindingSource7, "Id", true));
            this.textBox1.Location = new System.Drawing.Point(190, 81);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(233, 22);
            this.textBox1.TabIndex = 46;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(35, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 17);
            this.label4.TabIndex = 44;
            this.label4.Text = "Products and Quantity";
            // 
            // Supp_nam_Quo
            // 
            this.Supp_nam_Quo.AutoSize = true;
            this.Supp_nam_Quo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Supp_nam_Quo.ForeColor = System.Drawing.SystemColors.Control;
            this.Supp_nam_Quo.Location = new System.Drawing.Point(34, 163);
            this.Supp_nam_Quo.Name = "Supp_nam_Quo";
            this.Supp_nam_Quo.Size = new System.Drawing.Size(101, 17);
            this.Supp_nam_Quo.TabIndex = 43;
            this.Supp_nam_Quo.Text = "Supplier Name";
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.Color.LawnGreen;
            this.btn_edit.Location = new System.Drawing.Point(648, 98);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(125, 41);
            this.btn_edit.TabIndex = 49;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 17);
            this.label5.TabIndex = 45;
            // 
            // Quotation_id
            // 
            this.Quotation_id.AutoSize = true;
            this.Quotation_id.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Quotation_id.ForeColor = System.Drawing.SystemColors.Control;
            this.Quotation_id.Location = new System.Drawing.Point(37, 82);
            this.Quotation_id.Name = "Quotation_id";
            this.Quotation_id.Size = new System.Drawing.Size(59, 17);
            this.Quotation_id.TabIndex = 42;
            this.Quotation_id.Text = "Oder_id";
            this.Quotation_id.Click += new System.EventHandler(this.Quotation_id_Click);
            // 
            // techFixDBDataSet2
            // 
            this.techFixDBDataSet2.DataSetName = "TechFixDBDataSet2";
            this.techFixDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblorderBindingSource
            // 
            this.tblorderBindingSource.DataMember = "tblorder";
            this.tblorderBindingSource.DataSource = this.techFixDBDataSet2;
            // 
            // tblorderTableAdapter
            // 
            this.tblorderTableAdapter.ClearBeforeFill = true;
            // 
            // tblorderBindingSource1
            // 
            this.tblorderBindingSource1.DataMember = "tblorder";
            this.tblorderBindingSource1.DataSource = this.techFixDBDataSet2;
            // 
            // tblorderBindingSource2
            // 
            this.tblorderBindingSource2.DataMember = "tblorder";
            this.tblorderBindingSource2.DataSource = this.techFixDBDataSet2;
            // 
            // tblorderBindingSource3
            // 
            this.tblorderBindingSource3.DataMember = "tblorder";
            this.tblorderBindingSource3.DataSource = this.techFixDBDataSet2;
            // 
            // tblorderBindingSource4
            // 
            this.tblorderBindingSource4.DataMember = "tblorder";
            this.tblorderBindingSource4.DataSource = this.techFixDBDataSet2;
            // 
            // tblorderBindingSource5
            // 
            this.tblorderBindingSource5.DataMember = "tblorder";
            this.tblorderBindingSource5.DataSource = this.techFixDBDataSet2;
            // 
            // tblorderBindingSource6
            // 
            this.tblorderBindingSource6.DataMember = "tblorder";
            this.tblorderBindingSource6.DataSource = this.techFixDBDataSet2;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Order Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 80;
            // 
            // quotationidDataGridViewTextBoxColumn
            // 
            this.quotationidDataGridViewTextBoxColumn.DataPropertyName = "quotationid";
            this.quotationidDataGridViewTextBoxColumn.HeaderText = "Quotation id";
            this.quotationidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.quotationidDataGridViewTextBoxColumn.Name = "quotationidDataGridViewTextBoxColumn";
            this.quotationidDataGridViewTextBoxColumn.Width = 80;
            // 
            // suppliernameDataGridViewTextBoxColumn
            // 
            this.suppliernameDataGridViewTextBoxColumn.DataPropertyName = "suppliername";
            this.suppliernameDataGridViewTextBoxColumn.HeaderText = "Supplier Name";
            this.suppliernameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.suppliernameDataGridViewTextBoxColumn.Name = "suppliernameDataGridViewTextBoxColumn";
            this.suppliernameDataGridViewTextBoxColumn.Width = 125;
            // 
            // productandquantityDataGridViewTextBoxColumn
            // 
            this.productandquantityDataGridViewTextBoxColumn.DataPropertyName = "productandquantity";
            this.productandquantityDataGridViewTextBoxColumn.HeaderText = "Product and Quantity";
            this.productandquantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productandquantityDataGridViewTextBoxColumn.Name = "productandquantityDataGridViewTextBoxColumn";
            this.productandquantityDataGridViewTextBoxColumn.Width = 160;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price(Rs.)";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.Width = 125;
            // 
            // tblorderBindingSource7
            // 
            this.tblorderBindingSource7.DataMember = "tblorder";
            this.tblorderBindingSource7.DataSource = this.techFixDBDataSet2;
            // 
            // Order_TechFix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 697);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgv_orders);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_new);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Quotation_id);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Order_TechFix";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order_TechFix";
            this.Load += new System.EventHandler(this.Order_TechFix_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblquotationsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.techFixDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblquotationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_orders)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.techFixDBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblorderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblorderBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblorderBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblorderBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblorderBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblorderBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblorderBindingSource6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblorderBindingSource7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource tblquotationsBindingSource1;
        private TechFixDBDataSet1 techFixDBDataSet1;
        private TechFixDBDataSet1TableAdapters.tblquotationsTableAdapter tblquotationsTableAdapter;
        private System.Windows.Forms.BindingSource tblquotationsBindingSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_orders;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label wel_supp;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Supp_nam_Quo;
        private System.Windows.Forms.Label Quotation_id;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label3;
        private TechFixDBDataSet2 techFixDBDataSet2;
        private System.Windows.Forms.BindingSource tblorderBindingSource;
        private TechFixDBDataSet2TableAdapters.tblorderTableAdapter tblorderTableAdapter;
        private System.Windows.Forms.BindingSource tblorderBindingSource2;
        private System.Windows.Forms.BindingSource tblorderBindingSource3;
        private System.Windows.Forms.BindingSource tblorderBindingSource1;
        private System.Windows.Forms.BindingSource tblorderBindingSource4;
        private System.Windows.Forms.BindingSource tblorderBindingSource5;
        private System.Windows.Forms.BindingSource tblorderBindingSource6;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quotationidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn suppliernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productandquantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tblorderBindingSource7;
    }
}