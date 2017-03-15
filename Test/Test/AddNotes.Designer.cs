namespace Test
{
    partial class AddNotes
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
            this.notestb = new System.Windows.Forms.TextBox();
            this.submitNotes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // notestb
            // 
            this.notestb.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notestb.Location = new System.Drawing.Point(170, 140);
            this.notestb.Multiline = true;
            this.notestb.Name = "notestb";
            this.notestb.Size = new System.Drawing.Size(575, 303);
            this.notestb.TabIndex = 0;
            // 
            // submitNotes
            // 
            this.submitNotes.Location = new System.Drawing.Point(769, 521);
            this.submitNotes.Name = "submitNotes";
            this.submitNotes.Size = new System.Drawing.Size(175, 53);
            this.submitNotes.TabIndex = 1;
            this.submitNotes.Text = "Submit Notes";
            this.submitNotes.UseVisualStyleBackColor = true;
            // 
            // AddNotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 615);
            this.Controls.Add(this.submitNotes);
            this.Controls.Add(this.notestb);
            this.Name = "AddNotes";
            this.Text = "Notes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox notestb;
        private System.Windows.Forms.Button submitNotes;
    }
}