namespace RadioButtonlaTecrübeSiralama
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
            lblAd = new Label();
            lblSoyad = new Label();
            txtAdi = new TextBox();
            txtSoyadi = new TextBox();
            rdbtnTecrubeli = new RadioButton();
            rdnbtnOnTecrube = new RadioButton();
            btnTecrubeGoster = new Button();
            SuspendLayout();
            // 
            // lblAd
            // 
            lblAd.AutoSize = true;
            lblAd.Location = new Point(203, 104);
            lblAd.Name = "lblAd";
            lblAd.Size = new Size(28, 20);
            lblAd.TabIndex = 0;
            lblAd.Text = "Ad";
            // 
            // lblSoyad
            // 
            lblSoyad.AutoSize = true;
            lblSoyad.Location = new Point(203, 149);
            lblSoyad.Name = "lblSoyad";
            lblSoyad.Size = new Size(50, 20);
            lblSoyad.TabIndex = 1;
            lblSoyad.Text = "Soyad";
            // 
            // txtAdi
            // 
            txtAdi.Location = new Point(373, 92);
            txtAdi.Name = "txtAdi";
            txtAdi.Size = new Size(141, 27);
            txtAdi.TabIndex = 2;
            // 
            // txtSoyadi
            // 
            txtSoyadi.Location = new Point(375, 158);
            txtSoyadi.Name = "txtSoyadi";
            txtSoyadi.Size = new Size(145, 27);
            txtSoyadi.TabIndex = 3;
            // 
            // rdbtnTecrubeli
            // 
            rdbtnTecrubeli.AutoSize = true;
            rdbtnTecrubeli.Location = new Point(254, 220);
            rdbtnTecrubeli.Name = "rdbtnTecrubeli";
            rdbtnTecrubeli.Size = new Size(127, 24);
            rdbtnTecrubeli.TabIndex = 4;
            rdbtnTecrubeli.TabStop = true;
            rdbtnTecrubeli.Text = "0-5 yıl Tecrube";
            rdbtnTecrubeli.UseVisualStyleBackColor = true;
            // 
            // rdnbtnOnTecrube
            // 
            rdnbtnOnTecrube.AutoSize = true;
            rdnbtnOnTecrube.Location = new Point(254, 262);
            rdnbtnOnTecrube.Name = "rdnbtnOnTecrube";
            rdnbtnOnTecrube.Size = new Size(110, 24);
            rdnbtnOnTecrube.TabIndex = 5;
            rdnbtnOnTecrube.TabStop = true;
            rdnbtnOnTecrube.Text = "10+ tecrube";
            rdnbtnOnTecrube.UseVisualStyleBackColor = true;
            // 
            // btnTecrubeGoster
            // 
            btnTecrubeGoster.Location = new Point(540, 294);
            btnTecrubeGoster.Name = "btnTecrubeGoster";
            btnTecrubeGoster.Size = new Size(127, 44);
            btnTecrubeGoster.TabIndex = 6;
            btnTecrubeGoster.Text = "Tecrube Goster";
            btnTecrubeGoster.UseVisualStyleBackColor = true;
            btnTecrubeGoster.Click += btnTecrubeGoster_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnTecrubeGoster);
            Controls.Add(rdnbtnOnTecrube);
            Controls.Add(rdbtnTecrubeli);
            Controls.Add(txtSoyadi);
            Controls.Add(txtAdi);
            Controls.Add(lblSoyad);
            Controls.Add(lblAd);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAd;
        private Label lblSoyad;
        private TextBox txtAdi;
        private TextBox txtSoyadi;
        private RadioButton rdbtnTecrubeli;
        private RadioButton rdnbtnOnTecrube;
        private Button btnTecrubeGoster;
    }
}
