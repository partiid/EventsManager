namespace EventsManager
{
    partial class UserForm
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
            this.eventNameInput = new System.Windows.Forms.ComboBox();
            this.eventNameLabel = new System.Windows.Forms.Label();
            this.eventAgenda = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.info1Label = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.part_1 = new System.Windows.Forms.RadioButton();
            this.part_2 = new System.Windows.Forms.RadioButton();
            this.part_3 = new System.Windows.Forms.RadioButton();
            this.part_4 = new System.Windows.Forms.RadioButton();
            this.participationTypeLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.food_2 = new System.Windows.Forms.RadioButton();
            this.food_1 = new System.Windows.Forms.RadioButton();
            this.food_3 = new System.Windows.Forms.RadioButton();
            this.saveEventButton = new System.Windows.Forms.Button();
            this.errorLabel = new System.Windows.Forms.Label();
            this.participantPanel = new System.Windows.Forms.Panel();
            this.foodPanel = new System.Windows.Forms.Panel();
            this.signUpView = new System.Windows.Forms.Panel();
            this.navView = new System.Windows.Forms.Panel();
            this.userLoginLabel = new System.Windows.Forms.Label();
            this.navigateSignUpView = new System.Windows.Forms.Button();
            this.navigateEventsView = new System.Windows.Forms.Button();
            this.participantPanel.SuspendLayout();
            this.foodPanel.SuspendLayout();
            this.signUpView.SuspendLayout();
            this.navView.SuspendLayout();
            this.SuspendLayout();
            // 
            // eventNameInput
            // 
            this.eventNameInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eventNameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.eventNameInput.FormattingEnabled = true;
            this.eventNameInput.Location = new System.Drawing.Point(68, 146);
            this.eventNameInput.Name = "eventNameInput";
            this.eventNameInput.Size = new System.Drawing.Size(218, 28);
            this.eventNameInput.TabIndex = 0;
            this.eventNameInput.SelectedIndexChanged += new System.EventHandler(this.eventNameInput_SelectedIndexChanged);
            // 
            // eventNameLabel
            // 
            this.eventNameLabel.AutoSize = true;
            this.eventNameLabel.Location = new System.Drawing.Point(65, 121);
            this.eventNameLabel.Name = "eventNameLabel";
            this.eventNameLabel.Size = new System.Drawing.Size(96, 13);
            this.eventNameLabel.TabIndex = 1;
            this.eventNameLabel.Text = "Nazwa wydarzenia";
            // 
            // eventAgenda
            // 
            this.eventAgenda.BackColor = System.Drawing.SystemColors.Highlight;
            this.eventAgenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eventAgenda.ForeColor = System.Drawing.Color.FloralWhite;
            this.eventAgenda.Location = new System.Drawing.Point(451, 106);
            this.eventAgenda.Name = "eventAgenda";
            this.eventAgenda.Padding = new System.Windows.Forms.Padding(24);
            this.eventAgenda.Size = new System.Drawing.Size(285, 232);
            this.eventAgenda.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(451, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Opis Wydarzenia";
            // 
            // info1Label
            // 
            this.info1Label.AutoSize = true;
            this.info1Label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.info1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.info1Label.Location = new System.Drawing.Point(63, 24);
            this.info1Label.Name = "info1Label";
            this.info1Label.Size = new System.Drawing.Size(232, 29);
            this.info1Label.TabIndex = 4;
            this.info1Label.Text = "Zapis na wydarzenie";
            // 
            // dateLabel
            // 
            this.dateLabel.BackColor = System.Drawing.SystemColors.Control;
            this.dateLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateLabel.ForeColor = System.Drawing.Color.Black;
            this.dateLabel.Location = new System.Drawing.Point(64, 65);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(183, 24);
            this.dateLabel.TabIndex = 5;
            // 
            // part_1
            // 
            this.part_1.AutoSize = true;
            this.part_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.part_1.Location = new System.Drawing.Point(3, 28);
            this.part_1.Name = "part_1";
            this.part_1.Size = new System.Drawing.Size(70, 17);
            this.part_1.TabIndex = 6;
            this.part_1.TabStop = true;
            this.part_1.Text = "Słuchacz";
            this.part_1.UseVisualStyleBackColor = true;
            // 
            // part_2
            // 
            this.part_2.AutoSize = true;
            this.part_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.part_2.Location = new System.Drawing.Point(3, 51);
            this.part_2.Name = "part_2";
            this.part_2.Size = new System.Drawing.Size(49, 17);
            this.part_2.TabIndex = 7;
            this.part_2.TabStop = true;
            this.part_2.Text = "Autor";
            this.part_2.UseVisualStyleBackColor = true;
            // 
            // part_3
            // 
            this.part_3.AutoSize = true;
            this.part_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.part_3.Location = new System.Drawing.Point(3, 74);
            this.part_3.Name = "part_3";
            this.part_3.Size = new System.Drawing.Size(63, 17);
            this.part_3.TabIndex = 8;
            this.part_3.TabStop = true;
            this.part_3.Text = "Sponsor";
            this.part_3.UseVisualStyleBackColor = true;
            // 
            // part_4
            // 
            this.part_4.AutoSize = true;
            this.part_4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.part_4.Location = new System.Drawing.Point(3, 97);
            this.part_4.Name = "part_4";
            this.part_4.Size = new System.Drawing.Size(78, 17);
            this.part_4.TabIndex = 9;
            this.part_4.TabStop = true;
            this.part_4.Text = "Organizator";
            this.part_4.UseVisualStyleBackColor = true;
            // 
            // participationTypeLabel
            // 
            this.participationTypeLabel.AutoSize = true;
            this.participationTypeLabel.Location = new System.Drawing.Point(1, 12);
            this.participationTypeLabel.Name = "participationTypeLabel";
            this.participationTypeLabel.Size = new System.Drawing.Size(87, 13);
            this.participationTypeLabel.TabIndex = 10;
            this.participationTypeLabel.Text = "Typ uczesnictwa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-3, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Wyżywienie";
            // 
            // food_2
            // 
            this.food_2.AutoSize = true;
            this.food_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.food_2.Location = new System.Drawing.Point(3, 56);
            this.food_2.Name = "food_2";
            this.food_2.Size = new System.Drawing.Size(53, 17);
            this.food_2.TabIndex = 12;
            this.food_2.TabStop = true;
            this.food_2.Text = "Wege";
            this.food_2.UseVisualStyleBackColor = true;
            // 
            // food_1
            // 
            this.food_1.AutoSize = true;
            this.food_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.food_1.Location = new System.Drawing.Point(3, 33);
            this.food_1.Name = "food_1";
            this.food_1.Size = new System.Drawing.Size(94, 17);
            this.food_1.TabIndex = 11;
            this.food_1.TabStop = true;
            this.food_1.Text = "Bez preferencji";
            this.food_1.UseVisualStyleBackColor = true;
            // 
            // food_3
            // 
            this.food_3.AutoSize = true;
            this.food_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.food_3.Location = new System.Drawing.Point(3, 79);
            this.food_3.Name = "food_3";
            this.food_3.Size = new System.Drawing.Size(80, 17);
            this.food_3.TabIndex = 13;
            this.food_3.TabStop = true;
            this.food_3.Text = "Bez glutenu";
            this.food_3.UseVisualStyleBackColor = true;
            // 
            // saveEventButton
            // 
            this.saveEventButton.BackColor = System.Drawing.Color.ForestGreen;
            this.saveEventButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveEventButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.saveEventButton.Location = new System.Drawing.Point(68, 392);
            this.saveEventButton.Name = "saveEventButton";
            this.saveEventButton.Size = new System.Drawing.Size(227, 51);
            this.saveEventButton.TabIndex = 16;
            this.saveEventButton.Text = "Zapisz się";
            this.saveEventButton.UseVisualStyleBackColor = false;
            this.saveEventButton.Click += new System.EventHandler(this.saveEventButton_Click);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(68, 357);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(52, 24);
            this.errorLabel.TabIndex = 17;
            this.errorLabel.Text = "Error";
            this.errorLabel.Visible = false;
            // 
            // participantPanel
            // 
            this.participantPanel.Controls.Add(this.part_1);
            this.participantPanel.Controls.Add(this.part_2);
            this.participantPanel.Controls.Add(this.part_3);
            this.participantPanel.Controls.Add(this.part_4);
            this.participantPanel.Controls.Add(this.participationTypeLabel);
            this.participantPanel.Location = new System.Drawing.Point(68, 189);
            this.participantPanel.Name = "participantPanel";
            this.participantPanel.Size = new System.Drawing.Size(89, 153);
            this.participantPanel.TabIndex = 18;
            // 
            // foodPanel
            // 
            this.foodPanel.Controls.Add(this.food_1);
            this.foodPanel.Controls.Add(this.food_2);
            this.foodPanel.Controls.Add(this.food_3);
            this.foodPanel.Controls.Add(this.label2);
            this.foodPanel.Location = new System.Drawing.Point(180, 189);
            this.foodPanel.Name = "foodPanel";
            this.foodPanel.Size = new System.Drawing.Size(106, 100);
            this.foodPanel.TabIndex = 19;
            // 
            // signUpView
            // 
            this.signUpView.Controls.Add(this.foodPanel);
            this.signUpView.Controls.Add(this.eventAgenda);
            this.signUpView.Controls.Add(this.participantPanel);
            this.signUpView.Controls.Add(this.eventNameInput);
            this.signUpView.Controls.Add(this.errorLabel);
            this.signUpView.Controls.Add(this.eventNameLabel);
            this.signUpView.Controls.Add(this.saveEventButton);
            this.signUpView.Controls.Add(this.label1);
            this.signUpView.Controls.Add(this.dateLabel);
            this.signUpView.Controls.Add(this.info1Label);
            this.signUpView.Location = new System.Drawing.Point(166, 27);
            this.signUpView.Name = "signUpView";
            this.signUpView.Size = new System.Drawing.Size(795, 493);
            this.signUpView.TabIndex = 20;
            // 
            // navView
            // 
            this.navView.Controls.Add(this.navigateEventsView);
            this.navView.Controls.Add(this.navigateSignUpView);
            this.navView.Controls.Add(this.userLoginLabel);
            this.navView.Location = new System.Drawing.Point(13, 27);
            this.navView.Name = "navView";
            this.navView.Size = new System.Drawing.Size(147, 493);
            this.navView.TabIndex = 21;
            // 
            // userLoginLabel
            // 
            this.userLoginLabel.BackColor = System.Drawing.SystemColors.Control;
            this.userLoginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.userLoginLabel.Location = new System.Drawing.Point(21, 84);
            this.userLoginLabel.Name = "userLoginLabel";
            this.userLoginLabel.Size = new System.Drawing.Size(100, 23);
            this.userLoginLabel.TabIndex = 0;
            // 
            // navigateSignUpView
            // 
            this.navigateSignUpView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.navigateSignUpView.Location = new System.Drawing.Point(4, 146);
            this.navigateSignUpView.Name = "navigateSignUpView";
            this.navigateSignUpView.Size = new System.Drawing.Size(143, 23);
            this.navigateSignUpView.TabIndex = 1;
            this.navigateSignUpView.Text = "Zapis na wydarzenie";
            this.navigateSignUpView.UseVisualStyleBackColor = true;
            this.navigateSignUpView.Click += new System.EventHandler(this.navigateSignUpView_Click);
            // 
            // navigateEventsView
            // 
            this.navigateEventsView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.navigateEventsView.Location = new System.Drawing.Point(4, 175);
            this.navigateEventsView.Name = "navigateEventsView";
            this.navigateEventsView.Size = new System.Drawing.Size(143, 23);
            this.navigateEventsView.TabIndex = 2;
            this.navigateEventsView.Text = "Twoje wydarzenia";
            this.navigateEventsView.UseVisualStyleBackColor = true;
            this.navigateEventsView.Click += new System.EventHandler(this.navigateEventsView_Click);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 543);
            this.Controls.Add(this.navView);
            this.Controls.Add(this.signUpView);
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.Load += new System.EventHandler(this.UserForm_Load);
            this.participantPanel.ResumeLayout(false);
            this.participantPanel.PerformLayout();
            this.foodPanel.ResumeLayout(false);
            this.foodPanel.PerformLayout();
            this.signUpView.ResumeLayout(false);
            this.signUpView.PerformLayout();
            this.navView.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox eventNameInput;
        
        private System.Windows.Forms.Label eventNameLabel;
        private System.Windows.Forms.Label eventAgenda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label info1Label;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.RadioButton part_1;
        private System.Windows.Forms.RadioButton part_2;
        private System.Windows.Forms.RadioButton part_3;
        private System.Windows.Forms.RadioButton part_4;
        private System.Windows.Forms.Label participationTypeLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton food_1;
        private System.Windows.Forms.RadioButton food_3;
        private System.Windows.Forms.Button saveEventButton;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Panel participantPanel;
        private System.Windows.Forms.Panel foodPanel;
        private System.Windows.Forms.RadioButton food_2;
        private System.Windows.Forms.Panel signUpView;
        private System.Windows.Forms.Panel navView;
        private System.Windows.Forms.Button navigateEventsView;
        private System.Windows.Forms.Button navigateSignUpView;
        private System.Windows.Forms.Label userLoginLabel;
    }
}