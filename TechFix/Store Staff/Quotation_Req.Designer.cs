
namespace TechFix.Store_Staff
{
    partial class Quotation_Req
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
            this.wel_supp = new System.Windows.Forms.Label();
            this.Quotation_id = new System.Windows.Forms.Label();
            this.Supp_nam_Quo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tblquotationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.techFixDBDataSet1 = new TechFix.TechFixDBDataSet1();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tblquotationsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_new = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.dgv_quotations = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suppliernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productsandquntityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specialnoteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tblquotationsTableAdapter = new TechFix.TechFixDBDataSet1TableAdapters.tblquotationsTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.techFixDBDataset_Sup = new TechFix.TechFixDBDataset_Sup();
            this.tblsupquotationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblsupquotationTableAdapter = new TechFix.TechFixDBDataset_SupTableAdapters.tblsupquotationTableAdapter();
            this.suppliernameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitprice1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quntity1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quntity2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitprice2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitprice3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quntity3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitprice4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quntity4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalpriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.tblquotationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.techFixDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblquotationsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_quotations)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.techFixDBDataset_Sup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblsupquotationBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // wel_supp
            // 
            this.wel_supp.AutoSize = true;
            this.wel_supp.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.wel_supp.Font = new System.Drawing.Font("PanRoman", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.wel_supp.ForeColor = System.Drawing.Color.Red;
            this.wel_supp.Location = new System.Drawing.Point(12, 24);
            this.wel_supp.Name = "wel_supp";
            this.wel_supp.Size = new System.Drawing.Size(329, 39);
            this.wel_supp.TabIndex = 19;
            this.wel_supp.Text = "Request Quotations";
            this.wel_supp.Click += new System.EventHandler(this.wel_supp_Click);
            // 
            // Quotation_id
            // 
            this.Quotation_id.AutoSize = true;
            this.Quotation_id.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Quotation_id.ForeColor = System.Drawing.SystemColors.Control;
            this.Quotation_id.Location = new System.Drawing.Point(33, 114);
            this.Quotation_id.Name = "Quotation_id";
            this.Quotation_id.Size = new System.Drawing.Size(89, 17);
            this.Quotation_id.TabIndex = 20;
            this.Quotation_id.Text = "Quotation_id";
            // 
            // Supp_nam_Quo
            // 
            this.Supp_nam_Quo.AutoSize = true;
            this.Supp_nam_Quo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Supp_nam_Quo.ForeColor = System.Drawing.SystemColors.Control;
            this.Supp_nam_Quo.Location = new System.Drawing.Point(33, 154);
            this.Supp_nam_Quo.Name = "Supp_nam_Quo";
            this.Supp_nam_Quo.Size = new System.Drawing.Size(101, 17);
            this.Supp_nam_Quo.TabIndex = 21;
            this.Supp_nam_Quo.Text = "Supplier Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(33, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 17);
            this.label4.TabIndex = 23;
            this.label4.Text = "Products & Quantity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 17);
            this.label5.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(36, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 25;
            this.label1.Text = "Special Note";
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblquotationsBindingSource, "Id", true));
            this.textBox1.Location = new System.Drawing.Point(164, 109);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(233, 22);
            this.textBox1.TabIndex = 26;
            // 
            // tblquotationsBindingSource
            // 
            this.tblquotationsBindingSource.DataMember = "tblquotations";
            this.tblquotationsBindingSource.DataSource = this.techFixDBDataSet1;
            // 
            // techFixDBDataSet1
            // 
            this.techFixDBDataSet1.DataSetName = "TechFixDBDataSet1";
            this.techFixDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblquotationsBindingSource1, "suppliername", true));
            this.textBox2.Location = new System.Drawing.Point(164, 149);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(233, 22);
            this.textBox2.TabIndex = 27;
            // 
            // tblquotationsBindingSource1
            // 
            this.tblquotationsBindingSource1.DataMember = "tblquotations";
            this.tblquotationsBindingSource1.DataSource = this.techFixDBDataSet1;
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.tblquotationsBindingSource, "specialnote", true));
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblquotationsBindingSource1, "specialnote", true));
            this.textBox4.Location = new System.Drawing.Point(167, 242);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(233, 22);
            this.textBox4.TabIndex = 32;
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.SystemColors.Info;
            this.btn_cancel.Location = new System.Drawing.Point(116, 516);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(125, 41);
            this.btn_cancel.TabIndex = 37;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(590, 289);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 41);
            this.button1.TabIndex = 38;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_new
            // 
            this.btn_new.BackColor = System.Drawing.Color.Yellow;
            this.btn_new.Location = new System.Drawing.Point(36, 347);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(125, 41);
            this.btn_new.TabIndex = 33;
            this.btn_new.Text = "New";
            this.btn_new.UseVisualStyleBackColor = false;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.Lime;
            this.btn_save.Location = new System.Drawing.Point(216, 347);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(125, 41);
            this.btn_save.TabIndex = 35;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Red;
            this.btn_delete.Location = new System.Drawing.Point(216, 427);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(125, 41);
            this.btn_delete.TabIndex = 36;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.Color.LawnGreen;
            this.btn_edit.Location = new System.Drawing.Point(36, 427);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(125, 41);
            this.btn_edit.TabIndex = 34;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // dgv_quotations
            // 
            this.dgv_quotations.AutoGenerateColumns = false;
            this.dgv_quotations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_quotations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.suppliernameDataGridViewTextBoxColumn,
            this.productsandquntityDataGridViewTextBoxColumn,
            this.specialnoteDataGridViewTextBoxColumn});
            this.dgv_quotations.DataSource = this.tblquotationsBindingSource1;
            this.dgv_quotations.Location = new System.Drawing.Point(436, 358);
            this.dgv_quotations.Name = "dgv_quotations";
            this.dgv_quotations.RowHeadersWidth = 51;
            this.dgv_quotations.RowTemplate.Height = 24;
            this.dgv_quotations.Size = new System.Drawing.Size(719, 215);
            this.dgv_quotations.TabIndex = 39;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Quotation Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // suppliernameDataGridViewTextBoxColumn
            // 
            this.suppliernameDataGridViewTextBoxColumn.DataPropertyName = "suppliername";
            this.suppliernameDataGridViewTextBoxColumn.HeaderText = "Supplier Name";
            this.suppliernameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.suppliernameDataGridViewTextBoxColumn.Name = "suppliernameDataGridViewTextBoxColumn";
            this.suppliernameDataGridViewTextBoxColumn.Width = 125;
            // 
            // productsandquntityDataGridViewTextBoxColumn
            // 
            this.productsandquntityDataGridViewTextBoxColumn.DataPropertyName = "productsandquntity";
            this.productsandquntityDataGridViewTextBoxColumn.HeaderText = "Products and Quntity";
            this.productsandquntityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productsandquntityDataGridViewTextBoxColumn.Name = "productsandquntityDataGridViewTextBoxColumn";
            this.productsandquntityDataGridViewTextBoxColumn.Width = 125;
            // 
            // specialnoteDataGridViewTextBoxColumn
            // 
            this.specialnoteDataGridViewTextBoxColumn.DataPropertyName = "specialnote";
            this.specialnoteDataGridViewTextBoxColumn.HeaderText = "Special Note";
            this.specialnoteDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.specialnoteDataGridViewTextBoxColumn.Name = "specialnoteDataGridViewTextBoxColumn";
            this.specialnoteDataGridViewTextBoxColumn.Width = 125;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.btn_cancel);
            this.panel1.Controls.Add(this.btn_new);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.wel_supp);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.btn_save);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.btn_delete);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.Supp_nam_Quo);
            this.panel1.Controls.Add(this.btn_edit);
            this.panel1.Controls.Add(this.Quotation_id);
            this.panel1.Location = new System.Drawing.Point(0, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(430, 635);
            this.panel1.TabIndex = 40;
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblquotationsBindingSource1, "productsandquntity", true));
            this.textBox3.Location = new System.Drawing.Point(167, 194);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(233, 22);
            this.textBox3.TabIndex = 26;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Desktop;
            this.label2.Font = new System.Drawing.Font("PanRoman", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(445, 307);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(459, 39);
            this.label2.TabIndex = 41;
            this.label2.Text = "Request Quotations History";
            // 
            // tblquotationsTableAdapter
            // 
            this.tblquotationsTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.MenuBar;
            this.label3.Font = new System.Drawing.Font("PanRoman", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(445, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(465, 39);
            this.label3.TabIndex = 42;
            this.label3.Text = "List of Quotations Received";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.suppliernameDataGridViewTextBoxColumn1,
            this.product1DataGridViewTextBoxColumn,
            this.unitprice1DataGridViewTextBoxColumn,
            this.quntity1DataGridViewTextBoxColumn,
            this.product2DataGridViewTextBoxColumn,
            this.quntity2DataGridViewTextBoxColumn,
            this.unitprice2DataGridViewTextBoxColumn,
            this.product3DataGridViewTextBoxColumn,
            this.unitprice3DataGridViewTextBoxColumn,
            this.quntity3DataGridViewTextBoxColumn,
            this.product4DataGridViewTextBoxColumn,
            this.unitprice4DataGridViewTextBoxColumn,
            this.quntity4DataGridViewTextBoxColumn,
            this.discountDataGridViewTextBoxColumn,
            this.totalpriceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblsupquotationBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(436, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(715, 237);
            this.dataGridView1.TabIndex = 43;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // techFixDBDataset_Sup
            // 
            this.techFixDBDataset_Sup.DataSetName = "TechFixDBDataset_Sup";
            this.techFixDBDataset_Sup.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblsupquotationBindingSource
            // 
            this.tblsupquotationBindingSource.DataMember = "tblsupquotation";
            this.tblsupquotationBindingSource.DataSource = this.techFixDBDataset_Sup;
            // 
            // tblsupquotationTableAdapter
            // 
            this.tblsupquotationTableAdapter.ClearBeforeFill = true;
            // 
            // suppliernameDataGridViewTextBoxColumn1
            // 
            this.suppliernameDataGridViewTextBoxColumn1.DataPropertyName = "suppliername";
            this.suppliernameDataGridViewTextBoxColumn1.HeaderText = "suppliername";
            this.suppliernameDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.suppliernameDataGridViewTextBoxColumn1.Name = "suppliernameDataGridViewTextBoxColumn1";
            this.suppliernameDataGridViewTextBoxColumn1.Width = 80;
            // 
            // product1DataGridViewTextBoxColumn
            // 
            this.product1DataGridViewTextBoxColumn.DataPropertyName = "product1";
            this.product1DataGridViewTextBoxColumn.HeaderText = "product1";
            this.product1DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.product1DataGridViewTextBoxColumn.Name = "product1DataGridViewTextBoxColumn";
            this.product1DataGridViewTextBoxColumn.Width = 60;
            // 
            // unitprice1DataGridViewTextBoxColumn
            // 
            this.unitprice1DataGridViewTextBoxColumn.DataPropertyName = "unitprice1";
            this.unitprice1DataGridViewTextBoxColumn.HeaderText = "unitprice1";
            this.unitprice1DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.unitprice1DataGridViewTextBoxColumn.Name = "unitprice1DataGridViewTextBoxColumn";
            this.unitprice1DataGridViewTextBoxColumn.Width = 60;
            // 
            // quntity1DataGridViewTextBoxColumn
            // 
            this.quntity1DataGridViewTextBoxColumn.DataPropertyName = "Quntity1";
            this.quntity1DataGridViewTextBoxColumn.HeaderText = "Quntity1";
            this.quntity1DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.quntity1DataGridViewTextBoxColumn.Name = "quntity1DataGridViewTextBoxColumn";
            this.quntity1DataGridViewTextBoxColumn.Width = 60;
            // 
            // product2DataGridViewTextBoxColumn
            // 
            this.product2DataGridViewTextBoxColumn.DataPropertyName = "product2";
            this.product2DataGridViewTextBoxColumn.HeaderText = "product2";
            this.product2DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.product2DataGridViewTextBoxColumn.Name = "product2DataGridViewTextBoxColumn";
            this.product2DataGridViewTextBoxColumn.Width = 60;
            // 
            // quntity2DataGridViewTextBoxColumn
            // 
            this.quntity2DataGridViewTextBoxColumn.DataPropertyName = "Quntity2";
            this.quntity2DataGridViewTextBoxColumn.HeaderText = "Quntity2";
            this.quntity2DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.quntity2DataGridViewTextBoxColumn.Name = "quntity2DataGridViewTextBoxColumn";
            this.quntity2DataGridViewTextBoxColumn.Width = 60;
            // 
            // unitprice2DataGridViewTextBoxColumn
            // 
            this.unitprice2DataGridViewTextBoxColumn.DataPropertyName = "unitprice2";
            this.unitprice2DataGridViewTextBoxColumn.HeaderText = "unitprice2";
            this.unitprice2DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.unitprice2DataGridViewTextBoxColumn.Name = "unitprice2DataGridViewTextBoxColumn";
            this.unitprice2DataGridViewTextBoxColumn.Width = 60;
            // 
            // product3DataGridViewTextBoxColumn
            // 
            this.product3DataGridViewTextBoxColumn.DataPropertyName = "product3";
            this.product3DataGridViewTextBoxColumn.HeaderText = "product3";
            this.product3DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.product3DataGridViewTextBoxColumn.Name = "product3DataGridViewTextBoxColumn";
            this.product3DataGridViewTextBoxColumn.Width = 60;
            // 
            // unitprice3DataGridViewTextBoxColumn
            // 
            this.unitprice3DataGridViewTextBoxColumn.DataPropertyName = "unitprice3";
            this.unitprice3DataGridViewTextBoxColumn.HeaderText = "unitprice3";
            this.unitprice3DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.unitprice3DataGridViewTextBoxColumn.Name = "unitprice3DataGridViewTextBoxColumn";
            this.unitprice3DataGridViewTextBoxColumn.Width = 60;
            // 
            // quntity3DataGridViewTextBoxColumn
            // 
            this.quntity3DataGridViewTextBoxColumn.DataPropertyName = "Quntity3";
            this.quntity3DataGridViewTextBoxColumn.HeaderText = "Quntity3";
            this.quntity3DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.quntity3DataGridViewTextBoxColumn.Name = "quntity3DataGridViewTextBoxColumn";
            this.quntity3DataGridViewTextBoxColumn.Width = 60;
            // 
            // product4DataGridViewTextBoxColumn
            // 
            this.product4DataGridViewTextBoxColumn.DataPropertyName = "product4";
            this.product4DataGridViewTextBoxColumn.HeaderText = "product4";
            this.product4DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.product4DataGridViewTextBoxColumn.Name = "product4DataGridViewTextBoxColumn";
            this.product4DataGridViewTextBoxColumn.Width = 60;
            // 
            // unitprice4DataGridViewTextBoxColumn
            // 
            this.unitprice4DataGridViewTextBoxColumn.DataPropertyName = "unitprice4";
            this.unitprice4DataGridViewTextBoxColumn.HeaderText = "unitprice4";
            this.unitprice4DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.unitprice4DataGridViewTextBoxColumn.Name = "unitprice4DataGridViewTextBoxColumn";
            this.unitprice4DataGridViewTextBoxColumn.Width = 60;
            // 
            // quntity4DataGridViewTextBoxColumn
            // 
            this.quntity4DataGridViewTextBoxColumn.DataPropertyName = "Quntity4";
            this.quntity4DataGridViewTextBoxColumn.HeaderText = "Quntity4";
            this.quntity4DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.quntity4DataGridViewTextBoxColumn.Name = "quntity4DataGridViewTextBoxColumn";
            this.quntity4DataGridViewTextBoxColumn.Width = 60;
            // 
            // discountDataGridViewTextBoxColumn
            // 
            this.discountDataGridViewTextBoxColumn.DataPropertyName = "Discount";
            this.discountDataGridViewTextBoxColumn.HeaderText = "Discount";
            this.discountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.discountDataGridViewTextBoxColumn.Name = "discountDataGridViewTextBoxColumn";
            this.discountDataGridViewTextBoxColumn.Width = 60;
            // 
            // totalpriceDataGridViewTextBoxColumn
            // 
            this.totalpriceDataGridViewTextBoxColumn.DataPropertyName = "totalprice";
            this.totalpriceDataGridViewTextBoxColumn.HeaderText = "totalprice";
            this.totalpriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalpriceDataGridViewTextBoxColumn.Name = "totalpriceDataGridViewTextBoxColumn";
            this.totalpriceDataGridViewTextBoxColumn.Width = 60;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(426, 294);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(736, 338);
            this.panel2.TabIndex = 38;
            // 
            // Quotation_Req
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 632);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgv_quotations);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Quotation_Req";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quotation_Req";
            this.Load += new System.EventHandler(this.Quotation_Req_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblquotationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.techFixDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblquotationsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_quotations)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.techFixDBDataset_Sup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblsupquotationBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label wel_supp;
        private System.Windows.Forms.Label Quotation_id;
        private System.Windows.Forms.Label Supp_nam_Quo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.DataGridView dgv_quotations;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private TechFixDBDataSet1 techFixDBDataSet1;
        private System.Windows.Forms.BindingSource tblquotationsBindingSource;
        private TechFixDBDataSet1TableAdapters.tblquotationsTableAdapter tblquotationsTableAdapter;
        private System.Windows.Forms.BindingSource tblquotationsBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn suppliernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productsandquntityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn specialnoteDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private TechFixDBDataset_Sup techFixDBDataset_Sup;
        private System.Windows.Forms.BindingSource tblsupquotationBindingSource;
        private TechFixDBDataset_SupTableAdapters.tblsupquotationTableAdapter tblsupquotationTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn suppliernameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn product1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitprice1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quntity1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn product2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quntity2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitprice2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn product3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitprice3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quntity3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn product4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitprice4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quntity4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn discountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalpriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
    }
}