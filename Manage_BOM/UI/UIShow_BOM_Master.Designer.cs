namespace Manage_BOM.UI
{
    partial class UIShow_BOM_Master
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.m_dgv = new MetroFramework.Controls.MetroGrid();
            this.m_btn_copy_bom = new MetroFramework.Controls.MetroButton();
            this.m_btn_delete = new MetroFramework.Controls.MetroButton();
            this.txt_find = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.m_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // m_dgv
            // 
            this.m_dgv.AllowUserToResizeRows = false;
            this.m_dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.m_dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.m_dgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.m_dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.m_dgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.m_dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.m_dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.m_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.m_dgv.DefaultCellStyle = dataGridViewCellStyle2;
            this.m_dgv.EnableHeadersVisualStyles = false;
            this.m_dgv.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.m_dgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.m_dgv.Location = new System.Drawing.Point(23, 119);
            this.m_dgv.Name = "m_dgv";
            this.m_dgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.m_dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.m_dgv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.m_dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.m_dgv.Size = new System.Drawing.Size(854, 358);
            this.m_dgv.TabIndex = 0;
            this.m_dgv.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.m_dgv_CellEnter);
            // 
            // m_btn_copy_bom
            // 
            this.m_btn_copy_bom.Location = new System.Drawing.Point(23, 63);
            this.m_btn_copy_bom.Name = "m_btn_copy_bom";
            this.m_btn_copy_bom.Size = new System.Drawing.Size(100, 50);
            this.m_btn_copy_bom.TabIndex = 1;
            this.m_btn_copy_bom.Text = "Copy BOM";
            this.m_btn_copy_bom.UseCustomBackColor = true;
            this.m_btn_copy_bom.UseCustomForeColor = true;
            this.m_btn_copy_bom.UseSelectable = true;
            this.m_btn_copy_bom.Click += new System.EventHandler(this.m_btn_copy_bom_Click);
            // 
            // m_btn_delete
            // 
            this.m_btn_delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.m_btn_delete.BackColor = System.Drawing.Color.Red;
            this.m_btn_delete.Location = new System.Drawing.Point(777, 63);
            this.m_btn_delete.Name = "m_btn_delete";
            this.m_btn_delete.Size = new System.Drawing.Size(100, 50);
            this.m_btn_delete.TabIndex = 2;
            this.m_btn_delete.Text = "DELETE";
            this.m_btn_delete.UseCustomBackColor = true;
            this.m_btn_delete.UseCustomForeColor = true;
            this.m_btn_delete.UseSelectable = true;
            this.m_btn_delete.Click += new System.EventHandler(this.m_btn_delete_Click);
            // 
            // txt_find
            // 
            this.txt_find.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txt_find.Location = new System.Drawing.Point(129, 82);
            this.txt_find.Name = "txt_find";
            this.txt_find.Size = new System.Drawing.Size(211, 31);
            this.txt_find.TabIndex = 3;
            this.txt_find.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_find_KeyDown);
            // 
            // UIShow_BOM_Master
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.txt_find);
            this.Controls.Add(this.m_btn_delete);
            this.Controls.Add(this.m_btn_copy_bom);
            this.Controls.Add(this.m_dgv);
            this.Name = "UIShow_BOM_Master";
            this.Text = "UIShow_BOM_Master";
            this.Load += new System.EventHandler(this.UIShow_BOM_Master_Load);
            ((System.ComponentModel.ISupportInitialize)(this.m_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroGrid m_dgv;
        private MetroFramework.Controls.MetroButton m_btn_copy_bom;
        private MetroFramework.Controls.MetroButton m_btn_delete;
        private System.Windows.Forms.TextBox txt_find;
    }
}