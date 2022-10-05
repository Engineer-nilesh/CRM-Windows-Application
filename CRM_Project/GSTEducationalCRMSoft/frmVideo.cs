using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GSTEducationalCRMSoft
{
    public partial class frmVideo : Form
    {
        public frmVideo(string vid1)
        {
            InitializeComponent();

            axWindowsMediaPlayerVideo.URL = vid1;
        }
    }
}
