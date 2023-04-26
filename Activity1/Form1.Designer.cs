namespace Activity1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            panel2But = new Button();
            panel1But = new Button();
            panel2 = new Panel();
            display2 = new TextBox();
            label4 = new Label();
            display1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            userControl11 = new UserControl1();
            userControl21 = new UserControl2();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2But);
            panel1.Controls.Add(panel1But);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(162, 341);
            panel1.TabIndex = 0;
            // 
            // panel2But
            // 
            panel2But.Location = new Point(51, 164);
            panel2But.Name = "panel2But";
            panel2But.Size = new Size(75, 23);
            panel2But.TabIndex = 1;
            panel2But.Text = "Panel Two";
            panel2But.UseVisualStyleBackColor = true;
            panel2But.Click += panel2But_Click;
            // 
            // panel1But
            // 
            panel1But.Location = new Point(51, 109);
            panel1But.Name = "panel1But";
            panel1But.Size = new Size(75, 23);
            panel1But.TabIndex = 0;
            panel1But.Text = "Panel One";
            panel1But.UseVisualStyleBackColor = true;
            panel1But.Click += panel1But_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(display2);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(display1);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(539, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(182, 341);
            panel2.TabIndex = 1;
            // 
            // display2
            // 
            display2.Location = new Point(16, 165);
            display2.Name = "display2";
            display2.Size = new Size(154, 23);
            display2.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 141);
            label4.Name = "label4";
            label4.Size = new Size(65, 15);
            label4.TabIndex = 6;
            label4.Text = "Input Two: ";
            // 
            // display1
            // 
            display1.Location = new Point(16, 109);
            display1.Name = "display1";
            display1.Size = new Size(154, 23);
            display1.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 85);
            label3.Name = "label3";
            label3.Size = new Size(66, 15);
            label3.TabIndex = 4;
            label3.Text = "Input One: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(16, 33);
            label2.Name = "label2";
            label2.Size = new Size(55, 25);
            label2.TabIndex = 3;
            label2.Text = "Data:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(168, 9);
            label1.Name = "label1";
            label1.Size = new Size(270, 25);
            label1.TabIndex = 2;
            label1.Text = "User Control Panel Application";
            // 
            // userControl11
            // 
            userControl11.BackColor = Color.Moccasin;
            userControl11.Location = new Point(168, 37);
            userControl11.Name = "userControl11";
            userControl11.Size = new Size(365, 304);
            userControl11.TabIndex = 3;
            // 
            // userControl21
            // 
            userControl21.BackColor = Color.Moccasin;
            userControl21.Location = new Point(168, 37);
            userControl21.Name = "userControl21";
            userControl21.Size = new Size(365, 304);
            userControl21.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(721, 341);
            Controls.Add(userControl21);
            Controls.Add(userControl11);
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button panel2But;
        private Button panel1But;
        private Panel panel2;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private UserControl1 userControl11;
        private UserControl2 userControl21;
        private TextBox display2;
        private TextBox display1;
    }
}