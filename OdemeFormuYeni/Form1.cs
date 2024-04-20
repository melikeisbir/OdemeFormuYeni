using Microsoft.Data.SqlClient;

namespace OdemeFormuYeni
{
    public partial class Form1 : Form
    {
        string secilenOdemeYontemi;
        OdemeIslemi odemeIslemi = null;
        OdemeIslemiFactory factory;
        IOdemeTipi iOdemeTipi = null;
        string connectionString = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOdemeYap_Click(object sender, EventArgs e)
        {
            //reflection runtimeda tipi bilinmeyen classtan nesne olu�turma 
            if (secilenOdemeYontemi == "Se�iniz" || secilenOdemeYontemi == null)
            {
                MessageBox.Show("L�tfen bir �deme y�ntemi se�iniz");
            }
            else
            {
                {
                    if (txtTutar.Text.Length == 0)
                    {
                        MessageBox.Show("L�tfen bir tutar giriniz");
                    }
                    else
                    {
                        double tutar = Convert.ToDouble(txtTutar.Text);
                        factory = new OdemeIslemiFactory();
                        iOdemeTipi = factory.NesneOlustur(secilenOdemeYontemi);
                        odemeIslemi = new OdemeIslemi(iOdemeTipi);
                        lblSonuc.Text = odemeIslemi.Ode(tutar);
                    }
                }
            }
        }
        private void cmbOdemeYontemi_SelectedIndexChanged(object sender, EventArgs e)
        {
            secilenOdemeYontemi = cmbOdemeYontemi.SelectedValue.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OdemeTipiGetir();
        }
        public void OdemeTipiGetir()
        {
            connectionString = @"Data Source=MELI\SQLEXPRESS;Initial Catalog=TechCareer;Trusted_Connection=True; MultipleActiveResultSets=true; TrustServerCertificate=True;";
            List<OdemeTipi> odemeTipleri = null;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string sorgu = "select * from OdemeYontemi";
                    SqlCommand command = new SqlCommand(sorgu, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    odemeTipleri = new List<OdemeTipi>();
                    odemeTipleri.Add(new OdemeTipi
                    {
                        className = "",
                        displayName = "�deme Tipi Se�iniz"
                    });
                    while (reader.Read()) //kay�t oldu�u s�rece verileri okur
                    {
                        string classAdi = (string)reader["CLASS_NAME"];
                        string displayAdi = (string)reader["DISPLAY_NAME"];
                        odemeTipleri.Add(new OdemeTipi
                        {
                            className = classAdi,
                            displayName = displayAdi
                        });
                    }
                    connection.Close();
                    cmbOdemeYontemi.DataSource = odemeTipleri;
                    cmbOdemeYontemi.DisplayMember = "displayName";
                    cmbOdemeYontemi.ValueMember = "className";
                }
                catch (Exception ex) //sorunun neyden kaynakland��� yaz�lmal�
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }
    }
}



//double tutar = Convert.ToDouble(txtTutar.Text);
//if (secilenOdemeYontemi == "Kredi Kart�")
//{
//    KrediKarti krediKarti = new KrediKarti();
//    lblSonuc.Text= krediKarti.Ode(tutar);
//}
//else if(secilenOdemeYontemi =="Mail Order")
//{
//    MailOrder mailOrder = new MailOrder();
//    lblSonuc.Text = mailOrder.Ode(tutar);
//}