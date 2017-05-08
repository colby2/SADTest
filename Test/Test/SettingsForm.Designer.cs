namespace Test
{
    partial class SettingsForm
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
            this.passBox = new System.Windows.Forms.TextBox();
            this.updatePass = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // passBox
            // 
            this.passBox.Location = new System.Drawing.Point(12, 37);
            this.passBox.Name = "passBox";
            this.passBox.PasswordChar = '*';
            this.passBox.Size = new System.Drawing.Size(100, 20);
            this.passBox.TabIndex = 0;
            // 
            // updatePass
            // 
            this.updatePass.Location = new System.Drawing.Point(118, 37);
            this.updatePass.Name = "updatePass";
            this.updatePass.Size = new System.Drawing.Size(75, 23);
            this.updatePass.TabIndex = 1;
            this.updatePass.Text = "Update Password";
            this.updatePass.UseVisualStyleBackColor = true;
            this.updatePass.Click += new System.EventHandler(this.updatePass_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 122);
            this.Controls.Add(this.updatePass);
            this.Controls.Add(this.passBox);
            this.Name = "SettingsForm";
            this.Text = "DatabasePasswordUpdate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox passBox;
        private System.Windows.Forms.Button updatePass;
    }
}