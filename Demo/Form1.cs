using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using SeqIDGenerator;

namespace Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenID_Click(object sender, EventArgs e)
        {
            try
            {
                string id = SeqID.New();

                WriteMsg(id);
            }
            catch(Exception ex)
            {
                WriteMsg(ex.ToString());
            }
        }

        private void WriteMsg(string msg)
        {
            txtMsg.AppendText(msg + "\r\n\r\n");
        }
    }
}
