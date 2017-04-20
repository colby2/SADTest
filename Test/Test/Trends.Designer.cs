namespace Test
{
    partial class Trends
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
            this.button1 = new System.Windows.Forms.Button();
            this.TrendLV = new System.Windows.Forms.ListView();
            this.HDL_ = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HgA1C_ = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BMI = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.Filters = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(800, 580);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Screen Shot";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // TrendLV
            // 
            this.TrendLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.HDL_,
            this.HgA1C_,
            this.BMI,
            this.Filters});
            this.TrendLV.Location = new System.Drawing.Point(12, 29);
            this.TrendLV.Name = "TrendLV";
            this.TrendLV.Size = new System.Drawing.Size(862, 429);
            this.TrendLV.TabIndex = 9;
            this.TrendLV.UseCompatibleStateImageBehavior = false;
            this.TrendLV.View = System.Windows.Forms.View.Details;
            this.TrendLV.SelectedIndexChanged += new System.EventHandler(this.TrendLV_SelectedIndexChanged);
            // 
            // HDL_
            // 
            this.HDL_.Text = "HDL";
            this.HDL_.Width = 114;
            // 
            // HgA1C_
            // 
            this.HgA1C_.Text = "HgA1C";
            this.HgA1C_.Width = 100;
            // 
            // BMI
            // 
            this.BMI.Text = "BMI";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Gender"});
            this.checkedListBox1.Location = new System.Drawing.Point(12, 464);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(280, 94);
            this.checkedListBox1.TabIndex = 10;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(298, 464);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 11;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // Filters
            // 
            this.Filters.Text = "Filters";
            // 
            // Trends
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(887, 615);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.TrendLV);
            this.Controls.Add(this.button1);
            this.Name = "Trends";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Trends_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView TrendLV;
        private System.Windows.Forms.ColumnHeader HDL_;
        private System.Windows.Forms.ColumnHeader HgA1C_;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.ColumnHeader BMI;
        private System.Windows.Forms.ColumnHeader Filters;
    }
}