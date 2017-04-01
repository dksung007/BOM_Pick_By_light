namespace Manage_BOM.UI
{
    partial class UIMain
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
            this.mt_product_master = new MetroFramework.Controls.MetroTile();
            this.mt_bom_master = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // mt_product_master
            // 
            this.mt_product_master.ActiveControl = null;
            this.mt_product_master.Location = new System.Drawing.Point(71, 63);
            this.mt_product_master.Name = "mt_product_master";
            this.mt_product_master.Size = new System.Drawing.Size(120, 100);
            this.mt_product_master.TabIndex = 0;
            this.mt_product_master.Text = "Product Master";
            this.mt_product_master.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mt_product_master.UseSelectable = true;
            this.mt_product_master.Click += new System.EventHandler(this.mt_product_master_Click);
            // 
            // mt_bom_master
            // 
            this.mt_bom_master.ActiveControl = null;
            this.mt_bom_master.Location = new System.Drawing.Point(197, 63);
            this.mt_bom_master.Name = "mt_bom_master";
            this.mt_bom_master.Size = new System.Drawing.Size(120, 100);
            this.mt_bom_master.TabIndex = 1;
            this.mt_bom_master.Text = "BOM Master";
            this.mt_bom_master.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mt_bom_master.UseSelectable = true;
            this.mt_bom_master.Click += new System.EventHandler(this.mt_bom_master_Click);
            // 
            // UIMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 200);
            this.Controls.Add(this.mt_bom_master);
            this.Controls.Add(this.mt_product_master);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UIMain";
            this.Resizable = false;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.UIMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile mt_product_master;
        private MetroFramework.Controls.MetroTile mt_bom_master;
    }
}