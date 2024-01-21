using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace sosya_medya
{
    public partial class RegisterForm : Form
    {
        SqlConnection baglanti;

        public RegisterForm()
        {
            InitializeComponent();
            baglanti = new SqlConnection(@"Data Source=DESKTOP-4D7MPRM\SQLEXPRESS;Initial Catalog=master;Integrated Security=True");
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO Kullanicilar (Kullanici_Adi, Ad, Soyad, Eposta, Sifre, Dogum_Tarihi, Cinsiyet) VALUES (@Kullanici_Adi, @Ad, @Soyad, @Eposta, @Sifre, @Dogum_Tarihi, @Cinsiyet)";

            using (SqlCommand command = new SqlCommand(query, baglanti))
            {
                command.Parameters.AddWithValue("@Kullanici_Adi", txtUsername.Text);
                command.Parameters.AddWithValue("@Ad", txtFirstName.Text);
                command.Parameters.AddWithValue("@Soyad", txtLastName.Text);
                command.Parameters.AddWithValue("@Eposta", txtEmail.Text);
                command.Parameters.AddWithValue("@Sifre", txtPassword.Text);
                command.Parameters.AddWithValue("@Dogum_Tarihi", dtBirthDate.Value);
                command.Parameters.AddWithValue("@Cinsiyet", cmbGender.SelectedItem.ToString());

                baglanti.Open();
                command.ExecuteNonQuery();
                baglanti.Close();
            }
        }
    }
}
