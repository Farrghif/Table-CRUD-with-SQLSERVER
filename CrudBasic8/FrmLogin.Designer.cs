namespace CrudBasic8
{
    partial class FrmLogin
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
            this.password_txtbox = new System.Windows.Forms.TextBox();
            this.username_txtBox = new System.Windows.Forms.TextBox();
            this.password_lbl = new System.Windows.Forms.Label();
            this.username_lbl = new System.Windows.Forms.Label();
            this.login_btn = new System.Windows.Forms.Button();
            this.register_btn = new System.Windows.Forms.Button();
            this.registerPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.passwordRegisTextBox = new System.Windows.Forms.TextBox();
            this.createButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.usernameRegisTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.registerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // password_txtbox
            // 
            this.password_txtbox.Location = new System.Drawing.Point(194, 112);
            this.password_txtbox.Multiline = true;
            this.password_txtbox.Name = "password_txtbox";
            this.password_txtbox.PasswordChar = '*';
            this.password_txtbox.Size = new System.Drawing.Size(390, 45);
            this.password_txtbox.TabIndex = 17;
            // 
            // username_txtBox
            // 
            this.username_txtBox.Location = new System.Drawing.Point(194, 43);
            this.username_txtBox.Multiline = true;
            this.username_txtBox.Name = "username_txtBox";
            this.username_txtBox.Size = new System.Drawing.Size(390, 42);
            this.username_txtBox.TabIndex = 16;
            // 
            // password_lbl
            // 
            this.password_lbl.AutoSize = true;
            this.password_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_lbl.Location = new System.Drawing.Point(35, 125);
            this.password_lbl.Name = "password_lbl";
            this.password_lbl.Size = new System.Drawing.Size(138, 32);
            this.password_lbl.TabIndex = 15;
            this.password_lbl.Text = "Password";
            // 
            // username_lbl
            // 
            this.username_lbl.AutoSize = true;
            this.username_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_lbl.Location = new System.Drawing.Point(29, 43);
            this.username_lbl.Name = "username_lbl";
            this.username_lbl.Size = new System.Drawing.Size(144, 32);
            this.username_lbl.TabIndex = 14;
            this.username_lbl.Text = "Username";
            // 
            // login_btn
            // 
            this.login_btn.Location = new System.Drawing.Point(343, 218);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(128, 34);
            this.login_btn.TabIndex = 19;
            this.login_btn.Text = "Login";
            this.login_btn.UseVisualStyleBackColor = true;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // register_btn
            // 
            this.register_btn.Location = new System.Drawing.Point(110, 218);
            this.register_btn.Name = "register_btn";
            this.register_btn.Size = new System.Drawing.Size(128, 34);
            this.register_btn.TabIndex = 18;
            this.register_btn.Text = "Register";
            this.register_btn.UseVisualStyleBackColor = true;
            this.register_btn.Click += new System.EventHandler(this.register_btn_Click);
            // 
            // registerPanel
            // 
            this.registerPanel.Controls.Add(this.label3);
            this.registerPanel.Controls.Add(this.passwordRegisTextBox);
            this.registerPanel.Controls.Add(this.createButton);
            this.registerPanel.Controls.Add(this.backButton);
            this.registerPanel.Controls.Add(this.usernameRegisTextBox);
            this.registerPanel.Controls.Add(this.label1);
            this.registerPanel.Controls.Add(this.label2);
            this.registerPanel.Location = new System.Drawing.Point(392, 290);
            this.registerPanel.Name = "registerPanel";
            this.registerPanel.Size = new System.Drawing.Size(695, 264);
            this.registerPanel.TabIndex = 20;
            this.registerPanel.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Old English Text MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(265, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 44);
            this.label3.TabIndex = 14;
            this.label3.Text = "Register";
            // 
            // passwordRegisTextBox
            // 
            this.passwordRegisTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordRegisTextBox.Location = new System.Drawing.Point(189, 164);
            this.passwordRegisTextBox.Name = "passwordRegisTextBox";
            this.passwordRegisTextBox.PasswordChar = '*';
            this.passwordRegisTextBox.Size = new System.Drawing.Size(437, 35);
            this.passwordRegisTextBox.TabIndex = 13;
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(426, 217);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(128, 34);
            this.createButton.TabIndex = 12;
            this.createButton.Text = "Create";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(223, 217);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(128, 34);
            this.backButton.TabIndex = 11;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // usernameRegisTextBox
            // 
            this.usernameRegisTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameRegisTextBox.Location = new System.Drawing.Point(189, 78);
            this.usernameRegisTextBox.Name = "usernameRegisTextBox";
            this.usernameRegisTextBox.Size = new System.Drawing.Size(437, 35);
            this.usernameRegisTextBox.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 32);
            this.label1.TabIndex = 9;
            this.label1.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 32);
            this.label2.TabIndex = 8;
            this.label2.Text = "Username";
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 624);
            this.Controls.Add(this.registerPanel);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.register_btn);
            this.Controls.Add(this.password_txtbox);
            this.Controls.Add(this.username_txtBox);
            this.Controls.Add(this.password_lbl);
            this.Controls.Add(this.username_lbl);
            this.Name = "FrmLogin";
            this.Text = "FrmLogin";
            this.registerPanel.ResumeLayout(false);
            this.registerPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox password_txtbox;
        private System.Windows.Forms.TextBox username_txtBox;
        private System.Windows.Forms.Label password_lbl;
        private System.Windows.Forms.Label username_lbl;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.Button register_btn;
        private System.Windows.Forms.Panel registerPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox passwordRegisTextBox;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.TextBox usernameRegisTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}