namespace PRGProject.PresentationLayer
{
    partial class Registration
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.usernamebtn = new System.Windows.Forms.Label();
            this.passwordtxt = new System.Windows.Forms.Label();
            this.cpassworsdtxt = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.registerbtn = new System.Windows.Forms.Button();
            this.cancelbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // usernamebtn
            // 
            this.usernamebtn.AutoSize = true;
            this.usernamebtn.Location = new System.Drawing.Point(207, 113);
            this.usernamebtn.Name = "usernamebtn";
            this.usernamebtn.Size = new System.Drawing.Size(66, 16);
            this.usernamebtn.TabIndex = 0;
            this.usernamebtn.Text = "Usename";
            // 
            // passwordtxt
            // 
            this.passwordtxt.AutoSize = true;
            this.passwordtxt.Location = new System.Drawing.Point(207, 168);
            this.passwordtxt.Name = "passwordtxt";
            this.passwordtxt.Size = new System.Drawing.Size(67, 16);
            this.passwordtxt.TabIndex = 1;
            this.passwordtxt.Text = "Password";
            // 
            // cpassworsdtxt
            // 
            this.cpassworsdtxt.AutoSize = true;
            this.cpassworsdtxt.Location = new System.Drawing.Point(161, 225);
            this.cpassworsdtxt.Name = "cpassworsdtxt";
            this.cpassworsdtxt.Size = new System.Drawing.Size(115, 16);
            this.cpassworsdtxt.TabIndex = 2;
            this.cpassworsdtxt.Text = "Confirm Password";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(295, 113);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(151, 22);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(295, 165);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(151, 22);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(295, 225);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(151, 22);
            this.textBox3.TabIndex = 5;
            // 
            // registerbtn
            // 
            this.registerbtn.Location = new System.Drawing.Point(247, 295);
            this.registerbtn.Name = "registerbtn";
            this.registerbtn.Size = new System.Drawing.Size(92, 33);
            this.registerbtn.TabIndex = 6;
            this.registerbtn.Text = "Register";
            this.registerbtn.UseVisualStyleBackColor = true;
            this.registerbtn.Click += new System.EventHandler(this.registerbtn_Click);
            // 
            // cancelbtn
            // 
            this.cancelbtn.Location = new System.Drawing.Point(361, 295);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(85, 33);
            this.cancelbtn.TabIndex = 7;
            this.cancelbtn.Text = "Cancel";
            this.cancelbtn.UseVisualStyleBackColor = true;
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 395);
            this.Controls.Add(this.cancelbtn);
            this.Controls.Add(this.registerbtn);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cpassworsdtxt);
            this.Controls.Add(this.passwordtxt);
            this.Controls.Add(this.usernamebtn);
            this.Name = "Registration";
            this.Text = "Registration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usernamebtn;
        private System.Windows.Forms.Label passwordtxt;
        private System.Windows.Forms.Label cpassworsdtxt;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button registerbtn;
        private System.Windows.Forms.Button cancelbtn;
    }
}