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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Patient));
            this.tcPatient = new System.Windows.Forms.TabControl();
            this.tpDemographics = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.visitDateUpdate = new System.Windows.Forms.Button();
            this.tbLastname = new System.Windows.Forms.TextBox();
            this.lLastName = new System.Windows.Forms.Label();
            this.bTrends = new System.Windows.Forms.Button();
            this.bEdit = new System.Windows.Forms.Button();
            this.bDelete = new System.Windows.Forms.Button();
            this.tbSecondaryInsurance = new System.Windows.Forms.TextBox();
            this.tbPrimaryInsurance = new System.Windows.Forms.TextBox();
            this.lSecondaryInsurance = new System.Windows.Forms.Label();
            this.lPrimaryInsurance = new System.Windows.Forms.Label();
            this.lInsurance = new System.Windows.Forms.Label();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.tbDOB = new System.Windows.Forms.TextBox();
            this.tbZip = new System.Windows.Forms.TextBox();
            this.tbState = new System.Windows.Forms.TextBox();
            this.tbCity = new System.Windows.Forms.TextBox();
            this.tbStreet = new System.Windows.Forms.TextBox();
            this.tbFirstname = new System.Windows.Forms.TextBox();
            this.tbDateOfLastVisit = new System.Windows.Forms.TextBox();
            this.lPhone = new System.Windows.Forms.Label();
            this.lDOB = new System.Windows.Forms.Label();
            this.lZip = new System.Windows.Forms.Label();
            this.lState = new System.Windows.Forms.Label();
            this.lStreet = new System.Windows.Forms.Label();
            this.lCity = new System.Windows.Forms.Label();
            this.lDateOfLastVisit = new System.Windows.Forms.Label();
            this.lFirstname = new System.Windows.Forms.Label();
            this.tpAllergies = new System.Windows.Forms.TabPage();
            this.tpMedication = new System.Windows.Forms.TabPage();
            this.tpVitals = new System.Windows.Forms.TabPage();
            this.tpDiabeticMeds = new System.Windows.Forms.TabPage();
            this.tpDiabeticTest = new System.Windows.Forms.TabPage();
            this.tpLipidTest = new System.Windows.Forms.TabPage();
            this.tpDiabeticBackground = new System.Windows.Forms.TabPage();
            this.tpNotes = new System.Windows.Forms.TabPage();
            this.tcPatient.SuspendLayout();
            this.tpDemographics.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcPatient
            // 
            this.tcPatient.Controls.Add(this.tpDemographics);
            this.tcPatient.Controls.Add(this.tpAllergies);
            this.tcPatient.Controls.Add(this.tpMedication);
            this.tcPatient.Controls.Add(this.tpVitals);
            this.tcPatient.Controls.Add(this.tpDiabeticMeds);
            this.tcPatient.Controls.Add(this.tpDiabeticTest);
            this.tcPatient.Controls.Add(this.tpLipidTest);
            this.tcPatient.Controls.Add(this.tpDiabeticBackground);
            this.tcPatient.Controls.Add(this.tpNotes);
            this.tcPatient.Location = new System.Drawing.Point(12, 12);
            this.tcPatient.Multiline = true;
            this.tcPatient.Name = "tcPatient";
            this.tcPatient.SelectedIndex = 0;
            this.tcPatient.Size = new System.Drawing.Size(699, 587);
            this.tcPatient.TabIndex = 0;
            // 
            // tpDemographics
            // 
            this.tpDemographics.Controls.Add(this.button1);
            this.tpDemographics.Controls.Add(this.visitDateUpdate);
            this.tpDemographics.Controls.Add(this.tbLastname);
            this.tpDemographics.Controls.Add(this.lLastName);
            this.tpDemographics.Controls.Add(this.bTrends);
            this.tpDemographics.Controls.Add(this.bEdit);
            this.tpDemographics.Controls.Add(this.bDelete);
            this.tpDemographics.Controls.Add(this.tbSecondaryInsurance);
            this.tpDemographics.Controls.Add(this.tbPrimaryInsurance);
            this.tpDemographics.Controls.Add(this.lSecondaryInsurance);
            this.tpDemographics.Controls.Add(this.lPrimaryInsurance);
            this.tpDemographics.Controls.Add(this.lInsurance);
            this.tpDemographics.Controls.Add(this.tbPhone);
            this.tpDemographics.Controls.Add(this.tbDOB);
            this.tpDemographics.Controls.Add(this.tbZip);
            this.tpDemographics.Controls.Add(this.tbState);
            this.tpDemographics.Controls.Add(this.tbCity);
            this.tpDemographics.Controls.Add(this.tbStreet);
            this.tpDemographics.Controls.Add(this.tbFirstname);
            this.tpDemographics.Controls.Add(this.tbDateOfLastVisit);
            this.tpDemographics.Controls.Add(this.lPhone);
            this.tpDemographics.Controls.Add(this.lDOB);
            this.tpDemographics.Controls.Add(this.lZip);
            this.tpDemographics.Controls.Add(this.lState);
            this.tpDemographics.Controls.Add(this.lStreet);
            this.tpDemographics.Controls.Add(this.lCity);
            this.tpDemographics.Controls.Add(this.lDateOfLastVisit);
            this.tpDemographics.Controls.Add(this.lFirstname);
            this.tpDemographics.Location = new System.Drawing.Point(4, 22);
            this.tpDemographics.Name = "tpDemographics";
            this.tpDemographics.Padding = new System.Windows.Forms.Padding(3);
            this.tpDemographics.Size = new System.Drawing.Size(691, 561);
            this.tpDemographics.TabIndex = 0;
            this.tpDemographics.Text = "Demographics";
            this.tpDemographics.UseVisualStyleBackColor = true;
            this.tpDemographics.Click += new System.EventHandler(this.tpDemographics_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(347, 532);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 23);
            this.button1.TabIndex = 32;
            this.button1.Text = "Review Notes";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // visitDateUpdate
            // 
            this.visitDateUpdate.Image = ((System.Drawing.Image)(resources.GetObject("visitDateUpdate.Image")));
            this.visitDateUpdate.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.visitDateUpdate.Location = new System.Drawing.Point(280, 274);
            this.visitDateUpdate.Name = "visitDateUpdate";
            this.visitDateUpdate.Size = new System.Drawing.Size(139, 28);
            this.visitDateUpdate.TabIndex = 31;
            this.visitDateUpdate.Text = "Update Last Visit";
            this.visitDateUpdate.UseVisualStyleBackColor = true;
            this.visitDateUpdate.Click += new System.EventHandler(this.visitDateUpdate_Click);
            // 
            // tbLastname
            // 
            this.tbLastname.Location = new System.Drawing.Point(147, 84);
            this.tbLastname.Name = "tbLastname";
            this.tbLastname.ReadOnly = true;
            this.tbLastname.Size = new System.Drawing.Size(100, 20);
            this.tbLastname.TabIndex = 30;
            // 
            // lLastName
            // 
            this.lLastName.AutoSize = true;
            this.lLastName.Location = new System.Drawing.Point(31, 87);
            this.lLastName.Name = "lLastName";
            this.lLastName.Size = new System.Drawing.Size(58, 13);
            this.lLastName.TabIndex = 29;
            this.lLastName.Text = "Last Name";
            // 
            // bTrends
            // 
            this.bTrends.Location = new System.Drawing.Point(448, 532);
            this.bTrends.Name = "bTrends";
            this.bTrends.Size = new System.Drawing.Size(75, 23);
            this.bTrends.TabIndex = 27;
            this.bTrends.Text = "Trends";
            this.bTrends.UseVisualStyleBackColor = true;
            this.bTrends.Click += new System.EventHandler(this.bTrends_Click);
            // 
            // bEdit
            // 
            this.bEdit.Location = new System.Drawing.Point(529, 532);
            this.bEdit.Name = "bEdit";
            this.bEdit.Size = new System.Drawing.Size(75, 23);
            this.bEdit.TabIndex = 26;
            this.bEdit.Text = "Edit";
            this.bEdit.UseVisualStyleBackColor = true;
            this.bEdit.Click += new System.EventHandler(this.bEdit_Click);
            // 
            // bDelete
            // 
            this.bDelete.Location = new System.Drawing.Point(556, 81);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(75, 23);
            this.bDelete.TabIndex = 25;
            this.bDelete.Text = "Delete";
            this.bDelete.UseVisualStyleBackColor = true;
            this.bDelete.Click += new System.EventHandler(this.bDelete_Click);
            // 
            // tbSecondaryInsurance
            // 
            this.tbSecondaryInsurance.Location = new System.Drawing.Point(147, 366);
            this.tbSecondaryInsurance.Name = "tbSecondaryInsurance";
            this.tbSecondaryInsurance.ReadOnly = true;
            this.tbSecondaryInsurance.Size = new System.Drawing.Size(100, 20);
            this.tbSecondaryInsurance.TabIndex = 23;
            // 
            // tbPrimaryInsurance
            // 
            this.tbPrimaryInsurance.Location = new System.Drawing.Point(147, 339);
            this.tbPrimaryInsurance.Name = "tbPrimaryInsurance";
            this.tbPrimaryInsurance.ReadOnly = true;
            this.tbPrimaryInsurance.Size = new System.Drawing.Size(100, 20);
            this.tbPrimaryInsurance.TabIndex = 22;
            // 
            // lSecondaryInsurance
            // 
            this.lSecondaryInsurance.AutoSize = true;
            this.lSecondaryInsurance.Location = new System.Drawing.Point(28, 369);
            this.lSecondaryInsurance.Name = "lSecondaryInsurance";
            this.lSecondaryInsurance.Size = new System.Drawing.Size(108, 13);
            this.lSecondaryInsurance.TabIndex = 20;
            this.lSecondaryInsurance.Text = "Secondary Insurance";
            // 
            // lPrimaryInsurance
            // 
            this.lPrimaryInsurance.AutoSize = true;
            this.lPrimaryInsurance.Location = new System.Drawing.Point(28, 342);
            this.lPrimaryInsurance.Name = "lPrimaryInsurance";
            this.lPrimaryInsurance.Size = new System.Drawing.Size(91, 13);
            this.lPrimaryInsurance.TabIndex = 19;
            this.lPrimaryInsurance.Text = "Primary Insurance";
            // 
            // lInsurance
            // 
            this.lInsurance.AutoSize = true;
            this.lInsurance.Location = new System.Drawing.Point(28, 320);
            this.lInsurance.Name = "lInsurance";
            this.lInsurance.Size = new System.Drawing.Size(57, 13);
            this.lInsurance.TabIndex = 18;
            this.lInsurance.Text = "Insurance:";
            this.lInsurance.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(147, 110);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.ReadOnly = true;
            this.tbPhone.Size = new System.Drawing.Size(100, 20);
            this.tbPhone.TabIndex = 17;
            // 
            // tbDOB
            // 
            this.tbDOB.Location = new System.Drawing.Point(147, 256);
            this.tbDOB.Name = "tbDOB";
            this.tbDOB.ReadOnly = true;
            this.tbDOB.Size = new System.Drawing.Size(100, 20);
            this.tbDOB.TabIndex = 16;
            this.tbDOB.TextChanged += new System.EventHandler(this.tbAge_TextChanged);
            // 
            // tbZip
            // 
            this.tbZip.Location = new System.Drawing.Point(147, 227);
            this.tbZip.Name = "tbZip";
            this.tbZip.ReadOnly = true;
            this.tbZip.Size = new System.Drawing.Size(100, 20);
            this.tbZip.TabIndex = 15;
            // 
            // tbState
            // 
            this.tbState.Location = new System.Drawing.Point(147, 198);
            this.tbState.Name = "tbState";
            this.tbState.ReadOnly = true;
            this.tbState.Size = new System.Drawing.Size(100, 20);
            this.tbState.TabIndex = 14;
            // 
            // tbCity
            // 
            this.tbCity.Location = new System.Drawing.Point(147, 168);
            this.tbCity.Name = "tbCity";
            this.tbCity.ReadOnly = true;
            this.tbCity.Size = new System.Drawing.Size(100, 20);
            this.tbCity.TabIndex = 13;
            // 
            // tbStreet
            // 
            this.tbStreet.Location = new System.Drawing.Point(147, 138);
            this.tbStreet.Name = "tbStreet";
            this.tbStreet.ReadOnly = true;
            this.tbStreet.Size = new System.Drawing.Size(100, 20);
            this.tbStreet.TabIndex = 12;
            // 
            // tbFirstname
            // 
            this.tbFirstname.Location = new System.Drawing.Point(147, 56);
            this.tbFirstname.Name = "tbFirstname";
            this.tbFirstname.ReadOnly = true;
            this.tbFirstname.Size = new System.Drawing.Size(100, 20);
            this.tbFirstname.TabIndex = 10;
            this.tbFirstname.TextChanged += new System.EventHandler(this.tbName_TextChanged);
            // 
            // tbDateOfLastVisit
            // 
            this.tbDateOfLastVisit.Location = new System.Drawing.Point(147, 282);
            this.tbDateOfLastVisit.Name = "tbDateOfLastVisit";
            this.tbDateOfLastVisit.ReadOnly = true;
            this.tbDateOfLastVisit.Size = new System.Drawing.Size(100, 20);
            this.tbDateOfLastVisit.TabIndex = 9;
            // 
            // lPhone
            // 
            this.lPhone.AutoSize = true;
            this.lPhone.Location = new System.Drawing.Point(31, 117);
            this.lPhone.Name = "lPhone";
            this.lPhone.Size = new System.Drawing.Size(38, 13);
            this.lPhone.TabIndex = 8;
            this.lPhone.Text = "Phone";
            // 
            // lDOB
            // 
            this.lDOB.AutoSize = true;
            this.lDOB.Location = new System.Drawing.Point(31, 259);
            this.lDOB.Name = "lDOB";
            this.lDOB.Size = new System.Drawing.Size(66, 13);
            this.lDOB.TabIndex = 7;
            this.lDOB.Text = "Date of Birth";
            this.lDOB.Click += new System.EventHandler(this.label8_Click);
            // 
            // lZip
            // 
            this.lZip.AutoSize = true;
            this.lZip.Location = new System.Drawing.Point(31, 230);
            this.lZip.Name = "lZip";
            this.lZip.Size = new System.Drawing.Size(22, 13);
            this.lZip.TabIndex = 6;
            this.lZip.Text = "Zip";
            // 
            // lState
            // 
            this.lState.AutoSize = true;
            this.lState.Location = new System.Drawing.Point(31, 201);
            this.lState.Name = "lState";
            this.lState.Size = new System.Drawing.Size(32, 13);
            this.lState.TabIndex = 5;
            this.lState.Text = "State";
            // 
            // lStreet
            // 
            this.lStreet.AutoSize = true;
            this.lStreet.Location = new System.Drawing.Point(31, 141);
            this.lStreet.Name = "lStreet";
            this.lStreet.Size = new System.Drawing.Size(35, 13);
            this.lStreet.TabIndex = 4;
            this.lStreet.Text = "Street";
            // 
            // lCity
            // 
            this.lCity.AutoSize = true;
            this.lCity.Location = new System.Drawing.Point(31, 171);
            this.lCity.Name = "lCity";
            this.lCity.Size = new System.Drawing.Size(24, 13);
            this.lCity.TabIndex = 3;
            this.lCity.Text = "City";
            // 
            // lDateOfLastVisit
            // 
            this.lDateOfLastVisit.AutoSize = true;
            this.lDateOfLastVisit.Location = new System.Drawing.Point(31, 289);
            this.lDateOfLastVisit.Name = "lDateOfLastVisit";
            this.lDateOfLastVisit.Size = new System.Drawing.Size(87, 13);
            this.lDateOfLastVisit.TabIndex = 2;
            this.lDateOfLastVisit.Text = "Date of Last Visit";
            // 
            // lFirstname
            // 
            this.lFirstname.AutoSize = true;
            this.lFirstname.Location = new System.Drawing.Point(31, 59);
            this.lFirstname.Name = "lFirstname";
            this.lFirstname.Size = new System.Drawing.Size(57, 13);
            this.lFirstname.TabIndex = 1;
            this.lFirstname.Text = "First Name";
            // 
            // tpAllergies
            // 
            this.tpAllergies.Location = new System.Drawing.Point(4, 22);
            this.tpAllergies.Name = "tpAllergies";
            this.tpAllergies.Size = new System.Drawing.Size(691, 561);
            this.tpAllergies.TabIndex = 4;
            this.tpAllergies.Text = "Allergies";
            this.tpAllergies.UseVisualStyleBackColor = true;
            // 
            // tpMedication
            // 
            this.tpMedication.Location = new System.Drawing.Point(4, 22);
            this.tpMedication.Name = "tpMedication";
            this.tpMedication.Size = new System.Drawing.Size(691, 561);
            this.tpMedication.TabIndex = 7;
            this.tpMedication.Text = "Medication";
            this.tpMedication.UseVisualStyleBackColor = true;
            // 
            // tpVitals
            // 
            this.tpVitals.Location = new System.Drawing.Point(4, 22);
            this.tpVitals.Name = "tpVitals";
            this.tpVitals.Size = new System.Drawing.Size(691, 561);
            this.tpVitals.TabIndex = 6;
            this.tpVitals.Text = "Vitals";
            this.tpVitals.UseVisualStyleBackColor = true;
            // 
            // tpDiabeticMeds
            // 
            this.tpDiabeticMeds.Location = new System.Drawing.Point(4, 22);
            this.tpDiabeticMeds.Name = "tpDiabeticMeds";
            this.tpDiabeticMeds.Size = new System.Drawing.Size(691, 561);
            this.tpDiabeticMeds.TabIndex = 3;
            this.tpDiabeticMeds.Text = "Diabetic Meds";
            this.tpDiabeticMeds.UseVisualStyleBackColor = true;
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
            // tpDiabeticBackground
            // 
            this.tpDiabeticBackground.Location = new System.Drawing.Point(4, 22);
            this.tpDiabeticBackground.Name = "tpDiabeticBackground";
            this.tpDiabeticBackground.Size = new System.Drawing.Size(691, 561);
            this.tpDiabeticBackground.TabIndex = 5;
            this.tpDiabeticBackground.Text = "Diabetic Background";
            this.tpDiabeticBackground.UseVisualStyleBackColor = true;
            // 
            // tpNotes
            // 
            this.tpNotes.Location = new System.Drawing.Point(4, 22);
            this.tpNotes.Name = "tpNotes";
            this.tpNotes.Padding = new System.Windows.Forms.Padding(3);
            this.tpNotes.Size = new System.Drawing.Size(691, 561);
            this.tpNotes.TabIndex = 8;
            this.tpNotes.Text = "Notes";
            this.tpNotes.UseVisualStyleBackColor = true;
            // 
            // Patient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 611);
            this.Controls.Add(this.tcPatient);
            this.Name = "Patient";
            this.Text = "Patient";
            this.Load += new System.EventHandler(this.Patient_Load);
            this.tcPatient.ResumeLayout(false);
            this.tpDemographics.ResumeLayout(false);
            this.tpDemographics.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcPatient;
        private System.Windows.Forms.TabPage tpDemographics;
        private System.Windows.Forms.TabPage tpLipidTest;
        private System.Windows.Forms.TabPage tpDiabeticTest;
        private System.Windows.Forms.Label lPhone;
        private System.Windows.Forms.Label lDOB;
        private System.Windows.Forms.Label lZip;
        private System.Windows.Forms.Label lState;
        private System.Windows.Forms.Label lStreet;
        private System.Windows.Forms.Label lCity;
        private System.Windows.Forms.Label lDateOfLastVisit;
        private System.Windows.Forms.Label lFirstname;
        private System.Windows.Forms.TabPage tpAllergies;
        private System.Windows.Forms.TabPage tpMedication;
        private System.Windows.Forms.TabPage tpVitals;
        private System.Windows.Forms.TabPage tpDiabeticMeds;
        private System.Windows.Forms.TabPage tpDiabeticBackground;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.TextBox tbDOB;
        private System.Windows.Forms.TextBox tbZip;
        private System.Windows.Forms.TextBox tbState;
        private System.Windows.Forms.TextBox tbCity;
        private System.Windows.Forms.TextBox tbStreet;
        private System.Windows.Forms.TextBox tbFirstname;
        private System.Windows.Forms.TextBox tbDateOfLastVisit;
        private System.Windows.Forms.Label lInsurance;
        private System.Windows.Forms.Button bTrends;
        private System.Windows.Forms.Button bEdit;
        private System.Windows.Forms.Button bDelete;
        private System.Windows.Forms.TextBox tbSecondaryInsurance;
        private System.Windows.Forms.TextBox tbPrimaryInsurance;
        private System.Windows.Forms.Label lSecondaryInsurance;
        private System.Windows.Forms.Label lPrimaryInsurance;
        private System.Windows.Forms.TextBox tbLastname;
        private System.Windows.Forms.Label lLastName;
        private System.Windows.Forms.Button visitDateUpdate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tpNotes;
    }
}