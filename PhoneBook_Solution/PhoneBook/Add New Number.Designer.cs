
namespace PhoneBook
{
    partial class Add_New_Number
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_New_Number));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.addNumber_button2 = new System.Windows.Forms.ToolStripButton();
            this.saveChanges_button = new System.Windows.Forms.ToolStripButton();
            this.info_groupbox = new System.Windows.Forms.GroupBox();
            this.label_id = new System.Windows.Forms.Label();
            this.label_FirstName = new System.Windows.Forms.Label();
            this.label_LastName = new System.Windows.Forms.Label();
            this.label_tel = new System.Windows.Forms.Label();
            this.label_email = new System.Windows.Forms.Label();
            this.label_comment = new System.Windows.Forms.Label();
            this.textBox1_ID = new System.Windows.Forms.TextBox();
            this.textBox2_FirstName = new System.Windows.Forms.TextBox();
            this.textBox3_LastName = new System.Windows.Forms.TextBox();
            this.textBox4_Tel = new System.Windows.Forms.TextBox();
            this.textBox5_Email = new System.Windows.Forms.TextBox();
            this.textBox6_Comment = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            this.info_groupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNumber_button2,
            this.saveChanges_button});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(365, 75);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // addNumber_button2
            // 
            this.addNumber_button2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.addNumber_button2.Image = ((System.Drawing.Image)(resources.GetObject("addNumber_button2.Image")));
            this.addNumber_button2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addNumber_button2.Name = "addNumber_button2";
            this.addNumber_button2.Size = new System.Drawing.Size(80, 72);
            this.addNumber_button2.Text = "Add Number";
            this.addNumber_button2.Click += new System.EventHandler(this.addNumber_button2_Click);
            // 
            // saveChanges_button
            // 
            this.saveChanges_button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.saveChanges_button.Enabled = false;
            this.saveChanges_button.Image = ((System.Drawing.Image)(resources.GetObject("saveChanges_button.Image")));
            this.saveChanges_button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveChanges_button.Name = "saveChanges_button";
            this.saveChanges_button.Size = new System.Drawing.Size(84, 72);
            this.saveChanges_button.Text = "Save Changes";
            this.saveChanges_button.Click += new System.EventHandler(this.saveChanges_button_Click);
            // 
            // info_groupbox
            // 
            this.info_groupbox.Controls.Add(this.textBox6_Comment);
            this.info_groupbox.Controls.Add(this.textBox5_Email);
            this.info_groupbox.Controls.Add(this.textBox4_Tel);
            this.info_groupbox.Controls.Add(this.textBox3_LastName);
            this.info_groupbox.Controls.Add(this.textBox2_FirstName);
            this.info_groupbox.Controls.Add(this.textBox1_ID);
            this.info_groupbox.Controls.Add(this.label_comment);
            this.info_groupbox.Controls.Add(this.label_email);
            this.info_groupbox.Controls.Add(this.label_tel);
            this.info_groupbox.Controls.Add(this.label_LastName);
            this.info_groupbox.Controls.Add(this.label_FirstName);
            this.info_groupbox.Controls.Add(this.label_id);
            this.info_groupbox.Enabled = false;
            this.info_groupbox.Location = new System.Drawing.Point(12, 78);
            this.info_groupbox.Name = "info_groupbox";
            this.info_groupbox.Size = new System.Drawing.Size(344, 270);
            this.info_groupbox.TabIndex = 1;
            this.info_groupbox.TabStop = false;
            this.info_groupbox.Text = "Information";
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Location = new System.Drawing.Point(7, 72);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(21, 13);
            this.label_id.TabIndex = 0;
            this.label_id.Text = "ID:";
            // 
            // label_FirstName
            // 
            this.label_FirstName.AutoSize = true;
            this.label_FirstName.Location = new System.Drawing.Point(6, 98);
            this.label_FirstName.Name = "label_FirstName";
            this.label_FirstName.Size = new System.Drawing.Size(60, 13);
            this.label_FirstName.TabIndex = 1;
            this.label_FirstName.Text = "First Name:";
            // 
            // label_LastName
            // 
            this.label_LastName.AutoSize = true;
            this.label_LastName.Location = new System.Drawing.Point(7, 124);
            this.label_LastName.Name = "label_LastName";
            this.label_LastName.Size = new System.Drawing.Size(61, 13);
            this.label_LastName.TabIndex = 2;
            this.label_LastName.Text = "Last Name:";
            // 
            // label_tel
            // 
            this.label_tel.AutoSize = true;
            this.label_tel.Location = new System.Drawing.Point(6, 150);
            this.label_tel.Name = "label_tel";
            this.label_tel.Size = new System.Drawing.Size(25, 13);
            this.label_tel.TabIndex = 3;
            this.label_tel.Text = "Tel:";
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.Location = new System.Drawing.Point(7, 176);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(35, 13);
            this.label_email.TabIndex = 4;
            this.label_email.Text = "Email:";
            // 
            // label_comment
            // 
            this.label_comment.AutoSize = true;
            this.label_comment.Location = new System.Drawing.Point(7, 202);
            this.label_comment.Name = "label_comment";
            this.label_comment.Size = new System.Drawing.Size(54, 13);
            this.label_comment.TabIndex = 5;
            this.label_comment.Text = "Comment:";
            // 
            // textBox1_ID
            // 
            this.textBox1_ID.Location = new System.Drawing.Point(71, 69);
            this.textBox1_ID.Name = "textBox1_ID";
            this.textBox1_ID.Size = new System.Drawing.Size(253, 20);
            this.textBox1_ID.TabIndex = 6;
            // 
            // textBox2_FirstName
            // 
            this.textBox2_FirstName.Location = new System.Drawing.Point(71, 95);
            this.textBox2_FirstName.Name = "textBox2_FirstName";
            this.textBox2_FirstName.Size = new System.Drawing.Size(253, 20);
            this.textBox2_FirstName.TabIndex = 7;
            // 
            // textBox3_LastName
            // 
            this.textBox3_LastName.Location = new System.Drawing.Point(71, 121);
            this.textBox3_LastName.Name = "textBox3_LastName";
            this.textBox3_LastName.Size = new System.Drawing.Size(253, 20);
            this.textBox3_LastName.TabIndex = 8;
            // 
            // textBox4_Tel
            // 
            this.textBox4_Tel.Location = new System.Drawing.Point(71, 147);
            this.textBox4_Tel.Name = "textBox4_Tel";
            this.textBox4_Tel.Size = new System.Drawing.Size(253, 20);
            this.textBox4_Tel.TabIndex = 9;
            // 
            // textBox5_Email
            // 
            this.textBox5_Email.Location = new System.Drawing.Point(71, 173);
            this.textBox5_Email.Name = "textBox5_Email";
            this.textBox5_Email.Size = new System.Drawing.Size(253, 20);
            this.textBox5_Email.TabIndex = 10;
            // 
            // textBox6_Comment
            // 
            this.textBox6_Comment.Location = new System.Drawing.Point(71, 199);
            this.textBox6_Comment.Name = "textBox6_Comment";
            this.textBox6_Comment.Size = new System.Drawing.Size(253, 20);
            this.textBox6_Comment.TabIndex = 11;
            // 
            // Add_New_Number
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 363);
            this.Controls.Add(this.info_groupbox);
            this.Controls.Add(this.toolStrip1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Add_New_Number";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Number";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.info_groupbox.ResumeLayout(false);
            this.info_groupbox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton addNumber_button2;
        private System.Windows.Forms.GroupBox info_groupbox;
        private System.Windows.Forms.TextBox textBox6_Comment;
        private System.Windows.Forms.TextBox textBox5_Email;
        private System.Windows.Forms.TextBox textBox4_Tel;
        private System.Windows.Forms.TextBox textBox3_LastName;
        private System.Windows.Forms.TextBox textBox2_FirstName;
        private System.Windows.Forms.TextBox textBox1_ID;
        private System.Windows.Forms.Label label_comment;
        private System.Windows.Forms.Label label_email;
        private System.Windows.Forms.Label label_tel;
        private System.Windows.Forms.Label label_LastName;
        private System.Windows.Forms.Label label_FirstName;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.ToolStripButton saveChanges_button;
    }
}