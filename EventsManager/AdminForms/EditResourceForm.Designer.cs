namespace EventsManager.AdminForms
{
    partial class EditResourceForm
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
            this.panelLabels = new System.Windows.Forms.FlowLayoutPanel();
            this.panelFields = new System.Windows.Forms.FlowLayoutPanel();
            this.submitEditButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panelLabels
            // 
            this.panelLabels.Location = new System.Drawing.Point(0, 0);
            this.panelLabels.Name = "panelLabels";
            this.panelLabels.Size = new System.Drawing.Size(113, 305);
            this.panelLabels.TabIndex = 0;
            // 
            // panelFields
            // 
            this.panelFields.Location = new System.Drawing.Point(143, 0);
            this.panelFields.Name = "panelFields";
            this.panelFields.Size = new System.Drawing.Size(198, 305);
            this.panelFields.TabIndex = 1;
            // 
            // submitEditButton
            // 
            this.submitEditButton.Location = new System.Drawing.Point(143, 355);
            this.submitEditButton.Name = "submitEditButton";
            this.submitEditButton.Size = new System.Drawing.Size(101, 43);
            this.submitEditButton.TabIndex = 2;
            this.submitEditButton.Text = "Zapisz";
            this.submitEditButton.UseVisualStyleBackColor = true;
            this.submitEditButton.Click += new System.EventHandler(this.submitEditButton_Click);
            // 
            // EditResourceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 444);
            this.Controls.Add(this.submitEditButton);
            this.Controls.Add(this.panelFields);
            this.Controls.Add(this.panelLabels);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditResourceForm";
            this.Text = "EditResourceForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel panelLabels;
        private System.Windows.Forms.FlowLayoutPanel panelFields;
        private System.Windows.Forms.Button submitEditButton;
    }
}