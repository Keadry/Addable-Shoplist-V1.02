
namespace Addable_Shoplist_V1._02
{
    partial class formAlisveris
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formAlisveris));
            this.btnEkleme = new System.Windows.Forms.Button();
            this.txtEkleme = new System.Windows.Forms.TextBox();
            this.lboxListe = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnEkleme
            // 
            this.btnEkleme.Location = new System.Drawing.Point(52, 251);
            this.btnEkleme.Name = "btnEkleme";
            this.btnEkleme.Size = new System.Drawing.Size(147, 29);
            this.btnEkleme.TabIndex = 0;
            this.btnEkleme.Text = "Eklemek İçin Tıklayınız.";
            this.btnEkleme.UseVisualStyleBackColor = true;
            this.btnEkleme.Click += new System.EventHandler(this.btnEkleme_Click);
            // 
            // txtEkleme
            // 
            this.txtEkleme.Location = new System.Drawing.Point(52, 222);
            this.txtEkleme.Name = "txtEkleme";
            this.txtEkleme.Size = new System.Drawing.Size(147, 23);
            this.txtEkleme.TabIndex = 1;
            // 
            // lboxListe
            // 
            this.lboxListe.FormattingEnabled = true;
            this.lboxListe.ItemHeight = 15;
            this.lboxListe.Location = new System.Drawing.Point(247, 54);
            this.lboxListe.Name = "lboxListe";
            this.lboxListe.Size = new System.Drawing.Size(164, 394);
            this.lboxListe.TabIndex = 2;
            // 
            // formAlisveris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(440, 499);
            this.Controls.Add(this.lboxListe);
            this.Controls.Add(this.txtEkleme);
            this.Controls.Add(this.btnEkleme);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formAlisveris";
            this.Text = "Alisveris Listesi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEkleme;
        private System.Windows.Forms.TextBox txtEkleme;
        private System.Windows.Forms.ListBox lboxListe;
    }
}

