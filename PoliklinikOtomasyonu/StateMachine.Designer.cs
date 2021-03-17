
namespace PoliklinikOtomasyonu
{
    partial class StateMachine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StateMachine));
            this.randevuSistemiButton = new System.Windows.Forms.PictureBox();
            this.loginPanelButton = new System.Windows.Forms.PictureBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.randevuSistemiButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginPanelButton)).BeginInit();
            this.SuspendLayout();
            // 
            // randevuSistemiButton
            // 
            this.randevuSistemiButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.randevuSistemiButton.Image = ((System.Drawing.Image)(resources.GetObject("randevuSistemiButton.Image")));
            this.randevuSistemiButton.Location = new System.Drawing.Point(278, 228);
            this.randevuSistemiButton.Name = "randevuSistemiButton";
            this.randevuSistemiButton.Size = new System.Drawing.Size(123, 113);
            this.randevuSistemiButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.randevuSistemiButton.TabIndex = 2;
            this.randevuSistemiButton.TabStop = false;
            this.randevuSistemiButton.Click += new System.EventHandler(this.randevuSistemiButton_Click);
            // 
            // loginPanelButton
            // 
            this.loginPanelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginPanelButton.Image = ((System.Drawing.Image)(resources.GetObject("loginPanelButton.Image")));
            this.loginPanelButton.Location = new System.Drawing.Point(12, 12);
            this.loginPanelButton.Name = "loginPanelButton";
            this.loginPanelButton.Size = new System.Drawing.Size(123, 113);
            this.loginPanelButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.loginPanelButton.TabIndex = 3;
            this.loginPanelButton.TabStop = false;
            this.loginPanelButton.Click += new System.EventHandler(this.loginPanelButton_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label18.Location = new System.Drawing.Point(58, 139);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(140, 24);
            this.label18.TabIndex = 46;
            this.label18.Text = "GİRİŞ PANELİ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(131, 353);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 24);
            this.label1.TabIndex = 47;
            this.label1.Text = "HASTA RANDEVU SİSTEMİ";
            // 
            // StateMachine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 401);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.loginPanelButton);
            this.Controls.Add(this.randevuSistemiButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "StateMachine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StateMachine";
            this.Load += new System.EventHandler(this.StateMachine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.randevuSistemiButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginPanelButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox randevuSistemiButton;
        private System.Windows.Forms.PictureBox loginPanelButton;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label1;
    }
}