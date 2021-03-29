namespace Cafe
{
    partial class CustomTable
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomTable));
            this.lbl_total = new System.Windows.Forms.Label();
            this.lbl_table_name = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Location = new System.Drawing.Point(4, 68);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(34, 13);
            this.lbl_total.TabIndex = 1;
            this.lbl_total.Text = "CƏM:";
            // 
            // lbl_table_name
            // 
            this.lbl_table_name.AutoSize = true;
            this.lbl_table_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_table_name.Location = new System.Drawing.Point(3, 3);
            this.lbl_table_name.Name = "lbl_table_name";
            this.lbl_table_name.Size = new System.Drawing.Size(51, 20);
            this.lbl_table_name.TabIndex = 4;
            this.lbl_table_name.Text = "label1";
            // 
            // CustomTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.lbl_table_name);
            this.Controls.Add(this.lbl_total);
            this.Name = "CustomTable";
            this.Size = new System.Drawing.Size(96, 95);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Label lbl_table_name;
    }
}
