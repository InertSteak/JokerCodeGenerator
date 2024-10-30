namespace PokemonCodeGenerator
{
    partial class Calculate
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
            this.includeCalculate = new System.Windows.Forms.CheckBox();
            this.scoringBox = new System.Windows.Forms.CheckedListBox();
            this.includeScoring = new System.Windows.Forms.CheckBox();
            this.includeIndividual = new System.Windows.Forms.CheckBox();
            this.individualBox = new System.Windows.Forms.CheckedListBox();
            this.includeRepetition = new System.Windows.Forms.CheckBox();
            this.repetitionBox = new System.Windows.Forms.CheckedListBox();
            this.excludeEndr = new System.Windows.Forms.CheckBox();
            this.excludeEndi = new System.Windows.Forms.CheckBox();
            this.includeEnd = new System.Windows.Forms.CheckBox();
            this.endBox = new System.Windows.Forms.CheckedListBox();
            this.includeEvolution = new System.Windows.Forms.CheckBox();
            this.evolveBox = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.EvolutionName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // includeCalculate
            // 
            this.includeCalculate.AutoSize = true;
            this.includeCalculate.Checked = true;
            this.includeCalculate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.includeCalculate.Location = new System.Drawing.Point(13, 13);
            this.includeCalculate.Name = "includeCalculate";
            this.includeCalculate.Size = new System.Drawing.Size(158, 17);
            this.includeCalculate.TabIndex = 0;
            this.includeCalculate.Text = "Include Calculate Function?";
            this.includeCalculate.UseVisualStyleBackColor = true;
            // 
            // scoringBox
            // 
            this.scoringBox.FormattingEnabled = true;
            this.scoringBox.Items.AddRange(new object[] {
            "Before",
            "Joker Main",
            "After"});
            this.scoringBox.Location = new System.Drawing.Point(13, 72);
            this.scoringBox.Name = "scoringBox";
            this.scoringBox.Size = new System.Drawing.Size(120, 49);
            this.scoringBox.TabIndex = 1;
            // 
            // includeScoring
            // 
            this.includeScoring.AutoSize = true;
            this.includeScoring.Location = new System.Drawing.Point(13, 49);
            this.includeScoring.Name = "includeScoring";
            this.includeScoring.Size = new System.Drawing.Size(175, 17);
            this.includeScoring.TabIndex = 2;
            this.includeScoring.Text = "Include Joker in Scoring Hand?";
            this.includeScoring.UseVisualStyleBackColor = true;
            // 
            // includeIndividual
            // 
            this.includeIndividual.AutoSize = true;
            this.includeIndividual.Location = new System.Drawing.Point(12, 127);
            this.includeIndividual.Name = "includeIndividual";
            this.includeIndividual.Size = new System.Drawing.Size(115, 17);
            this.includeIndividual.TabIndex = 3;
            this.includeIndividual.Text = "Include Individual?";
            this.includeIndividual.UseVisualStyleBackColor = true;
            // 
            // individualBox
            // 
            this.individualBox.FormattingEnabled = true;
            this.individualBox.Items.AddRange(new object[] {
            "Play",
            "Hand"});
            this.individualBox.Location = new System.Drawing.Point(13, 150);
            this.individualBox.Name = "individualBox";
            this.individualBox.Size = new System.Drawing.Size(120, 34);
            this.individualBox.TabIndex = 4;
            // 
            // includeRepetition
            // 
            this.includeRepetition.AutoSize = true;
            this.includeRepetition.Location = new System.Drawing.Point(12, 199);
            this.includeRepetition.Name = "includeRepetition";
            this.includeRepetition.Size = new System.Drawing.Size(118, 17);
            this.includeRepetition.TabIndex = 5;
            this.includeRepetition.Text = "Include Repetition?";
            this.includeRepetition.UseVisualStyleBackColor = true;
            // 
            // repetitionBox
            // 
            this.repetitionBox.FormattingEnabled = true;
            this.repetitionBox.Items.AddRange(new object[] {
            "Play",
            "Hand"});
            this.repetitionBox.Location = new System.Drawing.Point(12, 222);
            this.repetitionBox.Name = "repetitionBox";
            this.repetitionBox.Size = new System.Drawing.Size(121, 34);
            this.repetitionBox.TabIndex = 6;
            // 
            // excludeEndr
            // 
            this.excludeEndr.AutoSize = true;
            this.excludeEndr.Checked = true;
            this.excludeEndr.CheckState = System.Windows.Forms.CheckState.Checked;
            this.excludeEndr.Location = new System.Drawing.Point(136, 199);
            this.excludeEndr.Name = "excludeEndr";
            this.excludeEndr.Size = new System.Drawing.Size(139, 17);
            this.excludeEndr.TabIndex = 7;
            this.excludeEndr.Text = "Exclude End of Round?";
            this.excludeEndr.UseVisualStyleBackColor = true;
            // 
            // excludeEndi
            // 
            this.excludeEndi.AutoSize = true;
            this.excludeEndi.Checked = true;
            this.excludeEndi.CheckState = System.Windows.Forms.CheckState.Checked;
            this.excludeEndi.Location = new System.Drawing.Point(136, 127);
            this.excludeEndi.Name = "excludeEndi";
            this.excludeEndi.Size = new System.Drawing.Size(139, 17);
            this.excludeEndi.TabIndex = 8;
            this.excludeEndi.Text = "Exclude End of Round?";
            this.excludeEndi.UseVisualStyleBackColor = true;
            // 
            // includeEnd
            // 
            this.includeEnd.AutoSize = true;
            this.includeEnd.Location = new System.Drawing.Point(12, 275);
            this.includeEnd.Name = "includeEnd";
            this.includeEnd.Size = new System.Drawing.Size(136, 17);
            this.includeEnd.TabIndex = 9;
            this.includeEnd.Text = "Include End of Round?";
            this.includeEnd.UseVisualStyleBackColor = true;
            this.includeEnd.CheckedChanged += new System.EventHandler(this.includeEnd_CheckedChanged);
            // 
            // endBox
            // 
            this.endBox.FormattingEnabled = true;
            this.endBox.Items.AddRange(new object[] {
            "Exclude Individual",
            "Exclude Repetition"});
            this.endBox.Location = new System.Drawing.Point(12, 298);
            this.endBox.Name = "endBox";
            this.endBox.Size = new System.Drawing.Size(136, 34);
            this.endBox.TabIndex = 10;
            // 
            // includeEvolution
            // 
            this.includeEvolution.AutoSize = true;
            this.includeEvolution.Location = new System.Drawing.Point(293, 49);
            this.includeEvolution.Name = "includeEvolution";
            this.includeEvolution.Size = new System.Drawing.Size(76, 17);
            this.includeEvolution.TabIndex = 11;
            this.includeEvolution.Text = "Evolution?";
            this.includeEvolution.UseVisualStyleBackColor = true;
            // 
            // evolveBox
            // 
            this.evolveBox.FormattingEnabled = true;
            this.evolveBox.Items.AddRange(new object[] {
            "Level",
            "Item",
            "Scaling",
            "Type"});
            this.evolveBox.Location = new System.Drawing.Point(293, 72);
            this.evolveBox.Name = "evolveBox";
            this.evolveBox.Size = new System.Drawing.Size(120, 64);
            this.evolveBox.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(422, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Name";
            // 
            // EvolutionName
            // 
            this.EvolutionName.Location = new System.Drawing.Point(464, 49);
            this.EvolutionName.Name = "EvolutionName";
            this.EvolutionName.Size = new System.Drawing.Size(157, 20);
            this.EvolutionName.TabIndex = 14;
            this.EvolutionName.Text = "Ivysaur";
            // 
            // Calculate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EvolutionName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.evolveBox);
            this.Controls.Add(this.includeEvolution);
            this.Controls.Add(this.endBox);
            this.Controls.Add(this.includeEnd);
            this.Controls.Add(this.excludeEndi);
            this.Controls.Add(this.excludeEndr);
            this.Controls.Add(this.repetitionBox);
            this.Controls.Add(this.includeRepetition);
            this.Controls.Add(this.individualBox);
            this.Controls.Add(this.includeIndividual);
            this.Controls.Add(this.includeScoring);
            this.Controls.Add(this.scoringBox);
            this.Controls.Add(this.includeCalculate);
            this.Name = "Calculate";
            this.Text = "Calculate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.CheckBox includeCalculate;
        public System.Windows.Forms.CheckedListBox scoringBox;
        public System.Windows.Forms.CheckBox includeScoring;
        public System.Windows.Forms.CheckBox includeIndividual;
        public System.Windows.Forms.CheckedListBox individualBox;
        public System.Windows.Forms.CheckBox includeRepetition;
        public System.Windows.Forms.CheckedListBox repetitionBox;
        public System.Windows.Forms.CheckBox excludeEndr;
        public System.Windows.Forms.CheckBox excludeEndi;
        public System.Windows.Forms.CheckBox includeEnd;
        public System.Windows.Forms.CheckedListBox endBox;
        public System.Windows.Forms.CheckBox includeEvolution;
        public System.Windows.Forms.CheckedListBox evolveBox;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox EvolutionName;
    }
}