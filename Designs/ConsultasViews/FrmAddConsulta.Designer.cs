
namespace HealtyALTF4.Designs.ConsultasViews
{
    partial class FrmAddConsulta
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
            this.txtPacienteNombre = new System.Windows.Forms.TextBox();
            this.txtNoPaciente = new System.Windows.Forms.TextBox();
            this.btnAddPaciente = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAddMedico = new System.Windows.Forms.Button();
            this.txtNoMedico = new System.Windows.Forms.TextBox();
            this.txtMedicoNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtFechaConsulta = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPacienteNombre
            // 
            this.txtPacienteNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPacienteNombre.Location = new System.Drawing.Point(146, 143);
            this.txtPacienteNombre.Name = "txtPacienteNombre";
            this.txtPacienteNombre.ReadOnly = true;
            this.txtPacienteNombre.Size = new System.Drawing.Size(515, 26);
            this.txtPacienteNombre.TabIndex = 0;
            // 
            // txtNoPaciente
            // 
            this.txtNoPaciente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNoPaciente.Location = new System.Drawing.Point(460, 37);
            this.txtNoPaciente.Name = "txtNoPaciente";
            this.txtNoPaciente.ReadOnly = true;
            this.txtNoPaciente.Size = new System.Drawing.Size(201, 26);
            this.txtNoPaciente.TabIndex = 1;
            // 
            // btnAddPaciente
            // 
            this.btnAddPaciente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddPaciente.Location = new System.Drawing.Point(684, 86);
            this.btnAddPaciente.Name = "btnAddPaciente";
            this.btnAddPaciente.Size = new System.Drawing.Size(175, 34);
            this.btnAddPaciente.TabIndex = 2;
            this.btnAddPaciente.Text = "Agregar paciente";
            this.btnAddPaciente.UseVisualStyleBackColor = true;
            this.btnAddPaciente.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "N° Paciente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre completo";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtNoPaciente);
            this.groupBox1.Controls.Add(this.txtPacienteNombre);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnAddPaciente);
            this.groupBox1.Location = new System.Drawing.Point(6, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(865, 233);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del paciente";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnAddMedico);
            this.groupBox2.Controls.Add(this.txtNoMedico);
            this.groupBox2.Controls.Add(this.txtMedicoNombre);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(6, 264);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(865, 207);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos del médico";
            // 
            // btnAddMedico
            // 
            this.btnAddMedico.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddMedico.Location = new System.Drawing.Point(684, 76);
            this.btnAddMedico.Name = "btnAddMedico";
            this.btnAddMedico.Size = new System.Drawing.Size(175, 34);
            this.btnAddMedico.TabIndex = 9;
            this.btnAddMedico.Text = "Agregar médico";
            this.btnAddMedico.UseVisualStyleBackColor = true;
            this.btnAddMedico.Click += new System.EventHandler(this.btnAddMedico_Click);
            // 
            // txtNoMedico
            // 
            this.txtNoMedico.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNoMedico.Location = new System.Drawing.Point(460, 32);
            this.txtNoMedico.Name = "txtNoMedico";
            this.txtNoMedico.ReadOnly = true;
            this.txtNoMedico.Size = new System.Drawing.Size(201, 26);
            this.txtNoMedico.TabIndex = 6;
            // 
            // txtMedicoNombre
            // 
            this.txtMedicoNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMedicoNombre.Location = new System.Drawing.Point(146, 127);
            this.txtMedicoNombre.Name = "txtMedicoNombre";
            this.txtMedicoNombre.ReadOnly = true;
            this.txtMedicoNombre.Size = new System.Drawing.Size(515, 26);
            this.txtMedicoNombre.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nombre completo";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "N° Médico";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.btnNext);
            this.flowLayoutPanel1.Controls.Add(this.btnBack);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(16, 597);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(877, 62);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.Location = new System.Drawing.Point(724, 3);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(150, 35);
            this.btnNext.TabIndex = 0;
            this.btnNext.Text = "Siguiente";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.Location = new System.Drawing.Point(568, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(150, 35);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Atrás";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.dtFechaConsulta);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Location = new System.Drawing.Point(16, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(877, 554);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos de la consulta";
            // 
            // dtFechaConsulta
            // 
            this.dtFechaConsulta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtFechaConsulta.Location = new System.Drawing.Point(158, 490);
            this.dtFechaConsulta.Name = "dtFechaConsulta";
            this.dtFechaConsulta.Size = new System.Drawing.Size(319, 26);
            this.dtFechaConsulta.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 495);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Fecha de consulta";
            // 
            // FrmAddConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 671);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "FrmAddConsulta";
            this.Text = "Agregar consulta";
            this.Load += new System.EventHandler(this.FrmAddConsulta_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAddPaciente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAddMedico;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dtFechaConsulta;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtNoPaciente;
        public System.Windows.Forms.TextBox txtPacienteNombre;
        public System.Windows.Forms.TextBox txtNoMedico;
        public System.Windows.Forms.TextBox txtMedicoNombre;
    }
}