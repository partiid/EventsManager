namespace EventsManager.UserForms
{
    partial class RegisterForm
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
            this.name = new System.Windows.Forms.TextBox();
            this.lastname = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.login = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lastnameLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.loginLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.errors = new System.Windows.Forms.Label();
            this.signupButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(48, 56);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(153, 20);
            this.name.TabIndex = 0;
            // 
            // lastname
            // 
            this.lastname.Location = new System.Drawing.Point(45, 102);
            this.lastname.Name = "lastname";
            this.lastname.Size = new System.Drawing.Size(153, 20);
            this.lastname.TabIndex = 1;
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(45, 145);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(153, 20);
            this.email.TabIndex = 2;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(233, 102);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(153, 20);
            this.password.TabIndex = 3;
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(233, 59);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(153, 20);
            this.login.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Imię";
            // 
            // lastnameLabel
            // 
            this.lastnameLabel.AutoSize = true;
            this.lastnameLabel.Location = new System.Drawing.Point(42, 86);
            this.lastnameLabel.Name = "lastnameLabel";
            this.lastnameLabel.Size = new System.Drawing.Size(53, 13);
            this.lastnameLabel.TabIndex = 6;
            this.lastnameLabel.Text = "Nazwisko";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(45, 129);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(31, 13);
            this.emailLabel.TabIndex = 7;
            this.emailLabel.Text = "email";
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Location = new System.Drawing.Point(230, 43);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(33, 13);
            this.loginLabel.TabIndex = 8;
            this.loginLabel.Text = "Login";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(230, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Hasło";
            // 
            // errors
            // 
            this.errors.AutoSize = true;
            this.errors.ForeColor = System.Drawing.Color.Red;
            this.errors.Location = new System.Drawing.Point(45, 200);
            this.errors.Name = "errors";
            this.errors.Size = new System.Drawing.Size(0, 13);
            this.errors.TabIndex = 10;
            // 
            // signupButton
            // 
            this.signupButton.Location = new System.Drawing.Point(48, 226);
            this.signupButton.Name = "signupButton";
            this.signupButton.Size = new System.Drawing.Size(338, 23);
            this.signupButton.TabIndex = 11;
            this.signupButton.Text = "Zarejestruj";
            this.signupButton.UseVisualStyleBackColor = true;
            this.signupButton.Click += new System.EventHandler(this.SignupButton_click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 349);
            this.Controls.Add(this.signupButton);
            this.Controls.Add(this.errors);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.lastnameLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.login);
            this.Controls.Add(this.password);
            this.Controls.Add(this.email);
            this.Controls.Add(this.lastname);
            this.Controls.Add(this.name);
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox lastname;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lastnameLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label errors;
        private System.Windows.Forms.Button signupButton;
    }
}