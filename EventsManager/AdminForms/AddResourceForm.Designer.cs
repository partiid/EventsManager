namespace EventsManager.AdminForms
{
    partial class AddResourceForm
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
            this.submitBtn = new System.Windows.Forms.Button();
            this.panelLabels = new System.Windows.Forms.FlowLayoutPanel();
            this.panelFields = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(181, 338);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(75, 23);
            this.submitBtn.TabIndex = 0;
            this.submitBtn.Text = "Potwierdź";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // panelLabels
            // 
            this.panelLabels.Location = new System.Drawing.Point(23, 34);
            this.panelLabels.Name = "panelLabels";
            this.panelLabels.Size = new System.Drawing.Size(113, 284);
            this.panelLabels.TabIndex = 1;
            // 
            // panelFields
            // 
            this.panelFields.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.panelFields.Location = new System.Drawing.Point(165, 34);
            this.panelFields.Name = "panelFields";
            this.panelFields.Size = new System.Drawing.Size(242, 284);
            this.panelFields.TabIndex = 2;
            // 
            // AddResourceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 410);
            this.Controls.Add(this.panelFields);
            this.Controls.Add(this.panelLabels);
            this.Controls.Add(this.submitBtn);
            this.Name = "AddResourceForm";
            this.Text = "AddResourceForm";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.FlowLayoutPanel panelLabels;
        private System.Windows.Forms.FlowLayoutPanel panelFields;
    }
}