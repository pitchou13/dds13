namespace DonDuSang.Modules
{
    partial class GestionUtilisateur
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionUtilisateur));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.biNouveauUtilisateur = new DevExpress.XtraBars.BarButtonItem();
            this.biModifierUtilisateur = new DevExpress.XtraBars.BarButtonItem();
            this.biSupprimerUtilisateur = new DevExpress.XtraBars.BarButtonItem();
            this.biFermer = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.gridControlUtilisateur = new DevExpress.XtraGrid.GridControl();
            this.gridViewUtilisateur = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlUtilisateur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewUtilisateur)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.biNouveauUtilisateur,
            this.biModifierUtilisateur,
            this.biSupprimerUtilisateur,
            this.biFermer});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 5;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(1158, 142);
            this.ribbonControl1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ribbonControl1_ItemClick);
            // 
            // biNouveauUtilisateur
            // 
            this.biNouveauUtilisateur.Caption = "Ajouter";
            this.biNouveauUtilisateur.Id = 1;
            this.biNouveauUtilisateur.LargeGlyph = global::DonDuSang.Properties.Resources.icon_new_employee_32;
            this.biNouveauUtilisateur.Name = "biNouveauUtilisateur";
            // 
            // biModifierUtilisateur
            // 
            this.biModifierUtilisateur.Caption = "Modifier";
            this.biModifierUtilisateur.Id = 2;
            this.biModifierUtilisateur.LargeGlyph = global::DonDuSang.Properties.Resources.icon_nav_employees_32;
            this.biModifierUtilisateur.Name = "biModifierUtilisateur";
            // 
            // biSupprimerUtilisateur
            // 
            this.biSupprimerUtilisateur.Caption = "Supprimer";
            this.biSupprimerUtilisateur.Id = 3;
            this.biSupprimerUtilisateur.LargeGlyph = global::DonDuSang.Properties.Resources.icon_remove_employee_321;
            this.biSupprimerUtilisateur.Name = "biSupprimerUtilisateur";
            // 
            // biFermer
            // 
            this.biFermer.Caption = "Fermer";
            this.biFermer.Glyph = ((System.Drawing.Image)(resources.GetObject("biFermer.Glyph")));
            this.biFermer.Id = 4;
            this.biFermer.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("biFermer.LargeGlyph")));
            this.biFermer.Name = "biFermer";
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
            this.ribbonPageGroup1.ItemLinks.Add(this.biNouveauUtilisateur);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            this.ribbonPageGroup1.Text = "Nouveau";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.AllowTextClipping = false;
            this.ribbonPageGroup2.ItemLinks.Add(this.biModifierUtilisateur);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.ShowCaptionButton = false;
            this.ribbonPageGroup2.Text = "Modifier";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.AllowTextClipping = false;
            this.ribbonPageGroup3.ItemLinks.Add(this.biSupprimerUtilisateur);
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
            // gridControlUtilisateur
            // 
            this.gridControlUtilisateur.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControlUtilisateur.Location = new System.Drawing.Point(178, 206);
            this.gridControlUtilisateur.MainView = this.gridViewUtilisateur;
            this.gridControlUtilisateur.MenuManager = this.ribbonControl1;
            this.gridControlUtilisateur.Name = "gridControlUtilisateur";
            this.gridControlUtilisateur.Size = new System.Drawing.Size(648, 247);
            this.gridControlUtilisateur.TabIndex = 3;
            this.gridControlUtilisateur.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewUtilisateur});
            this.gridControlUtilisateur.DoubleClick += new System.EventHandler(this.gridControlUtilisateur_DoubleClick);
            // 
            // gridViewUtilisateur
            // 
            this.gridViewUtilisateur.GridControl = this.gridControlUtilisateur;
            this.gridViewUtilisateur.Name = "gridViewUtilisateur";
            this.gridViewUtilisateur.OptionsBehavior.Editable = false;
            this.gridViewUtilisateur.OptionsFind.AlwaysVisible = true;
            this.gridViewUtilisateur.OptionsView.ShowFooter = true;
            this.gridViewUtilisateur.OptionsView.ShowGroupPanel = false;
            // 
            // GestionUtilisateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControlUtilisateur);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "GestionUtilisateur";
            this.Size = new System.Drawing.Size(1158, 568);
            this.Load += new System.EventHandler(this.GestionUtilisateur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlUtilisateur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewUtilisateur)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem biNouveauUtilisateur;
        private DevExpress.XtraBars.BarButtonItem biModifierUtilisateur;
        private DevExpress.XtraBars.BarButtonItem biSupprimerUtilisateur;
        private DevExpress.XtraBars.BarButtonItem biFermer;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraGrid.GridControl gridControlUtilisateur;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewUtilisateur;

    }
}
