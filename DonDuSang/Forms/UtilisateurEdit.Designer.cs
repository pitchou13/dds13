namespace DonDuSang.Forms
{
    partial class UtilisateurEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UtilisateurEdit));
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
            this.textEditUser = new DevExpress.XtraEditors.TextEdit();
            this.textEditMdp = new DevExpress.XtraEditors.TextEdit();
            this.lcUser = new DevExpress.XtraEditors.LabelControl();
            this.lbMdp = new DevExpress.XtraEditors.LabelControl();
            this.radioGroup1 = new DevExpress.XtraEditors.RadioGroup();
            this.lbAdmin = new DevExpress.XtraEditors.LabelControl();
            this.comboBoxEditType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lbType = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditUser.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditMdp.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditType.Properties)).BeginInit();
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
            this.ribbon.Size = new System.Drawing.Size(449, 144);
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
            this.ribbonStatusBar.Size = new System.Drawing.Size(449, 31);
            // 
            // textEditUser
            // 
            this.textEditUser.Location = new System.Drawing.Point(165, 178);
            this.textEditUser.MenuManager = this.ribbon;
            this.textEditUser.Name = "textEditUser";
            this.textEditUser.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEditUser.Properties.Appearance.Options.UseFont = true;
            this.textEditUser.Size = new System.Drawing.Size(140, 26);
            this.textEditUser.TabIndex = 2;
            // 
            // textEditMdp
            // 
            this.textEditMdp.Location = new System.Drawing.Point(165, 226);
            this.textEditMdp.MenuManager = this.ribbon;
            this.textEditMdp.Name = "textEditMdp";
            this.textEditMdp.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEditMdp.Properties.Appearance.Options.UseFont = true;
            this.textEditMdp.Size = new System.Drawing.Size(140, 26);
            this.textEditMdp.TabIndex = 3;
            // 
            // lcUser
            // 
            this.lcUser.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lcUser.Location = new System.Drawing.Point(36, 181);
            this.lcUser.Name = "lcUser";
            this.lcUser.Size = new System.Drawing.Size(114, 20);
            this.lcUser.TabIndex = 4;
            this.lcUser.Text = "Nom d\'utilisateur";
            // 
            // lbMdp
            // 
            this.lbMdp.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMdp.Location = new System.Drawing.Point(36, 229);
            this.lbMdp.Name = "lbMdp";
            this.lbMdp.Size = new System.Drawing.Size(89, 20);
            this.lbMdp.TabIndex = 5;
            this.lbMdp.Text = "Mot de passe";
            // 
            // radioGroup1
            // 
            this.radioGroup1.Location = new System.Drawing.Point(165, 274);
            this.radioGroup1.MenuManager = this.ribbon;
            this.radioGroup1.Name = "radioGroup1";
            this.radioGroup1.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioGroup1.Properties.Appearance.Options.UseFont = true;
            this.radioGroup1.Properties.Columns = 2;
            this.radioGroup1.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(true, "Oui"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(false, "Non")});
            this.radioGroup1.Size = new System.Drawing.Size(108, 29);
            this.radioGroup1.TabIndex = 6;
            this.radioGroup1.SelectedIndexChanged += new System.EventHandler(this.radioGroup1_SelectedIndexChanged);
            // 
            // lbAdmin
            // 
            this.lbAdmin.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAdmin.Location = new System.Drawing.Point(36, 279);
            this.lbAdmin.Name = "lbAdmin";
            this.lbAdmin.Size = new System.Drawing.Size(98, 20);
            this.lbAdmin.TabIndex = 7;
            this.lbAdmin.Text = "Administrateur";
            // 
            // comboBoxEditType
            // 
            this.comboBoxEditType.Enabled = false;
            this.comboBoxEditType.Location = new System.Drawing.Point(165, 320);
            this.comboBoxEditType.MenuManager = this.ribbon;
            this.comboBoxEditType.Name = "comboBoxEditType";
            this.comboBoxEditType.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxEditType.Properties.Appearance.Options.UseFont = true;
            this.comboBoxEditType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEditType.Properties.Items.AddRange(new object[] {
            "Controle Biologique"});
            this.comboBoxEditType.Size = new System.Drawing.Size(140, 26);
            this.comboBoxEditType.TabIndex = 10;
            // 
            // lbType
            // 
            this.lbType.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbType.Enabled = false;
            this.lbType.Location = new System.Drawing.Point(36, 323);
            this.lbType.Name = "lbType";
            this.lbType.Size = new System.Drawing.Size(32, 20);
            this.lbType.TabIndex = 11;
            this.lbType.Text = "Type";
            // 
            // UtilisateurEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 443);
            this.Controls.Add(this.lbType);
            this.Controls.Add(this.comboBoxEditType);
            this.Controls.Add(this.lbAdmin);
            this.Controls.Add(this.radioGroup1);
            this.Controls.Add(this.lbMdp);
            this.Controls.Add(this.lcUser);
            this.Controls.Add(this.textEditMdp);
            this.Controls.Add(this.textEditUser);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "UtilisateurEdit";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Utilisateur";
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditUser.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditMdp.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditType.Properties)).EndInit();
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
        private DevExpress.XtraEditors.TextEdit textEditUser;
        private DevExpress.XtraEditors.TextEdit textEditMdp;
        private DevExpress.XtraEditors.LabelControl lcUser;
        private DevExpress.XtraEditors.LabelControl lbMdp;
        private DevExpress.XtraEditors.RadioGroup radioGroup1;
        private DevExpress.XtraEditors.LabelControl lbAdmin;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEditType;
        private DevExpress.XtraEditors.LabelControl lbType;
    }
}