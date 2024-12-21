
namespace TechFix.Store_Staff
{
    partial class StaffHomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffHomePage));
            this.store_close = new System.Windows.Forms.Label();
            this.wel_supp = new System.Windows.Forms.Label();
            this.Store_oder = new System.Windows.Forms.Label();
            this.Store_Qote = new System.Windows.Forms.Label();
            this.Store_prod = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableAdapterManager1 = new TechFix.AppDataTableAdapters.TableAdapterManager();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // store_close
            // 
            this.store_close.AutoSize = true;
            this.store_close.BackColor = System.Drawing.Color.Red;
            this.store_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.store_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.store_close.ForeColor = System.Drawing.Color.Black;
            this.store_close.Location = new System.Drawing.Point(809, 662);
            this.store_close.Name = "store_close";
            this.store_close.Size = new System.Drawing.Size(84, 24);
            this.store_close.TabIndex = 11;
            this.store_close.Text = "Log Out";
            this.store_close.Click += new System.EventHandler(this.reg_close_Click);
            // 
            // wel_supp
            // 
            this.wel_supp.AutoSize = true;
            this.wel_supp.Font = new System.Drawing.Font("PanRoman", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.wel_supp.ForeColor = System.Drawing.Color.Red;
            this.wel_supp.Location = new System.Drawing.Point(124, 37);
            this.wel_supp.Name = "wel_supp";
            this.wel_supp.Size = new System.Drawing.Size(624, 39);
            this.wel_supp.TabIndex = 18;
            this.wel_supp.Text = "Welcome to TechFix staff home page";
            // 
            // Store_oder
            // 
            this.Store_oder.AutoSize = true;
            this.Store_oder.Font = new System.Drawing.Font("PanRoman", 22.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.Store_oder.ForeColor = System.Drawing.Color.Red;
            this.Store_oder.Location = new System.Drawing.Point(143, 569);
            this.Store_oder.Name = "Store_oder";
            this.Store_oder.Size = new System.Drawing.Size(119, 39);
            this.Store_oder.TabIndex = 16;
            this.Store_oder.Text = "Orders";
            this.Store_oder.Click += new System.EventHandler(this.Store_oder_Click);
            // 
            // Store_Qote
            // 
            this.Store_Qote.AutoSize = true;
            this.Store_Qote.Font = new System.Drawing.Font("PanRoman", 22.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.Store_Qote.ForeColor = System.Drawing.Color.Red;
            this.Store_Qote.Location = new System.Drawing.Point(568, 289);
            this.Store_Qote.Name = "Store_Qote";
            this.Store_Qote.Size = new System.Drawing.Size(168, 39);
            this.Store_Qote.TabIndex = 14;
            this.Store_Qote.Text = "Quotation";
            this.Store_Qote.Click += new System.EventHandler(this.Store_Qote_Click);
            // 
            // Store_prod
            // 
            this.Store_prod.AutoSize = true;
            this.Store_prod.Font = new System.Drawing.Font("PanRoman", 22.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.Store_prod.ForeColor = System.Drawing.Color.Red;
            this.Store_prod.Location = new System.Drawing.Point(124, 289);
            this.Store_prod.Name = "Store_prod";
            this.Store_prod.Size = new System.Drawing.Size(138, 39);
            this.Store_prod.TabIndex = 12;
            this.Store_prod.Text = "Product";
            this.Store_prod.Click += new System.EventHandler(this.Store_prod_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("PanRoman", 22.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(580, 569);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 39);
            this.label1.TabIndex = 19;
            this.label1.Text = "Add Supplier";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.tbllogTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = TechFix.AppDataTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(564, 360);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(254, 206);
            this.pictureBox4.TabIndex = 20;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(109, 360);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(238, 206);
            this.pictureBox3.TabIndex = 17;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(564, 93);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(254, 193);
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(108, 93);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(213, 194);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // StaffHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(932, 712);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.wel_supp);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.Store_oder);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Store_Qote);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Store_prod);
            this.Controls.Add(this.store_close);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForeColor = System.Drawing.Color.Red;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StaffHomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StaffHomePage";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label store_close;
        private System.Windows.Forms.Label wel_supp;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label Store_oder;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label Store_Qote;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Store_prod;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label1;
        private AppDataTableAdapters.TableAdapterManager tableAdapterManager1;
    }
}