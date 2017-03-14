namespace Test
{
    partial class GraphTemplate
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.InputButton = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lvSearch = new System.Windows.Forms.ListView();
            this.searchBar = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.testSelectBox = new System.Windows.Forms.ComboBox();
            this.firstNameCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lastNameCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.doBCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.iDCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // InputButton
            // 
            this.InputButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.InputButton.Location = new System.Drawing.Point(12, 580);
            this.InputButton.Name = "InputButton";
            this.InputButton.Size = new System.Drawing.Size(75, 23);
            this.InputButton.TabIndex = 1;
            this.InputButton.Text = "Input Data";
            this.InputButton.UseVisualStyleBackColor = true;
            this.InputButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 12);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(863, 438);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // lvSearch
            // 
            this.lvSearch.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.firstNameCol,
            this.lastNameCol,
            this.doBCol,
            this.iDCol});
            this.lvSearch.Location = new System.Drawing.Point(12, 456);
            this.lvSearch.Name = "lvSearch";
            this.lvSearch.Size = new System.Drawing.Size(332, 118);
            this.lvSearch.TabIndex = 2;
            this.lvSearch.UseCompatibleStateImageBehavior = false;
            this.lvSearch.View = System.Windows.Forms.View.Details;
            this.lvSearch.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // searchBar
            // 
            this.searchBar.Location = new System.Drawing.Point(350, 456);
            this.searchBar.Name = "searchBar";
            this.searchBar.Size = new System.Drawing.Size(142, 20);
            this.searchBar.TabIndex = 3;
            this.searchBar.TextChanged += new System.EventHandler(this.searchBar_TextChanged);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(498, 456);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 4;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // testSelectBox
            // 
            this.testSelectBox.FormattingEnabled = true;
            this.testSelectBox.Location = new System.Drawing.Point(350, 482);
            this.testSelectBox.Name = "testSelectBox";
            this.testSelectBox.Size = new System.Drawing.Size(142, 21);
            this.testSelectBox.TabIndex = 5;
            // 
            // firstNameCol
            // 
            this.firstNameCol.Text = "First Name";
            this.firstNameCol.Width = 82;
            // 
            // lastNameCol
            // 
            this.lastNameCol.Text = "Last Name";
            this.lastNameCol.Width = 82;
            // 
            // doBCol
            // 
            this.doBCol.Text = "DOB";
            this.doBCol.Width = 82;
            // 
            // iDCol
            // 
            this.iDCol.Text = "Unique ID";
            this.iDCol.Width = 82;
            // 
            // GraphTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 615);
            this.Controls.Add(this.testSelectBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchBar);
            this.Controls.Add(this.lvSearch);
            this.Controls.Add(this.InputButton);
            this.Controls.Add(this.chart1);
            this.Name = "GraphTemplate";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button InputButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ListView lvSearch;
        private System.Windows.Forms.TextBox searchBar;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.ComboBox testSelectBox;
        private System.Windows.Forms.ColumnHeader firstNameCol;
        private System.Windows.Forms.ColumnHeader lastNameCol;
        private System.Windows.Forms.ColumnHeader doBCol;
        private System.Windows.Forms.ColumnHeader iDCol;
    }
}