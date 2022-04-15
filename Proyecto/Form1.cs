using System;
using MySqlConnector;
using System.Windows.Forms;


namespace Proyecto
{
    public partial class Login : Form
    {
        Menu m;
        MySqlConnection cnx;
        public Login(Menu menu)
        {
            InitializeComponent();
            m = menu;
            string cadena = "server=localhost;user=root;database=reg;port=3306;Contraseña=";
            cnx = new MySqlConnection(cadena);
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            cnx.Open();                       //tabla id_Usuarios=2
            string sql = "SELECT Usuario FROM usuarios WHERE   Usuario='" + txtUsuario.Text + "' and Contraseña='" + txtContraseña.Text + "'";
            MySqlCommand cmd = new MySqlCommand(sql, cnx);
            object result = cmd.ExecuteScalar();
            if (result != null)
            {
                m.Opacity = 1;
                m.ShowInTaskbar = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Checa tu Constraseña y tu Usuario");
                txtUsuario.Clear();
                txtContraseña.Clear();
            }
            cnx.Close();
        }


    }
}
