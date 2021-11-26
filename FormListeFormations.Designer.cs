namespace AP3_FormaFlix
{
    partial class FormListeFormations
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormListeFormations));
            this.dgvFormations = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.listeDesCompétencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFermer = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbCompetences = new System.Windows.Forms.ListBox();
            this.gbCompetences = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFormations)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.gbCompetences.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvFormations
            // 
            this.dgvFormations.AllowUserToAddRows = false;
            this.dgvFormations.AllowUserToDeleteRows = false;
            this.dgvFormations.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvFormations.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvFormations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFormations.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFormations.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFormations.Location = new System.Drawing.Point(39, 53);
            this.dgvFormations.MultiSelect = false;
            this.dgvFormations.Name = "dgvFormations";
            this.dgvFormations.ReadOnly = true;
            this.dgvFormations.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvFormations.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFormations.Size = new System.Drawing.Size(555, 150);
            this.dgvFormations.TabIndex = 0;
            this.dgvFormations.SelectionChanged += new System.EventHandler(this.DgvFormations_SelectionChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listeDesCompétencesToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(194, 26);
            // 
            // listeDesCompétencesToolStripMenuItem
            // 
            this.listeDesCompétencesToolStripMenuItem.Name = "listeDesCompétencesToolStripMenuItem";
            this.listeDesCompétencesToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.listeDesCompétencesToolStripMenuItem.Text = "Liste des compétences";
            this.listeDesCompétencesToolStripMenuItem.Click += new System.EventHandler(this.ListeDesCompétencesToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(35, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Liste des Formations";
            // 
            // btnFermer
            // 
            this.btnFermer.BackColor = System.Drawing.Color.Black;
            this.btnFermer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFermer.ForeColor = System.Drawing.Color.White;
            this.btnFermer.Location = new System.Drawing.Point(494, 209);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(100, 39);
            this.btnFermer.TabIndex = 2;
            this.btnFermer.Text = "FERMER";
            this.btnFermer.UseVisualStyleBackColor = false;
            this.btnFermer.Click += new System.EventHandler(this.BtnFermer_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(46, 279);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(507, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Faire click droit sur une formation pour lister ses compétences";
            // 
            // lbCompetences
            // 
            this.lbCompetences.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCompetences.FormattingEnabled = true;
            this.lbCompetences.ItemHeight = 16;
            this.lbCompetences.Location = new System.Drawing.Point(16, 19);
            this.lbCompetences.Name = "lbCompetences";
            this.lbCompetences.Size = new System.Drawing.Size(163, 100);
            this.lbCompetences.TabIndex = 5;
            // 
            // gbCompetences
            // 
            this.gbCompetences.BackColor = System.Drawing.Color.Transparent;
            this.gbCompetences.Controls.Add(this.lbCompetences);
            this.gbCompetences.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCompetences.ForeColor = System.Drawing.Color.Red;
            this.gbCompetences.Location = new System.Drawing.Point(639, 53);
            this.gbCompetences.Name = "gbCompetences";
            this.gbCompetences.Size = new System.Drawing.Size(200, 150);
            this.gbCompetences.TabIndex = 7;
            this.gbCompetences.TabStop = false;
            this.gbCompetences.Text = "Liste des compétences";
            this.gbCompetences.Visible = false;
            // 
            // FormListeFormations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(880, 311);
            this.ControlBox = false;
            this.Controls.Add(this.gbCompetences);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvFormations);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormListeFormations";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FORMA\'FLIX : Liste des Formations";
            this.Load += new System.EventHandler(this.FormListeFormations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFormations)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.gbCompetences.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFormations;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem listeDesCompétencesToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbCompetences;
        private System.Windows.Forms.GroupBox gbCompetences;
    }
}