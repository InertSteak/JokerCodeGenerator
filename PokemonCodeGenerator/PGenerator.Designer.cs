namespace PokemonCodeGenerator
{
    partial class PGenerator
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
            this.button1 = new System.Windows.Forms.Button();
            this.PokemonName = new System.Windows.Forms.TextBox();
            this.Preview = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.previewbutton = new System.Windows.Forms.Button();
            this.posx = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Xpos = new System.Windows.Forms.NumericUpDown();
            this.Ypos = new System.Windows.Forms.NumericUpDown();
            this.varButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Atlas = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Rarity = new System.Windows.Forms.ComboBox();
            this.Cost = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Stage = new System.Windows.Forms.ComboBox();
            this.Type = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Perishable = new System.Windows.Forms.CheckBox();
            this.Blueprint = new System.Windows.Forms.CheckBox();
            this.RequireItem = new System.Windows.Forms.CheckBox();
            this.Item = new System.Windows.Forms.ComboBox();
            this.ItemLabel = new System.Windows.Forms.Label();
            this.Calculate = new System.Windows.Forms.Button();
            this.Enhance = new System.Windows.Forms.ComboBox();
            this.labelEnhance = new System.Windows.Forms.Label();
            this.requireEnhance = new System.Windows.Forms.CheckBox();
            this.copyClip = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.Directory = new System.Windows.Forms.TextBox();
            this.Eternal = new System.Windows.Forms.CheckBox();
            this.AddDeck = new System.Windows.Forms.CheckBox();
            this.RemoveDeck = new System.Windows.Forms.CheckBox();
            this.noPoke = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.Xpos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ypos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cost)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(579, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Write To File";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PokemonName
            // 
            this.PokemonName.Location = new System.Drawing.Point(12, 21);
            this.PokemonName.Name = "PokemonName";
            this.PokemonName.Size = new System.Drawing.Size(158, 20);
            this.PokemonName.TabIndex = 1;
            this.PokemonName.Text = "Jimbo";
            // 
            // Preview
            // 
            this.Preview.Location = new System.Drawing.Point(360, 51);
            this.Preview.Multiline = true;
            this.Preview.Name = "Preview";
            this.Preview.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Preview.Size = new System.Drawing.Size(923, 392);
            this.Preview.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // previewbutton
            // 
            this.previewbutton.Location = new System.Drawing.Point(362, 21);
            this.previewbutton.Name = "previewbutton";
            this.previewbutton.Size = new System.Drawing.Size(75, 23);
            this.previewbutton.TabIndex = 5;
            this.previewbutton.Text = "Preview";
            this.previewbutton.UseVisualStyleBackColor = true;
            this.previewbutton.Click += new System.EventHandler(this.button2_Click);
            // 
            // posx
            // 
            this.posx.AutoSize = true;
            this.posx.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.posx.Location = new System.Drawing.Point(9, 54);
            this.posx.Name = "posx";
            this.posx.Size = new System.Drawing.Size(40, 13);
            this.posx.TabIndex = 6;
            this.posx.Text = "Pos X";
            this.posx.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Pos Y";
            // 
            // Xpos
            // 
            this.Xpos.Location = new System.Drawing.Point(50, 52);
            this.Xpos.Name = "Xpos";
            this.Xpos.Size = new System.Drawing.Size(120, 20);
            this.Xpos.TabIndex = 8;
            // 
            // Ypos
            // 
            this.Ypos.Location = new System.Drawing.Point(50, 78);
            this.Ypos.Name = "Ypos";
            this.Ypos.Size = new System.Drawing.Size(120, 20);
            this.Ypos.TabIndex = 9;
            // 
            // varButton
            // 
            this.varButton.Location = new System.Drawing.Point(186, 21);
            this.varButton.Name = "varButton";
            this.varButton.Size = new System.Drawing.Size(158, 23);
            this.varButton.TabIndex = 10;
            this.varButton.Text = "Extra Vars";
            this.varButton.UseVisualStyleBackColor = true;
            this.varButton.Click += new System.EventHandler(this.varButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Atlas";
            // 
            // Atlas
            // 
            this.Atlas.Location = new System.Drawing.Point(50, 108);
            this.Atlas.Name = "Atlas";
            this.Atlas.Size = new System.Drawing.Size(120, 20);
            this.Atlas.TabIndex = 12;
            this.Atlas.Text = "Pokedex1";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(186, 50);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(158, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Text";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Rarity";
            // 
            // Rarity
            // 
            this.Rarity.FormattingEnabled = true;
            this.Rarity.Items.AddRange(new object[] {
            "Common",
            "Uncommon",
            "Rare",
            "Safari"});
            this.Rarity.Location = new System.Drawing.Point(50, 135);
            this.Rarity.Name = "Rarity";
            this.Rarity.Size = new System.Drawing.Size(121, 21);
            this.Rarity.TabIndex = 15;
            this.Rarity.Text = "Common";
            this.Rarity.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Cost
            // 
            this.Cost.Location = new System.Drawing.Point(50, 162);
            this.Cost.Name = "Cost";
            this.Cost.Size = new System.Drawing.Size(120, 20);
            this.Cost.TabIndex = 16;
            this.Cost.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Cost";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Stage";
            // 
            // Stage
            // 
            this.Stage.FormattingEnabled = true;
            this.Stage.Items.AddRange(new object[] {
            "Baby",
            "Basic",
            "One",
            "Two",
            "Legendary"});
            this.Stage.Location = new System.Drawing.Point(49, 189);
            this.Stage.Name = "Stage";
            this.Stage.Size = new System.Drawing.Size(121, 21);
            this.Stage.TabIndex = 19;
            this.Stage.Text = "Basic";
            // 
            // Type
            // 
            this.Type.FormattingEnabled = true;
            this.Type.Items.AddRange(new object[] {
            "Grass",
            "Fire",
            "Water",
            "Lightning",
            "Psychic",
            "Fighting",
            "Colorless",
            "Dark",
            "Metal",
            "Fairy",
            "Dragon",
            "Earth"});
            this.Type.Location = new System.Drawing.Point(49, 216);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(121, 21);
            this.Type.TabIndex = 21;
            this.Type.Text = "Grass";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Type";
            // 
            // Perishable
            // 
            this.Perishable.AutoSize = true;
            this.Perishable.Checked = true;
            this.Perishable.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Perishable.Location = new System.Drawing.Point(12, 261);
            this.Perishable.Name = "Perishable";
            this.Perishable.Size = new System.Drawing.Size(136, 17);
            this.Perishable.TabIndex = 22;
            this.Perishable.Text = "Perishable Compatibility";
            this.Perishable.UseVisualStyleBackColor = true;
            // 
            // Blueprint
            // 
            this.Blueprint.AutoSize = true;
            this.Blueprint.Checked = true;
            this.Blueprint.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Blueprint.Location = new System.Drawing.Point(12, 284);
            this.Blueprint.Name = "Blueprint";
            this.Blueprint.Size = new System.Drawing.Size(128, 17);
            this.Blueprint.TabIndex = 23;
            this.Blueprint.Text = "Blueprint Compatibility";
            this.Blueprint.UseVisualStyleBackColor = true;
            // 
            // RequireItem
            // 
            this.RequireItem.AutoSize = true;
            this.RequireItem.Location = new System.Drawing.Point(12, 324);
            this.RequireItem.Name = "RequireItem";
            this.RequireItem.Size = new System.Drawing.Size(139, 17);
            this.RequireItem.TabIndex = 24;
            this.RequireItem.Text = "Require Item Evolution?";
            this.RequireItem.UseVisualStyleBackColor = true;
            // 
            // Item
            // 
            this.Item.FormattingEnabled = true;
            this.Item.Items.AddRange(new object[] {
            "Moon Stone",
            "Sun Stone",
            "Water Stone",
            "Leaf Stone",
            "Fire Stone",
            "Thunder Stone",
            "Linking Cord",
            "Kings Rock",
            "Upgrade",
            "Icestone",
            "Shinystone"});
            this.Item.Location = new System.Drawing.Point(49, 342);
            this.Item.Name = "Item";
            this.Item.Size = new System.Drawing.Size(121, 21);
            this.Item.TabIndex = 26;
            this.Item.Text = "Moon Stone";
            // 
            // ItemLabel
            // 
            this.ItemLabel.AutoSize = true;
            this.ItemLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemLabel.Location = new System.Drawing.Point(9, 344);
            this.ItemLabel.Name = "ItemLabel";
            this.ItemLabel.Size = new System.Drawing.Size(31, 13);
            this.ItemLabel.TabIndex = 25;
            this.ItemLabel.Text = "Item";
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(186, 80);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(158, 23);
            this.Calculate.TabIndex = 27;
            this.Calculate.Text = "Caculate";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.button3_Click);
            // 
            // Enhance
            // 
            this.Enhance.FormattingEnabled = true;
            this.Enhance.Items.AddRange(new object[] {
            "Mult",
            "Wild",
            "Bonus",
            "Stone",
            "Steel",
            "Glass",
            "Gold",
            "Lucky"});
            this.Enhance.Location = new System.Drawing.Point(49, 392);
            this.Enhance.Name = "Enhance";
            this.Enhance.Size = new System.Drawing.Size(121, 21);
            this.Enhance.TabIndex = 31;
            this.Enhance.Text = "Mult";
            this.Enhance.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // labelEnhance
            // 
            this.labelEnhance.AutoSize = true;
            this.labelEnhance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEnhance.Location = new System.Drawing.Point(9, 395);
            this.labelEnhance.Name = "labelEnhance";
            this.labelEnhance.Size = new System.Drawing.Size(34, 13);
            this.labelEnhance.TabIndex = 30;
            this.labelEnhance.Text = "Gate";
            this.labelEnhance.Click += new System.EventHandler(this.label9_Click);
            // 
            // requireEnhance
            // 
            this.requireEnhance.AutoSize = true;
            this.requireEnhance.Location = new System.Drawing.Point(13, 369);
            this.requireEnhance.Name = "requireEnhance";
            this.requireEnhance.Size = new System.Drawing.Size(138, 17);
            this.requireEnhance.TabIndex = 32;
            this.requireEnhance.Text = "Require Enhancement?";
            this.requireEnhance.UseVisualStyleBackColor = true;
            // 
            // copyClip
            // 
            this.copyClip.Location = new System.Drawing.Point(443, 22);
            this.copyClip.Name = "copyClip";
            this.copyClip.Size = new System.Drawing.Size(130, 23);
            this.copyClip.TabIndex = 33;
            this.copyClip.Text = "Copy To Clipboard";
            this.copyClip.UseVisualStyleBackColor = true;
            this.copyClip.Click += new System.EventHandler(this.copyClip_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(660, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 34;
            this.label9.Text = "Directory";
            // 
            // Directory
            // 
            this.Directory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Directory.Location = new System.Drawing.Point(724, 25);
            this.Directory.Name = "Directory";
            this.Directory.Size = new System.Drawing.Size(540, 20);
            this.Directory.TabIndex = 35;
            // 
            // Eternal
            // 
            this.Eternal.AutoSize = true;
            this.Eternal.Checked = true;
            this.Eternal.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Eternal.Location = new System.Drawing.Point(12, 304);
            this.Eternal.Name = "Eternal";
            this.Eternal.Size = new System.Drawing.Size(120, 17);
            this.Eternal.TabIndex = 36;
            this.Eternal.Text = "Eternal Compatibility";
            this.Eternal.UseVisualStyleBackColor = true;
            // 
            // AddDeck
            // 
            this.AddDeck.AutoSize = true;
            this.AddDeck.Location = new System.Drawing.Point(186, 111);
            this.AddDeck.Name = "AddDeck";
            this.AddDeck.Size = new System.Drawing.Size(92, 17);
            this.AddDeck.TabIndex = 37;
            this.AddDeck.Text = "Add to Deck?";
            this.AddDeck.UseVisualStyleBackColor = true;
            // 
            // RemoveDeck
            // 
            this.RemoveDeck.AutoSize = true;
            this.RemoveDeck.Location = new System.Drawing.Point(186, 137);
            this.RemoveDeck.Name = "RemoveDeck";
            this.RemoveDeck.Size = new System.Drawing.Size(127, 17);
            this.RemoveDeck.TabIndex = 38;
            this.RemoveDeck.Text = "Remove From Deck?";
            this.RemoveDeck.UseVisualStyleBackColor = true;
            // 
            // noPoke
            // 
            this.noPoke.AutoSize = true;
            this.noPoke.Location = new System.Drawing.Point(211, 426);
            this.noPoke.Name = "noPoke";
            this.noPoke.Size = new System.Drawing.Size(143, 17);
            this.noPoke.TabIndex = 39;
            this.noPoke.Text = "Disable Pokermon FIelds";
            this.noPoke.UseVisualStyleBackColor = true;
            this.noPoke.CheckedChanged += new System.EventHandler(this.noPoke_CheckedChanged);
            // 
            // PGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1295, 450);
            this.Controls.Add(this.noPoke);
            this.Controls.Add(this.RemoveDeck);
            this.Controls.Add(this.AddDeck);
            this.Controls.Add(this.Eternal);
            this.Controls.Add(this.Directory);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.copyClip);
            this.Controls.Add(this.requireEnhance);
            this.Controls.Add(this.Enhance);
            this.Controls.Add(this.labelEnhance);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.Item);
            this.Controls.Add(this.ItemLabel);
            this.Controls.Add(this.RequireItem);
            this.Controls.Add(this.Blueprint);
            this.Controls.Add(this.Perishable);
            this.Controls.Add(this.Type);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Stage);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Cost);
            this.Controls.Add(this.Rarity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Atlas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.varButton);
            this.Controls.Add(this.Ypos);
            this.Controls.Add(this.Xpos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.posx);
            this.Controls.Add(this.previewbutton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Preview);
            this.Controls.Add(this.PokemonName);
            this.Controls.Add(this.button1);
            this.Name = "PGenerator";
            this.Text = "Pokemon Code Generator";
            this.Load += new System.EventHandler(this.PGenerator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Xpos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ypos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cost)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button previewbutton;
        public System.Windows.Forms.TextBox PokemonName;
        public System.Windows.Forms.TextBox Preview;
        private System.Windows.Forms.Label posx;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.NumericUpDown Xpos;
        public System.Windows.Forms.NumericUpDown Ypos;
        private System.Windows.Forms.Button varButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label ItemLabel;
        public System.Windows.Forms.TextBox Atlas;
        public System.Windows.Forms.ComboBox Rarity;
        public System.Windows.Forms.NumericUpDown Cost;
        public System.Windows.Forms.ComboBox Stage;
        public System.Windows.Forms.ComboBox Type;
        public System.Windows.Forms.CheckBox Perishable;
        public System.Windows.Forms.CheckBox Blueprint;
        public System.Windows.Forms.CheckBox RequireItem;
        public System.Windows.Forms.ComboBox Item;
        private System.Windows.Forms.Button Calculate;
        public System.Windows.Forms.ComboBox Enhance;
        private System.Windows.Forms.Label labelEnhance;
        public System.Windows.Forms.CheckBox requireEnhance;
        private System.Windows.Forms.Button copyClip;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Directory;
        public System.Windows.Forms.CheckBox Eternal;
        public System.Windows.Forms.CheckBox AddDeck;
        public System.Windows.Forms.CheckBox RemoveDeck;
        public System.Windows.Forms.CheckBox noPoke;
    }
}

