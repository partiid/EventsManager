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
            this.fieldsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // panelLabels
            // 
            this.panelLabels.Location = new System.Drawing.Point(0, 0);
            this.panelLabels.Name = "panelLabels";
            this.panelLabels.Size = new System.Drawing.Size(113, 305);
            this.panelLabels.TabIndex = 0;
            // 
            // fieldsPanel
            // 
            this.fieldsPanel.Location = new System.Drawing.Point(143, 0);
            this.fieldsPanel.Name = "fieldsPanel";
            this.fieldsPanel.Size = new System.Drawing.Size(198, 305);
            this.fieldsPanel.TabIndex = 1;
            // 
            // EditResourceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 444);
            this.Controls.Add(this.fieldsPanel);
            this.Controls.Add(this.panelLabels);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditResourceForm";
            this.Text = "EditResourceForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel panelLabels;
        private System.Windows.Forms.FlowLayoutPanel fieldsPanel;
    }
}