using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RHSkillEditor
{
    public partial class Readme : Form
    {
        public Readme()
        {
            InitializeComponent();
            readmeBox.Rtf = Properties.Resources.readme;
        }
    }
}
