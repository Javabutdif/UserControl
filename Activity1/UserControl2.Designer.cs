namespace Activity1
{
    partial class UserControl2
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            input2 = new TextBox();
            label4 = new Label();
            input1 = new TextBox();
            label3 = new Label();
            label1 = new Label();
            submitBut = new Button();
            SuspendLayout();
            // 
            // input2
            // 
            input2.Location = new Point(22, 177);
            input2.Name = "input2";
            input2.Size = new Size(154, 23);
            input2.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 153);
            label4.Name = "label4";
            label4.Size = new Size(65, 15);
            label4.TabIndex = 15;
            label4.Text = "Input Two: ";
            // 
            // input1
            // 
            input1.Location = new Point(22, 121);
            input1.Name = "input1";
            input1.Size = new Size(154, 23);
            input1.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 97);
            label3.Name = "label3";
            label3.Size = new Size(66, 15);
            label3.TabIndex = 13;
            label3.Text = "Input One: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(22, 44);
            label1.Name = "label1";
            label1.Size = new Size(103, 25);
            label1.TabIndex = 12;
            label1.Text = "Panel Two!";
            // 
            // submitBut
            // 
            submitBut.Location = new Point(22, 254);
            submitBut.Name = "submitBut";
            submitBut.Size = new Size(75, 23);
            submitBut.TabIndex = 17;
            submitBut.Text = "Submit";
            submitBut.UseVisualStyleBackColor = true;
            submitBut.Click += submitBut_Click;
            // 
            // UserControl2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Moccasin;
            Controls.Add(submitBut);
            Controls.Add(input2);
            Controls.Add(label4);
            Controls.Add(input1);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "UserControl2";
            Size = new Size(491, 351);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox input2;
        private Label label4;
        private TextBox input1;
        private Label label3;
        private Label label1;
        private Button submitBut;
    }
}
