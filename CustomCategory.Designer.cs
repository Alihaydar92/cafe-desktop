namespace Cafe
{
    partial class CustomCategory
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
            this.pic_cat = new System.Windows.Forms.PictureBox();
            this.lbl_cat_name = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_cat)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_cat
            // 
            this.pic_cat.Location = new System.Drawing.Point(0, 44);
            this.pic_cat.Name = "pic_cat";
            this.pic_cat.Size = new System.Drawing.Size(117, 86);
            this.pic_cat.TabIndex = 0;
            this.pic_cat.TabStop = false;
            // 
            // lbl_cat_name
            // 
            this.lbl_cat_name.AutoSize = true;
            this.lbl_cat_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_cat_name.Location = new System.Drawing.Point(3, 0);
            this.lbl_cat_name.Name = "lbl_cat_name";
            this.lbl_cat_name.Size = new System.Drawing.Size(80, 20);
            this.lbl_cat_name.TabIndex = 1;
            this.lbl_cat_name.Text = "cat_name";
            // 
            // CustomCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_cat_name);
            this.Controls.Add(this.pic_cat);
            this.Name = "CustomCategory";
            this.Size = new System.Drawing.Size(117, 130);
            ((System.ComponentModel.ISupportInitialize)(this.pic_cat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_cat;
        private System.Windows.Forms.Label lbl_cat_name;
    }
}
