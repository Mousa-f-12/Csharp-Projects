namespace Csharp_Projects
{
    partial class Form1
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.lbLogIn = new System.Windows.Forms.Label();
            this.btnShowName = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Salmon;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnLogin.Location = new System.Drawing.Point(59, 100);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(220, 86);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lbLogIn
            // 
            this.lbLogIn.AutoSize = true;
            this.lbLogIn.Font = new System.Drawing.Font("Segoe Print", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLogIn.Location = new System.Drawing.Point(62, 244);
            this.lbLogIn.Name = "lbLogIn";
            this.lbLogIn.Size = new System.Drawing.Size(0, 70);
            this.lbLogIn.TabIndex = 1;
            // 
            // btnShowName
            // 
            this.btnShowName.BackColor = System.Drawing.Color.Salmon;
            this.btnShowName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnShowName.Location = new System.Drawing.Point(533, 135);
            this.btnShowName.Name = "btnShowName";
            this.btnShowName.Size = new System.Drawing.Size(151, 51);
            this.btnShowName.TabIndex = 2;
            this.btnShowName.Text = "Submit";
            this.btnShowName.UseVisualStyleBackColor = false;
            this.btnShowName.Click += new System.EventHandler(this.btnShowName_Click);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtName.Location = new System.Drawing.Point(533, 234);
            this.txtName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(153, 30);
            this.txtName.TabIndex = 3;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lbName.Location = new System.Drawing.Point(525, 305);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(0, 46);
            this.lbName.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(367, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Enter Your Name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnShowName);
            this.Controls.Add(this.lbLogIn);
            this.Controls.Add(this.btnLogin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lbLogIn;
        private System.Windows.Forms.Button btnShowName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label label1;
    }
}

