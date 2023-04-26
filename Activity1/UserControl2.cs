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
    public partial class UserControl2 : UserControl
    {
        public UserControl2()
        {
            InitializeComponent();
        }

        private void submitBut_Click(object sender, EventArgs e)
        {

            var inputOne = this.input1.Text;
            var inputTwo = this.input2.Text;

            var parent = this.Parent as Form1;

            parent.setData = inputOne;
            parent.setData1 = inputTwo;
        }
    }
}
