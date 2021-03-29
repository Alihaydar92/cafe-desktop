namespace Cafe.Forms
{
    partial class form_add_edit_table
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_add_edit_table));
            this.txt_table_name = new System.Windows.Forms.TextBox();
            this.txt_table_desc = new System.Windows.Forms.RichTextBox();
            this.lbl_table_name = new System.Windows.Forms.Label();
            this.lbl_table_desc = new System.Windows.Forms.Label();
            this.tableLayout_table = new System.Windows.Forms.TableLayoutPanel();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_add_edit_table = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tableLayout_table.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_table_name
            // 
            this.txt_table_name.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txt_table_name.Location = new System.Drawing.Point(149, 23);
            this.txt_table_name.Name = "txt_table_name";
            this.txt_table_name.Size = new System.Drawing.Size(141, 26);
            this.txt_table_name.TabIndex = 0;
            this.txt_table_name.TextChanged += new System.EventHandler(this.txt_table_name_TextChanged);
            // 
            // txt_table_desc
            // 
            this.txt_table_desc.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_table_desc.Location = new System.Drawing.Point(149, 89);
            this.txt_table_desc.Name = "txt_table_desc";
            this.txt_table_desc.Size = new System.Drawing.Size(141, 97);
            this.txt_table_desc.TabIndex = 1;
            this.txt_table_desc.Text = "";
            // 
            // lbl_table_name
            // 
            this.lbl_table_name.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_table_name.AutoSize = true;
            this.lbl_table_name.BackColor = System.Drawing.Color.White;
            this.lbl_table_name.Location = new System.Drawing.Point(81, 26);
            this.lbl_table_name.Name = "lbl_table_name";
            this.lbl_table_name.Size = new System.Drawing.Size(62, 20);
            this.lbl_table_name.TabIndex = 3;
            this.lbl_table_name.Text = "Stol adı";
            // 
            // lbl_table_desc
            // 
            this.lbl_table_desc.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_table_desc.AutoSize = true;
            this.lbl_table_desc.BackColor = System.Drawing.Color.White;
            this.lbl_table_desc.Location = new System.Drawing.Point(29, 127);
            this.lbl_table_desc.Name = "lbl_table_desc";
            this.lbl_table_desc.Size = new System.Drawing.Size(114, 20);
            this.lbl_table_desc.TabIndex = 4;
            this.lbl_table_desc.Text = "Əlavə məlumat";
            this.lbl_table_desc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLayout_table
            // 
            this.tableLayout_table.BackColor = System.Drawing.Color.Transparent;
            this.tableLayout_table.ColumnCount = 2;
            this.tableLayout_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayout_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayout_table.Controls.Add(this.btn_close, 0, 2);
            this.tableLayout_table.Controls.Add(this.lbl_table_name, 0, 0);
            this.tableLayout_table.Controls.Add(this.txt_table_name, 1, 0);
            this.tableLayout_table.Controls.Add(this.txt_table_desc, 1, 1);
            this.tableLayout_table.Controls.Add(this.lbl_table_desc, 0, 1);
            this.tableLayout_table.Controls.Add(this.btn_add_edit_table, 1, 2);
            this.tableLayout_table.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tableLayout_table.Location = new System.Drawing.Point(47, 12);
            this.tableLayout_table.Name = "tableLayout_table";
            this.tableLayout_table.RowCount = 3;
            this.tableLayout_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.37415F));
            this.tableLayout_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 64.62585F));
            this.tableLayout_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.tableLayout_table.Size = new System.Drawing.Size(293, 281);
            this.tableLayout_table.TabIndex = 6;
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(3, 206);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(140, 37);
            this.btn_close.TabIndex = 7;
            this.btn_close.Text = "Bağla";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_add_edit_table
            // 
            this.btn_add_edit_table.Location = new System.Drawing.Point(149, 206);
            this.btn_add_edit_table.Name = "btn_add_edit_table";
            this.btn_add_edit_table.Size = new System.Drawing.Size(141, 37);
            this.btn_add_edit_table.TabIndex = 6;
            this.btn_add_edit_table.Text = "Əlavə et";
            this.btn_add_edit_table.UseVisualStyleBackColor = true;
            this.btn_add_edit_table.Click += new System.EventHandler(this.btn_add_edit_table_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // form_add_edit_table
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(387, 320);
            this.Controls.Add(this.tableLayout_table);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "form_add_edit_table";
            this.Text = "AddTableForm";
            this.Load += new System.EventHandler(this.form_add_edit_table_Load);
            this.tableLayout_table.ResumeLayout(false);
            this.tableLayout_table.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_table_name;
        private System.Windows.Forms.RichTextBox txt_table_desc;
        private System.Windows.Forms.Label lbl_table_name;
        private System.Windows.Forms.Label lbl_table_desc;
        private System.Windows.Forms.TableLayoutPanel tableLayout_table;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btn_add_edit_table;
        private System.Windows.Forms.Button btn_close;
    }
}