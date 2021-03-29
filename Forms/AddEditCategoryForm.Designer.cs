namespace Cafe.Forms
{
    partial class form_add_edit_category
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_add_edit_category));
            this.txt_cat_name = new System.Windows.Forms.TextBox();
            this.txt_cat_desc = new System.Windows.Forms.RichTextBox();
            this.lbl_cat_name = new System.Windows.Forms.Label();
            this.lbl_cat_desc = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_add_edit_category = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_cat_name
            // 
            this.txt_cat_name.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txt_cat_name.Location = new System.Drawing.Point(149, 29);
            this.txt_cat_name.Name = "txt_cat_name";
            this.txt_cat_name.Size = new System.Drawing.Size(141, 26);
            this.txt_cat_name.TabIndex = 0;
            this.txt_cat_name.TextChanged += new System.EventHandler(this.txt_cat_name_TextChanged);
            // 
            // txt_cat_desc
            // 
            this.txt_cat_desc.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_cat_desc.Location = new System.Drawing.Point(149, 112);
            this.txt_cat_desc.Name = "txt_cat_desc";
            this.txt_cat_desc.Size = new System.Drawing.Size(141, 97);
            this.txt_cat_desc.TabIndex = 1;
            this.txt_cat_desc.Text = "";
            // 
            // lbl_cat_name
            // 
            this.lbl_cat_name.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_cat_name.AutoSize = true;
            this.lbl_cat_name.BackColor = System.Drawing.Color.White;
            this.lbl_cat_name.Location = new System.Drawing.Point(34, 32);
            this.lbl_cat_name.Name = "lbl_cat_name";
            this.lbl_cat_name.Size = new System.Drawing.Size(109, 20);
            this.lbl_cat_name.TabIndex = 3;
            this.lbl_cat_name.Text = "Kateqoriya adı";
            // 
            // lbl_cat_desc
            // 
            this.lbl_cat_desc.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_cat_desc.AutoSize = true;
            this.lbl_cat_desc.BackColor = System.Drawing.Color.White;
            this.lbl_cat_desc.Location = new System.Drawing.Point(29, 151);
            this.lbl_cat_desc.Name = "lbl_cat_desc";
            this.lbl_cat_desc.Size = new System.Drawing.Size(114, 20);
            this.lbl_cat_desc.TabIndex = 4;
            this.lbl_cat_desc.Text = "Əlavə məlumat";
            this.lbl_cat_desc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btn_close, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbl_cat_name, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txt_cat_name, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txt_cat_desc, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_cat_desc, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_add_edit_category, 1, 2);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(47, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.37415F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 64.62585F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(293, 281);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(3, 241);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(140, 37);
            this.btn_close.TabIndex = 8;
            this.btn_close.Text = "Bağla";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_add_edit_category
            // 
            this.btn_add_edit_category.Location = new System.Drawing.Point(149, 241);
            this.btn_add_edit_category.Name = "btn_add_edit_category";
            this.btn_add_edit_category.Size = new System.Drawing.Size(141, 37);
            this.btn_add_edit_category.TabIndex = 6;
            this.btn_add_edit_category.Text = "Əlavə et";
            this.btn_add_edit_category.UseVisualStyleBackColor = true;
            this.btn_add_edit_category.Click += new System.EventHandler(this.btn_add_edit_category_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // form_add_edit_category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(387, 320);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "form_add_edit_category";
            this.Text = "AddCategoryForm";
            this.Load += new System.EventHandler(this.form_add_edit_category_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_cat_name;
        private System.Windows.Forms.RichTextBox txt_cat_desc;
        private System.Windows.Forms.Label lbl_cat_name;
        private System.Windows.Forms.Label lbl_cat_desc;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btn_add_edit_category;
        private System.Windows.Forms.Button btn_close;
    }
}