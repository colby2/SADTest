namespace Test
{
    partial class Patient
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
            this.tcPatient = new System.Windows.Forms.TabControl();
            this.tpDemographics = new System.Windows.Forms.TabPage();
            this.tpLipidTest = new System.Windows.Forms.TabPage();
            this.tpDiabeticTest = new System.Windows.Forms.TabPage();
            this.tcPatient.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcPatient
            // 
            this.tcPatient.Controls.Add(this.tpDemographics);
            this.tcPatient.Controls.Add(this.tpLipidTest);
            this.tcPatient.Controls.Add(this.tpDiabeticTest);
            this.tcPatient.Location = new System.Drawing.Point(12, 12);
            this.tcPatient.Multiline = true;
            this.tcPatient.Name = "tcPatient";
            this.tcPatient.SelectedIndex = 0;
            this.tcPatient.Size = new System.Drawing.Size(699, 587);
            this.tcPatient.TabIndex = 0;
            // 
            // tpDemographics
            // 
            this.tpDemographics.Location = new System.Drawing.Point(4, 22);
            this.tpDemographics.Name = "tpDemographics";
            this.tpDemographics.Padding = new System.Windows.Forms.Padding(3);
            this.tpDemographics.Size = new System.Drawing.Size(691, 561);
            this.tpDemographics.TabIndex = 0;
            this.tpDemographics.Text = "Demographics";
            this.tpDemographics.UseVisualStyleBackColor = true;
            // 
            // tpLipidTest
            // 
            this.tpLipidTest.Location = new System.Drawing.Point(4, 22);
            this.tpLipidTest.Name = "tpLipidTest";
            this.tpLipidTest.Padding = new System.Windows.Forms.Padding(3);
            this.tpLipidTest.Size = new System.Drawing.Size(691, 561);
            this.tpLipidTest.TabIndex = 1;
            this.tpLipidTest.Text = "LipidTest";
            this.tpLipidTest.UseVisualStyleBackColor = true;
            // 
            // tpDiabeticTest
            // 
            this.tpDiabeticTest.Location = new System.Drawing.Point(4, 22);
            this.tpDiabeticTest.Name = "tpDiabeticTest";
            this.tpDiabeticTest.Size = new System.Drawing.Size(691, 561);
            this.tpDiabeticTest.TabIndex = 2;
            this.tpDiabeticTest.Text = "DiabeticTest";
            this.tpDiabeticTest.UseVisualStyleBackColor = true;
            // 
            // Patient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 611);
            this.Controls.Add(this.tcPatient);
            this.Name = "Patient";
            this.Text = "Patient";
            this.tcPatient.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcPatient;
        private System.Windows.Forms.TabPage tpDemographics;
        private System.Windows.Forms.TabPage tpLipidTest;
        private System.Windows.Forms.TabPage tpDiabeticTest;
    }
}