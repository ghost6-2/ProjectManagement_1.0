namespace projekt
{
    partial class IzvjestajForma
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.IzvjestajBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.IzvjestajSet = new projekt.IzvjestajSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.IzvjestajTableAdapter = new projekt.IzvjestajSetTableAdapters.IzvjestajTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.IzvjestajBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IzvjestajSet)).BeginInit();
            this.SuspendLayout();
            // 
            // IzvjestajBindingSource
            // 
            this.IzvjestajBindingSource.DataMember = "Izvjestaj";
            this.IzvjestajBindingSource.DataSource = this.IzvjestajSet;
            // 
            // IzvjestajSet
            // 
            this.IzvjestajSet.DataSetName = "IzvjestajSet";
            this.IzvjestajSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.IzvjestajBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "projekt.Izvjestaj.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(829, 357);
            this.reportViewer1.TabIndex = 0;
            // 
            // IzvjestajTableAdapter
            // 
            this.IzvjestajTableAdapter.ClearBeforeFill = true;
            // 
            // IzvjestajForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(829, 357);
            this.Controls.Add(this.reportViewer1);
            this.Name = "IzvjestajForma";
            this.Text = "IzvjestajForma";
            this.Load += new System.EventHandler(this.IzvjestajForma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.IzvjestajBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IzvjestajSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource IzvjestajBindingSource;
        private IzvjestajSet IzvjestajSet;
        private IzvjestajSetTableAdapters.IzvjestajTableAdapter IzvjestajTableAdapter;
    }
}