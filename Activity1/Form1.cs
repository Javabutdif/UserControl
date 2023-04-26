using System.Runtime.CompilerServices;

namespace Activity1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }




        private void Form1_Load(object sender, EventArgs e)
        {


            this.userControl11.Visible = false;
            this.userControl21.Visible = false;
        }
        public string setData
        {
            set
            {
                display1.Text = value;
            }
        }
        public string setData1
        {
            set
            {
                display2.Text = value;
            }
        }

        private void panel1But_Click(object sender, EventArgs e)
        {
            this.userControl11.Visible = true;
            this.userControl21.Visible = false;
        }

        private void panel2But_Click(object sender, EventArgs e)
        {
            this.userControl11.Visible = false;
            this.userControl21.Visible = true;
        }
    }
}