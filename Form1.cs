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
                string versionInfo = client.DownloadString("");
                // Procesar la informaci�n de la versi�n
            }
        }
    }
}
