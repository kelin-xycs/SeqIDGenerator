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
                string[] ids = new string[10];

                for (int i=0; i<10; i++)
                {
                    ids[i] = SeqID.New();
                }

                //  把 产生 ID 和 WriteMsg() 分开， 是因为 WriteMsg() 是 窗口操作， 比较慢， 可能超过 1毫秒， 
                //  这样就看不出来 1毫秒 内 ID 尾数序号 的 递增
                for (int i = 0; i < 10; i++)
                {
                    WriteMsg(ids[i]);
                }
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
