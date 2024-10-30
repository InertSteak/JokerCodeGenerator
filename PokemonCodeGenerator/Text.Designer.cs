namespace PokemonCodeGenerator
{
    partial class PokeTextWin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PokeText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // PokeText
            // 
            this.PokeText.Location = new System.Drawing.Point(12, 12);
            this.PokeText.Multiline = true;
            this.PokeText.Name = "PokeText";
            this.PokeText.Size = new System.Drawing.Size(258, 286);
            this.PokeText.TabIndex = 1;
            this.PokeText.Text = "Pokemon Text Goes Here";
            this.PokeText.TextChanged += new System.EventHandler(this.PokeText_TextChanged);
            // 
            // PokeTextWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 308);
            this.Controls.Add(this.PokeText);
            this.Name = "PokeTextWin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox PokeText;
    }
}