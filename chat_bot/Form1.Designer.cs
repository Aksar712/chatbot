namespace chat_bot
{
    partial class Form1
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
            txtKonusmaGecmisi = new TextBox();
            txtKullaniciGirdisi = new TextBox();
            btnGonder = new Button();
            SuspendLayout();
            // 
            // txtKonusmaGecmisi
            // 
            txtKonusmaGecmisi.BorderStyle = BorderStyle.FixedSingle;
            txtKonusmaGecmisi.Location = new Point(188, 40);
            txtKonusmaGecmisi.Multiline = true;
            txtKonusmaGecmisi.Name = "txtKonusmaGecmisi";
            txtKonusmaGecmisi.ScrollBars = ScrollBars.Horizontal;
            txtKonusmaGecmisi.Size = new Size(335, 239);
            txtKonusmaGecmisi.TabIndex = 0;
            // 
            // txtKullaniciGirdisi
            // 
            txtKullaniciGirdisi.Location = new Point(188, 286);
            txtKullaniciGirdisi.Multiline = true;
            txtKullaniciGirdisi.Name = "txtKullaniciGirdisi";
            txtKullaniciGirdisi.Size = new Size(269, 23);
            txtKullaniciGirdisi.TabIndex = 1;
            // 
            // btnGonder
            // 
            btnGonder.Location = new Point(463, 286);
            btnGonder.Name = "btnGonder";
            btnGonder.Size = new Size(60, 23);
            btnGonder.TabIndex = 2;
            btnGonder.Text = "Gönder";
            btnGonder.UseVisualStyleBackColor = true;
            btnGonder.Click += btnGonder_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGonder);
            Controls.Add(txtKullaniciGirdisi);
            Controls.Add(txtKonusmaGecmisi);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtKonusmaGecmisi;
        private TextBox txtKullaniciGirdisi;
        private Button btnGonder;
    }
}
