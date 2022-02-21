namespace TVP_Lab1
{
    partial class Authorization
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(93, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "User:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxUser
            // 
            this.textBoxUser.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxUser.Location = new System.Drawing.Point(180, 31);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(200, 43);
            this.textBoxUser.TabIndex = 1;
            this.textBoxUser.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(165, 220);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 45);
            this.button1.TabIndex = 2;
            this.button1.Text = "Create user";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(40, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password:";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxPassword.Location = new System.Drawing.Point(180, 91);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(200, 43);
            this.textBoxPassword.TabIndex = 4;
            this.textBoxPassword.TextChanged += new System.EventHandler(this.textBoxPassword_TextChanged);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(60, 160);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(170, 45);
            this.button2.TabIndex = 5;
            this.button2.Text = "OK";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(270, 160);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(170, 45);
            this.button3.TabIndex = 6;
            this.button3.Text = "Exit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 311);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxUser);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Authorization";
            this.Text = "Authorization";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox textBoxUser;
        private Button button1;
        private Label label2;
        private TextBox textBoxPassword;
        private Button button2;
        private Button button3;
    }
}