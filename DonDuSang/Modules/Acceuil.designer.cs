namespace DonDuSang.Modules
{
    partial class Acceuil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Acceuil));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.biNouveauDonneur = new DevExpress.XtraBars.BarButtonItem();
            this.biModifierDonneur = new DevExpress.XtraBars.BarButtonItem();
            this.biSupprimerDonneur = new DevExpress.XtraBars.BarButtonItem();
            this.biFermer = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup7 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup8 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup9 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup10 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup11 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.gridControlDonneur = new DevExpress.XtraGrid.GridControl();
            this.gridViewDonneur = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDonneur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDonneur)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.biNouveauDonneur,
            this.biModifierDonneur,
            this.biSupprimerDonneur,
            this.biFermer});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 6;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(973, 142);
            this.ribbonControl1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ribbonControl1_ItemClick);
            // 
            // biNouveauDonneur
            // 
            this.biNouveauDonneur.Caption = "Nouveau";
            this.biNouveauDonneur.Id = 1;
            this.biNouveauDonneur.Name = "biNouveauDonneur";
            // 
            // biModifierDonneur
            // 
            this.biModifierDonneur.Caption = "Modifier";
            this.biModifierDonneur.Id = 2;
            this.biModifierDonneur.LargeGlyph = global::DonDuSang.Properties.Resources.icon_edit_32;
            this.biModifierDonneur.Name = "biModifierDonneur";
            // 
            // biSupprimerDonneur
            // 
            this.biSupprimerDonneur.Caption = "Supprimer";
            this.biSupprimerDonneur.Id = 3;
            this.biSupprimerDonneur.LargeGlyph = global::DonDuSang.Properties.Resources.icon_delete_32;
            this.biSupprimerDonneur.Name = "biSupprimerDonneur";
            // 
            // biFermer
            // 
            this.biFermer.Caption = "Fermer";
            this.biFermer.Id = 5;
            this.biFermer.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("biFermer.LargeGlyph")));
            this.biFermer.Name = "biFermer";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Acceuil";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.ItemLinks.Add(this.biNouveauDonneur);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            this.ribbonPageGroup1.Text = "Nouveau";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.AllowTextClipping = false;
            this.ribbonPageGroup2.ItemLinks.Add(this.biModifierDonneur);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.ShowCaptionButton = false;
            this.ribbonPageGroup2.Text = "Modifier";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.AllowTextClipping = false;
            this.ribbonPageGroup3.ItemLinks.Add(this.biSupprimerDonneur);
            this.ribbonPageGroup3.ItemLinks.Add(this.biFermer);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.ShowCaptionButton = false;
            this.ribbonPageGroup3.Text = "Actions";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.AllowTextClipping = false;
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.ShowCaptionButton = false;
            this.ribbonPageGroup4.Text = "Nouveau";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.AllowTextClipping = false;
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.ShowCaptionButton = false;
            this.ribbonPageGroup5.Text = "Modifier";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.AllowTextClipping = false;
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            this.ribbonPageGroup6.ShowCaptionButton = false;
            this.ribbonPageGroup6.Text = "Supprimer";
            // 
            // ribbonPageGroup7
            // 
            this.ribbonPageGroup7.AllowTextClipping = false;
            this.ribbonPageGroup7.Name = "ribbonPageGroup7";
            this.ribbonPageGroup7.ShowCaptionButton = false;
            this.ribbonPageGroup7.Text = "Fermer";
            // 
            // ribbonPageGroup8
            // 
            this.ribbonPageGroup8.AllowTextClipping = false;
            this.ribbonPageGroup8.Name = "ribbonPageGroup8";
            this.ribbonPageGroup8.ShowCaptionButton = false;
            this.ribbonPageGroup8.Text = "Nouveau";
            // 
            // ribbonPageGroup9
            // 
            this.ribbonPageGroup9.AllowTextClipping = false;
            this.ribbonPageGroup9.Name = "ribbonPageGroup9";
            this.ribbonPageGroup9.ShowCaptionButton = false;
            this.ribbonPageGroup9.Text = "Modifier";
            // 
            // ribbonPageGroup10
            // 
            this.ribbonPageGroup10.AllowTextClipping = false;
            this.ribbonPageGroup10.Name = "ribbonPageGroup10";
            this.ribbonPageGroup10.ShowCaptionButton = false;
            this.ribbonPageGroup10.Text = "Supprimer";
            // 
            // ribbonPageGroup11
            // 
            this.ribbonPageGroup11.AllowTextClipping = false;
            this.ribbonPageGroup11.Name = "ribbonPageGroup11";
            this.ribbonPageGroup11.ShowCaptionButton = false;
            this.ribbonPageGroup11.Text = "Fermer";
            // 
            // gridControlDonneur
            // 
            this.gridControlDonneur.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControlDonneur.Location = new System.Drawing.Point(69, 212);
            this.gridControlDonneur.MainView = this.gridViewDonneur;
            this.gridControlDonneur.MenuManager = this.ribbonControl1;
            this.gridControlDonneur.Name = "gridControlDonneur";
            this.gridControlDonneur.Size = new System.Drawing.Size(663, 323);
            this.gridControlDonneur.TabIndex = 4;
            this.gridControlDonneur.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewDonneur});
            this.gridControlDonneur.DoubleClick += new System.EventHandler(this.gridControlDonneur_DoubleClick);
            // 
            // gridViewDonneur
            // 
            this.gridViewDonneur.GridControl = this.gridControlDonneur;
            this.gridViewDonneur.Name = "gridViewDonneur";
            this.gridViewDonneur.OptionsBehavior.Editable = false;
            this.gridViewDonneur.OptionsFind.AllowFindPanel = false;
            this.gridViewDonneur.OptionsView.ShowFooter = true;
            this.gridViewDonneur.OptionsView.ShowGroupPanel = false;
            // 
            // Acceuil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControlDonneur);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "Acceuil";
            this.Size = new System.Drawing.Size(973, 568);
            this.Load += new System.EventHandler(this.Acceuil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDonneur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDonneur)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem biNouveauDonneur;
        private DevExpress.XtraBars.BarButtonItem biModifierDonneur;
        private DevExpress.XtraBars.BarButtonItem biSupprimerDonneur;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup7;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup8;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup9;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup10;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup11;
        private DevExpress.XtraBars.BarButtonItem biFermer;
        private DevExpress.XtraGrid.GridControl gridControlDonneur;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewDonneur;

    }
}
