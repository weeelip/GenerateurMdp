namespace GenerateurMdp
{
    partial class GenMdp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GenMdp));
            this.tabListe = new System.Windows.Forms.TabPage();
            this.progressGen = new System.Windows.Forms.ProgressBar();
            this.btnParcourir = new System.Windows.Forms.Button();
            this.btnGenListe = new System.Windows.Forms.Button();
            this.boxDossier = new System.Windows.Forms.GroupBox();
            this.txtSauvegarde = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nbMdp = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.nbCara = new System.Windows.Forms.NumericUpDown();
            this.specListe = new System.Windows.Forms.CheckBox();
            this.chiffresListe = new System.Windows.Forms.CheckBox();
            this.minListe = new System.Windows.Forms.CheckBox();
            this.majListe = new System.Windows.Forms.CheckBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tabGenMdp = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nb = new System.Windows.Forms.Label();
            this.NbCar = new System.Windows.Forms.NumericUpDown();
            this.CarSpe = new System.Windows.Forms.CheckBox();
            this.Chiffres = new System.Windows.Forms.CheckBox();
            this.LMaj = new System.Windows.Forms.CheckBox();
            this.LMin = new System.Windows.Forms.CheckBox();
            this.clear = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Gen = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.result = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.app = new System.Windows.Forms.Button();
            this.quit = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabListe.SuspendLayout();
            this.boxDossier.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbMdp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbCara)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabGenMdp.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NbCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabListe
            // 
            this.tabListe.Controls.Add(this.progressGen);
            this.tabListe.Controls.Add(this.btnParcourir);
            this.tabListe.Controls.Add(this.btnGenListe);
            this.tabListe.Controls.Add(this.boxDossier);
            this.tabListe.Controls.Add(this.groupBox7);
            this.tabListe.Controls.Add(this.groupBox6);
            this.tabListe.Controls.Add(this.groupBox5);
            this.tabListe.Controls.Add(this.pictureBox2);
            this.tabListe.Location = new System.Drawing.Point(4, 22);
            this.tabListe.Name = "tabListe";
            this.tabListe.Padding = new System.Windows.Forms.Padding(3);
            this.tabListe.Size = new System.Drawing.Size(972, 638);
            this.tabListe.TabIndex = 1;
            this.tabListe.Text = "Liste";
            this.tabListe.UseVisualStyleBackColor = true;
            // 
            // progressGen
            // 
            this.progressGen.Location = new System.Drawing.Point(515, 516);
            this.progressGen.Name = "progressGen";
            this.progressGen.Size = new System.Drawing.Size(270, 23);
            this.progressGen.TabIndex = 14;
            // 
            // btnParcourir
            // 
            this.btnParcourir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnParcourir.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParcourir.Location = new System.Drawing.Point(809, 386);
            this.btnParcourir.Name = "btnParcourir";
            this.btnParcourir.Size = new System.Drawing.Size(98, 31);
            this.btnParcourir.TabIndex = 13;
            this.btnParcourir.Text = "Parcourir";
            this.btnParcourir.UseVisualStyleBackColor = true;
            this.btnParcourir.Click += new System.EventHandler(this.btnParcourir_Click);
            // 
            // btnGenListe
            // 
            this.btnGenListe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenListe.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenListe.Location = new System.Drawing.Point(531, 446);
            this.btnGenListe.Name = "btnGenListe";
            this.btnGenListe.Size = new System.Drawing.Size(225, 41);
            this.btnGenListe.TabIndex = 12;
            this.btnGenListe.Text = "Généner la liste de mots de passe";
            this.btnGenListe.UseVisualStyleBackColor = true;
            this.btnGenListe.Click += new System.EventHandler(this.btnGenListe_Click);
            // 
            // boxDossier
            // 
            this.boxDossier.Controls.Add(this.txtSauvegarde);
            this.boxDossier.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxDossier.Location = new System.Drawing.Point(488, 368);
            this.boxDossier.Name = "boxDossier";
            this.boxDossier.Size = new System.Drawing.Size(315, 58);
            this.boxDossier.TabIndex = 11;
            this.boxDossier.TabStop = false;
            this.boxDossier.Text = "Dossier de sauvegarde";
            // 
            // txtSauvegarde
            // 
            this.txtSauvegarde.Location = new System.Drawing.Point(19, 23);
            this.txtSauvegarde.Name = "txtSauvegarde";
            this.txtSauvegarde.Size = new System.Drawing.Size(278, 22);
            this.txtSauvegarde.TabIndex = 14;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label4);
            this.groupBox7.Controls.Add(this.nbMdp);
            this.groupBox7.Controls.Add(this.label3);
            this.groupBox7.Controls.Add(this.nbCara);
            this.groupBox7.Controls.Add(this.specListe);
            this.groupBox7.Controls.Add(this.chiffresListe);
            this.groupBox7.Controls.Add(this.minListe);
            this.groupBox7.Controls.Add(this.majListe);
            this.groupBox7.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.Location = new System.Drawing.Point(488, 6);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(315, 338);
            this.groupBox7.TabIndex = 10;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Options";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(140, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nombre de mots de passe";
            // 
            // nbMdp
            // 
            this.nbMdp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nbMdp.Location = new System.Drawing.Point(19, 267);
            this.nbMdp.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nbMdp.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nbMdp.Name = "nbMdp";
            this.nbMdp.Size = new System.Drawing.Size(120, 22);
            this.nbMdp.TabIndex = 6;
            this.nbMdp.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(140, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nombre de caractères";
            // 
            // nbCara
            // 
            this.nbCara.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nbCara.Location = new System.Drawing.Point(19, 214);
            this.nbCara.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.nbCara.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nbCara.Name = "nbCara";
            this.nbCara.Size = new System.Drawing.Size(120, 22);
            this.nbCara.TabIndex = 4;
            this.nbCara.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // specListe
            // 
            this.specListe.AutoSize = true;
            this.specListe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.specListe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.specListe.Location = new System.Drawing.Point(19, 170);
            this.specListe.Name = "specListe";
            this.specListe.Size = new System.Drawing.Size(156, 19);
            this.specListe.TabIndex = 3;
            this.specListe.Text = "Caractères spéciaux";
            this.specListe.UseVisualStyleBackColor = true;
            // 
            // chiffresListe
            // 
            this.chiffresListe.AutoSize = true;
            this.chiffresListe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chiffresListe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chiffresListe.Location = new System.Drawing.Point(19, 125);
            this.chiffresListe.Name = "chiffresListe";
            this.chiffresListe.Size = new System.Drawing.Size(75, 19);
            this.chiffresListe.TabIndex = 2;
            this.chiffresListe.Text = "Chiffres";
            this.chiffresListe.UseVisualStyleBackColor = true;
            // 
            // minListe
            // 
            this.minListe.AutoSize = true;
            this.minListe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minListe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minListe.Location = new System.Drawing.Point(19, 37);
            this.minListe.Name = "minListe";
            this.minListe.Size = new System.Drawing.Size(147, 19);
            this.minListe.TabIndex = 1;
            this.minListe.Text = "Lettres majuscules";
            this.minListe.UseVisualStyleBackColor = true;
            // 
            // majListe
            // 
            this.majListe.AutoSize = true;
            this.majListe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.majListe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.majListe.Location = new System.Drawing.Point(19, 83);
            this.majListe.Name = "majListe";
            this.majListe.Size = new System.Drawing.Size(147, 19);
            this.majListe.TabIndex = 0;
            this.majListe.Text = "Lettres minuscules";
            this.majListe.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.button2);
            this.groupBox6.Controls.Add(this.button3);
            this.groupBox6.Location = new System.Drawing.Point(13, 554);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(956, 76);
            this.groupBox6.TabIndex = 9;
            this.groupBox6.TabStop = false;
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(677, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 41);
            this.button2.TabIndex = 6;
            this.button2.Text = "A propos";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.app_Click);
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Location = new System.Drawing.Point(832, 19);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(118, 41);
            this.button3.TabIndex = 5;
            this.button3.Text = "Quitter";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.quit_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(45, 255);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(354, 284);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Fonctionnement";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(309, 221);
            this.label2.TabIndex = 1;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::GenerateurMdp.Properties.Resources.téléchargement_removebg_preview;
            this.pictureBox2.Location = new System.Drawing.Point(81, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(241, 225);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // tabGenMdp
            // 
            this.tabGenMdp.BackColor = System.Drawing.Color.White;
            this.tabGenMdp.Controls.Add(this.button1);
            this.tabGenMdp.Controls.Add(this.groupBox1);
            this.tabGenMdp.Controls.Add(this.clear);
            this.tabGenMdp.Controls.Add(this.pictureBox1);
            this.tabGenMdp.Controls.Add(this.Gen);
            this.tabGenMdp.Controls.Add(this.groupBox4);
            this.tabGenMdp.Controls.Add(this.groupBox2);
            this.tabGenMdp.Controls.Add(this.groupBox3);
            this.tabGenMdp.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabGenMdp.ForeColor = System.Drawing.Color.Black;
            this.tabGenMdp.Location = new System.Drawing.Point(4, 22);
            this.tabGenMdp.Name = "tabGenMdp";
            this.tabGenMdp.Padding = new System.Windows.Forms.Padding(3);
            this.tabGenMdp.Size = new System.Drawing.Size(972, 638);
            this.tabGenMdp.TabIndex = 0;
            this.tabGenMdp.Text = "Unique";
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(595, 494);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 40);
            this.button1.TabIndex = 6;
            this.button1.Text = "Copier le mot de passe";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nb);
            this.groupBox1.Controls.Add(this.NbCar);
            this.groupBox1.Controls.Add(this.CarSpe);
            this.groupBox1.Controls.Add(this.Chiffres);
            this.groupBox1.Controls.Add(this.LMaj);
            this.groupBox1.Controls.Add(this.LMin);
            this.groupBox1.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(488, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(315, 291);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // nb
            // 
            this.nb.AutoSize = true;
            this.nb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nb.Location = new System.Drawing.Point(145, 242);
            this.nb.Name = "nb";
            this.nb.Size = new System.Drawing.Size(149, 15);
            this.nb.TabIndex = 5;
            this.nb.Text = "Nombre de caractères";
            // 
            // NbCar
            // 
            this.NbCar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NbCar.Location = new System.Drawing.Point(19, 241);
            this.NbCar.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.NbCar.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.NbCar.Name = "NbCar";
            this.NbCar.Size = new System.Drawing.Size(120, 22);
            this.NbCar.TabIndex = 4;
            this.NbCar.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // CarSpe
            // 
            this.CarSpe.AutoSize = true;
            this.CarSpe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CarSpe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CarSpe.Location = new System.Drawing.Point(19, 187);
            this.CarSpe.Name = "CarSpe";
            this.CarSpe.Size = new System.Drawing.Size(156, 19);
            this.CarSpe.TabIndex = 3;
            this.CarSpe.Text = "Caractères spéciaux";
            this.CarSpe.UseVisualStyleBackColor = true;
            // 
            // Chiffres
            // 
            this.Chiffres.AutoSize = true;
            this.Chiffres.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Chiffres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chiffres.Location = new System.Drawing.Point(19, 147);
            this.Chiffres.Name = "Chiffres";
            this.Chiffres.Size = new System.Drawing.Size(75, 19);
            this.Chiffres.TabIndex = 2;
            this.Chiffres.Text = "Chiffres";
            this.Chiffres.UseVisualStyleBackColor = true;
            // 
            // LMaj
            // 
            this.LMaj.AutoSize = true;
            this.LMaj.Checked = true;
            this.LMaj.CheckState = System.Windows.Forms.CheckState.Checked;
            this.LMaj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LMaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LMaj.Location = new System.Drawing.Point(19, 55);
            this.LMaj.Name = "LMaj";
            this.LMaj.Size = new System.Drawing.Size(147, 19);
            this.LMaj.TabIndex = 1;
            this.LMaj.Text = "Lettres majuscules";
            this.LMaj.UseVisualStyleBackColor = true;
            // 
            // LMin
            // 
            this.LMin.AutoSize = true;
            this.LMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LMin.Location = new System.Drawing.Point(19, 98);
            this.LMin.Name = "LMin";
            this.LMin.Size = new System.Drawing.Size(147, 19);
            this.LMin.TabIndex = 0;
            this.LMin.Text = "Lettres minuscules";
            this.LMin.UseVisualStyleBackColor = true;
            // 
            // clear
            // 
            this.clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clear.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.Location = new System.Drawing.Point(690, 323);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(97, 41);
            this.clear.TabIndex = 4;
            this.clear.Text = "Effacer";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GenerateurMdp.Properties.Resources.téléchargement_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(81, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(241, 225);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Gen
            // 
            this.Gen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Gen.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gen.Location = new System.Drawing.Point(502, 323);
            this.Gen.Name = "Gen";
            this.Gen.Size = new System.Drawing.Size(152, 41);
            this.Gen.TabIndex = 3;
            this.Gen.Text = "Générer mot de passe";
            this.Gen.UseVisualStyleBackColor = true;
            this.Gen.Click += new System.EventHandler(this.Gen_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(45, 255);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(354, 284);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Fonctionnement";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 221);
            this.label1.TabIndex = 1;
            this.label1.Text = resources.GetString("label1.Text");
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.result);
            this.groupBox2.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(488, 388);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(449, 100);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mot de passe proposé : ";
            // 
            // result
            // 
            this.result.Font = new System.Drawing.Font("Lucida Bright", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result.Location = new System.Drawing.Point(15, 30);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(408, 50);
            this.result.TabIndex = 0;
            this.result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.app);
            this.groupBox3.Controls.Add(this.quit);
            this.groupBox3.Location = new System.Drawing.Point(13, 554);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(956, 76);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            // 
            // app
            // 
            this.app.Cursor = System.Windows.Forms.Cursors.Hand;
            this.app.Location = new System.Drawing.Point(677, 19);
            this.app.Name = "app";
            this.app.Size = new System.Drawing.Size(118, 41);
            this.app.TabIndex = 6;
            this.app.Text = "A propos";
            this.app.UseVisualStyleBackColor = true;
            this.app.Click += new System.EventHandler(this.app_Click);
            // 
            // quit
            // 
            this.quit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.quit.Location = new System.Drawing.Point(832, 19);
            this.quit.Name = "quit";
            this.quit.Size = new System.Drawing.Size(118, 41);
            this.quit.TabIndex = 5;
            this.quit.Text = "Quitter";
            this.quit.UseVisualStyleBackColor = true;
            this.quit.Click += new System.EventHandler(this.quit_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabGenMdp);
            this.tabControl1.Controls.Add(this.tabListe);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(980, 664);
            this.tabControl1.TabIndex = 8;
            // 
            // GenMdp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(980, 664);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(996, 703);
            this.MinimumSize = new System.Drawing.Size(996, 703);
            this.Name = "GenMdp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Générateur de mot de passe By Célian";
            this.tabListe.ResumeLayout(false);
            this.boxDossier.ResumeLayout(false);
            this.boxDossier.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbMdp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbCara)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabGenMdp.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NbCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabListe;
        private System.Windows.Forms.TabPage tabGenMdp;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label nb;
        private System.Windows.Forms.NumericUpDown NbCar;
        private System.Windows.Forms.CheckBox CarSpe;
        private System.Windows.Forms.CheckBox Chiffres;
        private System.Windows.Forms.CheckBox LMaj;
        private System.Windows.Forms.CheckBox LMin;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Gen;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button app;
        private System.Windows.Forms.Button quit;
        private System.Windows.Forms.Button btnParcourir;
        private System.Windows.Forms.Button btnGenListe;
        private System.Windows.Forms.GroupBox boxDossier;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nbMdp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nbCara;
        private System.Windows.Forms.CheckBox specListe;
        private System.Windows.Forms.CheckBox chiffresListe;
        private System.Windows.Forms.CheckBox minListe;
        private System.Windows.Forms.CheckBox majListe;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtSauvegarde;
        private System.Windows.Forms.ProgressBar progressGen;
        private System.Windows.Forms.TabControl tabControl1;
    }
}

