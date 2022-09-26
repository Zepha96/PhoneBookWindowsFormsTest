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
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
        }

        private void newNumber_button1_Click(object sender, EventArgs e)
        {
            Add_New_Number addData = new Add_New_Number();
            addData.MdiParent = this;
            //addData.Show();
            var form = Application.OpenForms["Add_New_Number"] ;
            if(form == null)
            {
                addData.Show();
            }
            else
            {
                MessageBox.Show("Form is already Open", "Error");
            }
        }

        private void searchNumber_button_Click(object sender, EventArgs e)
        {
            Search_Number searchNumber = new Search_Number();
            searchNumber.MdiParent = this;
            //searchNumber.Show();
            var form = Application.OpenForms["Search_Number"];
            if (form == null)
            {
                searchNumber.Show();
            }
            else
            {
                MessageBox_Error("You can only search 1 item at a time");
            }

        }

        public void MessageBox_Error(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
