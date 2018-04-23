namespace S134179 {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.captionBar1 = new S134179.CaptionBar();
            ((System.ComponentModel.ISupportInitialize)(this.captionBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Money Twins";
            // 
            // captionBar1
            // 
            this.captionBar1.AppearanceCaption.Font = new System.Drawing.Font("Comic Sans MS", 32F);
            this.captionBar1.AppearanceCaption.Options.UseFont = true;
            this.captionBar1.AppearanceCaption.Options.UseTextOptions = true;
            this.captionBar1.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.captionBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.captionBar1.Location = new System.Drawing.Point(0, 0);
            this.captionBar1.Name = "captionBar1";
            this.captionBar1.Size = new System.Drawing.Size(292, 67);
            this.captionBar1.TabIndex = 1;
            this.captionBar1.Text = "Dx Sample";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.captionBar1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.captionBar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private CaptionBar captionBar1;

    }
}

