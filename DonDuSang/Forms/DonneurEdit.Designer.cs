namespace DonDuSang.Forms
{
    partial class DonneurEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DonneurEdit));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.biFermer = new DevExpress.XtraBars.BarButtonItem();
            this.biSauvegarder = new DevExpress.XtraBars.BarButtonItem();
            this.biSauvegarderFermer = new DevExpress.XtraBars.BarButtonItem();
            this.biAnnulerChangement = new DevExpress.XtraBars.BarButtonItem();
            this.biSupprimer = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.textEditNom = new DevExpress.XtraEditors.TextEdit();
            this.textEditPrenom = new DevExpress.XtraEditors.TextEdit();
            this.lbNom = new DevExpress.XtraEditors.LabelControl();
            this.lbPrenom = new DevExpress.XtraEditors.LabelControl();
            this.lbDateNaissance = new DevExpress.XtraEditors.LabelControl();
            this.comboBoxEditSexe = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lbSexe = new DevExpress.XtraEditors.LabelControl();
            this.dateEditNaissance = new DevExpress.XtraEditors.DateEdit();
            this.lbMail = new DevExpress.XtraEditors.LabelControl();
            this.lbAdresse = new DevExpress.XtraEditors.LabelControl();
            this.textEditMail = new DevExpress.XtraEditors.TextEdit();
            this.textEditAdresse = new DevExpress.XtraEditors.TextEdit();
            this.lbNumTel = new DevExpress.XtraEditors.LabelControl();
            this.textEditNumTel = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditNom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditPrenom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditSexe.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditNaissance.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditNaissance.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditMail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditAdresse.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditNumTel.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.biFermer,
            this.biSauvegarder,
            this.biSauvegarderFermer,
            this.biAnnulerChangement,
            this.biSupprimer});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 6;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbon.Size = new System.Drawing.Size(533, 144);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // biFermer
            // 
            this.biFermer.Caption = "Fermer";
            this.biFermer.Id = 1;
            this.biFermer.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("biFermer.LargeGlyph")));
            this.biFermer.Name = "biFermer";
            this.biFermer.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.biFermer_ItemClick);
            // 
            // biSauvegarder
            // 
            this.biSauvegarder.Caption = "Sauvegarder";
            this.biSauvegarder.Id = 2;
            this.biSauvegarder.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("biSauvegarder.LargeGlyph")));
            this.biSauvegarder.Name = "biSauvegarder";
            this.biSauvegarder.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.biSauvegarder_ItemClick);
            // 
            // biSauvegarderFermer
            // 
            this.biSauvegarderFermer.Caption = "Sauvegarder et fermer";
            this.biSauvegarderFermer.Id = 3;
            this.biSauvegarderFermer.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("biSauvegarderFermer.LargeGlyph")));
            this.biSauvegarderFermer.Name = "biSauvegarderFermer";
            this.biSauvegarderFermer.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.biSauvegarderFermer_ItemClick);
            // 
            // biAnnulerChangement
            // 
            this.biAnnulerChangement.Caption = "Annuler modification";
            this.biAnnulerChangement.Id = 4;
            this.biAnnulerChangement.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("biAnnulerChangement.LargeGlyph")));
            this.biAnnulerChangement.Name = "biAnnulerChangement";
            this.biAnnulerChangement.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.biAnnulerChangement_ItemClick);
            // 
            // biSupprimer
            // 
            this.biSupprimer.Caption = "Supprimer";
            this.biSupprimer.Id = 5;
            this.biSupprimer.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("biSupprimer.LargeGlyph")));
            this.biSupprimer.Name = "biSupprimer";
            this.biSupprimer.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.biSupprimer_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3,
            this.ribbonPageGroup4});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Acceuil";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.ItemLinks.Add(this.biSauvegarder);
            this.ribbonPageGroup1.ItemLinks.Add(this.biSauvegarderFermer);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            this.ribbonPageGroup1.Text = "Sauvegarder";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.AllowTextClipping = false;
            this.ribbonPageGroup2.ItemLinks.Add(this.biAnnulerChangement);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.ShowCaptionButton = false;
            this.ribbonPageGroup2.Text = "Editer";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.AllowTextClipping = false;
            this.ribbonPageGroup3.ItemLinks.Add(this.biSupprimer);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.ShowCaptionButton = false;
            this.ribbonPageGroup3.Text = "Supprimer";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.AllowTextClipping = false;
            this.ribbonPageGroup4.ItemLinks.Add(this.biFermer);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.ShowCaptionButton = false;
            this.ribbonPageGroup4.Text = "Fermer";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 412);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(533, 31);
            // 
            // textEditNom
            // 
            this.textEditNom.Location = new System.Drawing.Point(124, 178);
            this.textEditNom.MenuManager = this.ribbon;
            this.textEditNom.Name = "textEditNom";
            this.textEditNom.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEditNom.Properties.Appearance.Options.UseFont = true;
            this.textEditNom.Size = new System.Drawing.Size(140, 26);
            this.textEditNom.TabIndex = 2;
            // 
            // textEditPrenom
            // 
            this.textEditPrenom.Location = new System.Drawing.Point(369, 178);
            this.textEditPrenom.MenuManager = this.ribbon;
            this.textEditPrenom.Name = "textEditPrenom";
            this.textEditPrenom.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEditPrenom.Properties.Appearance.Options.UseFont = true;
            this.textEditPrenom.Size = new System.Drawing.Size(140, 26);
            this.textEditPrenom.TabIndex = 3;
            // 
            // lbNom
            // 
            this.lbNom.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNom.Location = new System.Drawing.Point(36, 181);
            this.lbNom.Name = "lbNom";
            this.lbNom.Size = new System.Drawing.Size(33, 20);
            this.lbNom.TabIndex = 4;
            this.lbNom.Text = "Nom";
            // 
            // lbPrenom
            // 
            this.lbPrenom.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrenom.Location = new System.Drawing.Point(296, 181);
            this.lbPrenom.Name = "lbPrenom";
            this.lbPrenom.Size = new System.Drawing.Size(51, 20);
            this.lbPrenom.TabIndex = 5;
            this.lbPrenom.Text = "Prénom";
            // 
            // lbDateNaissance
            // 
            this.lbDateNaissance.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDateNaissance.Location = new System.Drawing.Point(21, 243);
            this.lbDateNaissance.Name = "lbDateNaissance";
            this.lbDateNaissance.Size = new System.Drawing.Size(99, 20);
            this.lbDateNaissance.TabIndex = 7;
            this.lbDateNaissance.Text = "Date naissance";
            // 
            // comboBoxEditSexe
            // 
            this.comboBoxEditSexe.Enabled = false;
            this.comboBoxEditSexe.Location = new System.Drawing.Point(369, 240);
            this.comboBoxEditSexe.MenuManager = this.ribbon;
            this.comboBoxEditSexe.Name = "comboBoxEditSexe";
            this.comboBoxEditSexe.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxEditSexe.Properties.Appearance.Options.UseFont = true;
            this.comboBoxEditSexe.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEditSexe.Properties.Items.AddRange(new object[] {
            "Masculin",
            "Féminin"});
            this.comboBoxEditSexe.Size = new System.Drawing.Size(140, 26);
            this.comboBoxEditSexe.TabIndex = 10;
            // 
            // lbSexe
            // 
            this.lbSexe.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSexe.Enabled = false;
            this.lbSexe.Location = new System.Drawing.Point(296, 246);
            this.lbSexe.Name = "lbSexe";
            this.lbSexe.Size = new System.Drawing.Size(31, 20);
            this.lbSexe.TabIndex = 11;
            this.lbSexe.Text = "Sexe";
            // 
            // dateEditNaissance
            // 
            this.dateEditNaissance.EditValue = null;
            this.dateEditNaissance.Location = new System.Drawing.Point(124, 240);
            this.dateEditNaissance.MenuManager = this.ribbon;
            this.dateEditNaissance.Name = "dateEditNaissance";
            this.dateEditNaissance.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateEditNaissance.Properties.Appearance.Options.UseFont = true;
            this.dateEditNaissance.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditNaissance.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditNaissance.Size = new System.Drawing.Size(140, 26);
            this.dateEditNaissance.TabIndex = 14;
            // 
            // lbMail
            // 
            this.lbMail.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMail.Location = new System.Drawing.Point(296, 310);
            this.lbMail.Name = "lbMail";
            this.lbMail.Size = new System.Drawing.Size(32, 20);
            this.lbMail.TabIndex = 20;
            this.lbMail.Text = "Mail.";
            // 
            // lbAdresse
            // 
            this.lbAdresse.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAdresse.Location = new System.Drawing.Point(36, 310);
            this.lbAdresse.Name = "lbAdresse";
            this.lbAdresse.Size = new System.Drawing.Size(52, 20);
            this.lbAdresse.TabIndex = 19;
            this.lbAdresse.Text = "Adresse";
            // 
            // textEditMail
            // 
            this.textEditMail.Location = new System.Drawing.Point(369, 307);
            this.textEditMail.MenuManager = this.ribbon;
            this.textEditMail.Name = "textEditMail";
            this.textEditMail.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEditMail.Properties.Appearance.Options.UseFont = true;
            this.textEditMail.Size = new System.Drawing.Size(140, 26);
            this.textEditMail.TabIndex = 18;
            // 
            // textEditAdresse
            // 
            this.textEditAdresse.Location = new System.Drawing.Point(124, 307);
            this.textEditAdresse.MenuManager = this.ribbon;
            this.textEditAdresse.Name = "textEditAdresse";
            this.textEditAdresse.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEditAdresse.Properties.Appearance.Options.UseFont = true;
            this.textEditAdresse.Size = new System.Drawing.Size(140, 26);
            this.textEditAdresse.TabIndex = 17;
            // 
            // lbNumTel
            // 
            this.lbNumTel.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumTel.Location = new System.Drawing.Point(36, 374);
            this.lbNumTel.Name = "lbNumTel";
            this.lbNumTel.Size = new System.Drawing.Size(56, 20);
            this.lbNumTel.TabIndex = 22;
            this.lbNumTel.Text = "Num Tél";
            // 
            // textEditNumTel
            // 
            this.textEditNumTel.Location = new System.Drawing.Point(124, 371);
            this.textEditNumTel.MenuManager = this.ribbon;
            this.textEditNumTel.Name = "textEditNumTel";
            this.textEditNumTel.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEditNumTel.Properties.Appearance.Options.UseFont = true;
            this.textEditNumTel.Size = new System.Drawing.Size(140, 26);
            this.textEditNumTel.TabIndex = 21;
            // 
            // DonneurEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 443);
            this.Controls.Add(this.lbNumTel);
            this.Controls.Add(this.textEditNumTel);
            this.Controls.Add(this.lbMail);
            this.Controls.Add(this.lbAdresse);
            this.Controls.Add(this.textEditMail);
            this.Controls.Add(this.textEditAdresse);
            this.Controls.Add(this.dateEditNaissance);
            this.Controls.Add(this.lbSexe);
            this.Controls.Add(this.comboBoxEditSexe);
            this.Controls.Add(this.lbDateNaissance);
            this.Controls.Add(this.lbPrenom);
            this.Controls.Add(this.lbNom);
            this.Controls.Add(this.textEditPrenom);
            this.Controls.Add(this.textEditNom);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "DonneurEdit";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Donneur";
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditNom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditPrenom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditSexe.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditNaissance.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditNaissance.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditMail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditAdresse.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditNumTel.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem biFermer;
        private DevExpress.XtraBars.BarButtonItem biSauvegarder;
        private DevExpress.XtraBars.BarButtonItem biSauvegarderFermer;
        private DevExpress.XtraBars.BarButtonItem biAnnulerChangement;
        private DevExpress.XtraBars.BarButtonItem biSupprimer;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraEditors.TextEdit textEditNom;
        private DevExpress.XtraEditors.TextEdit textEditPrenom;
        private DevExpress.XtraEditors.LabelControl lbNom;
        private DevExpress.XtraEditors.LabelControl lbPrenom;
        private DevExpress.XtraEditors.LabelControl lbDateNaissance;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEditSexe;
        private DevExpress.XtraEditors.LabelControl lbSexe;
        private DevExpress.XtraEditors.DateEdit dateEditNaissance;
        private DevExpress.XtraEditors.LabelControl lbMail;
        private DevExpress.XtraEditors.LabelControl lbAdresse;
        private DevExpress.XtraEditors.TextEdit textEditMail;
        private DevExpress.XtraEditors.TextEdit textEditAdresse;
        private DevExpress.XtraEditors.LabelControl lbNumTel;
        private DevExpress.XtraEditors.TextEdit textEditNumTel;
    }
}