namespace Cafe.Forms
{
    partial class CategoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoryForm));
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_add_category = new System.Windows.Forms.Button();
            this.btn_edit_category = new System.Windows.Forms.Button();
            this.btn_delete_category = new System.Windows.Forms.Button();
            this.lv_category = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(733, 358);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(139, 41);
            this.btn_cancel.TabIndex = 8;
            this.btn_cancel.Text = "BAĞLA";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_add_category
            // 
            this.btn_add_category.Location = new System.Drawing.Point(733, 12);
            this.btn_add_category.Name = "btn_add_category";
            this.btn_add_category.Size = new System.Drawing.Size(139, 41);
            this.btn_add_category.TabIndex = 7;
            this.btn_add_category.Text = "ƏLAVƏ ET";
            this.btn_add_category.UseVisualStyleBackColor = true;
            this.btn_add_category.Click += new System.EventHandler(this.btn_add_category_Click);
            // 
            // btn_edit_category
            // 
            this.btn_edit_category.Location = new System.Drawing.Point(733, 59);
            this.btn_edit_category.Name = "btn_edit_category";
            this.btn_edit_category.Size = new System.Drawing.Size(139, 41);
            this.btn_edit_category.TabIndex = 6;
            this.btn_edit_category.Text = "DƏYİŞ";
            this.btn_edit_category.UseVisualStyleBackColor = true;
            this.btn_edit_category.Click += new System.EventHandler(this.btn_edit_category_Click);
            // 
            // btn_delete_category
            // 
            this.btn_delete_category.Location = new System.Drawing.Point(733, 106);
            this.btn_delete_category.Name = "btn_delete_category";
            this.btn_delete_category.Size = new System.Drawing.Size(139, 41);
            this.btn_delete_category.TabIndex = 5;
            this.btn_delete_category.Text = "SİL";
            this.btn_delete_category.UseVisualStyleBackColor = true;
            this.btn_delete_category.Click += new System.EventHandler(this.btn_delete_category_Click);
            // 
            // lv_category
            // 
            this.lv_category.BackColor = System.Drawing.Color.LightGray;
            this.lv_category.Dock = System.Windows.Forms.DockStyle.Left;
            this.lv_category.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lv_category.HideSelection = false;
            this.lv_category.Location = new System.Drawing.Point(0, 0);
            this.lv_category.Name = "lv_category";
            this.lv_category.Size = new System.Drawing.Size(180, 411);
            this.lv_category.TabIndex = 9;
            this.lv_category.UseCompatibleStateImageBehavior = false;
            this.lv_category.View = System.Windows.Forms.View.Details;
            this.lv_category.SelectedIndexChanged += new System.EventHandler(this.lv_category_SelectedIndexChanged);
            // 
            // CategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(884, 411);
            this.Controls.Add(this.lv_category);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_add_category);
            this.Controls.Add(this.btn_edit_category);
            this.Controls.Add(this.btn_delete_category);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CategoryForm";
            this.Text = "KATEQORİYA";
            this.Load += new System.EventHandler(this.CategoryForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_add_category;
        private System.Windows.Forms.Button btn_edit_category;
        private System.Windows.Forms.Button btn_delete_category;
        private System.Windows.Forms.ListView lv_category;
    }
}