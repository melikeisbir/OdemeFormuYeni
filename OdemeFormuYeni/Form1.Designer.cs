namespace OdemeFormuYeni
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
            lblOdemeYontemi = new Label();
            cmbOdemeYontemi = new ComboBox();
            lblTutar = new Label();
            txtTutar = new TextBox();
            btnOdemeYap = new Button();
            lblSonuc = new Label();
            SuspendLayout();
            // 
            // lblOdemeYontemi
            // 
            lblOdemeYontemi.AutoSize = true;
            lblOdemeYontemi.Location = new Point(143, 80);
            lblOdemeYontemi.Name = "lblOdemeYontemi";
            lblOdemeYontemi.Size = new Size(93, 15);
            lblOdemeYontemi.TabIndex = 0;
            lblOdemeYontemi.Text = "Ödeme Yöntemi";
            // 
            // cmbOdemeYontemi
            // 
            cmbOdemeYontemi.FormattingEnabled = true;
            cmbOdemeYontemi.Items.AddRange(new object[] { "Seçiniz", "Kredi Kartı", "Mail Order", "Paypal", "Apple Pay" });
            cmbOdemeYontemi.Location = new Point(268, 80);
            cmbOdemeYontemi.Name = "cmbOdemeYontemi";
            cmbOdemeYontemi.Size = new Size(121, 23);
            cmbOdemeYontemi.TabIndex = 1;
            cmbOdemeYontemi.SelectedIndexChanged += cmbOdemeYontemi_SelectedIndexChanged;
            // 
            // lblTutar
            // 
            lblTutar.AutoSize = true;
            lblTutar.Location = new Point(143, 149);
            lblTutar.Name = "lblTutar";
            lblTutar.Size = new Size(37, 15);
            lblTutar.TabIndex = 2;
            lblTutar.Text = "Tutar:";
            // 
            // txtTutar
            // 
            txtTutar.Location = new Point(268, 141);
            txtTutar.Name = "txtTutar";
            txtTutar.Size = new Size(100, 23);
            txtTutar.TabIndex = 3;
            // 
            // btnOdemeYap
            // 
            btnOdemeYap.BackColor = SystemColors.ActiveCaption;
            btnOdemeYap.Location = new Point(268, 212);
            btnOdemeYap.Name = "btnOdemeYap";
            btnOdemeYap.Size = new Size(111, 37);
            btnOdemeYap.TabIndex = 4;
            btnOdemeYap.Text = "Ödeme Yap";
            btnOdemeYap.UseVisualStyleBackColor = false;
            btnOdemeYap.Click += btnOdemeYap_Click;
            // 
            // lblSonuc
            // 
            lblSonuc.AutoSize = true;
            lblSonuc.Location = new Point(143, 296);
            lblSonuc.Name = "lblSonuc";
            lblSonuc.Size = new Size(43, 15);
            lblSonuc.TabIndex = 5;
            lblSonuc.Text = "Sonuç:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblSonuc);
            Controls.Add(btnOdemeYap);
            Controls.Add(txtTutar);
            Controls.Add(lblTutar);
            Controls.Add(cmbOdemeYontemi);
            Controls.Add(lblOdemeYontemi);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblOdemeYontemi;
        private ComboBox cmbOdemeYontemi;
        private Label lblTutar;
        private TextBox txtTutar;
        private Button btnOdemeYap;
        private Label lblSonuc;
    }
}
