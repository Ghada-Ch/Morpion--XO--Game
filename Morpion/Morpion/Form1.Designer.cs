namespace Morpion
{
    partial class Morpion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Morpion));
            this.lblJoueur = new System.Windows.Forms.Label();
            this.cmdGo = new System.Windows.Forms.Button();
            this.txtJeu1 = new System.Windows.Forms.Label();
            this.txtJeu9 = new System.Windows.Forms.Label();
            this.txtJeu8 = new System.Windows.Forms.Label();
            this.txtJeu7 = new System.Windows.Forms.Label();
            this.txtJeu6 = new System.Windows.Forms.Label();
            this.txtJeu5 = new System.Windows.Forms.Label();
            this.txtJeu3 = new System.Windows.Forms.Label();
            this.txtJeu4 = new System.Windows.Forms.Label();
            this.txtJeu2 = new System.Windows.Forms.Label();
            this.cmdJeu1 = new System.Windows.Forms.Button();
            this.cmdJeu8 = new System.Windows.Forms.Button();
            this.cmdJeu3 = new System.Windows.Forms.Button();
            this.cmdJeu4 = new System.Windows.Forms.Button();
            this.cmdJeu5 = new System.Windows.Forms.Button();
            this.cmdJeu2 = new System.Windows.Forms.Button();
            this.cmdJeu7 = new System.Windows.Forms.Button();
            this.cmdJeu6 = new System.Windows.Forms.Button();
            this.cmdJeu9 = new System.Windows.Forms.Button();
            this.lblFin = new System.Windows.Forms.Label();
            this.lblJoueurAct = new System.Windows.Forms.Label();
            this.grbox = new System.Windows.Forms.GroupBox();
            this.btReplay = new System.Windows.Forms.Button();
            this.btQuitter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblJoueur
            // 
            this.lblJoueur.AutoSize = true;
            this.lblJoueur.BackColor = System.Drawing.Color.Transparent;
            this.lblJoueur.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJoueur.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblJoueur.Location = new System.Drawing.Point(7, 27);
            this.lblJoueur.Name = "lblJoueur";
            this.lblJoueur.Size = new System.Drawing.Size(93, 24);
            this.lblJoueur.TabIndex = 0;
            this.lblJoueur.Text = "Joueur : ";
            // 
            // cmdGo
            // 
            this.cmdGo.BackColor = System.Drawing.Color.White;
            this.cmdGo.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.cmdGo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGo.ForeColor = System.Drawing.Color.Red;
            this.cmdGo.Location = new System.Drawing.Point(244, 27);
            this.cmdGo.Name = "cmdGo";
            this.cmdGo.Size = new System.Drawing.Size(75, 33);
            this.cmdGo.TabIndex = 1;
            this.cmdGo.Text = "GO";
            this.cmdGo.UseVisualStyleBackColor = false;
            this.cmdGo.Click += new System.EventHandler(this.cmdGo_Click);
            // 
            // txtJeu1
            // 
            this.txtJeu1.AutoSize = true;
            this.txtJeu1.BackColor = System.Drawing.Color.Transparent;
            this.txtJeu1.Font = new System.Drawing.Font("Cooper Black", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJeu1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtJeu1.Location = new System.Drawing.Point(81, 100);
            this.txtJeu1.Name = "txtJeu1";
            this.txtJeu1.Size = new System.Drawing.Size(26, 36);
            this.txtJeu1.TabIndex = 2;
            this.txtJeu1.Text = "l";
            // 
            // txtJeu9
            // 
            this.txtJeu9.AutoSize = true;
            this.txtJeu9.BackColor = System.Drawing.Color.Transparent;
            this.txtJeu9.Font = new System.Drawing.Font("Cooper Black", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJeu9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtJeu9.Location = new System.Drawing.Point(229, 257);
            this.txtJeu9.Name = "txtJeu9";
            this.txtJeu9.Size = new System.Drawing.Size(26, 36);
            this.txtJeu9.TabIndex = 4;
            this.txtJeu9.Text = "l";
            // 
            // txtJeu8
            // 
            this.txtJeu8.AutoSize = true;
            this.txtJeu8.BackColor = System.Drawing.Color.Transparent;
            this.txtJeu8.Font = new System.Drawing.Font("Cooper Black", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJeu8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtJeu8.Location = new System.Drawing.Point(155, 257);
            this.txtJeu8.Name = "txtJeu8";
            this.txtJeu8.Size = new System.Drawing.Size(26, 36);
            this.txtJeu8.TabIndex = 5;
            this.txtJeu8.Text = "l";
            // 
            // txtJeu7
            // 
            this.txtJeu7.AutoSize = true;
            this.txtJeu7.BackColor = System.Drawing.Color.Transparent;
            this.txtJeu7.Font = new System.Drawing.Font("Cooper Black", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJeu7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtJeu7.Location = new System.Drawing.Point(81, 257);
            this.txtJeu7.Name = "txtJeu7";
            this.txtJeu7.Size = new System.Drawing.Size(26, 36);
            this.txtJeu7.TabIndex = 6;
            this.txtJeu7.Text = "l";
            // 
            // txtJeu6
            // 
            this.txtJeu6.AutoSize = true;
            this.txtJeu6.BackColor = System.Drawing.Color.Transparent;
            this.txtJeu6.Font = new System.Drawing.Font("Cooper Black", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJeu6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtJeu6.Location = new System.Drawing.Point(229, 180);
            this.txtJeu6.Name = "txtJeu6";
            this.txtJeu6.Size = new System.Drawing.Size(26, 36);
            this.txtJeu6.TabIndex = 7;
            this.txtJeu6.Text = "l";
            // 
            // txtJeu5
            // 
            this.txtJeu5.AutoSize = true;
            this.txtJeu5.BackColor = System.Drawing.Color.Transparent;
            this.txtJeu5.Font = new System.Drawing.Font("Cooper Black", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJeu5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtJeu5.Location = new System.Drawing.Point(155, 180);
            this.txtJeu5.Name = "txtJeu5";
            this.txtJeu5.Size = new System.Drawing.Size(26, 36);
            this.txtJeu5.TabIndex = 8;
            this.txtJeu5.Text = "l";
            // 
            // txtJeu3
            // 
            this.txtJeu3.AutoSize = true;
            this.txtJeu3.BackColor = System.Drawing.Color.Transparent;
            this.txtJeu3.Font = new System.Drawing.Font("Cooper Black", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJeu3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtJeu3.Location = new System.Drawing.Point(227, 100);
            this.txtJeu3.Name = "txtJeu3";
            this.txtJeu3.Size = new System.Drawing.Size(26, 36);
            this.txtJeu3.TabIndex = 9;
            this.txtJeu3.Text = "l";
            // 
            // txtJeu4
            // 
            this.txtJeu4.AutoSize = true;
            this.txtJeu4.BackColor = System.Drawing.Color.Transparent;
            this.txtJeu4.Font = new System.Drawing.Font("Cooper Black", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJeu4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtJeu4.Location = new System.Drawing.Point(81, 180);
            this.txtJeu4.Name = "txtJeu4";
            this.txtJeu4.Size = new System.Drawing.Size(26, 36);
            this.txtJeu4.TabIndex = 10;
            this.txtJeu4.Text = "l";
            // 
            // txtJeu2
            // 
            this.txtJeu2.AutoSize = true;
            this.txtJeu2.BackColor = System.Drawing.Color.Transparent;
            this.txtJeu2.Font = new System.Drawing.Font("Cooper Black", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJeu2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtJeu2.Location = new System.Drawing.Point(155, 99);
            this.txtJeu2.Name = "txtJeu2";
            this.txtJeu2.Size = new System.Drawing.Size(26, 36);
            this.txtJeu2.TabIndex = 11;
            this.txtJeu2.Text = "l";
            // 
            // cmdJeu1
            // 
            this.cmdJeu1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.cmdJeu1.Location = new System.Drawing.Point(70, 92);
            this.cmdJeu1.Name = "cmdJeu1";
            this.cmdJeu1.Size = new System.Drawing.Size(60, 56);
            this.cmdJeu1.TabIndex = 12;
            this.cmdJeu1.UseVisualStyleBackColor = false;
            this.cmdJeu1.Click += new System.EventHandler(this.cmdJeu1_Click_1);
            // 
            // cmdJeu8
            // 
            this.cmdJeu8.BackColor = System.Drawing.SystemColors.ControlDark;
            this.cmdJeu8.Location = new System.Drawing.Point(138, 245);
            this.cmdJeu8.Name = "cmdJeu8";
            this.cmdJeu8.Size = new System.Drawing.Size(60, 56);
            this.cmdJeu8.TabIndex = 13;
            this.cmdJeu8.UseVisualStyleBackColor = false;
            this.cmdJeu8.Click += new System.EventHandler(this.cmdJeu8_Click);
            // 
            // cmdJeu3
            // 
            this.cmdJeu3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.cmdJeu3.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.cmdJeu3.Location = new System.Drawing.Point(207, 91);
            this.cmdJeu3.Name = "cmdJeu3";
            this.cmdJeu3.Size = new System.Drawing.Size(60, 56);
            this.cmdJeu3.TabIndex = 14;
            this.cmdJeu3.UseVisualStyleBackColor = false;
            this.cmdJeu3.Click += new System.EventHandler(this.cmdJeu3_Click);
            // 
            // cmdJeu4
            // 
            this.cmdJeu4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.cmdJeu4.Location = new System.Drawing.Point(71, 170);
            this.cmdJeu4.Name = "cmdJeu4";
            this.cmdJeu4.Size = new System.Drawing.Size(60, 56);
            this.cmdJeu4.TabIndex = 15;
            this.cmdJeu4.UseVisualStyleBackColor = false;
            this.cmdJeu4.Click += new System.EventHandler(this.cmdJeu4_Click);
            // 
            // cmdJeu5
            // 
            this.cmdJeu5.BackColor = System.Drawing.SystemColors.ControlDark;
            this.cmdJeu5.Location = new System.Drawing.Point(139, 170);
            this.cmdJeu5.Name = "cmdJeu5";
            this.cmdJeu5.Size = new System.Drawing.Size(60, 56);
            this.cmdJeu5.TabIndex = 16;
            this.cmdJeu5.UseVisualStyleBackColor = false;
            this.cmdJeu5.Click += new System.EventHandler(this.cmdJeu5_Click);
            // 
            // cmdJeu2
            // 
            this.cmdJeu2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.cmdJeu2.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.cmdJeu2.FlatAppearance.BorderSize = 0;
            this.cmdJeu2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.cmdJeu2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.cmdJeu2.Location = new System.Drawing.Point(139, 90);
            this.cmdJeu2.Name = "cmdJeu2";
            this.cmdJeu2.Size = new System.Drawing.Size(60, 56);
            this.cmdJeu2.TabIndex = 17;
            this.cmdJeu2.UseVisualStyleBackColor = false;
            this.cmdJeu2.Click += new System.EventHandler(this.cmdJeu2_Click);
            // 
            // cmdJeu7
            // 
            this.cmdJeu7.BackColor = System.Drawing.SystemColors.ControlDark;
            this.cmdJeu7.Location = new System.Drawing.Point(71, 245);
            this.cmdJeu7.Name = "cmdJeu7";
            this.cmdJeu7.Size = new System.Drawing.Size(60, 56);
            this.cmdJeu7.TabIndex = 18;
            this.cmdJeu7.UseVisualStyleBackColor = false;
            this.cmdJeu7.Click += new System.EventHandler(this.cmdJeu7_Click);
            // 
            // cmdJeu6
            // 
            this.cmdJeu6.BackColor = System.Drawing.SystemColors.ControlDark;
            this.cmdJeu6.Location = new System.Drawing.Point(207, 170);
            this.cmdJeu6.Name = "cmdJeu6";
            this.cmdJeu6.Size = new System.Drawing.Size(60, 56);
            this.cmdJeu6.TabIndex = 19;
            this.cmdJeu6.UseVisualStyleBackColor = false;
            this.cmdJeu6.Click += new System.EventHandler(this.cmdJeu6_Click);
            // 
            // cmdJeu9
            // 
            this.cmdJeu9.BackColor = System.Drawing.SystemColors.ControlDark;
            this.cmdJeu9.Location = new System.Drawing.Point(208, 245);
            this.cmdJeu9.Name = "cmdJeu9";
            this.cmdJeu9.Size = new System.Drawing.Size(60, 56);
            this.cmdJeu9.TabIndex = 20;
            this.cmdJeu9.UseVisualStyleBackColor = false;
            this.cmdJeu9.Click += new System.EventHandler(this.cmdJeu9_Click);
            // 
            // lblFin
            // 
            this.lblFin.AutoSize = true;
            this.lblFin.BackColor = System.Drawing.Color.Transparent;
            this.lblFin.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblFin.Location = new System.Drawing.Point(106, 344);
            this.lblFin.Name = "lblFin";
            this.lblFin.Size = new System.Drawing.Size(113, 22);
            this.lblFin.TabIndex = 21;
            this.lblFin.Text = "Fin Game";
            // 
            // lblJoueurAct
            // 
            this.lblJoueurAct.AutoSize = true;
            this.lblJoueurAct.BackColor = System.Drawing.Color.Transparent;
            this.lblJoueurAct.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJoueurAct.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblJoueurAct.Location = new System.Drawing.Point(106, 30);
            this.lblJoueurAct.Name = "lblJoueurAct";
            this.lblJoueurAct.Size = new System.Drawing.Size(0, 24);
            this.lblJoueurAct.TabIndex = 22;
            // 
            // grbox
            // 
            this.grbox.BackColor = System.Drawing.Color.Transparent;
            this.grbox.Location = new System.Drawing.Point(7, 4);
            this.grbox.Name = "grbox";
            this.grbox.Size = new System.Drawing.Size(334, 71);
            this.grbox.TabIndex = 23;
            this.grbox.TabStop = false;
            // 
            // btReplay
            // 
            this.btReplay.BackColor = System.Drawing.Color.White;
            this.btReplay.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btReplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btReplay.ForeColor = System.Drawing.Color.Black;
            this.btReplay.Location = new System.Drawing.Point(45, 417);
            this.btReplay.Name = "btReplay";
            this.btReplay.Size = new System.Drawing.Size(75, 33);
            this.btReplay.TabIndex = 24;
            this.btReplay.Text = "Replay";
            this.btReplay.UseVisualStyleBackColor = false;
            this.btReplay.Click += new System.EventHandler(this.btReplay_Click);
            // 
            // btQuitter
            // 
            this.btQuitter.BackColor = System.Drawing.Color.White;
            this.btQuitter.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btQuitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btQuitter.ForeColor = System.Drawing.Color.Red;
            this.btQuitter.Location = new System.Drawing.Point(224, 417);
            this.btQuitter.Name = "btQuitter";
            this.btQuitter.Size = new System.Drawing.Size(75, 33);
            this.btQuitter.TabIndex = 25;
            this.btQuitter.Text = "Quitter";
            this.btQuitter.UseVisualStyleBackColor = false;
            this.btQuitter.Click += new System.EventHandler(this.btQuitter_Click);
            // 
            // Morpion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(350, 462);
            this.Controls.Add(this.btQuitter);
            this.Controls.Add(this.btReplay);
            this.Controls.Add(this.lblJoueurAct);
            this.Controls.Add(this.lblFin);
            this.Controls.Add(this.lblJoueur);
            this.Controls.Add(this.cmdGo);
            this.Controls.Add(this.cmdJeu7);
            this.Controls.Add(this.cmdJeu2);
            this.Controls.Add(this.cmdJeu5);
            this.Controls.Add(this.cmdJeu4);
            this.Controls.Add(this.cmdJeu1);
            this.Controls.Add(this.cmdJeu9);
            this.Controls.Add(this.cmdJeu6);
            this.Controls.Add(this.cmdJeu3);
            this.Controls.Add(this.txtJeu2);
            this.Controls.Add(this.txtJeu4);
            this.Controls.Add(this.txtJeu3);
            this.Controls.Add(this.txtJeu5);
            this.Controls.Add(this.txtJeu6);
            this.Controls.Add(this.txtJeu9);
            this.Controls.Add(this.txtJeu1);
            this.Controls.Add(this.txtJeu7);
            this.Controls.Add(this.grbox);
            this.Controls.Add(this.cmdJeu8);
            this.Controls.Add(this.txtJeu8);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(-2000, -2000);
            this.Name = "Morpion";
            this.Text = "Morpion";
            this.Load += new System.EventHandler(this.Morpion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblJoueur;
        private System.Windows.Forms.Button cmdGo;
        private System.Windows.Forms.Label txtJeu1;
        private System.Windows.Forms.Label txtJeu9;
        private System.Windows.Forms.Label txtJeu8;
        private System.Windows.Forms.Label txtJeu7;
        private System.Windows.Forms.Label txtJeu6;
        private System.Windows.Forms.Label txtJeu5;
        private System.Windows.Forms.Label txtJeu3;
        private System.Windows.Forms.Label txtJeu4;
        private System.Windows.Forms.Label txtJeu2;
        private System.Windows.Forms.Button cmdJeu1;
        private System.Windows.Forms.Button cmdJeu8;
        private System.Windows.Forms.Button cmdJeu3;
        private System.Windows.Forms.Button cmdJeu4;
        private System.Windows.Forms.Button cmdJeu5;
        private System.Windows.Forms.Button cmdJeu2;
        private System.Windows.Forms.Button cmdJeu7;
        private System.Windows.Forms.Button cmdJeu6;
        private System.Windows.Forms.Button cmdJeu9;
        private System.Windows.Forms.Label lblFin;
       public  System.Windows.Forms.Label lblJoueurAct;
        private System.Windows.Forms.GroupBox grbox;
        private System.Windows.Forms.Button btReplay;
        private System.Windows.Forms.Button btQuitter;
    }
}

