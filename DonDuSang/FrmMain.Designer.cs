using DevExpress.Utils;

namespace DonDuSang
{
    partial class FrmMain
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
            DevExpress.Utils.Animation.Transition transition1 = new DevExpress.Utils.Animation.Transition();
            DevExpress.Utils.Animation.SlideFadeTransition slideFadeTransition1 = new DevExpress.Utils.Animation.SlideFadeTransition();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.modulesContainer = new DevExpress.XtraEditors.XtraUserControl();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.rgbiSkins = new DevExpress.XtraBars.SkinRibbonGalleryBarItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.transitionManager1 = new DevExpress.Utils.Animation.TransitionManager();
            this.officeNavigationBar1 = new DevExpress.XtraBars.Navigation.OfficeNavigationBar();
            this.navigationBarItem1 = new DevExpress.XtraBars.Navigation.NavigationBarItem();
            this.navigationBarItem2 = new DevExpress.XtraBars.Navigation.NavigationBarItem();
            this.navigationBarItem3 = new DevExpress.XtraBars.Navigation.NavigationBarItem();
            this.navigationBarItem4 = new DevExpress.XtraBars.Navigation.NavigationBarItem();
            this.navigationBarItem5 = new DevExpress.XtraBars.Navigation.NavigationBarItem();
            this.dockManager = new DevExpress.XtraBars.Docking.DockManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.officeNavigationBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager)).BeginInit();
            this.SuspendLayout();
            // 
            // modulesContainer
            // 
            this.modulesContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.modulesContainer.Location = new System.Drawing.Point(0, 144);
            this.modulesContainer.Name = "modulesContainer";
            this.modulesContainer.Size = new System.Drawing.Size(957, 554);
            this.modulesContainer.TabIndex = 2;
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 736);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbonControl;
            this.ribbonStatusBar.Size = new System.Drawing.Size(957, 31);
            // 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl.ExpandCollapseItem,
            this.rgbiSkins});
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.MaxItemId = 3;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbonControl.Size = new System.Drawing.Size(957, 144);
            this.ribbonControl.StatusBar = this.ribbonStatusBar;
            // 
            // rgbiSkins
            // 
            this.rgbiSkins.Caption = "skinRibbonGalleryBarItem1";
            this.rgbiSkins.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.rgbiSkins.Id = 1;
            this.rgbiSkins.Name = "rgbiSkins";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Acceuil";
            // 
            // transitionManager1
            // 
            transition1.Control = this.modulesContainer;
            transition1.ShowWaitingIndicator = DevExpress.Utils.DefaultBoolean.True;
            slideFadeTransition1.Parameters.Background = System.Drawing.Color.Empty;
            slideFadeTransition1.Parameters.EffectOptions = DevExpress.Utils.Animation.PushEffectOptions.FromRight;
            slideFadeTransition1.Parameters.FrameInterval = 5000;
            slideFadeTransition1.Parameters.FramesCount = null;
            transition1.TransitionType = slideFadeTransition1;
            transition1.WaitingIndicatorProperties.ContentMinSize = new System.Drawing.Size(160, 0);
            transition1.WaitingIndicatorProperties.Description = "Chargement...";
            this.transitionManager1.Transitions.Add(transition1);
            // 
            // officeNavigationBar1
            // 
            this.officeNavigationBar1.AllowDrag = true;
            this.officeNavigationBar1.AppearanceItem.Normal.BackColor = System.Drawing.Color.Transparent;
            this.officeNavigationBar1.AppearanceItem.Normal.BackColor2 = System.Drawing.Color.Transparent;
            this.officeNavigationBar1.AppearanceItem.Normal.BorderColor = System.Drawing.Color.Transparent;
            this.officeNavigationBar1.AppearanceItem.Normal.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.officeNavigationBar1.AppearanceItem.Normal.Options.UseBackColor = true;
            this.officeNavigationBar1.AppearanceItem.Normal.Options.UseBorderColor = true;
            this.officeNavigationBar1.AppearanceItem.Normal.Options.UseFont = true;
            this.officeNavigationBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.officeNavigationBar1.Items.AddRange(new DevExpress.XtraBars.Navigation.NavigationBarItem[] {
            this.navigationBarItem1,
            this.navigationBarItem2,
            this.navigationBarItem3,
            this.navigationBarItem4,
            this.navigationBarItem5});
            this.officeNavigationBar1.Location = new System.Drawing.Point(0, 698);
            this.officeNavigationBar1.Name = "officeNavigationBar1";
            this.officeNavigationBar1.Size = new System.Drawing.Size(957, 38);
            this.officeNavigationBar1.TabIndex = 8;
            this.officeNavigationBar1.Text = "officeNavigationBar1";
            this.officeNavigationBar1.ItemClick += new DevExpress.XtraBars.Navigation.NavigationBarItemClickEventHandler(this.officeNavigationBar_ItemClick);
            // 
            // navigationBarItem1
            // 
            this.navigationBarItem1.Name = "navigationBarItem1";
            this.navigationBarItem1.Text = "Acceuil";
            // 
            // navigationBarItem2
            // 
            this.navigationBarItem2.Name = "navigationBarItem2";
            this.navigationBarItem2.Text = "Service Médicale";
            // 
            // navigationBarItem3
            // 
            this.navigationBarItem3.Name = "navigationBarItem3";
            this.navigationBarItem3.Text = "Prélevement";
            // 
            // navigationBarItem4
            // 
            this.navigationBarItem4.Name = "navigationBarItem4";
            this.navigationBarItem4.Text = "Controle Biologique";
            // 
            // navigationBarItem5
            // 
            this.navigationBarItem5.Name = "navigationBarItem5";
            this.navigationBarItem5.Text = "Distribution";
            // 
            // dockManager
            // 
            this.dockManager.DockingOptions.FloatOnDblClick = false;
            this.dockManager.DockingOptions.ShowAutoHideButton = false;
            this.dockManager.DockingOptions.ShowMaximizeButton = false;
            this.dockManager.Form = this.modulesContainer;
            this.dockManager.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "System.Windows.Forms.MenuStrip",
            "System.Windows.Forms.StatusStrip",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl",
            "DevExpress.XtraBars.Navigation.OfficeNavigationBar",
            "DevExpress.XtraBars.Navigation.TileNavPane"});
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 767);
            this.Controls.Add(this.modulesContainer);
            this.Controls.Add(this.officeNavigationBar1);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbonControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FrmMain";
            this.Ribbon = this.ribbonControl;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Don du Sang";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.officeNavigationBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.Utils.Animation.TransitionManager transitionManager1;
        private DevExpress.XtraBars.Navigation.OfficeNavigationBar officeNavigationBar1;
        private DevExpress.XtraBars.Navigation.NavigationBarItem navigationBarItem1;
        private DevExpress.XtraBars.Navigation.NavigationBarItem navigationBarItem2;
        private DevExpress.XtraBars.Navigation.NavigationBarItem navigationBarItem3;
        private DevExpress.XtraBars.Navigation.NavigationBarItem navigationBarItem4;
        private DevExpress.XtraBars.Navigation.NavigationBarItem navigationBarItem5;
        private DevExpress.XtraBars.Docking.DockManager dockManager;
        private DevExpress.XtraEditors.XtraUserControl modulesContainer;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.SkinRibbonGalleryBarItem rgbiSkins;
    }
}