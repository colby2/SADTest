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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bSearch = new System.Windows.Forms.Button();
            this.bLogout = new System.Windows.Forms.Button();
            this.bAdd = new System.Windows.Forms.Button();
            this.bGraphs = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(195, 83);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(187, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // bSearch
            // 
            this.bSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bSearch.Location = new System.Drawing.Point(388, 80);
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
            this.bLogout.Location = new System.Drawing.Point(388, 12);
            this.bLogout.Name = "bLogout";
            this.bLogout.Size = new System.Drawing.Size(75, 23);
            this.bLogout.TabIndex = 2;
            this.bLogout.Text = "Logout";
            this.bLogout.UseVisualStyleBackColor = true;
            // 
            // bAdd
            // 
            this.bAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bAdd.Location = new System.Drawing.Point(388, 109);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(75, 23);
            this.bAdd.TabIndex = 3;
            this.bAdd.Text = "Add";
            this.bAdd.UseVisualStyleBackColor = true;
            // 
            // bGraphs
            // 
            this.bGraphs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bGraphs.Location = new System.Drawing.Point(388, 138);
            this.bGraphs.Name = "bGraphs";
            this.bGraphs.Size = new System.Drawing.Size(75, 23);
            this.bGraphs.TabIndex = 4;
            this.bGraphs.Text = "Graphs";
            this.bGraphs.UseVisualStyleBackColor = true;
            this.bGraphs.Click += new System.EventHandler(this.bGraphs_Click);
            // 
            // Hub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 428);
            this.Controls.Add(this.bGraphs);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.bLogout);
            this.Controls.Add(this.bSearch);
            this.Controls.Add(this.textBox1);
            this.Name = "Hub";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Hub_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button bSearch;
        private System.Windows.Forms.Button bLogout;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.Button bGraphs;
    }
}