using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity1
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }
        private string name;
        private string name1;

     
        private void submit_Click(object sender, EventArgs e)
        {
            var input12 = this.input1.Text;
            var input2 = this.input2.Text;

            var parent = this.Parent as Form1;
            parent.setData = input12;
            parent.setData1 = input2;

        }
    }
}
