
namespace WindowsFormsApp4
{
    partial class FrmPersonnel
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstPersonnel = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.grpGstPersonnel = new System.Windows.Forms.GroupBox();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtNOm = new System.Windows.Forms.TextBox();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.btnAbs = new System.Windows.Forms.Button();
            this.grpGstPersonnel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstPersonnel
            // 
            this.lstPersonnel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lstPersonnel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstPersonnel.FormattingEnabled = true;
            this.lstPersonnel.Location = new System.Drawing.Point(12, 42);
            this.lstPersonnel.Name = "lstPersonnel";
            this.lstPersonnel.Size = new System.Drawing.Size(438, 197);
            this.lstPersonnel.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(119, 23);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(225, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "Liste du Personnel";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // grpGstPersonnel
            // 
            this.grpGstPersonnel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.grpGstPersonnel.Controls.Add(this.btnAbs);
            this.grpGstPersonnel.Controls.Add(this.btnSupprimer);
            this.grpGstPersonnel.Controls.Add(this.btnModifier);
            this.grpGstPersonnel.Controls.Add(this.btnAjouter);
            this.grpGstPersonnel.Controls.Add(this.txtMail);
            this.grpGstPersonnel.Controls.Add(this.txtTel);
            this.grpGstPersonnel.Controls.Add(this.txtPrenom);
            this.grpGstPersonnel.Controls.Add(this.txtNOm);
            this.grpGstPersonnel.Controls.Add(this.lblPrenom);
            this.grpGstPersonnel.Controls.Add(this.label3);
            this.grpGstPersonnel.Controls.Add(this.label2);
            this.grpGstPersonnel.Controls.Add(this.lblNom);
            this.grpGstPersonnel.Controls.Add(this.textBox3);
            this.grpGstPersonnel.Location = new System.Drawing.Point(19, 298);
            this.grpGstPersonnel.Name = "grpGstPersonnel";
            this.grpGstPersonnel.Size = new System.Drawing.Size(431, 245);
            this.grpGstPersonnel.TabIndex = 5;
            this.grpGstPersonnel.TabStop = false;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnSupprimer.Enabled = false;
            this.btnSupprimer.Location = new System.Drawing.Point(270, 162);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(108, 29);
            this.btnSupprimer.TabIndex = 12;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = false;
            // 
            // btnModifier
            // 
            this.btnModifier.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnModifier.Enabled = false;
            this.btnModifier.Location = new System.Drawing.Point(270, 119);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(108, 29);
            this.btnModifier.TabIndex = 11;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = false;
            // 
            // btnAjouter
            // 
            this.btnAjouter.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnAjouter.Enabled = false;
            this.btnAjouter.Location = new System.Drawing.Point(270, 78);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(108, 28);
            this.btnAjouter.TabIndex = 10;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = false;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(75, 209);
            this.txtMail.Multiline = true;
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(145, 20);
            this.txtMail.TabIndex = 9;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(75, 163);
            this.txtTel.Multiline = true;
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(145, 20);
            this.txtTel.TabIndex = 8;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(75, 120);
            this.txtPrenom.Multiline = true;
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(145, 20);
            this.txtPrenom.TabIndex = 7;
            // 
            // txtNOm
            // 
            this.txtNOm.Location = new System.Drawing.Point(75, 75);
            this.txtNOm.Multiline = true;
            this.txtNOm.Name = "txtNOm";
            this.txtNOm.Size = new System.Drawing.Size(145, 20);
            this.txtNOm.TabIndex = 6;
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(11, 127);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(43, 13);
            this.lblPrenom.TabIndex = 5;
            this.lblPrenom.Text = "Prenom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mail";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "N° Tel";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(11, 78);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(29, 13);
            this.lblNom.TabIndex = 2;
            this.lblNom.Text = "Nom";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBox3.Location = new System.Drawing.Point(14, 35);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(206, 20);
            this.textBox3.TabIndex = 1;
            this.textBox3.Text = "Données personnelles";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBox7.Location = new System.Drawing.Point(119, 280);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(225, 22);
            this.textBox7.TabIndex = 6;
            this.textBox7.Text = "Gestion du personnel";
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAbs
            // 
            this.btnAbs.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnAbs.Location = new System.Drawing.Point(270, 206);
            this.btnAbs.Name = "btnAbs";
            this.btnAbs.Size = new System.Drawing.Size(109, 24);
            this.btnAbs.TabIndex = 13;
            this.btnAbs.Text = "Afficher Absences";
            this.btnAbs.UseVisualStyleBackColor = false;
            // 
            // FrmPersonnel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(481, 595);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.grpGstPersonnel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lstPersonnel);
            this.Name = "FrmPersonnel";
            this.Text = "Application de gestion du personnel";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.FrmPersonnel_Load);
            this.grpGstPersonnel.ResumeLayout(false);
            this.grpGstPersonnel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstPersonnel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox grpGstPersonnel;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtNOm;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button btnAbs;
    }
}

