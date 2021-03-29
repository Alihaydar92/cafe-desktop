namespace Cafe.Forms
{
    partial class TableForm1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TableForm1));
            this.btn_delete_table = new System.Windows.Forms.Button();
            this.btn_edit_table = new System.Windows.Forms.Button();
            this.btn_add_table = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.lv_table = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // btn_delete_table
            // 
            this.btn_delete_table.Location = new System.Drawing.Point(733, 106);
            this.btn_delete_table.Name = "btn_delete_table";
            this.btn_delete_table.Size = new System.Drawing.Size(139, 41);
            this.btn_delete_table.TabIndex = 1;
            this.btn_delete_table.Text = "SİL";
            this.btn_delete_table.UseVisualStyleBackColor = true;
            this.btn_delete_table.Click += new System.EventHandler(this.btn_delete_table_Click);
            // 
            // btn_edit_table
            // 
            this.btn_edit_table.Location = new System.Drawing.Point(733, 59);
            this.btn_edit_table.Name = "btn_edit_table";
            this.btn_edit_table.Size = new System.Drawing.Size(139, 41);
            this.btn_edit_table.TabIndex = 2;
            this.btn_edit_table.Text = "DƏYİŞ";
            this.btn_edit_table.UseVisualStyleBackColor = true;
            this.btn_edit_table.Click += new System.EventHandler(this.btn_edit_table_Click);
            // 
            // btn_add_table
            // 
            this.btn_add_table.Location = new System.Drawing.Point(733, 12);
            this.btn_add_table.Name = "btn_add_table";
            this.btn_add_table.Size = new System.Drawing.Size(139, 41);
            this.btn_add_table.TabIndex = 3;
            this.btn_add_table.Text = "ƏLAVƏ ET";
            this.btn_add_table.UseVisualStyleBackColor = true;
            this.btn_add_table.Click += new System.EventHandler(this.btn_add_table_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(733, 358);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(139, 41);
            this.btn_cancel.TabIndex = 4;
            this.btn_cancel.Text = "BAĞLA";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // lv_table
            // 
            this.lv_table.Dock = System.Windows.Forms.DockStyle.Left;
            this.lv_table.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_table.HideSelection = false;
            this.lv_table.Location = new System.Drawing.Point(0, 0);
            this.lv_table.Name = "lv_table";
            this.lv_table.Size = new System.Drawing.Size(174, 411);
            this.lv_table.TabIndex = 5;
            this.lv_table.UseCompatibleStateImageBehavior = false;
            this.lv_table.View = System.Windows.Forms.View.Details;
            this.lv_table.SelectedIndexChanged += new System.EventHandler(this.lv_table_SelectedIndexChanged);
            // 
            // TableForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(884, 411);
            this.Controls.Add(this.lv_table);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_add_table);
            this.Controls.Add(this.btn_edit_table);
            this.Controls.Add(this.btn_delete_table);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TableForm1";
            this.Text = "STOL";
            this.Load += new System.EventHandler(this.TableForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_delete_table;
        private System.Windows.Forms.Button btn_edit_table;
        private System.Windows.Forms.Button btn_add_table;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.ListView lv_table;
    }
}