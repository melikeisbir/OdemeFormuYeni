namespace OdemeFormuYeni
{
    public partial class Form1 : Form
    {
        string secilenOdemeYontemi;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOdemeYap_Click(object sender, EventArgs e)
        {
            //reflection runtimeda tipi bilinmeyen classtan nesne oluþturma 
            double tutar = Convert.ToDouble(txtTutar.Text);
            if (secilenOdemeYontemi == "Kredi Kartý")
            {
                KrediKarti krediKarti = new KrediKarti();
                lblSonuc.Text= krediKarti.Ode(tutar);
            }
            else if(secilenOdemeYontemi =="Mail Order")
            {
                MailOrder mailOrder = new MailOrder();
                lblSonuc.Text = mailOrder.Ode(tutar);
            }
        }
        private void cmbOdemeYontemi_SelectedIndexChanged(object sender, EventArgs e)
        {
            secilenOdemeYontemi = cmbOdemeYontemi.SelectedItem.ToString();
        }
    }
}
