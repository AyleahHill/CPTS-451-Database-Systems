namespace YelpPlatform1._1 {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.yelpDBDataSet = new YelpPlatform1._1.YelpDBDataSet();
            this.businessesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.businessesTableAdapter = new YelpPlatform1._1.YelpDBDataSetTableAdapters.BusinessesTableAdapter();
            this.GO = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yelpDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.businessesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(450, 398);
            this.dataGridView1.TabIndex = 0;
            // 
            // yelpDBDataSet
            // 
            this.yelpDBDataSet.DataSetName = "YelpDBDataSet";
            this.yelpDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // businessesBindingSource
            // 
            this.businessesBindingSource.DataMember = "Businesses";
            this.businessesBindingSource.DataSource = this.yelpDBDataSet;
            // 
            // businessesTableAdapter
            // 
            this.businessesTableAdapter.ClearBeforeFill = true;
            // 
            // GO
            // 
            this.GO.Location = new System.Drawing.Point(665, 10);
            this.GO.Name = "GO";
            this.GO.Size = new System.Drawing.Size(75, 23);
            this.GO.TabIndex = 2;
            this.GO.Text = "GO";
            this.GO.UseVisualStyleBackColor = true;
            this.GO.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.GO);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yelpDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.businessesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private YelpDBDataSet yelpDBDataSet;
        private System.Windows.Forms.BindingSource businessesBindingSource;
        private YelpDBDataSetTableAdapters.BusinessesTableAdapter businessesTableAdapter;
        private System.Windows.Forms.Button GO;
    }
}

