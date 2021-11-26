
namespace AP3_FormaFlix
{
    partial class FormListeCommentaires
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvCommentaires = new System.Windows.Forms.DataGridView();
            this.btnFermer = new System.Windows.Forms.Button();
            this.btnRP = new System.Windows.Forms.Button();
            this.btnArchiver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCommentaires)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(10, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Liste des Commentaires";
            // 
            // dgvCommentaires
            // 
            this.dgvCommentaires.AllowUserToAddRows = false;
            this.dgvCommentaires.AllowUserToDeleteRows = false;
            this.dgvCommentaires.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvCommentaires.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvCommentaires.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCommentaires.Location = new System.Drawing.Point(14, 70);
            this.dgvCommentaires.MultiSelect = false;
            this.dgvCommentaires.Name = "dgvCommentaires";
            this.dgvCommentaires.ReadOnly = true;
            this.dgvCommentaires.RowHeadersWidth = 51;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCommentaires.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCommentaires.Size = new System.Drawing.Size(595, 167);
            this.dgvCommentaires.TabIndex = 3;
            // 
            // btnFermer
            // 
            this.btnFermer.BackColor = System.Drawing.Color.Black;
            this.btnFermer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFermer.ForeColor = System.Drawing.Color.White;
            this.btnFermer.Location = new System.Drawing.Point(526, 258);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(92, 39);
            this.btnFermer.TabIndex = 9;
            this.btnFermer.Text = "FERMER";
            this.btnFermer.UseVisualStyleBackColor = false;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // btnRP
            // 
            this.btnRP.BackColor = System.Drawing.Color.Black;
            this.btnRP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRP.ForeColor = System.Drawing.Color.White;
            this.btnRP.Location = new System.Drawing.Point(158, 258);
            this.btnRP.Name = "btnRP";
            this.btnRP.Size = new System.Drawing.Size(209, 39);
            this.btnRP.TabIndex = 10;
            this.btnRP.Text = "RENDRE PUBLIC";
            this.btnRP.UseVisualStyleBackColor = false;
            this.btnRP.Visible = false;
            this.btnRP.Click += new System.EventHandler(this.btnRP_Click);
            // 
            // btnArchiver
            // 
            this.btnArchiver.BackColor = System.Drawing.Color.Black;
            this.btnArchiver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArchiver.ForeColor = System.Drawing.Color.White;
            this.btnArchiver.Location = new System.Drawing.Point(374, 258);
            this.btnArchiver.Name = "btnArchiver";
            this.btnArchiver.Size = new System.Drawing.Size(147, 39);
            this.btnArchiver.TabIndex = 11;
            this.btnArchiver.Text = "ARCHIVER";
            this.btnArchiver.UseVisualStyleBackColor = false;
            this.btnArchiver.Click += new System.EventHandler(this.btnArchiver_Click);
            // 
            // FormListeCommentaires
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AP3_FormaFlix.Properties.Resources.home;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(653, 344);
            this.Controls.Add(this.btnArchiver);
            this.Controls.Add(this.btnRP);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.dgvCommentaires);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormListeCommentaires";
            this.Text = "FormListeCommentaires";
            this.Load += new System.EventHandler(this.FormListeCommentaires_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCommentaires)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvCommentaires;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.Button btnRP;
        private System.Windows.Forms.Button btnArchiver;
    }
}