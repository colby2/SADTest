namespace Test
{
    partial class AddAllergyInfo
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
            this.AllergicTo = new System.Windows.Forms.TextBox();
            this.Reaction = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.closeForm = new System.Windows.Forms.Button();
            this.updateAllergyButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AllergicTo
            // 
            this.AllergicTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllergicTo.Location = new System.Drawing.Point(221, 73);
            this.AllergicTo.Multiline = true;
            this.AllergicTo.Name = "AllergicTo";
            this.AllergicTo.Size = new System.Drawing.Size(189, 83);
            this.AllergicTo.TabIndex = 0;
            // 
            // Reaction
            // 
            this.Reaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reaction.Location = new System.Drawing.Point(221, 173);
            this.Reaction.Multiline = true;
            this.Reaction.Name = "Reaction";
            this.Reaction.Size = new System.Drawing.Size(189, 88);
            this.Reaction.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Drug Patient is Allergic to";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "The Reaction the Patient Has";
            // 
            // closeForm
            // 
            this.closeForm.Location = new System.Drawing.Point(443, 323);
            this.closeForm.Name = "closeForm";
            this.closeForm.Size = new System.Drawing.Size(146, 37);
            this.closeForm.TabIndex = 4;
            this.closeForm.Text = "Cancel and Return to Patient Allergy Info";
            this.closeForm.UseVisualStyleBackColor = true;
            this.closeForm.Click += new System.EventHandler(this.closeForm_Click);
            // 
            // updateAllergyButton
            // 
            this.updateAllergyButton.Location = new System.Drawing.Point(236, 323);
            this.updateAllergyButton.Name = "updateAllergyButton";
            this.updateAllergyButton.Size = new System.Drawing.Size(151, 37);
            this.updateAllergyButton.TabIndex = 5;
            this.updateAllergyButton.Text = "Add this Information to the Patients Records";
            this.updateAllergyButton.UseVisualStyleBackColor = true;
            this.updateAllergyButton.Click += new System.EventHandler(this.updateAllergyButton_Click);
            // 
            // AddAllergyInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 431);
            this.Controls.Add(this.updateAllergyButton);
            this.Controls.Add(this.closeForm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Reaction);
            this.Controls.Add(this.AllergicTo);
            this.Name = "AddAllergyInfo";
            this.Text = "AddAllergyInfo";
            this.Load += new System.EventHandler(this.AddAllergyInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox AllergicTo;
        private System.Windows.Forms.TextBox Reaction;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button closeForm;
        private System.Windows.Forms.Button updateAllergyButton;
    }
}