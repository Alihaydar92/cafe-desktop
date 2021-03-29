namespace Cafe
{
    partial class CustomFood
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
            this.lbl_food_name = new System.Windows.Forms.Label();
            this.pb_food = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_food)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_food_name
            // 
            this.lbl_food_name.AutoSize = true;
            this.lbl_food_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_food_name.Location = new System.Drawing.Point(3, 0);
            this.lbl_food_name.Name = "lbl_food_name";
            this.lbl_food_name.Size = new System.Drawing.Size(90, 20);
            this.lbl_food_name.TabIndex = 0;
            this.lbl_food_name.Text = "food_name";
            // 
            // pb_food
            // 
            this.pb_food.Location = new System.Drawing.Point(0, 36);
            this.pb_food.Name = "pb_food";
            this.pb_food.Size = new System.Drawing.Size(117, 94);
            this.pb_food.TabIndex = 1;
            this.pb_food.TabStop = false;
            // 
            // CustomFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pb_food);
            this.Controls.Add(this.lbl_food_name);
            this.Name = "CustomFood";
            this.Size = new System.Drawing.Size(117, 130);
            ((System.ComponentModel.ISupportInitialize)(this.pb_food)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_food_name;
        private System.Windows.Forms.PictureBox pb_food;
    }
}
