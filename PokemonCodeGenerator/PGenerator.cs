﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PokemonCodeGenerator
{
    public partial class PGenerator : Form
    {
        public PokeTextWin ptext = new PokeTextWin();
        public Jvars jvar;
        public Calculate cal = new Calculate();
        public PGenerator()
        {
            this.jvar = new Jvars(ptext);
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pokename = PokemonName.Text;
            String line, directory;
            string[] contents;
            string[] newcontents;
            List<string> contentslist;
            Boolean modify = false;
            StreamReader sr;
            Generator generator = new Generator(this, jvar, ptext, cal);
            directory = $@"{Directory.Text}";
            string[] files = System.IO.Directory.GetFiles(directory);
            Console.WriteLine(files.Length);
            for (int i = 0; i < files.Length; i++)
            {
                sr = new StreamReader(files[i]);
                try
                {
                    line = sr.ReadLine();
                    while (line != null)
                    {
                        if (line.Contains("-- " + pokename) && (pokename.Length > 0))
                        {
                            Console.WriteLine(Path.GetFileName(files[i]));
                            modify = true;
                        }
                        if (modify) break;
                        //Read the next line
                        line = sr.ReadLine();
                    }
                    sr.Close();
                    if (modify)
                    {
                        contents = File.ReadAllLines(files[i]);
                        contentslist = contents.ToList(); 
                        for (int j = 0; j < contentslist.Count; j++)
                        {
                            if (contentslist[j].Contains("-- " + pokename))
                            {
                                contentslist.Insert(j+1, generator.createCode());
                            }
                        }
                        newcontents = contentslist.ToArray();
                        File.WriteAllLines(files[i], newcontents);
                        Console.WriteLine("Done");
                        break;
                    }
                }
                catch (Exception caughexpection)
                {
                    Console.WriteLine("Exception: " + caughexpection.Message);
                }
            }
            written_label.Text = "Written";
            written_label.ForeColor = Color.Green;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Generator generator = new Generator(this, jvar, ptext, cal);
            Preview.Text = generator.createCode();
            written_label.Text = "Not Written";
            written_label.ForeColor = Color.Red;
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void varButton_Click(object sender, EventArgs e)
        {
            jvar.ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            ptext.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cost.Value = 5 + (1 * Rarity.SelectedIndex);
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void copyClip_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Preview.Text))
            {
                Clipboard.SetText(Preview.Text);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cal.ShowDialog();
        }

        private void PGenerator_Load(object sender, EventArgs e)
        {

        }

        private void noPoke_CheckedChanged(object sender, EventArgs e)
        {
            if (noPoke.Checked == true)
            {
                RequireItem.Enabled = false;
                Item.Enabled = false;
                Stage.Enabled = false;
                Type.Enabled = false;
            }
            else
            {
                RequireItem.Enabled = true;
                Item.Enabled = true;
                Stage.Enabled = true;
                Type.Enabled = true;
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
