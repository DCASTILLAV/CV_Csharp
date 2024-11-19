using System.Net;

namespace Prueba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (WebClient client = new WebClient())
            {
                string versionInfo = client.DownloadString("https://github.com/DCASTILLAV/CV_Csharp/tree/master/pubicacion/version.json");
                // Procesar la información de la versión

                client.DownloadFile("https://github.com/DCASTILLAV/CV_Csharp/tree/master/pubicacion/Designer.exe", "D:/Descargas/");
                MessageBox.Show("se descargo la aplicacion de forma correcta");
            }
        }
    }
}
