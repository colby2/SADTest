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
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.bSearch = new System.Windows.Forms.Button();
            this.bLogout = new System.Windows.Forms.Button();
            this.bAdd = new System.Windows.Forms.Button();
            this.bGraphs = new System.Windows.Forms.Button();
            this.lbSearchList = new System.Windows.Forms.ListBox();
            this.lvSearchList = new System.Windows.Forms.ListView();
            this.FirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DOB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UniqueID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // tbSearch
            // 
            this.tbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSearch.Location = new System.Drawing.Point(574, 83);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(187, 20);
            this.tbSearch.TabIndex = 0;
            this.tbSearch.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // bSearch
            // 
            this.bSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bSearch.Location = new System.Drawing.Point(767, 80);
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
            this.bLogout.Location = new System.Drawing.Point(767, 12);
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
            this.bAdd.Location = new System.Drawing.Point(767, 109);
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
            this.bGraphs.Location = new System.Drawing.Point(767, 138);
            this.bGraphs.Name = "bGraphs";
            this.bGraphs.Size = new System.Drawing.Size(75, 23);
            this.bGraphs.TabIndex = 4;
            this.bGraphs.Text = "Graphs";
            this.bGraphs.UseVisualStyleBackColor = true;
            this.bGraphs.Click += new System.EventHandler(this.bGraphs_Click);
            // 
            // lbSearchList
            // 
            this.lbSearchList.FormattingEnabled = true;
            this.lbSearchList.Location = new System.Drawing.Point(12, 167);
            this.lbSearchList.Name = "lbSearchList";
            this.lbSearchList.Size = new System.Drawing.Size(830, 264);
            this.lbSearchList.TabIndex = 0;
            this.lbSearchList.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // lvSearchList
            // 
            this.lvSearchList.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lvSearchList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FirstName,
            this.LastName,
            this.DOB,
            this.UniqueID});
            this.lvSearchList.Location = new System.Drawing.Point(12, 64);
            this.lvSearchList.Name = "lvSearchList";
            this.lvSearchList.Size = new System.Drawing.Size(407, 97);
            this.lvSearchList.TabIndex = 6;
            this.lvSearchList.UseCompatibleStateImageBehavior = false;
            this.lvSearchList.View = System.Windows.Forms.View.Details;
            this.lvSearchList.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // FirstName
            // 
            this.FirstName.DisplayIndex = 0;
            this.FirstName.Text = "First Name";
            this.FirstName.Width = 82;
            // 
            // LastName
            // 
            this.LastName.DisplayIndex = 1;
            this.LastName.Text = "Last Name";
            this.LastName.Width = 91;
            // 
            // DOB
            // 
            this.DOB.DisplayIndex = 2;
            this.DOB.Text = "DOB";
            this.DOB.Width = 91;
            // 
            // UniqueID
            // 
            this.UniqueID.DisplayIndex = 3;
            this.UniqueID.Text = "Unique ID";
            // 
            // Hub
            // 
            this.AcceptButton = this.bSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 435);
            this.Controls.Add(this.lvSearchList);
            this.Controls.Add(this.lbSearchList);
            this.Controls.Add(this.bGraphs);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.bLogout);
            this.Controls.Add(this.bSearch);
            this.Controls.Add(this.tbSearch);
            this.Name = "Hub";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Hub_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bSearch;
        private System.Windows.Forms.Button bLogout;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.Button bGraphs;
        private System.Windows.Forms.ListBox lbSearchList;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.ListView lvSearchList;
        private System.Windows.Forms.ColumnHeader FirstName;
        private System.Windows.Forms.ColumnHeader LastName;
        private System.Windows.Forms.ColumnHeader DOB;
        private System.Windows.Forms.ColumnHeader UniqueID;
    }
}