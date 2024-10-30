using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokemonCodeGenerator
{
    public partial class Calculate : Form
    {
        public Calculate()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void includeEnd_CheckedChanged(object sender, EventArgs e)
        {
            Boolean checkstate;
            if (includeEnd.Checked == true)
            {
                checkstate = true;
            }
            else
            {
                checkstate = false;
            }

            for (int i = 0; i < endBox.Items.Count; i++)
            {
                endBox.SetItemChecked(i, checkstate);
            }
        }
    }
}
