namespace Cafe.Forms
{
    partial class FoodStuffForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FoodStuffForm));
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_add_food = new System.Windows.Forms.Button();
            this.btn_edit_food = new System.Windows.Forms.Button();
            this.btn_delete_food = new System.Windows.Forms.Button();
            this.dgv_food = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_food)).BeginInit();
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
            // btn_add_food
            // 
            this.btn_add_food.Location = new System.Drawing.Point(733, 12);
            this.btn_add_food.Name = "btn_add_food";
            this.btn_add_food.Size = new System.Drawing.Size(139, 41);
            this.btn_add_food.TabIndex = 7;
            this.btn_add_food.Text = "ƏLAVƏ ET";
            this.btn_add_food.UseVisualStyleBackColor = true;
            this.btn_add_food.Click += new System.EventHandler(this.btn_add_food_Click);
            // 
            // btn_edit_food
            // 
            this.btn_edit_food.Location = new System.Drawing.Point(733, 59);
            this.btn_edit_food.Name = "btn_edit_food";
            this.btn_edit_food.Size = new System.Drawing.Size(139, 41);
            this.btn_edit_food.TabIndex = 6;
            this.btn_edit_food.Text = "DƏYİŞ";
            this.btn_edit_food.UseVisualStyleBackColor = true;
            this.btn_edit_food.Click += new System.EventHandler(this.btn_edit_food_Click);
            // 
            // btn_delete_food
            // 
            this.btn_delete_food.Location = new System.Drawing.Point(733, 106);
            this.btn_delete_food.Name = "btn_delete_food";
            this.btn_delete_food.Size = new System.Drawing.Size(139, 41);
            this.btn_delete_food.TabIndex = 5;
            this.btn_delete_food.Text = "SİL";
            this.btn_delete_food.UseVisualStyleBackColor = true;
            this.btn_delete_food.Click += new System.EventHandler(this.btn_delete_food_Click);
            // 
            // dgv_food
            // 
            this.dgv_food.AllowUserToAddRows = false;
            this.dgv_food.AllowUserToDeleteRows = false;
            this.dgv_food.AllowUserToResizeRows = false;
            this.dgv_food.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_food.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_food.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_food.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_food.Location = new System.Drawing.Point(0, 0);
            this.dgv_food.MultiSelect = false;
            this.dgv_food.Name = "dgv_food";
            this.dgv_food.ReadOnly = true;
            this.dgv_food.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_food.RowHeadersVisible = false;
            this.dgv_food.Size = new System.Drawing.Size(532, 411);
            this.dgv_food.TabIndex = 9;
            this.dgv_food.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_food_CellClick);
            // 
            // FoodStuffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(884, 411);
            this.Controls.Add(this.dgv_food);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_add_food);
            this.Controls.Add(this.btn_edit_food);
            this.Controls.Add(this.btn_delete_food);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FoodStuffForm";
            this.Text = "QiDA";
            this.Load += new System.EventHandler(this.FoodStuffForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_food)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_add_food;
        private System.Windows.Forms.Button btn_edit_food;
        private System.Windows.Forms.Button btn_delete_food;
        private System.Windows.Forms.DataGridView dgv_food;
    }
}