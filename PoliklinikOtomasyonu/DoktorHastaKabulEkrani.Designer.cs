
namespace PoliklinikOtomasyonu
{
    partial class DoktorHastaKabulEkrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoktorHastaKabulEkrani));
            this.polklinikHastaAdiLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // polklinikHastaAdiLabel
            // 
            this.polklinikHastaAdiLabel.BackColor = System.Drawing.Color.Transparent;
            this.polklinikHastaAdiLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.polklinikHastaAdiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 80.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.polklinikHastaAdiLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.polklinikHastaAdiLabel.Location = new System.Drawing.Point(0, 0);
            this.polklinikHastaAdiLabel.Name = "polklinikHastaAdiLabel";
            this.polklinikHastaAdiLabel.Size = new System.Drawing.Size(1158, 599);
            this.polklinikHastaAdiLabel.TabIndex = 0;
            this.polklinikHastaAdiLabel.Text = "HASTA ADI";
            this.polklinikHastaAdiLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DoktorHastaKabulEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1158, 599);
            this.Controls.Add(this.polklinikHastaAdiLabel);
            this.Name = "DoktorHastaKabulEkrani";
            this.Text = "DoktorHastaKabulEkranı";
            this.Load += new System.EventHandler(this.DoktorHastaKabulEkranı_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label polklinikHastaAdiLabel;
    }
}