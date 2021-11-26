namespace AP3_FormaFlix
{
    partial class FormAjoutFormation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAjoutFormation));
            this.btnFermer = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbLibelle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbVideo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbVisible = new System.Windows.Forms.CheckBox();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.gbCompetences = new System.Windows.Forms.GroupBox();
            this.boutonRetirer = new System.Windows.Forms.Button();
            this.lbCompetences = new System.Windows.Forms.ListBox();
            this.cbCompetences = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbImage = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DTPVisibilite = new System.Windows.Forms.DateTimePicker();
            this.gbFormation = new System.Windows.Forms.GroupBox();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.cbFormationModif = new System.Windows.Forms.ComboBox();
            this.BtnModifier3 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.gbCompetences.SuspendLayout();
            this.gbFormation.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFermer
            // 
            this.btnFermer.BackColor = System.Drawing.Color.Black;
            this.btnFermer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFermer.ForeColor = System.Drawing.Color.White;
            this.btnFermer.Location = new System.Drawing.Point(312, 358);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(86, 41);
            this.btnFermer.TabIndex = 0;
            this.btnFermer.Text = "FERMER";
            this.btnFermer.UseVisualStyleBackColor = false;
            this.btnFermer.Click += new System.EventHandler(this.BtnFermer_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.BackColor = System.Drawing.Color.Black;
            this.btnAjouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.ForeColor = System.Drawing.Color.White;
            this.btnAjouter.Location = new System.Drawing.Point(64, 358);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(105, 41);
            this.btnAjouter.TabIndex = 1;
            this.btnAjouter.Text = "AJOUTER";
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Click += new System.EventHandler(this.BtnAjouter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Libellé de la formation";
            // 
            // tbLibelle
            // 
            this.tbLibelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLibelle.Location = new System.Drawing.Point(215, 40);
            this.tbLibelle.Name = "tbLibelle";
            this.tbLibelle.Size = new System.Drawing.Size(183, 22);
            this.tbLibelle.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Description de la formation";
            // 
            // tbDescription
            // 
            this.tbDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDescription.Location = new System.Drawing.Point(215, 84);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(183, 81);
            this.tbDescription.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Identifiant Video";
            // 
            // tbVideo
            // 
            this.tbVideo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbVideo.Location = new System.Drawing.Point(215, 184);
            this.tbVideo.Multiline = true;
            this.tbVideo.Name = "tbVideo";
            this.tbVideo.Size = new System.Drawing.Size(183, 28);
            this.tbVideo.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 318);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Visibilité Public";
            // 
            // cbVisible
            // 
            this.cbVisible.AutoSize = true;
            this.cbVisible.Location = new System.Drawing.Point(144, 318);
            this.cbVisible.Name = "cbVisible";
            this.cbVisible.Size = new System.Drawing.Size(45, 17);
            this.cbVisible.TabIndex = 9;
            this.cbVisible.Text = "OUI";
            this.cbVisible.UseVisualStyleBackColor = true;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.BackColor = System.Drawing.Color.Black;
            this.btnAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnuler.ForeColor = System.Drawing.Color.White;
            this.btnAnnuler.Location = new System.Drawing.Point(186, 358);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(108, 41);
            this.btnAnnuler.TabIndex = 10;
            this.btnAnnuler.Text = "ANNULER";
            this.btnAnnuler.UseVisualStyleBackColor = false;
            this.btnAnnuler.Click += new System.EventHandler(this.BtnAnnuler_Click);
            // 
            // gbCompetences
            // 
            this.gbCompetences.BackColor = System.Drawing.Color.White;
            this.gbCompetences.Controls.Add(this.boutonRetirer);
            this.gbCompetences.Controls.Add(this.lbCompetences);
            this.gbCompetences.Controls.Add(this.cbCompetences);
            this.gbCompetences.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCompetences.Location = new System.Drawing.Point(425, 29);
            this.gbCompetences.Name = "gbCompetences";
            this.gbCompetences.Size = new System.Drawing.Size(370, 183);
            this.gbCompetences.TabIndex = 11;
            this.gbCompetences.TabStop = false;
            this.gbCompetences.Text = "Ajout des compétences";
            // 
            // boutonRetirer
            // 
            this.boutonRetirer.Location = new System.Drawing.Point(160, 154);
            this.boutonRetirer.Margin = new System.Windows.Forms.Padding(2);
            this.boutonRetirer.Name = "boutonRetirer";
            this.boutonRetirer.Size = new System.Drawing.Size(190, 24);
            this.boutonRetirer.TabIndex = 2;
            this.boutonRetirer.Text = "RETIRER LA COMPETENCE ";
            this.boutonRetirer.UseVisualStyleBackColor = true;
            this.boutonRetirer.Click += new System.EventHandler(this.boutonRetirer_Click);
            // 
            // lbCompetences
            // 
            this.lbCompetences.FormattingEnabled = true;
            this.lbCompetences.ItemHeight = 16;
            this.lbCompetences.Location = new System.Drawing.Point(7, 73);
            this.lbCompetences.Name = "lbCompetences";
            this.lbCompetences.Size = new System.Drawing.Size(345, 68);
            this.lbCompetences.TabIndex = 1;
            // 
            // cbCompetences
            // 
            this.cbCompetences.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCompetences.FormattingEnabled = true;
            this.cbCompetences.Location = new System.Drawing.Point(6, 31);
            this.cbCompetences.Name = "cbCompetences";
            this.cbCompetences.Size = new System.Drawing.Size(346, 24);
            this.cbCompetences.TabIndex = 0;
            this.cbCompetences.SelectedIndexChanged += new System.EventHandler(this.CbCompetences_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(40, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Image";
            // 
            // tbImage
            // 
            this.tbImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbImage.Location = new System.Drawing.Point(215, 224);
            this.tbImage.Multiline = true;
            this.tbImage.Name = "tbImage";
            this.tbImage.Size = new System.Drawing.Size(183, 81);
            this.tbImage.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(212, 317);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Date Visibilité : ";
            // 
            // DTPVisibilite
            // 
            this.DTPVisibilite.Location = new System.Drawing.Point(312, 315);
            this.DTPVisibilite.Name = "DTPVisibilite";
            this.DTPVisibilite.Size = new System.Drawing.Size(86, 20);
            this.DTPVisibilite.TabIndex = 15;
            // 
            // gbFormation
            // 
            this.gbFormation.BackColor = System.Drawing.Color.White;
            this.gbFormation.Controls.Add(this.btnSupprimer);
            this.gbFormation.Controls.Add(this.cbFormationModif);
            this.gbFormation.Controls.Add(this.BtnModifier3);
            this.gbFormation.Controls.Add(this.label7);
            this.gbFormation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.gbFormation.ForeColor = System.Drawing.Color.Black;
            this.gbFormation.Location = new System.Drawing.Point(425, 236);
            this.gbFormation.Name = "gbFormation";
            this.gbFormation.Size = new System.Drawing.Size(370, 154);
            this.gbFormation.TabIndex = 18;
            this.gbFormation.TabStop = false;
            this.gbFormation.Text = "Liste des formations";
            this.gbFormation.Visible = false;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(248, 122);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(104, 23);
            this.btnSupprimer.TabIndex = 20;
            this.btnSupprimer.Text = "SUPPRIMER";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.BtnSupprimer_Click);
            // 
            // cbFormationModif
            // 
            this.cbFormationModif.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFormationModif.FormattingEnabled = true;
            this.cbFormationModif.Location = new System.Drawing.Point(9, 73);
            this.cbFormationModif.Name = "cbFormationModif";
            this.cbFormationModif.Size = new System.Drawing.Size(343, 24);
            this.cbFormationModif.TabIndex = 3;
            this.cbFormationModif.SelectedIndexChanged += new System.EventHandler(this.CbFormationModif_SelectedIndexChanged);
            // 
            // BtnModifier3
            // 
            this.BtnModifier3.Location = new System.Drawing.Point(9, 122);
            this.BtnModifier3.Name = "BtnModifier3";
            this.BtnModifier3.Size = new System.Drawing.Size(94, 23);
            this.BtnModifier3.TabIndex = 2;
            this.BtnModifier3.Text = "MODIFIER";
            this.BtnModifier3.UseVisualStyleBackColor = true;
            this.BtnModifier3.Click += new System.EventHandler(this.BtnModifier3_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(172, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "Sélectionner une formation :";
            // 
            // FormAjoutFormation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::AP3_FormaFlix.Properties.Resources.home;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(807, 402);
            this.ControlBox = false;
            this.Controls.Add(this.gbFormation);
            this.Controls.Add(this.DTPVisibilite);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbImage);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.gbCompetences);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.cbVisible);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbVideo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbLibelle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.btnFermer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAjoutFormation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FORMA\'FLIX : Ajout d\'une formation";
            this.Load += new System.EventHandler(this.FormAjoutFormation_Load);
            this.gbCompetences.ResumeLayout(false);
            this.gbFormation.ResumeLayout(false);
            this.gbFormation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbLibelle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbVideo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cbVisible;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.GroupBox gbCompetences;
        private System.Windows.Forms.ListBox lbCompetences;
        private System.Windows.Forms.ComboBox cbCompetences;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbImage;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker DTPVisibilite;
        private System.Windows.Forms.GroupBox gbFormation;
        private System.Windows.Forms.ComboBox cbFormationModif;
        private System.Windows.Forms.Button BtnModifier3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button boutonRetirer;
    }
}