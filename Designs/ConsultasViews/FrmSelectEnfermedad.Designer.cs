
namespace HealtyALTF4.Designs.ConsultasViews
{
    partial class FrmSelectEnfermedad
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
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.dgvSelect = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelect)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(11, 12);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(1158, 26);
            this.txtSearch.TabIndex = 8;
            // 
            // btnSelect
            // 
            this.btnSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelect.Location = new System.Drawing.Point(969, 647);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(200, 35);
            this.btnSelect.TabIndex = 7;
            this.btnSelect.Text = "Seleccionar";
            this.btnSelect.UseVisualStyleBackColor = true;
            // 
            // dgvSelect
            // 
            this.dgvSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSelect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSelect.Location = new System.Drawing.Point(10, 44);
            this.dgvSelect.Name = "dgvSelect";
            this.dgvSelect.RowHeadersWidth = 62;
            this.dgvSelect.RowTemplate.Height = 28;
            this.dgvSelect.Size = new System.Drawing.Size(1159, 597);
            this.dgvSelect.TabIndex = 6;
            this.dgvSelect.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSelect_CellContentClick);
            // 
            // FrmSelectEnfermedad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 694);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.dgvSelect);
            this.Name = "FrmSelectEnfermedad";
            this.Text = "FrmSelectEnfermedad";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelect)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.DataGridView dgvSelect;
    }
}