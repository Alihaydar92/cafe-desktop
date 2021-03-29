namespace Cafe
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menu_main = new System.Windows.Forms.MenuStrip();
            this.menu_strip_add_table = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_strip_add_category = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_strip_add_food = new System.Windows.Forms.ToolStripMenuItem();
            this.hESABATLARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flow_category = new System.Windows.Forms.FlowLayoutPanel();
            this.flow_table = new System.Windows.Forms.FlowLayoutPanel();
            this.flow_food_stuffs = new System.Windows.Forms.FlowLayoutPanel();
            this.dataGridView_total = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel_table = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lbl_table_name = new System.Windows.Forms.Label();
            this.lbl_waiter_name = new System.Windows.Forms.Label();
            this.panel_c = new System.Windows.Forms.Panel();
            this.panel_c_c = new System.Windows.Forms.Panel();
            this.panel_c_top = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel_c_bottom = new System.Windows.Forms.Panel();
            this.btn_close_table = new System.Windows.Forms.Button();
            this.panel_center = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip_open_table = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsm_table = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_category = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel_top = new System.Windows.Forms.Panel();
            this.panel_main = new System.Windows.Forms.Panel();
            this.menu_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_total)).BeginInit();
            this.panel_table.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel_c.SuspendLayout();
            this.panel_c_c.SuspendLayout();
            this.panel_c_top.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel_c_bottom.SuspendLayout();
            this.contextMenuStrip_open_table.SuspendLayout();
            this.panel_category.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu_main
            // 
            this.menu_main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_strip_add_table,
            this.menu_strip_add_category,
            this.menu_strip_add_food,
            this.hESABATLARToolStripMenuItem});
            this.menu_main.Location = new System.Drawing.Point(0, 0);
            this.menu_main.Name = "menu_main";
            this.menu_main.Size = new System.Drawing.Size(1251, 24);
            this.menu_main.TabIndex = 2;
            this.menu_main.Text = "menuStrip1";
            // 
            // menu_strip_add_table
            // 
            this.menu_strip_add_table.Name = "menu_strip_add_table";
            this.menu_strip_add_table.Size = new System.Drawing.Size(66, 20);
            this.menu_strip_add_table.Text = "STOLLAR";
            this.menu_strip_add_table.Click += new System.EventHandler(this.menu_strip_add_table_Click);
            // 
            // menu_strip_add_category
            // 
            this.menu_strip_add_category.Name = "menu_strip_add_category";
            this.menu_strip_add_category.Size = new System.Drawing.Size(108, 20);
            this.menu_strip_add_category.Text = "KATEQORİYALAR";
            this.menu_strip_add_category.Click += new System.EventHandler(this.menu_strip_add_category_Click);
            // 
            // menu_strip_add_food
            // 
            this.menu_strip_add_food.Name = "menu_strip_add_food";
            this.menu_strip_add_food.Size = new System.Drawing.Size(68, 20);
            this.menu_strip_add_food.Text = "QİDALAR";
            this.menu_strip_add_food.Click += new System.EventHandler(this.menu_strip_add_food_Click);
            // 
            // hESABATLARToolStripMenuItem
            // 
            this.hESABATLARToolStripMenuItem.Name = "hESABATLARToolStripMenuItem";
            this.hESABATLARToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.hESABATLARToolStripMenuItem.Text = "HESABATLAR";
            // 
            // flow_category
            // 
            this.flow_category.AutoScroll = true;
            this.flow_category.AutoSize = true;
            this.flow_category.BackColor = System.Drawing.SystemColors.Window;
            this.flow_category.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("flow_category.BackgroundImage")));
            this.flow_category.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flow_category.Location = new System.Drawing.Point(0, 24);
            this.flow_category.MinimumSize = new System.Drawing.Size(100, 100);
            this.flow_category.Name = "flow_category";
            this.flow_category.Size = new System.Drawing.Size(273, 629);
            this.flow_category.TabIndex = 4;
            // 
            // flow_table
            // 
            this.flow_table.AutoScroll = true;
            this.flow_table.BackColor = System.Drawing.Color.White;
            this.flow_table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flow_table.Location = new System.Drawing.Point(0, 24);
            this.flow_table.Name = "flow_table";
            this.flow_table.Size = new System.Drawing.Size(236, 629);
            this.flow_table.TabIndex = 6;
            // 
            // flow_food_stuffs
            // 
            this.flow_food_stuffs.AutoScroll = true;
            this.flow_food_stuffs.AutoSize = true;
            this.flow_food_stuffs.BackColor = System.Drawing.SystemColors.Window;
            this.flow_food_stuffs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flow_food_stuffs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flow_food_stuffs.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flow_food_stuffs.Location = new System.Drawing.Point(0, 0);
            this.flow_food_stuffs.MinimumSize = new System.Drawing.Size(100, 100);
            this.flow_food_stuffs.Name = "flow_food_stuffs";
            this.flow_food_stuffs.Size = new System.Drawing.Size(742, 336);
            this.flow_food_stuffs.TabIndex = 7;
            // 
            // dataGridView_total
            // 
            this.dataGridView_total.AllowUserToAddRows = false;
            this.dataGridView_total.AllowUserToDeleteRows = false;
            this.dataGridView_total.AllowUserToResizeColumns = false;
            this.dataGridView_total.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_total.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_total.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_total.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnDelete});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_total.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_total.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_total.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_total.Name = "dataGridView_total";
            this.dataGridView_total.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_total.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_total.RowHeadersVisible = false;
            this.dataGridView_total.Size = new System.Drawing.Size(742, 236);
            this.dataGridView_total.TabIndex = 8;
            this.dataGridView_total.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_total_CellContentClick);
            // 
            // btnDelete
            // 
            this.btnDelete.HeaderText = "Əməliyyat";
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnDelete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseColumnTextForButtonValue = true;
            this.btnDelete.Width = 60;
            // 
            // panel_table
            // 
            this.panel_table.BackColor = System.Drawing.SystemColors.Window;
            this.panel_table.Controls.Add(this.flow_table);
            this.panel_table.Controls.Add(this.panel6);
            this.panel_table.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_table.Location = new System.Drawing.Point(0, 0);
            this.panel_table.Name = "panel_table";
            this.panel_table.Size = new System.Drawing.Size(236, 653);
            this.panel_table.TabIndex = 9;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.lbl_table_name);
            this.panel6.Controls.Add(this.lbl_waiter_name);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(236, 24);
            this.panel6.TabIndex = 7;
            // 
            // lbl_table_name
            // 
            this.lbl_table_name.AutoSize = true;
            this.lbl_table_name.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbl_table_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_table_name.Location = new System.Drawing.Point(0, 0);
            this.lbl_table_name.Name = "lbl_table_name";
            this.lbl_table_name.Size = new System.Drawing.Size(112, 24);
            this.lbl_table_name.TabIndex = 7;
            this.lbl_table_name.Text = "Seçilməyib";
            // 
            // lbl_waiter_name
            // 
            this.lbl_waiter_name.AutoSize = true;
            this.lbl_waiter_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_waiter_name.Location = new System.Drawing.Point(121, 0);
            this.lbl_waiter_name.Name = "lbl_waiter_name";
            this.lbl_waiter_name.Size = new System.Drawing.Size(112, 24);
            this.lbl_waiter_name.TabIndex = 8;
            this.lbl_waiter_name.Text = "Seçilməyib";
            // 
            // panel_c
            // 
            this.panel_c.BackColor = System.Drawing.SystemColors.Window;
            this.panel_c.Controls.Add(this.panel_c_c);
            this.panel_c.Controls.Add(this.panel_c_top);
            this.panel_c.Controls.Add(this.panel3);
            this.panel_c.Controls.Add(this.panel_c_bottom);
            this.panel_c.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_c.Location = new System.Drawing.Point(509, 0);
            this.panel_c.Name = "panel_c";
            this.panel_c.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel_c.Size = new System.Drawing.Size(742, 653);
            this.panel_c.TabIndex = 10;
            // 
            // panel_c_c
            // 
            this.panel_c_c.Controls.Add(this.dataGridView_total);
            this.panel_c_c.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_c_c.Location = new System.Drawing.Point(0, 360);
            this.panel_c_c.Name = "panel_c_c";
            this.panel_c_c.Size = new System.Drawing.Size(742, 236);
            this.panel_c_c.TabIndex = 15;
            // 
            // panel_c_top
            // 
            this.panel_c_top.Controls.Add(this.flow_food_stuffs);
            this.panel_c_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_c_top.Location = new System.Drawing.Point(0, 24);
            this.panel_c_top.Name = "panel_c_top";
            this.panel_c_top.Size = new System.Drawing.Size(742, 336);
            this.panel_c_top.TabIndex = 14;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(742, 24);
            this.panel3.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "QİDA SİYAHISI";
            // 
            // panel_c_bottom
            // 
            this.panel_c_bottom.Controls.Add(this.btn_close_table);
            this.panel_c_bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_c_bottom.Location = new System.Drawing.Point(0, 596);
            this.panel_c_bottom.Name = "panel_c_bottom";
            this.panel_c_bottom.Size = new System.Drawing.Size(742, 57);
            this.panel_c_bottom.TabIndex = 9;
            // 
            // btn_close_table
            // 
            this.btn_close_table.Location = new System.Drawing.Point(346, 9);
            this.btn_close_table.Name = "btn_close_table";
            this.btn_close_table.Size = new System.Drawing.Size(116, 36);
            this.btn_close_table.TabIndex = 9;
            this.btn_close_table.Text = "Stolu bağla";
            this.btn_close_table.UseVisualStyleBackColor = true;
            this.btn_close_table.Click += new System.EventHandler(this.btn_close_table_Click);
            // 
            // panel_center
            // 
            this.panel_center.BackColor = System.Drawing.SystemColors.Window;
            this.panel_center.Location = new System.Drawing.Point(236, 280);
            this.panel_center.Name = "panel_center";
            this.panel_center.Size = new System.Drawing.Size(302, 397);
            this.panel_center.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "KATEQORİYA SİYAHISI";
            // 
            // contextMenuStrip_open_table
            // 
            this.contextMenuStrip_open_table.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_table});
            this.contextMenuStrip_open_table.Name = "contextMenuStrip_open_table";
            this.contextMenuStrip_open_table.Size = new System.Drawing.Size(117, 26);
            this.contextMenuStrip_open_table.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip_open_table_Opening);
            // 
            // tsm_table
            // 
            this.tsm_table.Name = "tsm_table";
            this.tsm_table.Size = new System.Drawing.Size(116, 22);
            this.tsm_table.Text = "Stolu aç";
            this.tsm_table.Click += new System.EventHandler(this.tsm_table_Click);
            // 
            // panel_category
            // 
            this.panel_category.BackColor = System.Drawing.SystemColors.Window;
            this.panel_category.Controls.Add(this.flow_category);
            this.panel_category.Controls.Add(this.panel4);
            this.panel_category.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_category.Location = new System.Drawing.Point(236, 0);
            this.panel_category.Name = "panel_category";
            this.panel_category.Size = new System.Drawing.Size(273, 653);
            this.panel_category.TabIndex = 7;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(273, 24);
            this.panel4.TabIndex = 0;
            // 
            // panel_top
            // 
            this.panel_top.Location = new System.Drawing.Point(0, 24);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(236, 33);
            this.panel_top.TabIndex = 15;
            // 
            // panel_main
            // 
            this.panel_main.Controls.Add(this.panel_c);
            this.panel_main.Controls.Add(this.panel_category);
            this.panel_main.Controls.Add(this.panel_table);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(0, 24);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(1251, 653);
            this.panel_main.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1251, 677);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.panel_top);
            this.Controls.Add(this.panel_center);
            this.Controls.Add(this.menu_main);
            this.MainMenuStrip = this.menu_main;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menu_main.ResumeLayout(false);
            this.menu_main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_total)).EndInit();
            this.panel_table.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel_c.ResumeLayout(false);
            this.panel_c_c.ResumeLayout(false);
            this.panel_c_top.ResumeLayout(false);
            this.panel_c_top.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel_c_bottom.ResumeLayout(false);
            this.contextMenuStrip_open_table.ResumeLayout(false);
            this.panel_category.ResumeLayout(false);
            this.panel_category.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel_main.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menu_main;
        private System.Windows.Forms.ToolStripMenuItem menu_strip_add_category;
        private System.Windows.Forms.ToolStripMenuItem menu_strip_add_food;
        private System.Windows.Forms.FlowLayoutPanel flow_category;
        private System.Windows.Forms.ToolStripMenuItem menu_strip_add_table;
        private System.Windows.Forms.FlowLayoutPanel flow_table;
        private System.Windows.Forms.FlowLayoutPanel flow_food_stuffs;
        private System.Windows.Forms.DataGridView dataGridView_total;
        private System.Windows.Forms.Panel panel_table;
        private System.Windows.Forms.Panel panel_c;
        private System.Windows.Forms.Panel panel_center;
        private System.Windows.Forms.Panel panel_c_top;
        private System.Windows.Forms.ToolStripMenuItem hESABATLARToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewButtonColumn btnDelete;
        private System.Windows.Forms.Button btn_close_table;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_open_table;
        private System.Windows.Forms.ToolStripMenuItem tsm_table;
        private System.Windows.Forms.Label lbl_table_name;
        private System.Windows.Forms.Label lbl_waiter_name;
        private System.Windows.Forms.Panel panel_category;
        private System.Windows.Forms.Panel panel_c_bottom;
        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.Panel panel_c_c;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel4;
    }
}

