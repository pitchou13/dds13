﻿namespace DonDuSang.Forms
{
    partial class Authentification
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Authentification));
            this.textEditLogin = new DevExpress.XtraEditors.TextEdit();
            this.textEditPassword = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.Connecter = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.Quitter = new DevExpress.XtraEditors.SimpleButton();
            this.pEFalse1 = new DevExpress.XtraEditors.PictureEdit();
            this.pEFalse2 = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditLogin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pEFalse1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pEFalse2.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // textEditLogin
            // 
            this.textEditLogin.Location = new System.Drawing.Point(162, 73);
            this.textEditLogin.Name = "textEditLogin";
            this.textEditLogin.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.textEditLogin.Properties.Appearance.Options.UseBackColor = true;
            this.textEditLogin.Size = new System.Drawing.Size(110, 20);
            this.textEditLogin.TabIndex = 0;
            this.textEditLogin.Enter += new System.EventHandler(this.textEditLogin_Enter);
            this.textEditLogin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textEditLogin_KeyDown);
            this.textEditLogin.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textEditLogin_KeyUp);
            // 
            // textEditPassword
            // 
            this.textEditPassword.Location = new System.Drawing.Point(162, 124);
            this.textEditPassword.Name = "textEditPassword";
            this.textEditPassword.Properties.PasswordChar = '*';
            this.textEditPassword.Size = new System.Drawing.Size(110, 20);
            this.textEditPassword.TabIndex = 1;
            this.textEditPassword.Enter += new System.EventHandler(this.textEditPassword_Enter);
            this.textEditPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textEditPassword_KeyDown);
            this.textEditPassword.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textEditPassword_KeyUp);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(51, 74);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(105, 16);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Nom d\'utilisateur :";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(51, 125);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(85, 16);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Mot de passe :";
            // 
            // Connecter
            // 
            this.Connecter.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Connecter.Appearance.Options.UseFont = true;
            this.Connecter.Location = new System.Drawing.Point(51, 167);
            this.Connecter.Name = "Connecter";
            this.Connecter.Size = new System.Drawing.Size(89, 23);
            this.Connecter.TabIndex = 2;
            this.Connecter.Text = "Se connecter";
            this.Connecter.Click += new System.EventHandler(this.Connecter_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(12, 30);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(339, 16);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Veuillez saisir votre nom d\'utilisateur et votre mot de passe";
            // 
            // Quitter
            // 
            this.Quitter.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quitter.Appearance.Options.UseFont = true;
            this.Quitter.Location = new System.Drawing.Point(197, 167);
            this.Quitter.Name = "Quitter";
            this.Quitter.Size = new System.Drawing.Size(75, 23);
            this.Quitter.TabIndex = 5;
            this.Quitter.Text = "Quitter";
            this.Quitter.Click += new System.EventHandler(this.Quitter_Click);
            // 
            // pEFalse1
            // 
            this.pEFalse1.EditValue = ((object)(resources.GetObject("pEFalse1.EditValue")));
            this.pEFalse1.Location = new System.Drawing.Point(278, 73);
            this.pEFalse1.Name = "pEFalse1";
            this.pEFalse1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pEFalse1.Properties.Appearance.Options.UseBackColor = true;
            this.pEFalse1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pEFalse1.Size = new System.Drawing.Size(21, 20);
            this.pEFalse1.TabIndex = 6;
            this.pEFalse1.Visible = false;
            // 
            // pEFalse2
            // 
            this.pEFalse2.EditValue = ((object)(resources.GetObject("pEFalse2.EditValue")));
            this.pEFalse2.Location = new System.Drawing.Point(278, 124);
            this.pEFalse2.Name = "pEFalse2";
            this.pEFalse2.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pEFalse2.Properties.Appearance.Options.UseBackColor = true;
            this.pEFalse2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pEFalse2.Size = new System.Drawing.Size(21, 20);
            this.pEFalse2.TabIndex = 7;
            this.pEFalse2.Visible = false;
            // 
            // Authentification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(364, 202);
            this.Controls.Add(this.pEFalse2);
            this.Controls.Add(this.pEFalse1);
            this.Controls.Add(this.Quitter);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.Connecter);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.textEditPassword);
            this.Controls.Add(this.textEditLogin);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Authentification";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Authentification";
            ((System.ComponentModel.ISupportInitialize)(this.textEditLogin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pEFalse1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pEFalse2.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit textEditLogin;
        private DevExpress.XtraEditors.TextEdit textEditPassword;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton Connecter;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton Quitter;
        private DevExpress.XtraEditors.PictureEdit pEFalse1;
        private DevExpress.XtraEditors.PictureEdit pEFalse2;
    }
}

