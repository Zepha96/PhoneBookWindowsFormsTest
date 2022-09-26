
namespace PhoneBook
{
    partial class Main_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.newNumber_button1 = new System.Windows.Forms.ToolStripButton();
            this.searchNumber_button = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newNumber_button1,
            this.searchNumber_button});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1031, 60);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // newNumber_button1
            // 
            this.newNumber_button1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.newNumber_button1.Image = ((System.Drawing.Image)(resources.GetObject("newNumber_button1.Image")));
            this.newNumber_button1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newNumber_button1.Name = "newNumber_button1";
            this.newNumber_button1.Size = new System.Drawing.Size(107, 57);
            this.newNumber_button1.Text = "Add New Number";
            this.newNumber_button1.Click += new System.EventHandler(this.newNumber_button1_Click);
            // 
            // searchNumber_button
            // 
            this.searchNumber_button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.searchNumber_button.Image = ((System.Drawing.Image)(resources.GetObject("searchNumber_button.Image")));
            this.searchNumber_button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.searchNumber_button.Name = "searchNumber_button";
            this.searchNumber_button.Size = new System.Drawing.Size(93, 57);
            this.searchNumber_button.Text = "Search Number";
            this.searchNumber_button.Click += new System.EventHandler(this.searchNumber_button_Click);
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 570);
            this.Controls.Add(this.toolStrip1);
            this.IsMdiContainer = true;
            this.Name = "Main_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phone App";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton newNumber_button1;
        private System.Windows.Forms.ToolStripButton searchNumber_button;
    }
}

