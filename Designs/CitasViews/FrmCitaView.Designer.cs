
namespace HealtyALTF4.Designs.CitasViews
{
    partial class FrmCitaView
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSearchPaciente = new System.Windows.Forms.Button();
            this.txtNameP = new System.Windows.Forms.TextBox();
            this.txtIDP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSearchMedico = new System.Windows.Forms.Button();
            this.txtNameM = new System.Windows.Forms.TextBox();
            this.txtIDM = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rtbMotivos = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dtHora = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.dgvCitita = new System.Windows.Forms.DataGridView();
            this.dataSet1 = new HealtyALTF4.Reports.DataSet1();
            this.reporteMedicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reporteMedicoTableAdapter = new HealtyALTF4.Reports.DataSet1TableAdapters.ReporteMedicoTableAdapter();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCitita)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporteMedicoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSearchPaciente);
            this.panel1.Controls.Add(this.txtNameP);
            this.panel1.Controls.Add(this.txtIDP);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1185, 192);
            this.panel1.TabIndex = 0;
            // 
            // btnSearchPaciente
            // 
            this.btnSearchPaciente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchPaciente.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSearchPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchPaciente.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSearchPaciente.ForeColor = System.Drawing.Color.White;
            this.btnSearchPaciente.Location = new System.Drawing.Point(1018, 63);
            this.btnSearchPaciente.Name = "btnSearchPaciente";
            this.btnSearchPaciente.Size = new System.Drawing.Size(150, 35);
            this.btnSearchPaciente.TabIndex = 5;
            this.btnSearchPaciente.Text = "Buscar";
            this.btnSearchPaciente.UseVisualStyleBackColor = true;
            this.btnSearchPaciente.Click += new System.EventHandler(this.btnSearchPaciente_Click);
            // 
            // txtNameP
            // 
            this.txtNameP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNameP.BackColor = System.Drawing.Color.White;
            this.txtNameP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameP.Location = new System.Drawing.Point(284, 126);
            this.txtNameP.Name = "txtNameP";
            this.txtNameP.ReadOnly = true;
            this.txtNameP.Size = new System.Drawing.Size(718, 30);
            this.txtNameP.TabIndex = 4;
            // 
            // txtIDP
            // 
            this.txtIDP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIDP.BackColor = System.Drawing.Color.White;
            this.txtIDP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDP.Location = new System.Drawing.Point(282, 62);
            this.txtIDP.Name = "txtIDP";
            this.txtIDP.ReadOnly = true;
            this.txtIDP.Size = new System.Drawing.Size(718, 30);
            this.txtIDP.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(16, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(243, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre del paciente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(56, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID del paciente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Datos del paciente";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSearchMedico);
            this.panel2.Controls.Add(this.txtNameM);
            this.panel2.Controls.Add(this.txtIDM);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 192);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1185, 180);
            this.panel2.TabIndex = 6;
            // 
            // btnSearchMedico
            // 
            this.btnSearchMedico.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchMedico.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSearchMedico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchMedico.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSearchMedico.ForeColor = System.Drawing.Color.White;
            this.btnSearchMedico.Location = new System.Drawing.Point(1018, 51);
            this.btnSearchMedico.Name = "btnSearchMedico";
            this.btnSearchMedico.Size = new System.Drawing.Size(150, 35);
            this.btnSearchMedico.TabIndex = 5;
            this.btnSearchMedico.Text = "Buscar";
            this.btnSearchMedico.UseVisualStyleBackColor = true;
            this.btnSearchMedico.Click += new System.EventHandler(this.btnSearchMedico_Click);
            // 
            // txtNameM
            // 
            this.txtNameM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNameM.BackColor = System.Drawing.Color.White;
            this.txtNameM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameM.Location = new System.Drawing.Point(284, 118);
            this.txtNameM.Name = "txtNameM";
            this.txtNameM.ReadOnly = true;
            this.txtNameM.Size = new System.Drawing.Size(716, 30);
            this.txtNameM.TabIndex = 4;
            // 
            // txtIDM
            // 
            this.txtIDM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIDM.BackColor = System.Drawing.Color.White;
            this.txtIDM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDM.Location = new System.Drawing.Point(282, 51);
            this.txtIDM.Name = "txtIDM";
            this.txtIDM.ReadOnly = true;
            this.txtIDM.Size = new System.Drawing.Size(718, 30);
            this.txtIDM.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(30, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(229, 28);
            this.label4.TabIndex = 2;
            this.label4.Text = "Nombre del médico";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(58, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 28);
            this.label5.TabIndex = 1;
            this.label5.Text = "ID del médico";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(3, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(222, 28);
            this.label6.TabIndex = 0;
            this.label6.Text = "Datos del médico";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rtbMotivos);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.dtHora);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.dtFecha);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 372);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1185, 318);
            this.panel3.TabIndex = 7;
            // 
            // rtbMotivos
            // 
            this.rtbMotivos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbMotivos.Location = new System.Drawing.Point(34, 192);
            this.rtbMotivos.Name = "rtbMotivos";
            this.rtbMotivos.Size = new System.Drawing.Size(967, 95);
            this.rtbMotivos.TabIndex = 5;
            this.rtbMotivos.Text = "";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(42, 162);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 28);
            this.label9.TabIndex = 4;
            this.label9.Text = "Motivos";
            // 
            // dtHora
            // 
            this.dtHora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtHora.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtHora.Location = new System.Drawing.Point(282, 98);
            this.dtHora.Name = "dtHora";
            this.dtHora.ShowUpDown = true;
            this.dtHora.Size = new System.Drawing.Size(720, 30);
            this.dtHora.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(42, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(174, 28);
            this.label8.TabIndex = 2;
            this.label8.Text = "Hora de la cita";
            // 
            // dtFecha
            // 
            this.dtFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFecha.Location = new System.Drawing.Point(282, 37);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(718, 30);
            this.dtFecha.TabIndex = 1;
            this.dtFecha.ValueChanged += new System.EventHandler(this.dtFecha_ValueChanged);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(42, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(185, 28);
            this.label7.TabIndex = 0;
            this.label7.Text = "Fecha de la cita";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnSave);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 935);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1185, 115);
            this.panel4.TabIndex = 8;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(500, 35);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(206, 54);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dgvCitita
            // 
            this.dgvCitita.BackgroundColor = System.Drawing.Color.White;
            this.dgvCitita.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCitita.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCitita.Location = new System.Drawing.Point(0, 690);
            this.dgvCitita.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvCitita.Name = "dgvCitita";
            this.dgvCitita.RowHeadersWidth = 62;
            this.dgvCitita.Size = new System.Drawing.Size(1185, 245);
            this.dgvCitita.TabIndex = 9;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reporteMedicoBindingSource
            // 
            this.reporteMedicoBindingSource.DataMember = "ReporteMedico";
            this.reporteMedicoBindingSource.DataSource = this.dataSet1;
            // 
            // reporteMedicoTableAdapter
            // 
            this.reporteMedicoTableAdapter.ClearBeforeFill = true;
            // 
            // FrmCitaView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(26)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(1185, 1050);
            this.Controls.Add(this.dgvCitita);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmCitaView";
            this.Text = "FrmCitaView";
            this.Load += new System.EventHandler(this.FrmCitaView_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCitita)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporteMedicoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSearchPaciente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSearchMedico;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RichTextBox rtbMotivos;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtHora;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtFecha;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.TextBox txtNameP;
        public System.Windows.Forms.TextBox txtIDP;
        public System.Windows.Forms.TextBox txtNameM;
        public System.Windows.Forms.TextBox txtIDM;
        private System.Windows.Forms.DataGridView dgvCitita;
        private System.Windows.Forms.BindingSource reporteMedicoBindingSource;
        private Reports.DataSet1 dataSet1;
        private Reports.DataSet1TableAdapters.ReporteMedicoTableAdapter reporteMedicoTableAdapter;
    }
}