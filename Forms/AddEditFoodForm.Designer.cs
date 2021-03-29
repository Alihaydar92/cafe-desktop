namespace Cafe.Forms
{
    partial class form_add_edit_food
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_add_edit_food));
            this.tableLayout_food = new System.Windows.Forms.TableLayoutPanel();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.lbl_food_name = new System.Windows.Forms.Label();
            this.txt_food_name = new System.Windows.Forms.TextBox();
            this.lbl_food_price = new System.Windows.Forms.Label();
            this.lbl_food_cost = new System.Windows.Forms.Label();
            this.txt_food_price = new System.Windows.Forms.TextBox();
            this.txt_food_cost = new System.Windows.Forms.TextBox();
            this.btn_add_edit_food = new System.Windows.Forms.Button();
            this.txt_food_desc = new System.Windows.Forms.RichTextBox();
            this.lbl_food_desc = new System.Windows.Forms.Label();
            this.lbl_category = new System.Windows.Forms.Label();
            this.cb_category = new System.Windows.Forms.ComboBox();
            this.tableLayout_food.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayout_food
            // 
            this.tableLayout_food.BackColor = System.Drawing.Color.Transparent;
            this.tableLayout_food.ColumnCount = 2;
            this.tableLayout_food.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayout_food.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayout_food.Controls.Add(this.btn_cancel, 0, 5);
            this.tableLayout_food.Controls.Add(this.lbl_food_name, 0, 0);
            this.tableLayout_food.Controls.Add(this.txt_food_name, 1, 0);
            this.tableLayout_food.Controls.Add(this.lbl_food_price, 0, 1);
            this.tableLayout_food.Controls.Add(this.lbl_food_cost, 0, 2);
            this.tableLayout_food.Controls.Add(this.txt_food_price, 1, 1);
            this.tableLayout_food.Controls.Add(this.txt_food_cost, 1, 2);
            this.tableLayout_food.Controls.Add(this.btn_add_edit_food, 1, 5);
            this.tableLayout_food.Controls.Add(this.txt_food_desc, 1, 4);
            this.tableLayout_food.Controls.Add(this.lbl_food_desc, 0, 4);
            this.tableLayout_food.Controls.Add(this.lbl_category, 0, 3);
            this.tableLayout_food.Controls.Add(this.cb_category, 1, 3);
            this.tableLayout_food.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tableLayout_food.Location = new System.Drawing.Point(47, 12);
            this.tableLayout_food.Name = "tableLayout_food";
            this.tableLayout_food.RowCount = 6;
            this.tableLayout_food.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.37415F));
            this.tableLayout_food.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 64.62585F));
            this.tableLayout_food.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.tableLayout_food.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.tableLayout_food.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.tableLayout_food.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayout_food.Size = new System.Drawing.Size(293, 360);
            this.tableLayout_food.TabIndex = 7;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(3, 318);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(140, 37);
            this.btn_cancel.TabIndex = 14;
            this.btn_cancel.Text = "Bağla";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // lbl_food_name
            // 
            this.lbl_food_name.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_food_name.AutoSize = true;
            this.lbl_food_name.BackColor = System.Drawing.Color.White;
            this.lbl_food_name.Location = new System.Drawing.Point(76, 9);
            this.lbl_food_name.Name = "lbl_food_name";
            this.lbl_food_name.Size = new System.Drawing.Size(67, 20);
            this.lbl_food_name.TabIndex = 3;
            this.lbl_food_name.Text = "Qida adı";
            // 
            // txt_food_name
            // 
            this.txt_food_name.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txt_food_name.Location = new System.Drawing.Point(149, 6);
            this.txt_food_name.Name = "txt_food_name";
            this.txt_food_name.Size = new System.Drawing.Size(141, 26);
            this.txt_food_name.TabIndex = 0;
            this.txt_food_name.TextChanged += new System.EventHandler(this.txt_food_name_TextChanged);
            // 
            // lbl_food_price
            // 
            this.lbl_food_price.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_food_price.AutoSize = true;
            this.lbl_food_price.BackColor = System.Drawing.Color.White;
            this.lbl_food_price.Location = new System.Drawing.Point(85, 63);
            this.lbl_food_price.Name = "lbl_food_price";
            this.lbl_food_price.Size = new System.Drawing.Size(58, 20);
            this.lbl_food_price.TabIndex = 8;
            this.lbl_food_price.Text = "Qiymət";
            // 
            // lbl_food_cost
            // 
            this.lbl_food_cost.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_food_cost.AutoSize = true;
            this.lbl_food_cost.BackColor = System.Drawing.Color.White;
            this.lbl_food_cost.Location = new System.Drawing.Point(50, 134);
            this.lbl_food_cost.Name = "lbl_food_cost";
            this.lbl_food_cost.Size = new System.Drawing.Size(93, 20);
            this.lbl_food_cost.TabIndex = 9;
            this.lbl_food_cost.Text = "Maya dəyəri";
            // 
            // txt_food_price
            // 
            this.txt_food_price.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txt_food_price.Location = new System.Drawing.Point(149, 60);
            this.txt_food_price.Name = "txt_food_price";
            this.txt_food_price.Size = new System.Drawing.Size(141, 26);
            this.txt_food_price.TabIndex = 10;
            this.txt_food_price.TextChanged += new System.EventHandler(this.txt_food_price_TextChanged);
            // 
            // txt_food_cost
            // 
            this.txt_food_cost.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txt_food_cost.Location = new System.Drawing.Point(149, 131);
            this.txt_food_cost.Name = "txt_food_cost";
            this.txt_food_cost.Size = new System.Drawing.Size(141, 26);
            this.txt_food_cost.TabIndex = 11;
            this.txt_food_cost.TextChanged += new System.EventHandler(this.txt_food_cost_TextChanged);
            // 
            // btn_add_edit_food
            // 
            this.btn_add_edit_food.Location = new System.Drawing.Point(149, 318);
            this.btn_add_edit_food.Name = "btn_add_edit_food";
            this.btn_add_edit_food.Size = new System.Drawing.Size(141, 37);
            this.btn_add_edit_food.TabIndex = 6;
            this.btn_add_edit_food.Text = "Əlavə et";
            this.btn_add_edit_food.UseVisualStyleBackColor = true;
            this.btn_add_edit_food.Click += new System.EventHandler(this.btn_add_edit_food_Click);
            // 
            // txt_food_desc
            // 
            this.txt_food_desc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_food_desc.Location = new System.Drawing.Point(149, 241);
            this.txt_food_desc.Name = "txt_food_desc";
            this.txt_food_desc.Size = new System.Drawing.Size(141, 71);
            this.txt_food_desc.TabIndex = 1;
            this.txt_food_desc.Text = "";
            // 
            // lbl_food_desc
            // 
            this.lbl_food_desc.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_food_desc.AutoSize = true;
            this.lbl_food_desc.BackColor = System.Drawing.Color.White;
            this.lbl_food_desc.Location = new System.Drawing.Point(29, 266);
            this.lbl_food_desc.Name = "lbl_food_desc";
            this.lbl_food_desc.Size = new System.Drawing.Size(114, 20);
            this.lbl_food_desc.TabIndex = 4;
            this.lbl_food_desc.Text = "Əlavə məlumat";
            this.lbl_food_desc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_category
            // 
            this.lbl_category.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_category.AutoSize = true;
            this.lbl_category.BackColor = System.Drawing.Color.White;
            this.lbl_category.Location = new System.Drawing.Point(59, 199);
            this.lbl_category.Name = "lbl_category";
            this.lbl_category.Size = new System.Drawing.Size(84, 20);
            this.lbl_category.TabIndex = 12;
            this.lbl_category.Text = "Kateqoriya";
            // 
            // cb_category
            // 
            this.cb_category.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cb_category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_category.FormattingEnabled = true;
            this.cb_category.Location = new System.Drawing.Point(149, 198);
            this.cb_category.Name = "cb_category";
            this.cb_category.Size = new System.Drawing.Size(141, 28);
            this.cb_category.TabIndex = 13;
            this.cb_category.SelectedIndexChanged += new System.EventHandler(this.cb_category_SelectedIndexChanged);
            // 
            // form_add_edit_food
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(387, 384);
            this.Controls.Add(this.tableLayout_food);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "form_add_edit_food";
            this.Text = "AddEditFoodForm";
            this.Load += new System.EventHandler(this.form_add_edit_food_Load);
            this.tableLayout_food.ResumeLayout(false);
            this.tableLayout_food.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayout_food;
        private System.Windows.Forms.Label lbl_food_name;
        private System.Windows.Forms.TextBox txt_food_name;
        private System.Windows.Forms.RichTextBox txt_food_desc;
        private System.Windows.Forms.Label lbl_food_desc;
        private System.Windows.Forms.Button btn_add_edit_food;
        private System.Windows.Forms.Label lbl_food_price;
        private System.Windows.Forms.Label lbl_food_cost;
        private System.Windows.Forms.TextBox txt_food_price;
        private System.Windows.Forms.TextBox txt_food_cost;
        private System.Windows.Forms.Label lbl_category;
        private System.Windows.Forms.ComboBox cb_category;
        private System.Windows.Forms.Button btn_cancel;
    }
}