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
    public partial class Jvars : Form
    {
        public PokeTextWin pokeText;
        public int checkedCounter = 0;
        public Jvars(PokeTextWin pokeText)
        {
            InitializeComponent();
            this.pokeText = pokeText;
        }

        private void Mult_ValueChanged(object sender, EventArgs e)
        {

        }

        private void includeMult_CheckedChanged(object sender, EventArgs e)
        {
            if (includeMult.Checked == true)
            {
                checkedCounter++;
            }
            else
            {
                checkedCounter--;
            }
        }
        private void includeMultMod_CheckedChanged(object sender, EventArgs e)
        {
            if (includeMultMod.Checked == true)
            {
                checkedCounter++;
            }
            else
            {
                checkedCounter--;
            }
        }

        private void includeChips_CheckedChanged(object sender, EventArgs e)
        {
            if (includeChips.Checked == true)
            {
                checkedCounter++;
            }
            else
            {
                checkedCounter--;
            }
        }

        private void includeChipMod_CheckedChanged(object sender, EventArgs e)
        {
            if (includeChipMod.Checked == true)
            {
                checkedCounter++;
            }
            else
            {
                checkedCounter--;
            }
        }

        private void includeXmult_CheckedChanged(object sender, EventArgs e)
        {
            if (includeXmult.Checked == true)
            {
                checkedCounter++;
            }
            else
            {
                checkedCounter--;
            }
        }

        private void includeXmultMod_CheckedChanged(object sender, EventArgs e)
        {
            if (includeXmultMod.Checked == true)
            {
                checkedCounter++;
            }
            else
            {
                checkedCounter--;
            }
        }

        private void includeMoney_CheckedChanged(object sender, EventArgs e)
        {
            if (includeMoney.Checked == true)
            {
                checkedCounter++;
            }
            else
            {
                checkedCounter--;
            }
        }

        private void includeOdds_CheckedChanged(object sender, EventArgs e)
        {
            if (includeOdds.Checked == true)
            {
                checkedCounter++;
            }
            else
            {
                checkedCounter--;
            }
        }

        private void includeRetriggers_CheckedChanged(object sender, EventArgs e)
        {
            if (includeRetriggers.Checked == true)
            {
                checkedCounter++;
            }
            else
            {
                checkedCounter--;
            }
        }

        private void includeRounds_CheckedChanged(object sender, EventArgs e)
        {
            if (includeRounds.Checked == true)
            {
                pokeText.Text = pokeText.Text + "\n*Rounds";
                checkedCounter++;
            }
            else
            {
                checkedCounter--;
            }
        }

        private void Jvars_Load(object sender, EventArgs e)
        {

        }
    }
}
