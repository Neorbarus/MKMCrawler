using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MKMCrawler
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void actualizarBaseDeDatosMenuSuperior_Click(object sender, EventArgs e)
        {
            RequestHelper requestHelper = new RequestHelper();
            requestHelper.makeRequest("https://www.mkmapi.eu/ws/v1.1/expansion/1/");
        }
    }
}
