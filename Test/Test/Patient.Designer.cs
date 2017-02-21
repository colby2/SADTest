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
            this.tpDiabeticMeds = new System.Windows.Forms.TabPage();
            this.tpAllergies = new System.Windows.Forms.TabPage();
            this.tpDiabeticBackground = new System.Windows.Forms.TabPage();
            this.tpVitals = new System.Windows.Forms.TabPage();
            this.tpMedication = new System.Windows.Forms.TabPage();
            this.tpInsurance = new System.Windows.Forms.TabPage();
            this.tpNotes = new System.Windows.Forms.TabPage();
            this.lPatientId = new System.Windows.Forms.Label();
            this.lName = new System.Windows.Forms.Label();
            this.lDateOfLastVisit = new System.Windows.Forms.Label();
            this.lCity = new System.Windows.Forms.Label();
            this.lStreet = new System.Windows.Forms.Label();
            this.lState = new System.Windows.Forms.Label();
            this.lZip = new System.Windows.Forms.Label();
            this.lAge = new System.Windows.Forms.Label();
            this.lPhone = new System.Windows.Forms.Label();
            this.tbDateOfLastVisit = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbPatientId = new System.Windows.Forms.TextBox();
            this.tbStreet = new System.Windows.Forms.TextBox();
            this.tbCity = new System.Windows.Forms.TextBox();
            this.tbState = new System.Windows.Forms.TextBox();
            this.tbZip = new System.Windows.Forms.TextBox();
            this.tbAge = new System.Windows.Forms.TextBox();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.tcPatient.SuspendLayout();
            this.tpDemographics.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcPatient
            // 
            this.tcPatient.Controls.Add(this.tpDemographics);
            this.tcPatient.Controls.Add(this.tpInsurance);
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
            this.tpDemographics.Controls.Add(this.tbPhone);
            this.tpDemographics.Controls.Add(this.tbAge);
            this.tpDemographics.Controls.Add(this.tbZip);
            this.tpDemographics.Controls.Add(this.tbState);
            this.tpDemographics.Controls.Add(this.tbCity);
            this.tpDemographics.Controls.Add(this.tbStreet);
            this.tpDemographics.Controls.Add(this.tbPatientId);
            this.tpDemographics.Controls.Add(this.tbName);
            this.tpDemographics.Controls.Add(this.tbDateOfLastVisit);
            this.tpDemographics.Controls.Add(this.lPhone);
            this.tpDemographics.Controls.Add(this.lAge);
            this.tpDemographics.Controls.Add(this.lZip);
            this.tpDemographics.Controls.Add(this.lState);
            this.tpDemographics.Controls.Add(this.lStreet);
            this.tpDemographics.Controls.Add(this.lCity);
            this.tpDemographics.Controls.Add(this.lDateOfLastVisit);
            this.tpDemographics.Controls.Add(this.lName);
            this.tpDemographics.Controls.Add(this.lPatientId);
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
            // tpDiabeticMeds
            // 
            this.tpDiabeticMeds.Location = new System.Drawing.Point(4, 22);
            this.tpDiabeticMeds.Name = "tpDiabeticMeds";
            this.tpDiabeticMeds.Size = new System.Drawing.Size(691, 561);
            this.tpDiabeticMeds.TabIndex = 3;
            this.tpDiabeticMeds.Text = "Diabetic Meds";
            this.tpDiabeticMeds.UseVisualStyleBackColor = true;
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
            // tpDiabeticBackground
            // 
            this.tpDiabeticBackground.Location = new System.Drawing.Point(4, 22);
            this.tpDiabeticBackground.Name = "tpDiabeticBackground";
            this.tpDiabeticBackground.Size = new System.Drawing.Size(691, 561);
            this.tpDiabeticBackground.TabIndex = 5;
            this.tpDiabeticBackground.Text = "Diabetic Background";
            this.tpDiabeticBackground.UseVisualStyleBackColor = true;
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
            // tpMedication
            // 
            this.tpMedication.Location = new System.Drawing.Point(4, 22);
            this.tpMedication.Name = "tpMedication";
            this.tpMedication.Size = new System.Drawing.Size(691, 561);
            this.tpMedication.TabIndex = 7;
            this.tpMedication.Text = "Medication";
            this.tpMedication.UseVisualStyleBackColor = true;
            // 
            // tpInsurance
            // 
            this.tpInsurance.Location = new System.Drawing.Point(4, 22);
            this.tpInsurance.Name = "tpInsurance";
            this.tpInsurance.Size = new System.Drawing.Size(691, 561);
            this.tpInsurance.TabIndex = 8;
            this.tpInsurance.Text = "Insurance";
            this.tpInsurance.UseVisualStyleBackColor = true;
            // 
            // tpNotes
            // 
            this.tpNotes.Location = new System.Drawing.Point(4, 22);
            this.tpNotes.Name = "tpNotes";
            this.tpNotes.Size = new System.Drawing.Size(691, 561);
            this.tpNotes.TabIndex = 9;
            this.tpNotes.Text = "Notes";
            this.tpNotes.UseVisualStyleBackColor = true;
            // 
            // lPatientId
            // 
            this.lPatientId.AutoSize = true;
            this.lPatientId.Location = new System.Drawing.Point(28, 30);
            this.lPatientId.Name = "lPatientId";
            this.lPatientId.Size = new System.Drawing.Size(54, 13);
            this.lPatientId.TabIndex = 0;
            this.lPatientId.Text = "Patient ID";
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Location = new System.Drawing.Point(31, 59);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(35, 13);
            this.lName.TabIndex = 1;
            this.lName.Text = "Name";
            // 
            // lDateOfLastVisit
            // 
            this.lDateOfLastVisit.AutoSize = true;
            this.lDateOfLastVisit.Location = new System.Drawing.Point(28, 87);
            this.lDateOfLastVisit.Name = "lDateOfLastVisit";
            this.lDateOfLastVisit.Size = new System.Drawing.Size(87, 13);
            this.lDateOfLastVisit.TabIndex = 2;
            this.lDateOfLastVisit.Text = "Date of Last Visit";
            // 
            // lCity
            // 
            this.lCity.AutoSize = true;
            this.lCity.Location = new System.Drawing.Point(28, 141);
            this.lCity.Name = "lCity";
            this.lCity.Size = new System.Drawing.Size(24, 13);
            this.lCity.TabIndex = 3;
            this.lCity.Text = "City";
            // 
            // lStreet
            // 
            this.lStreet.AutoSize = true;
            this.lStreet.Location = new System.Drawing.Point(28, 113);
            this.lStreet.Name = "lStreet";
            this.lStreet.Size = new System.Drawing.Size(35, 13);
            this.lStreet.TabIndex = 4;
            this.lStreet.Text = "Street";
            // 
            // lState
            // 
            this.lState.AutoSize = true;
            this.lState.Location = new System.Drawing.Point(28, 171);
            this.lState.Name = "lState";
            this.lState.Size = new System.Drawing.Size(32, 13);
            this.lState.TabIndex = 5;
            this.lState.Text = "State";
            // 
            // lZip
            // 
            this.lZip.AutoSize = true;
            this.lZip.Location = new System.Drawing.Point(28, 201);
            this.lZip.Name = "lZip";
            this.lZip.Size = new System.Drawing.Size(22, 13);
            this.lZip.TabIndex = 6;
            this.lZip.Text = "Zip";
            // 
            // lAge
            // 
            this.lAge.AutoSize = true;
            this.lAge.Location = new System.Drawing.Point(28, 230);
            this.lAge.Name = "lAge";
            this.lAge.Size = new System.Drawing.Size(26, 13);
            this.lAge.TabIndex = 7;
            this.lAge.Text = "Age";
            this.lAge.Click += new System.EventHandler(this.label8_Click);
            // 
            // lPhone
            // 
            this.lPhone.AutoSize = true;
            this.lPhone.Location = new System.Drawing.Point(28, 259);
            this.lPhone.Name = "lPhone";
            this.lPhone.Size = new System.Drawing.Size(38, 13);
            this.lPhone.TabIndex = 8;
            this.lPhone.Text = "Phone";
            // 
            // tbDateOfLastVisit
            // 
            this.tbDateOfLastVisit.Location = new System.Drawing.Point(121, 84);
            this.tbDateOfLastVisit.Name = "tbDateOfLastVisit";
            this.tbDateOfLastVisit.Size = new System.Drawing.Size(100, 20);
            this.tbDateOfLastVisit.TabIndex = 9;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(121, 56);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 20);
            this.tbName.TabIndex = 10;
            // 
            // tbPatientId
            // 
            this.tbPatientId.Location = new System.Drawing.Point(121, 27);
            this.tbPatientId.Name = "tbPatientId";
            this.tbPatientId.Size = new System.Drawing.Size(100, 20);
            this.tbPatientId.TabIndex = 11;
            // 
            // tbStreet
            // 
            this.tbStreet.Location = new System.Drawing.Point(121, 110);
            this.tbStreet.Name = "tbStreet";
            this.tbStreet.Size = new System.Drawing.Size(100, 20);
            this.tbStreet.TabIndex = 12;
            // 
            // tbCity
            // 
            this.tbCity.Location = new System.Drawing.Point(121, 138);
            this.tbCity.Name = "tbCity";
            this.tbCity.Size = new System.Drawing.Size(100, 20);
            this.tbCity.TabIndex = 13;
            // 
            // tbState
            // 
            this.tbState.Location = new System.Drawing.Point(121, 168);
            this.tbState.Name = "tbState";
            this.tbState.Size = new System.Drawing.Size(100, 20);
            this.tbState.TabIndex = 14;
            // 
            // tbZip
            // 
            this.tbZip.Location = new System.Drawing.Point(121, 198);
            this.tbZip.Name = "tbZip";
            this.tbZip.Size = new System.Drawing.Size(100, 20);
            this.tbZip.TabIndex = 15;
            // 
            // tbAge
            // 
            this.tbAge.Location = new System.Drawing.Point(121, 227);
            this.tbAge.Name = "tbAge";
            this.tbAge.Size = new System.Drawing.Size(100, 20);
            this.tbAge.TabIndex = 16;
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(121, 256);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(100, 20);
            this.tbPhone.TabIndex = 17;
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
        private System.Windows.Forms.Label lAge;
        private System.Windows.Forms.Label lZip;
        private System.Windows.Forms.Label lState;
        private System.Windows.Forms.Label lStreet;
        private System.Windows.Forms.Label lCity;
        private System.Windows.Forms.Label lDateOfLastVisit;
        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.Label lPatientId;
        private System.Windows.Forms.TabPage tpInsurance;
        private System.Windows.Forms.TabPage tpAllergies;
        private System.Windows.Forms.TabPage tpMedication;
        private System.Windows.Forms.TabPage tpVitals;
        private System.Windows.Forms.TabPage tpDiabeticMeds;
        private System.Windows.Forms.TabPage tpDiabeticBackground;
        private System.Windows.Forms.TabPage tpNotes;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.TextBox tbAge;
        private System.Windows.Forms.TextBox tbZip;
        private System.Windows.Forms.TextBox tbState;
        private System.Windows.Forms.TextBox tbCity;
        private System.Windows.Forms.TextBox tbStreet;
        private System.Windows.Forms.TextBox tbPatientId;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbDateOfLastVisit;
    }
}