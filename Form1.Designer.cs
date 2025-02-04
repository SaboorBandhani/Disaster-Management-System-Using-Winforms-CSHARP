namespace DisasterManagementSystem
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
            this.DisasterTypeComboBox = new System.Windows.Forms.ComboBox();
            this.AreaComboBox = new System.Windows.Forms.ComboBox();
            this.SuggestSafeAreaButton = new System.Windows.Forms.Button();
            this.ShareResourcesButton = new System.Windows.Forms.Button();
            this.SendNotificationsButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DisasterTypeComboBox
            // 
            this.DisasterTypeComboBox.FormattingEnabled = true;
            this.DisasterTypeComboBox.Location = new System.Drawing.Point(254, 40);
            this.DisasterTypeComboBox.Name = "DisasterTypeComboBox";
            this.DisasterTypeComboBox.Size = new System.Drawing.Size(265, 28);
            this.DisasterTypeComboBox.TabIndex = 0;
            this.DisasterTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.DisasterTypeComboBox_SelectedIndexChanged);
            // 
            // AreaComboBox
            // 
            this.AreaComboBox.FormattingEnabled = true;
            this.AreaComboBox.Location = new System.Drawing.Point(254, 112);
            this.AreaComboBox.Name = "AreaComboBox";
            this.AreaComboBox.Size = new System.Drawing.Size(265, 28);
            this.AreaComboBox.TabIndex = 1;
            this.AreaComboBox.SelectedIndexChanged += new System.EventHandler(this.AreaComboBox_SelectedIndexChanged_1);
            // 
            // SuggestSafeAreaButton
            // 
            this.SuggestSafeAreaButton.Location = new System.Drawing.Point(111, 200);
            this.SuggestSafeAreaButton.Name = "SuggestSafeAreaButton";
            this.SuggestSafeAreaButton.Size = new System.Drawing.Size(153, 67);
            this.SuggestSafeAreaButton.TabIndex = 2;
            this.SuggestSafeAreaButton.Text = "Safe Area ";
            this.SuggestSafeAreaButton.UseVisualStyleBackColor = true;
            this.SuggestSafeAreaButton.Click += new System.EventHandler(this.SuggestSafeAreaButton_Click);
            // 
            // ShareResourcesButton
            // 
            this.ShareResourcesButton.Location = new System.Drawing.Point(303, 200);
            this.ShareResourcesButton.Name = "ShareResourcesButton";
            this.ShareResourcesButton.Size = new System.Drawing.Size(161, 67);
            this.ShareResourcesButton.TabIndex = 3;
            this.ShareResourcesButton.Text = "Resources";
            this.ShareResourcesButton.UseVisualStyleBackColor = true;
            this.ShareResourcesButton.Click += new System.EventHandler(this.ShareResourcesButton_Click);
            // 
            // SendNotificationsButton
            // 
            this.SendNotificationsButton.Location = new System.Drawing.Point(525, 196);
            this.SendNotificationsButton.Name = "SendNotificationsButton";
            this.SendNotificationsButton.Size = new System.Drawing.Size(153, 71);
            this.SendNotificationsButton.TabIndex = 4;
            this.SendNotificationsButton.Text = "Notificatios";
            this.SendNotificationsButton.UseVisualStyleBackColor = true;
            this.SendNotificationsButton.Click += new System.EventHandler(this.SendNotificationsButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Disaster Type:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Affected Area:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SendNotificationsButton);
            this.Controls.Add(this.ShareResourcesButton);
            this.Controls.Add(this.SuggestSafeAreaButton);
            this.Controls.Add(this.AreaComboBox);
            this.Controls.Add(this.DisasterTypeComboBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox DisasterTypeComboBox;
        private System.Windows.Forms.ComboBox AreaComboBox;
        private System.Windows.Forms.Button SuggestSafeAreaButton;
        private System.Windows.Forms.Button ShareResourcesButton;
        private System.Windows.Forms.Button SendNotificationsButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

