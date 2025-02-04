namespace DisasterManagementSystem
{
    partial class SafeAreaForm
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
            this.lstSafeAreas = new System.Windows.Forms.ListBox();
            this.BtnMarkSafe = new System.Windows.Forms.Button();
            this.btnViewDetails = new System.Windows.Forms.Button();
            this.txtAffectedArea = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lstSafeAreas
            // 
            this.lstSafeAreas.FormattingEnabled = true;
            this.lstSafeAreas.ItemHeight = 20;
            this.lstSafeAreas.Location = new System.Drawing.Point(205, 35);
            this.lstSafeAreas.Name = "lstSafeAreas";
            this.lstSafeAreas.Size = new System.Drawing.Size(345, 144);
            this.lstSafeAreas.TabIndex = 2;
            this.lstSafeAreas.SelectedIndexChanged += new System.EventHandler(this.lstSafeAreas_SelectedIndexChanged);
            // 
            // BtnMarkSafe
            // 
            this.BtnMarkSafe.Location = new System.Drawing.Point(441, 292);
            this.BtnMarkSafe.Name = "BtnMarkSafe";
            this.BtnMarkSafe.Size = new System.Drawing.Size(179, 48);
            this.BtnMarkSafe.TabIndex = 3;
            this.BtnMarkSafe.Text = "Add Safe Area";
            this.BtnMarkSafe.UseVisualStyleBackColor = true;
            this.BtnMarkSafe.Click += new System.EventHandler(this.BtnMarkSafe_Click_1);
            // 
            // btnViewDetails
            // 
            this.btnViewDetails.Location = new System.Drawing.Point(91, 292);
            this.btnViewDetails.Name = "btnViewDetails";
            this.btnViewDetails.Size = new System.Drawing.Size(179, 48);
            this.btnViewDetails.TabIndex = 4;
            this.btnViewDetails.Text = "Safe Area Detail";
            this.btnViewDetails.UseVisualStyleBackColor = true;
            this.btnViewDetails.Click += new System.EventHandler(this.btnViewDetails_Click);
            // 
            // txtAffectedArea
            // 
            this.txtAffectedArea.Location = new System.Drawing.Point(575, 227);
            this.txtAffectedArea.Name = "txtAffectedArea";
            this.txtAffectedArea.Size = new System.Drawing.Size(0, 26);
            this.txtAffectedArea.TabIndex = 5;
            this.txtAffectedArea.Visible = false;
            this.txtAffectedArea.TextChanged += new System.EventHandler(this.txtAffectedArea_TextChanged);
            // 
            // SafeAreaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtAffectedArea);
            this.Controls.Add(this.btnViewDetails);
            this.Controls.Add(this.BtnMarkSafe);
            this.Controls.Add(this.lstSafeAreas);
            this.Name = "SafeAreaForm";
            this.Text = "SafeAreaFomr";
            this.Load += new System.EventHandler(this.SafeAreaForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lstSafeAreas;
        private System.Windows.Forms.Button BtnMarkSafe;
        private System.Windows.Forms.Button btnViewDetails;
        private System.Windows.Forms.TextBox txtAffectedArea;
    }
}