
namespace HealtyALTF4.Reports
{
    partial class FrmReporT
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource17 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource18 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource19 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource20 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.ReportePacienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet1 = new HealtyALTF4.Reports.DataSet1();
            this.ReporteMedicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ReporteDiagnosticoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ReporteEnfermedadesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ReportePacienteTableAdapter = new HealtyALTF4.Reports.DataSet1TableAdapters.ReportePacienteTableAdapter();
            this.ReporteMedicoTableAdapter = new HealtyALTF4.Reports.DataSet1TableAdapters.ReporteMedicoTableAdapter();
            this.ReporteDiagnosticoTableAdapter = new HealtyALTF4.Reports.DataSet1TableAdapters.ReporteDiagnosticoTableAdapter();
            this.ReporteEnfermedadesTableAdapter = new HealtyALTF4.Reports.DataSet1TableAdapters.ReporteEnfermedadesTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.txtNumerito = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.ReportePacienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteMedicoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteDiagnosticoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteEnfermedadesBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ReportePacienteBindingSource
            // 
            this.ReportePacienteBindingSource.DataMember = "ReportePaciente";
            this.ReportePacienteBindingSource.DataSource = this.DataSet1;
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ReporteMedicoBindingSource
            // 
            this.ReporteMedicoBindingSource.DataMember = "ReporteMedico";
            this.ReporteMedicoBindingSource.DataSource = this.DataSet1;
            // 
            // ReporteDiagnosticoBindingSource
            // 
            this.ReporteDiagnosticoBindingSource.DataMember = "ReporteDiagnostico";
            this.ReporteDiagnosticoBindingSource.DataSource = this.DataSet1;
            // 
            // ReporteEnfermedadesBindingSource
            // 
            this.ReporteEnfermedadesBindingSource.DataMember = "ReporteEnfermedades";
            this.ReporteEnfermedadesBindingSource.DataSource = this.DataSet1;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource17.Name = "DataPaciente";
            reportDataSource17.Value = this.ReportePacienteBindingSource;
            reportDataSource18.Name = "DataMedico";
            reportDataSource18.Value = this.ReporteMedicoBindingSource;
            reportDataSource19.Name = "DataDiagnostico";
            reportDataSource19.Value = this.ReporteDiagnosticoBindingSource;
            reportDataSource20.Name = "DataEnfermedad";
            reportDataSource20.Value = this.ReporteEnfermedadesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource17);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource18);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource19);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource20);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "HealtyALTF4.Reports.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 398);
            this.reportViewer1.TabIndex = 0;
            // 
            // ReportePacienteTableAdapter
            // 
            this.ReportePacienteTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteMedicoTableAdapter
            // 
            this.ReporteMedicoTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteDiagnosticoTableAdapter
            // 
            this.ReporteDiagnosticoTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteEnfermedadesTableAdapter
            // 
            this.ReporteEnfermedadesTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.txtNumerito);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 52);
            this.panel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(465, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtNumerito
            // 
            this.txtNumerito.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNumerito.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(26)))), ((int)(((byte)(41)))));
            this.txtNumerito.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNumerito.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumerito.ForeColor = System.Drawing.Color.White;
            this.txtNumerito.Location = new System.Drawing.Point(226, 12);
            this.txtNumerito.Name = "txtNumerito";
            this.txtNumerito.Size = new System.Drawing.Size(233, 19);
            this.txtNumerito.TabIndex = 0;
            this.txtNumerito.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.reportViewer1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 52);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 398);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel3.Location = new System.Drawing.Point(226, 37);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(233, 1);
            this.panel3.TabIndex = 1;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // FrmReporT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(26)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmReporT";
            this.Text = "FrmReporT";
            this.Load += new System.EventHandler(this.FrmReporT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ReportePacienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteMedicoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteDiagnosticoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteEnfermedadesBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ReportePacienteBindingSource;
        private DataSet1 DataSet1;
        private System.Windows.Forms.BindingSource ReporteMedicoBindingSource;
        private System.Windows.Forms.BindingSource ReporteDiagnosticoBindingSource;
        private System.Windows.Forms.BindingSource ReporteEnfermedadesBindingSource;
        private DataSet1TableAdapters.ReportePacienteTableAdapter ReportePacienteTableAdapter;
        private DataSet1TableAdapters.ReporteMedicoTableAdapter ReporteMedicoTableAdapter;
        private DataSet1TableAdapters.ReporteDiagnosticoTableAdapter ReporteDiagnosticoTableAdapter;
        private DataSet1TableAdapters.ReporteEnfermedadesTableAdapter ReporteEnfermedadesTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtNumerito;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}