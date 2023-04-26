namespace Activity1
{
    partial class UserControl1
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
            label1 = new Label();
            input2 = new TextBox();
            label4 = new Label();
            input1 = new TextBox();
            label3 = new Label();
            submit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(21, 29);
            label1.Name = "label1";
            label1.Size = new Size(104, 25);
            label1.TabIndex = 0;
            label1.Text = "Panel One!";
            // 
            // input2
            // 
            input2.Location = new Point(21, 162);
            input2.Name = "input2";
            input2.Size = new Size(154, 23);
            input2.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 138);
            label4.Name = "label4";
            label4.Size = new Size(65, 15);
            label4.TabIndex = 10;
            label4.Text = "Input Two: ";
            // 
            // input1
            // 
            input1.Location = new Point(21, 106);
            input1.Name = "input1";
            input1.Size = new Size(154, 23);
            input1.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 82);
            label3.Name = "label3";
            label3.Size = new Size(66, 15);
            label3.TabIndex = 8;
            label3.Text = "Input One: ";
            // 
            // submit
            // 
            submit.Location = new Point(21, 244);
            submit.Name = "submit";
            submit.Size = new Size(75, 23);
            submit.TabIndex = 12;
            submit.Text = "Submit";
            submit.UseVisualStyleBackColor = true;
            submit.Click += submit_Click;
            // 
            // UserControl1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Moccasin;
            Controls.Add(submit);
            Controls.Add(input2);
            Controls.Add(label4);
            Controls.Add(input1);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "UserControl1";
            Size = new Size(491, 351);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox input2;
        private Label label4;
        private TextBox input1;
        private Label label3;
        private Button submit;
    }
}
