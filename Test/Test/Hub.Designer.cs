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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbSearch
            // 
            this.tbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSearch.Location = new System.Drawing.Point(881, 77);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(187, 20);
            this.tbSearch.TabIndex = 0;
            this.tbSearch.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // bSearch
            // 
            this.bSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bSearch.Location = new System.Drawing.Point(1074, 74);
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
            this.bLogout.Location = new System.Drawing.Point(1074, 6);
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
            this.bAdd.Location = new System.Drawing.Point(1074, 103);
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
            this.bGraphs.Location = new System.Drawing.Point(1074, 132);
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
            this.lvSearchList.FullRowSelect = true;
            this.lvSearchList.Location = new System.Drawing.Point(9, 104);
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
            this.cbFirstName.Location = new System.Drawing.Point(6, 19);
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
            this.cbLastName.Location = new System.Drawing.Point(6, 42);
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
            this.cbDOB.Location = new System.Drawing.Point(6, 65);
            this.cbDOB.Name = "cbDOB";
            this.cbDOB.Size = new System.Drawing.Size(49, 17);
            this.cbDOB.TabIndex = 9;
            this.cbDOB.Text = "DOB";
            this.cbDOB.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Search By:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl1.Location = new System.Drawing.Point(-2, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1163, 704);
            this.tabControl1.TabIndex = 11;
            this.tabControl1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabControl1_DrawItem);
            this.tabControl1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tabControl1_MouseClick);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Honeydew;
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.bGraphs);
            this.tabPage1.Controls.Add(this.lvSearchList);
            this.tabPage1.Controls.Add(this.bAdd);
            this.tabPage1.Controls.Add(this.cbFirstName);
            this.tabPage1.Controls.Add(this.bLogout);
            this.tabPage1.Controls.Add(this.bSearch);
            this.tabPage1.Controls.Add(this.cbDOB);
            this.tabPage1.Controls.Add(this.tbSearch);
            this.tabPage1.Controls.Add(this.cbLastName);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1155, 678);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Hub";
            // 
            // Hub
            // 
            this.AcceptButton = this.bSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1157, 701);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Hub";
            this.Text = "Search Page";
            this.Load += new System.EventHandler(this.Hub_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
    }
}