namespace Test
{
    partial class AddDiabetesBackground
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddDiabetesBackground));
            this.diabetesType = new System.Windows.Forms.TextBox();
            this.dateInfoTaken = new System.Windows.Forms.DateTimePicker();
            this.dateDiagnosed = new System.Windows.Forms.DateTimePicker();
            this.heartRatelb = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // diabetesType
            // 
            this.diabetesType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diabetesType.Location = new System.Drawing.Point(246, 189);
            this.diabetesType.Margin = new System.Windows.Forms.Padding(4);
            this.diabetesType.Multiline = true;
            this.diabetesType.Name = "diabetesType";
            this.diabetesType.Size = new System.Drawing.Size(143, 33);
            this.diabetesType.TabIndex = 9;
            // 
            // dateInfoTaken
            // 
            this.dateInfoTaken.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateInfoTaken.Location = new System.Drawing.Point(246, 128);
            this.dateInfoTaken.Name = "dateInfoTaken";
            this.dateInfoTaken.Size = new System.Drawing.Size(200, 24);
            this.dateInfoTaken.TabIndex = 10;
            // 
            // dateDiagnosed
            // 
            this.dateDiagnosed.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateDiagnosed.Location = new System.Drawing.Point(246, 63);
            this.dateDiagnosed.Name = "dateDiagnosed";
            this.dateDiagnosed.Size = new System.Drawing.Size(200, 24);
            this.dateDiagnosed.TabIndex = 11;
            // 
            // heartRatelb
            // 
            this.heartRatelb.AutoSize = true;
            this.heartRatelb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heartRatelb.Location = new System.Drawing.Point(61, 68);
            this.heartRatelb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.heartRatelb.Name = "heartRatelb";
            this.heartRatelb.Size = new System.Drawing.Size(114, 18);
            this.heartRatelb.TabIndex = 12;
            this.heartRatelb.Text = "Date Diagnosed";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 133);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 18);
            this.label1.TabIndex = 13;
            this.label1.Text = "Date Information Taken";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(73, 196);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 18);
            this.label2.TabIndex = 14;
            this.label2.Text = "Diabetes Type";
            // 
            // AddDiabetesBackground
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 397);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.heartRatelb);
            this.Controls.Add(this.dateDiagnosed);
            this.Controls.Add(this.dateInfoTaken);
            this.Controls.Add(this.diabetesType);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddDiabetesBackground";
            this.Text = "Add Diabetes Background Info";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox diabetesType;
        private System.Windows.Forms.DateTimePicker dateInfoTaken;
        private System.Windows.Forms.DateTimePicker dateDiagnosed;
        private System.Windows.Forms.Label heartRatelb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}