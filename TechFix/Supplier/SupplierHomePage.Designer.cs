
namespace TechFix.Supplier
{
    partial class SupplierHomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SupplierHomePage));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Supp_close = new System.Windows.Forms.Label();
            this.wel_supp = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.sup_oder = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.sup_Qote = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.supp_prod = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Lime;
            this.panel1.Controls.Add(this.wel_supp);
            this.panel1.Controls.Add(this.sup_Qote);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.Supp_close);
            this.panel1.Controls.Add(this.supp_prod);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.sup_oder);
            this.panel1.Location = new System.Drawing.Point(-4, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(861, 564);
            this.panel1.TabIndex = 0;
            // 
            // Supp_close
            // 
            this.Supp_close.AutoSize = true;
            this.Supp_close.BackColor = System.Drawing.Color.Red;
            this.Supp_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Supp_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Supp_close.ForeColor = System.Drawing.Color.Black;
            this.Supp_close.Location = new System.Drawing.Point(719, 508);
            this.Supp_close.Name = "Supp_close";
            this.Supp_close.Size = new System.Drawing.Size(105, 29);
            this.Supp_close.TabIndex = 11;
            this.Supp_close.Text = "Log Out";
            this.Supp_close.Click += new System.EventHandler(this.Supp_close_Click);
            // 
            // wel_supp
            // 
            this.wel_supp.AutoSize = true;
            this.wel_supp.BackColor = System.Drawing.Color.Lime;
            this.wel_supp.Font = new System.Drawing.Font("PanRoman", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.wel_supp.ForeColor = System.Drawing.Color.Red;
            this.wel_supp.Location = new System.Drawing.Point(162, 27);
            this.wel_supp.Name = "wel_supp";
            this.wel_supp.Size = new System.Drawing.Size(538, 39);
            this.wel_supp.TabIndex = 8;
            this.wel_supp.Text = "Welcome to Supplier home page";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(347, 296);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(161, 152);
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // sup_oder
            // 
            this.sup_oder.AutoSize = true;
            this.sup_oder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sup_oder.Font = new System.Drawing.Font("PanRoman", 22.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.sup_oder.ForeColor = System.Drawing.Color.Red;
            this.sup_oder.Location = new System.Drawing.Point(366, 463);
            this.sup_oder.Name = "sup_oder";
            this.sup_oder.Size = new System.Drawing.Size(119, 39);
            this.sup_oder.TabIndex = 6;
            this.sup_oder.Text = "Orders";
            this.sup_oder.Click += new System.EventHandler(this.sup_oder_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(582, 106);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(161, 152);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // sup_Qote
            // 
            this.sup_Qote.AutoSize = true;
            this.sup_Qote.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sup_Qote.Font = new System.Drawing.Font("PanRoman", 22.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.sup_Qote.ForeColor = System.Drawing.Color.Red;
            this.sup_Qote.Location = new System.Drawing.Point(575, 261);
            this.sup_Qote.Name = "sup_Qote";
            this.sup_Qote.Size = new System.Drawing.Size(168, 39);
            this.sup_Qote.TabIndex = 4;
            this.sup_Qote.Text = "Quotation";
            this.sup_Qote.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(113, 106);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(154, 152);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // supp_prod
            // 
            this.supp_prod.AutoSize = true;
            this.supp_prod.Cursor = System.Windows.Forms.Cursors.Hand;
            this.supp_prod.Font = new System.Drawing.Font("PanRoman", 22.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.supp_prod.ForeColor = System.Drawing.Color.Red;
            this.supp_prod.Location = new System.Drawing.Point(117, 258);
            this.supp_prod.Name = "supp_prod";
            this.supp_prod.Size = new System.Drawing.Size(138, 39);
            this.supp_prod.TabIndex = 2;
            this.supp_prod.Text = "Product";
            this.supp_prod.Click += new System.EventHandler(this.supp_prod_Click);
            // 
            // SupplierHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 558);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SupplierHomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SupplierHomePage";
            this.Load += new System.EventHandler(this.SupplierHomePage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label supp_prod;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label sup_Qote;
        private System.Windows.Forms.Label wel_supp;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label sup_oder;
        private System.Windows.Forms.Label Supp_close;
    }
}