namespace WindowsFormsApplication1
{
    partial class admin_main
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addMobileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewMobileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewManuallyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateMobileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateFromTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateManuallyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteMobileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.menuStrip1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(683, 414);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Main";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(613, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(61, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Log Out";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(190, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(269, 26);
            this.label7.TabIndex = 15;
            this.label7.Text = "Mobile Inventory System";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.Location = new System.Drawing.Point(586, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "(Admin Panel)";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainToolStripMenuItem,
            this.addMobileToolStripMenuItem,
            this.viewMobileToolStripMenuItem,
            this.updateMobileToolStripMenuItem,
            this.deleteMobileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 18);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(677, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mainToolStripMenuItem
            // 
            this.mainToolStripMenuItem.Name = "mainToolStripMenuItem";
            this.mainToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.mainToolStripMenuItem.Text = "Main";
            // 
            // addMobileToolStripMenuItem
            // 
            this.addMobileToolStripMenuItem.Name = "addMobileToolStripMenuItem";
            this.addMobileToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.addMobileToolStripMenuItem.Text = "Add Mobile";
            this.addMobileToolStripMenuItem.Click += new System.EventHandler(this.addMobileToolStripMenuItem_Click);
            // 
            // viewMobileToolStripMenuItem
            // 
            this.viewMobileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewAllToolStripMenuItem,
            this.viewManuallyToolStripMenuItem});
            this.viewMobileToolStripMenuItem.Name = "viewMobileToolStripMenuItem";
            this.viewMobileToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.viewMobileToolStripMenuItem.Text = "View Mobile";
            // 
            // viewAllToolStripMenuItem
            // 
            this.viewAllToolStripMenuItem.Name = "viewAllToolStripMenuItem";
            this.viewAllToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.viewAllToolStripMenuItem.Text = "View All";
            this.viewAllToolStripMenuItem.Click += new System.EventHandler(this.viewAllToolStripMenuItem_Click_2);
            // 
            // viewManuallyToolStripMenuItem
            // 
            this.viewManuallyToolStripMenuItem.Name = "viewManuallyToolStripMenuItem";
            this.viewManuallyToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.viewManuallyToolStripMenuItem.Text = "View Manually";
            this.viewManuallyToolStripMenuItem.Click += new System.EventHandler(this.viewManuallyToolStripMenuItem_Click_1);
            // 
            // updateMobileToolStripMenuItem
            // 
            this.updateMobileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateFromTableToolStripMenuItem,
            this.updateManuallyToolStripMenuItem});
            this.updateMobileToolStripMenuItem.Name = "updateMobileToolStripMenuItem";
            this.updateMobileToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.updateMobileToolStripMenuItem.Text = "Update Mobile";
            // 
            // updateFromTableToolStripMenuItem
            // 
            this.updateFromTableToolStripMenuItem.Name = "updateFromTableToolStripMenuItem";
            this.updateFromTableToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.updateFromTableToolStripMenuItem.Text = "Update From Table";
            this.updateFromTableToolStripMenuItem.Click += new System.EventHandler(this.updateFromTableToolStripMenuItem_Click);
            // 
            // updateManuallyToolStripMenuItem
            // 
            this.updateManuallyToolStripMenuItem.Name = "updateManuallyToolStripMenuItem";
            this.updateManuallyToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.updateManuallyToolStripMenuItem.Text = "Update Manually";
            this.updateManuallyToolStripMenuItem.Click += new System.EventHandler(this.updateManuallyToolStripMenuItem_Click);
            // 
            // deleteMobileToolStripMenuItem
            // 
            this.deleteMobileToolStripMenuItem.Name = "deleteMobileToolStripMenuItem";
            this.deleteMobileToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.deleteMobileToolStripMenuItem.Text = "Delete Mobile";
            this.deleteMobileToolStripMenuItem.Click += new System.EventHandler(this.deleteMobileToolStripMenuItem_Click);
            // 
            // admin_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(689, 423);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "admin_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.admin_main_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mainToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addMobileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewMobileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewManuallyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateMobileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateFromTableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateManuallyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteMobileToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;

    }
}