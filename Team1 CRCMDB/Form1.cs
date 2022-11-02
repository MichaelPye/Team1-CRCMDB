using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Team1_CRCMDB
{
    public partial class CRCMDBmainform : Form
    {
        public CRCMDBmainform()
        {
            InitializeComponent();
        }

        // Opens Up Movie Management Form
        private void ManageMoviesButton_Click(object sender, EventArgs e)
        {
            MovieForm MovForm = new MovieForm();
            MovForm.Show();

        }

    }
}
