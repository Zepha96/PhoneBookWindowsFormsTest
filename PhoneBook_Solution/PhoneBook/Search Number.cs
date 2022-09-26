using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneBook
{
    public partial class Search_Number : Form
    {
        public Search_Number()
        {
            InitializeComponent();
        }

        private void saveChanges_button_Click(object sender, EventArgs e)
        {
            if (this.textBox1_ID.Text != "")
            {
                string originalPath;
                originalPath = "D:\\PhoneBookNumbers\\";
                //------------Create ID Directory------------
                System.IO.Directory.CreateDirectory(originalPath + this.textBox1_ID.Text.ToString());
                string fullPath;
                fullPath = originalPath + this.textBox1_ID.Text.ToString() + "\\";

                //-------------First Name--------------------
                System.IO.File.WriteAllText(fullPath + "First Name.txt", this.textBox2_FirstName.Text, Encoding.UTF8);

                //-------------Last Name---------------------
                System.IO.File.WriteAllText(fullPath + "Last Name.txt", this.textBox3_LastName.Text, Encoding.UTF8);

                //-------------Tel---------------------------
                System.IO.File.WriteAllText(fullPath + "Tel.txt", this.textBox4_Tel.Text, Encoding.UTF8);

                //-------------Email-------------------------
                System.IO.File.WriteAllText(fullPath + "Email.txt", this.textBox5_Email.Text, Encoding.UTF8);

                //-------------Comment-----------------------
                System.IO.File.WriteAllText(fullPath + "Comment.txt", this.textBox6_Comment.Text, Encoding.UTF8);
                //-------------------------------------------

                this.Close();
                MessageBox.Show("Changes to phone number saved!!", "Save Changes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please enter an ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SearchNumber_button_Click(object sender, EventArgs e)
        {
            if(textBox1_ID.Text != "")
            {
                this.changeDetails_button.Enabled = true;
                string originalPath;
                originalPath = "D:\\PhoneBookNumbers\\";
                string fullPath;
                fullPath = originalPath + this.textBox1_ID.Text.ToString() + "\\";

                if(System.IO.Directory.Exists(fullPath) == true)
                {
                    string read;
                    //-------------First Name--------------------
                    read = System.IO.File.ReadAllText(fullPath + "First Name.txt", Encoding.UTF8);
                    this.textBox2_FirstName.Text = read;
                    //-------------Last Name---------------------
                    read = System.IO.File.ReadAllText(fullPath + "Last Name.txt", Encoding.UTF8);
                    this.textBox3_LastName.Text = read;
                    //-------------Tel---------------------------
                    read = System.IO.File.ReadAllText(fullPath + "Tel.txt", Encoding.UTF8);
                    this.textBox4_Tel.Text = read;
                    //-------------Email-------------------------
                    read = System.IO.File.ReadAllText(fullPath + "Email.txt", Encoding.UTF8);
                    this.textBox5_Email.Text = read;
                    //-------------Comment-----------------------
                    read = System.IO.File.ReadAllText(fullPath + "Comment.txt", Encoding.UTF8);
                    this.textBox6_Comment.Text = read;
                    //-------------------------------------------
                }
                else
                {
                    MessageBox.Show("ID Not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            else
            {
                MessageBox.Show("Please enter an ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void changeDetails_button_Click(object sender, EventArgs e)
        {
            this.textBox1_ID.Enabled = false;
            this.saveChanges_button.Enabled = true;
            this.textBox2_FirstName.ReadOnly = false;
            this.textBox3_LastName.ReadOnly = false;
            this.textBox4_Tel.ReadOnly = false;
            this.textBox5_Email.ReadOnly = false;
            this.textBox6_Comment.ReadOnly = false;
        }
    }
}
