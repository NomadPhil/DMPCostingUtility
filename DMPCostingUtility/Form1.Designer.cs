namespace DMPCostingUtility
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.lblExportDirectory = new System.Windows.Forms.Label();
            this.txtExportDirectory = new System.Windows.Forms.TextBox();
            this.lblImportDirectory = new System.Windows.Forms.Label();
            this.txtImportDirectory = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.lblBaseCost = new System.Windows.Forms.Label();
            this.txtBaseCost = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPerItemCost = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.txtProcessedDirectory = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblExportDirectory
            // 
            this.lblExportDirectory.AutoSize = true;
            this.lblExportDirectory.Location = new System.Drawing.Point(98, 304);
            this.lblExportDirectory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExportDirectory.Name = "lblExportDirectory";
            this.lblExportDirectory.Size = new System.Drawing.Size(156, 17);
            this.lblExportDirectory.TabIndex = 8;
            this.lblExportDirectory.Text = "Directory of costed files";
            // 
            // txtExportDirectory
            // 
            this.txtExportDirectory.Location = new System.Drawing.Point(99, 336);
            this.txtExportDirectory.Margin = new System.Windows.Forms.Padding(4);
            this.txtExportDirectory.Name = "txtExportDirectory";
            this.txtExportDirectory.Size = new System.Drawing.Size(608, 22);
            this.txtExportDirectory.TabIndex = 4;
            // 
            // lblImportDirectory
            // 
            this.lblImportDirectory.AutoSize = true;
            this.lblImportDirectory.Location = new System.Drawing.Point(95, 203);
            this.lblImportDirectory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblImportDirectory.Name = "lblImportDirectory";
            this.lblImportDirectory.Size = new System.Drawing.Size(278, 17);
            this.lblImportDirectory.TabIndex = 6;
            this.lblImportDirectory.Text = "Directory of Woo Commerce Exported Files";
            // 
            // txtImportDirectory
            // 
            this.txtImportDirectory.Location = new System.Drawing.Point(99, 239);
            this.txtImportDirectory.Margin = new System.Windows.Forms.Padding(4);
            this.txtImportDirectory.Name = "txtImportDirectory";
            this.txtImportDirectory.Size = new System.Drawing.Size(608, 22);
            this.txtImportDirectory.TabIndex = 3;
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(530, 507);
            this.btnConvert.Margin = new System.Windows.Forms.Padding(4);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(177, 28);
            this.btnConvert.TabIndex = 6;
            this.btnConvert.Text = "Cost Orders";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // lblBaseCost
            // 
            this.lblBaseCost.AutoSize = true;
            this.lblBaseCost.Location = new System.Drawing.Point(94, 24);
            this.lblBaseCost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBaseCost.Name = "lblBaseCost";
            this.lblBaseCost.Size = new System.Drawing.Size(70, 17);
            this.lblBaseCost.TabIndex = 11;
            this.lblBaseCost.Text = "Base cost";
            // 
            // txtBaseCost
            // 
            this.txtBaseCost.Location = new System.Drawing.Point(98, 60);
            this.txtBaseCost.Margin = new System.Windows.Forms.Padding(4);
            this.txtBaseCost.Name = "txtBaseCost";
            this.txtBaseCost.Size = new System.Drawing.Size(152, 22);
            this.txtBaseCost.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 101);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Cost per additional item";
            // 
            // txtPerItemCost
            // 
            this.txtPerItemCost.Location = new System.Drawing.Point(98, 137);
            this.txtPerItemCost.Margin = new System.Windows.Forms.Padding(4);
            this.txtPerItemCost.Name = "txtPerItemCost";
            this.txtPerItemCost.Size = new System.Drawing.Size(152, 22);
            this.txtPerItemCost.TabIndex = 2;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 395);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(313, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Directory of costed Woo Comerce Exported Files";
            // 
            // txtProcessedDirectory
            // 
            this.txtProcessedDirectory.Location = new System.Drawing.Point(101, 429);
            this.txtProcessedDirectory.Margin = new System.Windows.Forms.Padding(4);
            this.txtProcessedDirectory.Name = "txtProcessedDirectory";
            this.txtProcessedDirectory.Size = new System.Drawing.Size(608, 22);
            this.txtProcessedDirectory.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 558);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtProcessedDirectory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPerItemCost);
            this.Controls.Add(this.lblBaseCost);
            this.Controls.Add(this.txtBaseCost);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.lblExportDirectory);
            this.Controls.Add(this.txtExportDirectory);
            this.Controls.Add(this.lblImportDirectory);
            this.Controls.Add(this.txtImportDirectory);
            this.Name = "Form1";
            this.Text = "DMP Costing Utility";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblExportDirectory;
        private System.Windows.Forms.TextBox txtExportDirectory;
        private System.Windows.Forms.Label lblImportDirectory;
        private System.Windows.Forms.TextBox txtImportDirectory;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Label lblBaseCost;
        private System.Windows.Forms.TextBox txtBaseCost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPerItemCost;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProcessedDirectory;
    }
}

