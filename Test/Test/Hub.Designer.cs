namespace Test
{
    partial class Hub
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hub));
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.bSearch = new System.Windows.Forms.Button();
            this.bLogout = new System.Windows.Forms.Button();
            this.bAdd = new System.Windows.Forms.Button();
            this.bGraphs = new System.Windows.Forms.Button();
            this.lvSearchList = new System.Windows.Forms.ListView();
            this.FirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DOB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UniqueID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.cbFirstName = new System.Windows.Forms.CheckBox();
            this.cbLastName = new System.Windows.Forms.CheckBox();
            this.cbDOB = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbSearch
            // 
            this.tbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSearch.Location = new System.Drawing.Point(245, 83);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(187, 20);
            this.tbSearch.TabIndex = 0;
            this.tbSearch.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // bSearch
            // 
            this.bSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bSearch.Location = new System.Drawing.Point(438, 80);
            this.bSearch.Name = "bSearch";
            this.bSearch.Size = new System.Drawing.Size(75, 23);
            this.bSearch.TabIndex = 1;
            this.bSearch.Text = "Search";
            this.bSearch.UseVisualStyleBackColor = true;
            this.bSearch.Click += new System.EventHandler(this.bSearch_Click);
            // 
            // bLogout
            // 
            this.bLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bLogout.Location = new System.Drawing.Point(438, 12);
            this.bLogout.Name = "bLogout";
            this.bLogout.Size = new System.Drawing.Size(75, 23);
            this.bLogout.TabIndex = 2;
            this.bLogout.Text = "Logout";
            this.bLogout.UseVisualStyleBackColor = true;
            this.bLogout.Click += new System.EventHandler(this.bLogout_Click);
            // 
            // bAdd
            // 
            this.bAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bAdd.Location = new System.Drawing.Point(438, 109);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(75, 23);
            this.bAdd.TabIndex = 3;
            this.bAdd.Text = "Add";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // bGraphs
            // 
            this.bGraphs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bGraphs.Location = new System.Drawing.Point(438, 138);
            this.bGraphs.Name = "bGraphs";
            this.bGraphs.Size = new System.Drawing.Size(75, 23);
            this.bGraphs.TabIndex = 4;
            this.bGraphs.Text = "Graphs";
            this.bGraphs.UseVisualStyleBackColor = true;
            this.bGraphs.Click += new System.EventHandler(this.bGraphs_Click);
            // 
            // lvSearchList
            // 
            this.lvSearchList.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lvSearchList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FirstName,
            this.LastName,
            this.DOB,
            this.UniqueID});
            this.lvSearchList.Location = new System.Drawing.Point(12, 183);
            this.lvSearchList.Name = "lvSearchList";
            this.lvSearchList.Size = new System.Drawing.Size(500, 240);
            this.lvSearchList.TabIndex = 6;
            this.lvSearchList.UseCompatibleStateImageBehavior = false;
            this.lvSearchList.View = System.Windows.Forms.View.Details;
            this.lvSearchList.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // FirstName
            // 
            this.FirstName.Text = "First Name";
            this.FirstName.Width = 124;
            // 
            // LastName
            // 
            this.LastName.Text = "Last Name";
            this.LastName.Width = 124;
            // 
            // DOB
            // 
            this.DOB.Text = "DOB";
            this.DOB.Width = 124;
            // 
            // UniqueID
            // 
            this.UniqueID.Text = "Unique ID";
            this.UniqueID.Width = 124;
            // 
            // cbFirstName
            // 
            this.cbFirstName.AutoSize = true;
            this.cbFirstName.Checked = true;
            this.cbFirstName.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbFirstName.Location = new System.Drawing.Point(12, 25);
            this.cbFirstName.Name = "cbFirstName";
            this.cbFirstName.Size = new System.Drawing.Size(76, 17);
            this.cbFirstName.TabIndex = 7;
            this.cbFirstName.Text = "First Name";
            this.cbFirstName.UseVisualStyleBackColor = true;
            // 
            // cbLastName
            // 
            this.cbLastName.AutoSize = true;
            this.cbLastName.Checked = true;
            this.cbLastName.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbLastName.Location = new System.Drawing.Point(12, 48);
            this.cbLastName.Name = "cbLastName";
            this.cbLastName.Size = new System.Drawing.Size(77, 17);
            this.cbLastName.TabIndex = 8;
            this.cbLastName.Text = "Last Name";
            this.cbLastName.UseVisualStyleBackColor = true;
            // 
            // cbDOB
            // 
            this.cbDOB.AutoSize = true;
            this.cbDOB.Checked = true;
            this.cbDOB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbDOB.Location = new System.Drawing.Point(12, 71);
            this.cbDOB.Name = "cbDOB";
            this.cbDOB.Size = new System.Drawing.Size(49, 17);
            this.cbDOB.TabIndex = 9;
            this.cbDOB.Text = "DOB";
            this.cbDOB.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Search By:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Hub
            // 
            this.AcceptButton = this.bSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(525, 435);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbDOB);
            this.Controls.Add(this.cbLastName);
            this.Controls.Add(this.cbFirstName);
            this.Controls.Add(this.lvSearchList);
            this.Controls.Add(this.bGraphs);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.bLogout);
            this.Controls.Add(this.bSearch);
            this.Controls.Add(this.tbSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Hub";
            this.Text = "Search Page";
            this.Load += new System.EventHandler(this.Hub_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bSearch;
        private System.Windows.Forms.Button bLogout;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.Button bGraphs;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.ListView lvSearchList;
        private System.Windows.Forms.ColumnHeader FirstName;
        private System.Windows.Forms.ColumnHeader LastName;
        private System.Windows.Forms.ColumnHeader DOB;
        private System.Windows.Forms.ColumnHeader UniqueID;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.CheckBox cbFirstName;
        private System.Windows.Forms.CheckBox cbLastName;
        private System.Windows.Forms.CheckBox cbDOB;
        private System.Windows.Forms.Label label1;
    }
}