using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chibrite_Sarkozi_Samuel
{
    public partial class Generic : Form
    {
        public Generic()
        {
            InitializeComponent();
        }

        private void Generic_MouseClick(object sender, MouseEventArgs e)
        {
            ActiveForm.Close();
        }
    }
}
