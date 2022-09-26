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
    public partial class Add_New_Number : Form
    {
        public Add_New_Number()
        {
            InitializeComponent();
        }

        private void addNumber_button2_Click(object sender, EventArgs e)
        {
            this.addNumber_button2.Enabled = false;
            this.saveChanges_button.Enabled = true;
            this.info_groupbox.Enabled = true;
        }

        private void saveChanges_button_Click(object sender, EventArgs e)
        {
            if( this.textBox1_ID.Text != "")
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
                MessageBox.Show("Phone number saved!!", "Save Changes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please enter an ID", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }
    }
}
