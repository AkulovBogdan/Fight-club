using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fight_club
{
    public partial class AuthForm : Form
    {
        public string PlayerName {get;set;}

        public AuthForm()
        {
            InitializeComponent();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (rtbName.Text != "" && rtbName.Text != "Your enemy")
            {
                Name = rtbName.Text;
                DialogResult = DialogResult.OK;
                Close();
            }
            else
                lblBoxEmpty.Visible = true;

        }
    }
}
