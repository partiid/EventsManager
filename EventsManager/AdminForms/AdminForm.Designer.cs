namespace EventsManager
{
    partial class AdminForm
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
            this.navPanel = new System.Windows.Forms.Panel();
            this.navigateRequests = new System.Windows.Forms.Button();
            this.navigateEvents = new System.Windows.Forms.Button();
            this.navigateUsers = new System.Windows.Forms.Button();
            this.adminLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataTable = new System.Windows.Forms.DataGridView();
            this.addButton = new System.Windows.Forms.Button();
            this.modifyButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.navPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).BeginInit();
            this.SuspendLayout();
            // 
            // navPanel
            // 
            this.navPanel.Controls.Add(this.removeButton);
            this.navPanel.Controls.Add(this.modifyButton);
            this.navPanel.Controls.Add(this.addButton);
            this.navPanel.Controls.Add(this.navigateRequests);
            this.navPanel.Controls.Add(this.navigateEvents);
            this.navPanel.Controls.Add(this.navigateUsers);
            this.navPanel.Controls.Add(this.adminLabel);
            this.navPanel.Location = new System.Drawing.Point(13, 13);
            this.navPanel.Name = "navPanel";
            this.navPanel.Size = new System.Drawing.Size(200, 425);
            this.navPanel.TabIndex = 0;
            // 
            // navigateRequests
            // 
            this.navigateRequests.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.navigateRequests.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.navigateRequests.Font = new System.Drawing.Font("Adobe Caslon Pro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.navigateRequests.Location = new System.Drawing.Point(-1, 181);
            this.navigateRequests.Name = "navigateRequests";
            this.navigateRequests.Size = new System.Drawing.Size(202, 41);
            this.navigateRequests.TabIndex = 3;
            this.navigateRequests.Text = "Prośby o dołączenie";
            this.navigateRequests.UseVisualStyleBackColor = true;
            this.navigateRequests.Click += new System.EventHandler(this.navigateRequests_Click);
            // 
            // navigateEvents
            // 
            this.navigateEvents.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.navigateEvents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.navigateEvents.Font = new System.Drawing.Font("Adobe Caslon Pro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.navigateEvents.Location = new System.Drawing.Point(-1, 134);
            this.navigateEvents.Name = "navigateEvents";
            this.navigateEvents.Size = new System.Drawing.Size(202, 41);
            this.navigateEvents.TabIndex = 2;
            this.navigateEvents.Text = "Wydarzenia";
            this.navigateEvents.UseVisualStyleBackColor = true;
            this.navigateEvents.Click += new System.EventHandler(this.navigateEvents_Click);
            // 
            // navigateUsers
            // 
            this.navigateUsers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.navigateUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.navigateUsers.Font = new System.Drawing.Font("Adobe Caslon Pro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.navigateUsers.Location = new System.Drawing.Point(-1, 87);
            this.navigateUsers.Name = "navigateUsers";
            this.navigateUsers.Size = new System.Drawing.Size(202, 41);
            this.navigateUsers.TabIndex = 1;
            this.navigateUsers.Text = "Użytkownicy";
            this.navigateUsers.UseVisualStyleBackColor = true;
            this.navigateUsers.Click += new System.EventHandler(this.navigateUsers_Click);
            // 
            // adminLabel
            // 
            this.adminLabel.AutoSize = true;
            this.adminLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.adminLabel.Location = new System.Drawing.Point(40, 15);
            this.adminLabel.Name = "adminLabel";
            this.adminLabel.Size = new System.Drawing.Size(127, 24);
            this.adminLabel.TabIndex = 0;
            this.adminLabel.Text = "Events Admin";
            this.adminLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataTable);
            this.panel1.Location = new System.Drawing.Point(220, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(568, 425);
            this.panel1.TabIndex = 1;
            // 
            // dataTable
            // 
            this.dataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTable.Location = new System.Drawing.Point(3, 6);
            this.dataTable.Name = "dataTable";
            this.dataTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataTable.Size = new System.Drawing.Size(565, 419);
            this.dataTable.TabIndex = 0;
            this.dataTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataTable_CellContentClick);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Location = new System.Drawing.Point(4, 239);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(93, 23);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "Dodaj nowy";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // modifyButton
            // 
            this.modifyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.modifyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modifyButton.Location = new System.Drawing.Point(107, 239);
            this.modifyButton.Name = "modifyButton";
            this.modifyButton.Size = new System.Drawing.Size(93, 23);
            this.modifyButton.TabIndex = 5;
            this.modifyButton.Text = "Edytuj";
            this.modifyButton.UseVisualStyleBackColor = false;
            this.modifyButton.Click += new System.EventHandler(this.modifyButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.removeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeButton.Location = new System.Drawing.Point(57, 268);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(93, 23);
            this.removeButton.TabIndex = 6;
            this.removeButton.Text = "Usuń";
            this.removeButton.UseVisualStyleBackColor = false;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 449);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.navPanel);
            this.MaximizeBox = false;
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.navPanel.ResumeLayout(false);
            this.navPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel navPanel;
        private System.Windows.Forms.Button navigateRequests;
        private System.Windows.Forms.Button navigateEvents;
        private System.Windows.Forms.Button navigateUsers;
        private System.Windows.Forms.Label adminLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataTable;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button modifyButton;
        private System.Windows.Forms.Button addButton;
    }
}