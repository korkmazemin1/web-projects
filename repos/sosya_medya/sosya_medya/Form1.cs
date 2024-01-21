Microsoft.Data.SqlClient;
namespace sosya_medya
{
    public partial class Form1 : Form
    {

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-4D7MPRM\SQLEXPRESS;Initial Catalog=master;Integrated Security=True")
        public Form1()

        {
            InitializeComponent();
        }
    }
}