namespace Manage_BOM.UI
{
    partial class UIProduct_Master
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.m_txt_item_no = new MetroFramework.Controls.MetroTextBox();
            this.m_btn_save = new MetroFramework.Controls.MetroButton();
            this.m_txt_desc = new MetroFramework.Controls.MetroTextBox();
            this.m_txt_pick_seq = new MetroFramework.Controls.MetroTextBox();
            this.m_txt_deault_grade = new MetroFramework.Controls.MetroTextBox();
            this.m_txt_status = new MetroFramework.Controls.MetroTextBox();
            this.m_txt_product_class = new MetroFramework.Controls.MetroTextBox();
            this.m_txt_min_pick_face = new MetroFramework.Controls.MetroTextBox();
            this.m_txt_max_pick_face = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.m_dgv = new MetroFramework.Controls.MetroGrid();
            this.m_lbl_zoning = new MetroFramework.Controls.MetroLabel();
            this.m_lbl_pro_barcode = new MetroFramework.Controls.MetroLabel();
            this.m_lbl_pro_uom = new MetroFramework.Controls.MetroLabel();
            this.m_lbl_pro_uom_temp = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.m_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // m_txt_item_no
            // 
            // 
            // 
            // 
            this.m_txt_item_no.CustomButton.Image = null;
            this.m_txt_item_no.CustomButton.Location = new System.Drawing.Point(192, 2);
            this.m_txt_item_no.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.m_txt_item_no.CustomButton.Name = "";
            this.m_txt_item_no.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.m_txt_item_no.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.m_txt_item_no.CustomButton.TabIndex = 1;
            this.m_txt_item_no.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.m_txt_item_no.CustomButton.UseSelectable = true;
            this.m_txt_item_no.CustomButton.Visible = false;
            this.m_txt_item_no.DisplayIcon = true;
            this.m_txt_item_no.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.m_txt_item_no.Lines = new string[0];
            this.m_txt_item_no.Location = new System.Drawing.Point(51, 103);
            this.m_txt_item_no.Margin = new System.Windows.Forms.Padding(4);
            this.m_txt_item_no.MaxLength = 32767;
            this.m_txt_item_no.Name = "m_txt_item_no";
            this.m_txt_item_no.PasswordChar = '\0';
            this.m_txt_item_no.PromptText = "Item No";
            this.m_txt_item_no.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.m_txt_item_no.SelectedText = "";
            this.m_txt_item_no.SelectionLength = 0;
            this.m_txt_item_no.SelectionStart = 0;
            this.m_txt_item_no.ShortcutsEnabled = true;
            this.m_txt_item_no.Size = new System.Drawing.Size(228, 38);
            this.m_txt_item_no.TabIndex = 0;
            this.m_txt_item_no.UseCustomBackColor = true;
            this.m_txt_item_no.UseCustomForeColor = true;
            this.m_txt_item_no.UseSelectable = true;
            this.m_txt_item_no.WaterMark = "Item No";
            this.m_txt_item_no.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.m_txt_item_no.WaterMarkFont = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // m_btn_save
            // 
            this.m_btn_save.BackColor = System.Drawing.Color.Green;
            this.m_btn_save.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.m_btn_save.ForeColor = System.Drawing.Color.White;
            this.m_btn_save.Location = new System.Drawing.Point(411, 265);
            this.m_btn_save.Margin = new System.Windows.Forms.Padding(4);
            this.m_btn_save.Name = "m_btn_save";
            this.m_btn_save.Size = new System.Drawing.Size(150, 60);
            this.m_btn_save.TabIndex = 1;
            this.m_btn_save.Text = "Save Data";
            this.m_btn_save.UseCustomBackColor = true;
            this.m_btn_save.UseCustomForeColor = true;
            this.m_btn_save.UseSelectable = true;
            this.m_btn_save.Click += new System.EventHandler(this.m_btn_save_Click);
            // 
            // m_txt_desc
            // 
            // 
            // 
            // 
            this.m_txt_desc.CustomButton.Image = null;
            this.m_txt_desc.CustomButton.Location = new System.Drawing.Point(192, 2);
            this.m_txt_desc.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.m_txt_desc.CustomButton.Name = "";
            this.m_txt_desc.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.m_txt_desc.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.m_txt_desc.CustomButton.TabIndex = 1;
            this.m_txt_desc.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.m_txt_desc.CustomButton.UseSelectable = true;
            this.m_txt_desc.CustomButton.Visible = false;
            this.m_txt_desc.DisplayIcon = true;
            this.m_txt_desc.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.m_txt_desc.Lines = new string[0];
            this.m_txt_desc.Location = new System.Drawing.Point(51, 149);
            this.m_txt_desc.Margin = new System.Windows.Forms.Padding(4);
            this.m_txt_desc.MaxLength = 32767;
            this.m_txt_desc.Name = "m_txt_desc";
            this.m_txt_desc.PasswordChar = '\0';
            this.m_txt_desc.PromptText = "Description";
            this.m_txt_desc.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.m_txt_desc.SelectedText = "";
            this.m_txt_desc.SelectionLength = 0;
            this.m_txt_desc.SelectionStart = 0;
            this.m_txt_desc.ShortcutsEnabled = true;
            this.m_txt_desc.Size = new System.Drawing.Size(228, 38);
            this.m_txt_desc.TabIndex = 2;
            this.m_txt_desc.UseCustomBackColor = true;
            this.m_txt_desc.UseCustomForeColor = true;
            this.m_txt_desc.UseSelectable = true;
            this.m_txt_desc.WaterMark = "Description";
            this.m_txt_desc.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.m_txt_desc.WaterMarkFont = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // m_txt_pick_seq
            // 
            // 
            // 
            // 
            this.m_txt_pick_seq.CustomButton.Image = null;
            this.m_txt_pick_seq.CustomButton.Location = new System.Drawing.Point(192, 2);
            this.m_txt_pick_seq.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.m_txt_pick_seq.CustomButton.Name = "";
            this.m_txt_pick_seq.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.m_txt_pick_seq.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.m_txt_pick_seq.CustomButton.TabIndex = 1;
            this.m_txt_pick_seq.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.m_txt_pick_seq.CustomButton.UseSelectable = true;
            this.m_txt_pick_seq.CustomButton.Visible = false;
            this.m_txt_pick_seq.DisplayIcon = true;
            this.m_txt_pick_seq.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.m_txt_pick_seq.Lines = new string[0];
            this.m_txt_pick_seq.Location = new System.Drawing.Point(333, 195);
            this.m_txt_pick_seq.Margin = new System.Windows.Forms.Padding(4);
            this.m_txt_pick_seq.MaxLength = 32767;
            this.m_txt_pick_seq.Name = "m_txt_pick_seq";
            this.m_txt_pick_seq.PasswordChar = '\0';
            this.m_txt_pick_seq.PromptText = "Pick Sequence";
            this.m_txt_pick_seq.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.m_txt_pick_seq.SelectedText = "";
            this.m_txt_pick_seq.SelectionLength = 0;
            this.m_txt_pick_seq.SelectionStart = 0;
            this.m_txt_pick_seq.ShortcutsEnabled = true;
            this.m_txt_pick_seq.Size = new System.Drawing.Size(228, 38);
            this.m_txt_pick_seq.TabIndex = 3;
            this.m_txt_pick_seq.UseCustomBackColor = true;
            this.m_txt_pick_seq.UseCustomForeColor = true;
            this.m_txt_pick_seq.UseSelectable = true;
            this.m_txt_pick_seq.WaterMark = "Pick Sequence";
            this.m_txt_pick_seq.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.m_txt_pick_seq.WaterMarkFont = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // m_txt_deault_grade
            // 
            // 
            // 
            // 
            this.m_txt_deault_grade.CustomButton.Image = null;
            this.m_txt_deault_grade.CustomButton.Location = new System.Drawing.Point(192, 2);
            this.m_txt_deault_grade.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.m_txt_deault_grade.CustomButton.Name = "";
            this.m_txt_deault_grade.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.m_txt_deault_grade.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.m_txt_deault_grade.CustomButton.TabIndex = 1;
            this.m_txt_deault_grade.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.m_txt_deault_grade.CustomButton.UseSelectable = true;
            this.m_txt_deault_grade.CustomButton.Visible = false;
            this.m_txt_deault_grade.DisplayIcon = true;
            this.m_txt_deault_grade.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.m_txt_deault_grade.Lines = new string[0];
            this.m_txt_deault_grade.Location = new System.Drawing.Point(333, 103);
            this.m_txt_deault_grade.Margin = new System.Windows.Forms.Padding(4);
            this.m_txt_deault_grade.MaxLength = 32767;
            this.m_txt_deault_grade.Name = "m_txt_deault_grade";
            this.m_txt_deault_grade.PasswordChar = '\0';
            this.m_txt_deault_grade.PromptText = "Default grade";
            this.m_txt_deault_grade.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.m_txt_deault_grade.SelectedText = "";
            this.m_txt_deault_grade.SelectionLength = 0;
            this.m_txt_deault_grade.SelectionStart = 0;
            this.m_txt_deault_grade.ShortcutsEnabled = true;
            this.m_txt_deault_grade.Size = new System.Drawing.Size(228, 38);
            this.m_txt_deault_grade.TabIndex = 4;
            this.m_txt_deault_grade.UseCustomBackColor = true;
            this.m_txt_deault_grade.UseCustomForeColor = true;
            this.m_txt_deault_grade.UseSelectable = true;
            this.m_txt_deault_grade.WaterMark = "Default grade";
            this.m_txt_deault_grade.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.m_txt_deault_grade.WaterMarkFont = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // m_txt_status
            // 
            // 
            // 
            // 
            this.m_txt_status.CustomButton.Image = null;
            this.m_txt_status.CustomButton.Location = new System.Drawing.Point(192, 2);
            this.m_txt_status.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.m_txt_status.CustomButton.Name = "";
            this.m_txt_status.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.m_txt_status.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.m_txt_status.CustomButton.TabIndex = 1;
            this.m_txt_status.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.m_txt_status.CustomButton.UseSelectable = true;
            this.m_txt_status.CustomButton.Visible = false;
            this.m_txt_status.DisplayIcon = true;
            this.m_txt_status.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.m_txt_status.Lines = new string[0];
            this.m_txt_status.Location = new System.Drawing.Point(333, 149);
            this.m_txt_status.Margin = new System.Windows.Forms.Padding(4);
            this.m_txt_status.MaxLength = 32767;
            this.m_txt_status.Name = "m_txt_status";
            this.m_txt_status.PasswordChar = '\0';
            this.m_txt_status.PromptText = "Status";
            this.m_txt_status.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.m_txt_status.SelectedText = "";
            this.m_txt_status.SelectionLength = 0;
            this.m_txt_status.SelectionStart = 0;
            this.m_txt_status.ShortcutsEnabled = true;
            this.m_txt_status.Size = new System.Drawing.Size(228, 38);
            this.m_txt_status.TabIndex = 5;
            this.m_txt_status.UseCustomBackColor = true;
            this.m_txt_status.UseCustomForeColor = true;
            this.m_txt_status.UseSelectable = true;
            this.m_txt_status.WaterMark = "Status";
            this.m_txt_status.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.m_txt_status.WaterMarkFont = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // m_txt_product_class
            // 
            // 
            // 
            // 
            this.m_txt_product_class.CustomButton.Image = null;
            this.m_txt_product_class.CustomButton.Location = new System.Drawing.Point(192, 2);
            this.m_txt_product_class.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.m_txt_product_class.CustomButton.Name = "";
            this.m_txt_product_class.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.m_txt_product_class.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.m_txt_product_class.CustomButton.TabIndex = 1;
            this.m_txt_product_class.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.m_txt_product_class.CustomButton.UseSelectable = true;
            this.m_txt_product_class.CustomButton.Visible = false;
            this.m_txt_product_class.DisplayIcon = true;
            this.m_txt_product_class.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.m_txt_product_class.Lines = new string[0];
            this.m_txt_product_class.Location = new System.Drawing.Point(51, 195);
            this.m_txt_product_class.Margin = new System.Windows.Forms.Padding(4);
            this.m_txt_product_class.MaxLength = 32767;
            this.m_txt_product_class.Name = "m_txt_product_class";
            this.m_txt_product_class.PasswordChar = '\0';
            this.m_txt_product_class.PromptText = "Product Class";
            this.m_txt_product_class.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.m_txt_product_class.SelectedText = "";
            this.m_txt_product_class.SelectionLength = 0;
            this.m_txt_product_class.SelectionStart = 0;
            this.m_txt_product_class.ShortcutsEnabled = true;
            this.m_txt_product_class.Size = new System.Drawing.Size(228, 38);
            this.m_txt_product_class.TabIndex = 6;
            this.m_txt_product_class.UseCustomBackColor = true;
            this.m_txt_product_class.UseCustomForeColor = true;
            this.m_txt_product_class.UseSelectable = true;
            this.m_txt_product_class.WaterMark = "Product Class";
            this.m_txt_product_class.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.m_txt_product_class.WaterMarkFont = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // m_txt_min_pick_face
            // 
            // 
            // 
            // 
            this.m_txt_min_pick_face.CustomButton.Image = null;
            this.m_txt_min_pick_face.CustomButton.Location = new System.Drawing.Point(192, 2);
            this.m_txt_min_pick_face.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.m_txt_min_pick_face.CustomButton.Name = "";
            this.m_txt_min_pick_face.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.m_txt_min_pick_face.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.m_txt_min_pick_face.CustomButton.TabIndex = 1;
            this.m_txt_min_pick_face.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.m_txt_min_pick_face.CustomButton.UseSelectable = true;
            this.m_txt_min_pick_face.CustomButton.Visible = false;
            this.m_txt_min_pick_face.DisplayIcon = true;
            this.m_txt_min_pick_face.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.m_txt_min_pick_face.Lines = new string[0];
            this.m_txt_min_pick_face.Location = new System.Drawing.Point(51, 241);
            this.m_txt_min_pick_face.Margin = new System.Windows.Forms.Padding(4);
            this.m_txt_min_pick_face.MaxLength = 32767;
            this.m_txt_min_pick_face.Name = "m_txt_min_pick_face";
            this.m_txt_min_pick_face.PasswordChar = '\0';
            this.m_txt_min_pick_face.PromptText = "Min pick face";
            this.m_txt_min_pick_face.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.m_txt_min_pick_face.SelectedText = "";
            this.m_txt_min_pick_face.SelectionLength = 0;
            this.m_txt_min_pick_face.SelectionStart = 0;
            this.m_txt_min_pick_face.ShortcutsEnabled = true;
            this.m_txt_min_pick_face.Size = new System.Drawing.Size(228, 38);
            this.m_txt_min_pick_face.TabIndex = 8;
            this.m_txt_min_pick_face.UseCustomBackColor = true;
            this.m_txt_min_pick_face.UseCustomForeColor = true;
            this.m_txt_min_pick_face.UseSelectable = true;
            this.m_txt_min_pick_face.WaterMark = "Min pick face";
            this.m_txt_min_pick_face.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.m_txt_min_pick_face.WaterMarkFont = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // m_txt_max_pick_face
            // 
            // 
            // 
            // 
            this.m_txt_max_pick_face.CustomButton.Image = null;
            this.m_txt_max_pick_face.CustomButton.Location = new System.Drawing.Point(192, 2);
            this.m_txt_max_pick_face.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.m_txt_max_pick_face.CustomButton.Name = "";
            this.m_txt_max_pick_face.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.m_txt_max_pick_face.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.m_txt_max_pick_face.CustomButton.TabIndex = 1;
            this.m_txt_max_pick_face.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.m_txt_max_pick_face.CustomButton.UseSelectable = true;
            this.m_txt_max_pick_face.CustomButton.Visible = false;
            this.m_txt_max_pick_face.DisplayIcon = true;
            this.m_txt_max_pick_face.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.m_txt_max_pick_face.Lines = new string[0];
            this.m_txt_max_pick_face.Location = new System.Drawing.Point(51, 287);
            this.m_txt_max_pick_face.Margin = new System.Windows.Forms.Padding(4);
            this.m_txt_max_pick_face.MaxLength = 32767;
            this.m_txt_max_pick_face.Name = "m_txt_max_pick_face";
            this.m_txt_max_pick_face.PasswordChar = '\0';
            this.m_txt_max_pick_face.PromptText = "Max pick face";
            this.m_txt_max_pick_face.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.m_txt_max_pick_face.SelectedText = "";
            this.m_txt_max_pick_face.SelectionLength = 0;
            this.m_txt_max_pick_face.SelectionStart = 0;
            this.m_txt_max_pick_face.ShortcutsEnabled = true;
            this.m_txt_max_pick_face.Size = new System.Drawing.Size(228, 38);
            this.m_txt_max_pick_face.TabIndex = 7;
            this.m_txt_max_pick_face.UseCustomBackColor = true;
            this.m_txt_max_pick_face.UseCustomForeColor = true;
            this.m_txt_max_pick_face.UseSelectable = true;
            this.m_txt_max_pick_face.WaterMark = "Max pick face";
            this.m_txt_max_pick_face.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.m_txt_max_pick_face.WaterMarkFont = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(51, 80);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(81, 19);
            this.metroLabel1.TabIndex = 9;
            this.metroLabel1.Text = "metroLabel1";
            // 
            // m_dgv
            // 
            this.m_dgv.AllowUserToResizeRows = false;
            this.m_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.m_dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.m_dgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.m_dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.m_dgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.m_dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.m_dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.m_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.m_dgv.DefaultCellStyle = dataGridViewCellStyle11;
            this.m_dgv.EnableHeadersVisualStyles = false;
            this.m_dgv.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.m_dgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.m_dgv.Location = new System.Drawing.Point(50, 332);
            this.m_dgv.Name = "m_dgv";
            this.m_dgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.m_dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.m_dgv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.m_dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.m_dgv.Size = new System.Drawing.Size(920, 171);
            this.m_dgv.TabIndex = 10;
            // 
            // m_lbl_zoning
            // 
            this.m_lbl_zoning.AutoSize = true;
            this.m_lbl_zoning.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.m_lbl_zoning.Location = new System.Drawing.Point(589, 116);
            this.m_lbl_zoning.Name = "m_lbl_zoning";
            this.m_lbl_zoning.Size = new System.Drawing.Size(130, 25);
            this.m_lbl_zoning.TabIndex = 11;
            this.m_lbl_zoning.Text = "Product Zoning";
            // 
            // m_lbl_pro_barcode
            // 
            this.m_lbl_pro_barcode.AutoSize = true;
            this.m_lbl_pro_barcode.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.m_lbl_pro_barcode.Location = new System.Drawing.Point(805, 116);
            this.m_lbl_pro_barcode.Name = "m_lbl_pro_barcode";
            this.m_lbl_pro_barcode.Size = new System.Drawing.Size(138, 25);
            this.m_lbl_pro_barcode.TabIndex = 12;
            this.m_lbl_pro_barcode.Text = "Product Barcode";
            // 
            // m_lbl_pro_uom
            // 
            this.m_lbl_pro_uom.AutoSize = true;
            this.m_lbl_pro_uom.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.m_lbl_pro_uom.Location = new System.Drawing.Point(589, 162);
            this.m_lbl_pro_uom.Name = "m_lbl_pro_uom";
            this.m_lbl_pro_uom.Size = new System.Drawing.Size(117, 25);
            this.m_lbl_pro_uom.TabIndex = 13;
            this.m_lbl_pro_uom.Text = "Product UOM";
            // 
            // m_lbl_pro_uom_temp
            // 
            this.m_lbl_pro_uom_temp.AutoSize = true;
            this.m_lbl_pro_uom_temp.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.m_lbl_pro_uom_temp.Location = new System.Drawing.Point(806, 162);
            this.m_lbl_pro_uom_temp.Name = "m_lbl_pro_uom_temp";
            this.m_lbl_pro_uom_temp.Size = new System.Drawing.Size(165, 25);
            this.m_lbl_pro_uom_temp.TabIndex = 14;
            this.m_lbl_pro_uom_temp.Text = "Product UOM TEMP";
            // 
            // UIProduct_Master
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 544);
            this.Controls.Add(this.m_lbl_pro_uom_temp);
            this.Controls.Add(this.m_lbl_pro_uom);
            this.Controls.Add(this.m_lbl_pro_barcode);
            this.Controls.Add(this.m_lbl_zoning);
            this.Controls.Add(this.m_dgv);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.m_txt_min_pick_face);
            this.Controls.Add(this.m_txt_max_pick_face);
            this.Controls.Add(this.m_txt_product_class);
            this.Controls.Add(this.m_txt_status);
            this.Controls.Add(this.m_txt_deault_grade);
            this.Controls.Add(this.m_txt_pick_seq);
            this.Controls.Add(this.m_txt_desc);
            this.Controls.Add(this.m_btn_save);
            this.Controls.Add(this.m_txt_item_no);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "UIProduct_Master";
            this.Padding = new System.Windows.Forms.Padding(47, 134, 47, 45);
            this.Resizable = false;
            this.Text = "UIProduct_Master";
            this.Load += new System.EventHandler(this.UIProduct_Master_Load);
            ((System.ComponentModel.ISupportInitialize)(this.m_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox m_txt_item_no;
        private MetroFramework.Controls.MetroButton m_btn_save;
        private MetroFramework.Controls.MetroTextBox m_txt_desc;
        private MetroFramework.Controls.MetroTextBox m_txt_pick_seq;
        private MetroFramework.Controls.MetroTextBox m_txt_deault_grade;
        private MetroFramework.Controls.MetroTextBox m_txt_status;
        private MetroFramework.Controls.MetroTextBox m_txt_product_class;
        private MetroFramework.Controls.MetroTextBox m_txt_min_pick_face;
        private MetroFramework.Controls.MetroTextBox m_txt_max_pick_face;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroGrid m_dgv;
        private MetroFramework.Controls.MetroLabel m_lbl_zoning;
        private MetroFramework.Controls.MetroLabel m_lbl_pro_barcode;
        private MetroFramework.Controls.MetroLabel m_lbl_pro_uom;
        private MetroFramework.Controls.MetroLabel m_lbl_pro_uom_temp;
    }
}