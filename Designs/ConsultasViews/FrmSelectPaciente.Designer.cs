
namespace HealtyALTF4.Designs.ConsultasViews
{
    partial class FrmSelectPaciente
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
            this.dgvSelect = new System.Windows.Forms.DataGridView();
            this.btnSelect = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelect)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSelect
            // 
            this.dgvSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSelect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSelect.Location = new System.Drawing.Point(12, 44);
            this.dgvSelect.Name = "dgvSelect";
            this.dgvSelect.RowHeadersWidth = 62;
            this.dgvSelect.RowTemplate.Height = 28;
            this.dgvSelect.Size = new System.Drawing.Size(1158, 594);
            this.dgvSelect.TabIndex = 0;
            // 
            // btnSelect
            // 
            this.btnSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelect.Location = new System.Drawing.Point(970, 647);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(200, 35);
            this.btnSelect.TabIndex = 1;
            this.btnSelect.Text = "Seleccionar";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(13, 12);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(1157, 26);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // FrmSelectPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 694);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.dgvSelect);
            this.Name = "FrmSelectPaciente";
            this.Text = "Seleccionar paciente";
            this.Load += new System.EventHandler(this.FrmSelectPaciente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelect)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSelect;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.TextBox txtSearch;
    }
}