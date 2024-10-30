using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokemonCodeGenerator
{
    public class Generator
    {
        PGenerator Form { get; set; }
        Jvars Jvars { get; set; }
        PokeTextWin  Ptext { get; set; }  

        Calculate Cal {  get; set; }

        int MultNum { get; set; }

        int MultModNum { get; set; }    

        int ChipsNum { get; set; }  

        int ChipsModNum { get; set; }   

        int XmultNum { get; set; }  

        int XmultModNum { get; set; }

        int MoneyNum {  get; set; }

        int OddsNum { get; set; }

        int RetriggersNum { get; set; }

        int RoundsNum { get; set; }

        public Generator(PGenerator mainForm, Jvars jVar, PokeTextWin pText, Calculate cal)
        {
            this.Form = mainForm;
            this.Jvars = jVar;
            this.Ptext = pText;
            this.Cal = cal;
        }
        public string createCode()
        {
            string master = "";
            Utils utils = new Utils();
            CodeLines[] codeArray = createCodeArray();
            for (int i = 0; i < codeArray.Length; i++)
            {
                master = utils.insertCodeLines(codeArray[i].Lines, master, codeArray[i].Indent);
            }
            
            return master;
        }

        public CodeLines[] createCodeArray()
        {
            string[] open = { "local " + Form.PokemonName.Text.ToLower() + "={"};
            string[] close = { "}" };
            CodeLines codeOpen = new CodeLines(open, 0);
            CodeLines codeClose = new CodeLines(close, 0);

            var masterCode = new List<CodeLines> { codeOpen };
            masterCode = masterCode.Concat(createVarArray()).ToList();
            masterCode = masterCode.Concat(createLocTextArray()).ToList();
            masterCode = masterCode.Concat(createLocVarArray()).ToList();
            masterCode = masterCode.Concat(createSecondVarArray()).ToList();
            if (Cal.includeCalculate.Checked)
            {
                masterCode = masterCode.Concat(createCalcArray()).ToList();
            }
            if (Form.AddDeck.Checked)
            {
                masterCode = masterCode.Concat(createAddToArray()).ToList();
            }
            if (Form.RemoveDeck.Checked)
            {
                masterCode = masterCode.Concat(createRemoveFromArray()).ToList();
            }
            masterCode.Add(codeClose);
            return masterCode.ToArray();
        }

        public List<CodeLines> createVarArray()
        {
            var initial = new List<string>
            {
                "name = \"" + Form.PokemonName.Text.ToLower() + "\",",
                "pos = {x = " + Form.Xpos.Value + ", y = " + Form.Ypos.Value + "},"
            };
            string config = "config = {extra = {";
            if (Jvars.includeMult.Checked)
            {
                config += "mult = " + Jvars.Mult.Value.ToString() + ",";
            }
            if (Jvars.includeMultMod.Checked)
            {
                config += "mult_mod = " + Jvars.MultMod.Value.ToString() + ",";
            }
            if (Jvars.includeChips.Checked)
            {
                config += "chips = " + Jvars.Chips.Value.ToString() + ",";
            }
            if (Jvars.includeChipMod.Checked)
            {
                config += "chip_mod = " + Jvars.ChipMod.Value.ToString() + ",";
            }
            if (Jvars.includeXmult.Checked)
            {
                config += "Xmult = " + Jvars.Xmult.Value.ToString() + ",";
            }
            if (Jvars.includeXmultMod.Checked)
            {
                config += "Xmult_mod = " + Jvars.XmultMod.Value.ToString() + ",";
            }
            if (Jvars.includeMoney.Checked)
            {
                config += "money = " + Jvars.Money.Value.ToString() + ",";
            }
            if (Jvars.includeOdds.Checked)
            {
                config += "odds = " + Jvars.Odds.Value.ToString() + ",";
            }
            if (Jvars.includeRetriggers.Checked)
            {
                config += "retriggers = " + Jvars.Retriggers.Value.ToString() + ",";
            }
            if (Jvars.includeRounds.Checked)
            {
                config += "rounds = " + Jvars.Rounds.Value.ToString() + ",";
            }
            config += "}},";
            initial.Add(config);
            CodeLines codeInit = new CodeLines(initial.ToArray(), 1);
            var varCode = new List<CodeLines> { codeInit };
            return varCode;
        }
        public List<CodeLines> createLocTextArray()
        {
            string[] convText = Ptext.PokeText.Lines;
            var initial = new List<string>
            {
                "loc_txt = {",
            };
            CodeLines codeInit = new CodeLines(initial.ToArray(), 1);

            var inner = new List<string>
            {
               "name = \"" + Form.PokemonName.Text + "\",",
               "text = {"
            };
            CodeLines codeInner = new CodeLines(inner.ToArray(), 2);

            for (int i = 0; i < convText.Length; i++)
            {
                convText[i] = "\"" + convText[i] + "\",";
                convText[i] = replaceAll(convText[i]);
            }

            List<string> text = new List<string>(convText);
            CodeLines codeText = new CodeLines(text.ToArray(), 3);

            var last = new List<string>
            {
                "},"
            };
            CodeLines codeLast = new CodeLines(last.ToArray(), 1);

            var varCode = new List<CodeLines> { codeInit, codeInner, codeText, codeLast };
            return varCode;
        }
        public List<CodeLines> createLocVarArray()
        {
            string retVars = "return {vars = {";
            string center = "center.ability.extra.";
            var initial = new List<string>
            {
                "loc_vars = function(self, info_queue, center)"
            };
            CodeLines codeInit = new CodeLines(initial.ToArray(), 1);

            var inner = new List<string>
            {
                "type_tooltip(self, info_queue, center)"
            };

            if (Jvars.includeMult.Checked)
            {
                retVars += center + "mult, ";
            }
            if (Jvars.includeMultMod.Checked)
            {
                retVars += center + "mult_mod, ";
            }
            if (Jvars.includeChips.Checked)
            {
                retVars += center + "chips, ";
            }
            if (Jvars.includeChipMod.Checked)
            {
                retVars += center + "chip_mod,";
            }
            if (Jvars.includeXmult.Checked)
            {
                retVars += center + "Xmult, ";
            }
            if (Jvars.includeXmultMod.Checked)
            {
                retVars += center + "Xmult_mod, ";
            }
            if (Jvars.includeMoney.Checked)
            {
                retVars += center + "money, ";
            }
            if (Jvars.includeOdds.Checked)
            {
                retVars += "\'\'..(G.GAME and G.GAME.probabilities.normal or 1), " + center + "odds, ";
            }
            if (Jvars.includeRetriggers.Checked)
            {
                retVars += center + "retriggers, ";
            }
            if (Jvars.includeRounds.Checked)
            {
                retVars += center + "rounds, ";
            }

            retVars += "}}";
            inner.Add(retVars);
            CodeLines codeInner = new CodeLines(inner.ToArray(), 2);

            var end = new List<string>
            {
                "end,"
            };
            CodeLines codeEnd = new CodeLines(end.ToArray(), 1);

            var varCode = new List<CodeLines> { codeInit, codeInner, codeEnd };
            return varCode;
        }
        public List<CodeLines> createSecondVarArray()
        {
            string rarity, cost, perish, blueprint, item, enhance, eternal;            
            var body = new List<string>();

            rarity = "rarity = ";
            rarity += Form.Rarity.SelectedItem.ToString() == "Common" ? "1" :
                Form.Rarity.SelectedItem.ToString() == "Uncommon" ? "2" :
                Form.Rarity.SelectedItem.ToString() == "Rare" ? "3" :
                "\"poke_safari\"";
            rarity += ",";
            body.Add(rarity);

            cost = "cost = " + Form.Cost.Value.ToString() + ",";
            body.Add(cost);

            if (Form.RequireItem.Checked)
            {
                item = Form.Item.SelectedItem.ToString().Replace(" ", "").ToLower(); ;
                body.Add("item_req = \"" + item + "\",");
            }

            if (Form.requireEnhance.Checked)
            {
                enhance = "m_" + Form.Enhance.SelectedItem.ToString().ToLower();
                body.Add("enhancement_gate = \"" + enhance + "\",");
            }

            body.Add("stage = \"" + Form.Stage.SelectedItem.ToString() + "\",");

            body.Add("ptype = \"" + Form.Type.SelectedItem.ToString() + "\",");

            body.Add("atlas = \"" + Form.Atlas.Text + "\",");

            perish = "perishable_compat = ";
            perish += Form.Perishable.Checked ? "true" : "false";
            perish += ",";
            body.Add(perish);

            blueprint = "blue_compat = ";
            blueprint += Form.Blueprint.Checked ? "true" : "false";
            blueprint += ",";
            body.Add(blueprint);

            eternal = "eternal_compat = ";
            eternal += Form.Eternal.Checked ? "true" : "false";
            eternal += ",";
            body.Add(eternal);

            CodeLines codeBody = new CodeLines(body.ToArray(), 1);

            var varCode = new List<CodeLines> { codeBody };
            return varCode;
        }
        public List<CodeLines> createCalcArray()
        {
            CodeLines codeScoringInner, codeIndividualInner, codeRepetitionInner, codeEndroundInner, codeEvolution;
            List<string> innerScoring = new List<string>();
            List<string> innerIndividual = new List<string>();
            List<string> innerRepetition = new List<string>();
            List<string> innerEndround = new List<string>();
            List<string> evolution = new List<string>();

            string individual, repetition, endround;

            string noblue = "and not context.blueprint ";
            string noEnd = "and not context.end_of_round ";

            //start of lines
            var initial = new List<string>
            {
                "calculate = function(self, card, context)"
            };
            CodeLines codeInit = new CodeLines(initial.ToArray(), 1);

            var end = new List<string>
            {
                "end,"
            };
            CodeLines codeEnd1 = new CodeLines(end.ToArray(), 1);
            CodeLines codeEnd2 = new CodeLines(end.ToArray(), 2);

            var scoringStart = new List<string>
            {
                "if context.cardarea == G.jokers and context.scoring_hand then",
            };
            CodeLines codeScoringStart = new CodeLines(scoringStart.ToArray(), 2);

            individual = "if context.individual " + (!Cal.excludeEndi.Checked ? "" : noEnd);
            individual += !Cal.individualBox.CheckedItems.Contains("Play") ? "" : "and context.cardarea == G.play ";
            individual += !Cal.individualBox.CheckedItems.Contains("Hand") ? "" : "and context.cardarea == G.hand ";
            var individualStart = new List<string>
            {
                individual + "then",
            };
            CodeLines codeIndividualStart = new CodeLines(individualStart.ToArray(), 2);

            repetition = "if context.repetition " + (!Cal.excludeEndr.Checked ? "" : noEnd);
            repetition += !Cal.repetitionBox.CheckedItems.Contains("Play") ? "" : "and context.cardarea == G.play ";
            repetition += !Cal.repetitionBox.CheckedItems.Contains("Hand") ? "" : "and context.cardarea == G.hand ";
            var repetitionStart = new List<string>
            {
                repetition + "then",
            };
            CodeLines codeRepetitionStart = new CodeLines(repetitionStart.ToArray(), 2);

            endround = "if context.end_of_round ";
            endround += !Cal.endBox.CheckedItems.Contains("Exclude Individual") ? "" : "and not context.individual ";
            endround += !Cal.endBox.CheckedItems.Contains("Exclude Repetition") ? "" : "and not context.repetition ";
            var endroundStart = new List<string>
            {
                endround + "then",
            };
            CodeLines codeEndroundStart = new CodeLines(endroundStart.ToArray(), 2);

            //Scoring
            var varCode = new List<CodeLines> { codeInit };
            if (Cal.includeScoring.Checked)
            {     
                varCode.Add(codeScoringStart);

                if (Cal.scoringBox.CheckedItems.Contains("Before"))
                {
                    innerScoring.Add("if context.before " + (Form.Blueprint.Checked ? "" : noblue) + "then");
                    innerScoring.Add("end,");
                }
                if (Cal.scoringBox.CheckedItems.Contains("Joker Main"))
                {
                    innerScoring.Add("if context.joker_main " + (Form.Blueprint.Checked ? "" : noblue) + "then");
                    innerScoring.Add("end,");
                }
                if (Cal.scoringBox.CheckedItems.Contains("After"))
                {
                    innerScoring.Add("if context.after " + (Form.Blueprint.Checked ? "" : noblue) + "then");
                    innerScoring.Add("end,");
                }

                if (innerScoring.Count > 0)
                {
                    codeScoringInner = new CodeLines(innerScoring.ToArray(), 3);
                    varCode.Add(codeScoringInner);
                }

                varCode.Add(codeEnd2);
            }
            //Individual
            if (Cal.includeIndividual.Checked)
            {
                varCode.Add(codeIndividualStart);
                varCode.Add(codeEnd2);
            }
            //Repetition
            if (Cal.includeRepetition.Checked)
            {
                varCode.Add(codeRepetitionStart);
                varCode.Add(codeEnd2);
            }
            //Endround
            if (Cal.includeEnd.Checked)
            {
                varCode.Add(codeEndroundStart);
                varCode.Add(codeEnd2);
            }

            //Evolution
            if (Cal.includeEvolution.Checked)
            {
                string key = "j_poke_" + Cal.EvolutionName.Text.ToLower(); 
                if (Cal.evolveBox.CheckedItems.Contains("Level"))
                {
                    evolution.Add($"return level_evo(self, card, context, \"{key}\")");
                }
                if (Cal.evolveBox.CheckedItems.Contains("Item"))
                {
                    evolution.Add($"return item_evo(self, card, context, \"{key}\")");
                }
                if (Cal.evolveBox.CheckedItems.Contains("Scaling"))
                {
                    evolution.Add($"return scaling_evo(self, card, context, \"{key}\", 0, 0)");
                }
                if (Cal.evolveBox.CheckedItems.Contains("Type"))
                {
                    evolution.Add($"return type_evo(self, card, context, \"{key}\", \"grass\")");
                }
                if (evolution.Count > 0 )
                {
                    codeEvolution = new CodeLines(evolution.ToArray(), 2);
                    varCode.Add(codeEvolution);
                }
            }

            varCode.Add(codeEnd1);
            return varCode;
        }

        public List<CodeLines> createAddToArray()
        {
            var initial = new List<string>
            {
                "add_to_deck = function(self, card, from_debuff)",
                "end,"
            };
            CodeLines codeInit = new CodeLines(initial.ToArray(), 1);

            var varCode = new List<CodeLines> { codeInit };
            return varCode;
        }

        public List<CodeLines> createRemoveFromArray()
        {
            var initial = new List<string>
            {
                "remove_from_deck = function(self, card, from_debuff)",
                "end,"
            };
            CodeLines codeInit = new CodeLines(initial.ToArray(), 1);

            var varCode = new List<CodeLines> { codeInit };
            return varCode;
        }

        public string replaceAll(string toReplace)
        {
            int count = 1;
            if (Jvars.includeMult.Checked)
            {
                if (MultNum == 0) { MultNum = count; }
                toReplace = toReplace.Replace("*Mult", "{C:mult}+#" + count.ToString() + "#{} Mult");
                toReplace = toReplace.Replace("~Mult", "{C:mult}+#" + count.ToString() + "#{C:inactive} Mult");
                count++;
            }
            if (Jvars.includeMultMod.Checked)
            {
                if (MultModNum == 0) { MultModNum = count; }
                toReplace = toReplace.Replace("*ModMult", "{C:mult}+#" + count.ToString() + "#{} Mult");
                count++;
            }
            if (Jvars.includeChips.Checked)
            {
                if (ChipsNum == 0) { ChipsNum = count; }
                toReplace = toReplace.Replace("*Chips", "{C:chips}+#" + count.ToString() + "#{} Chips");
                toReplace = toReplace.Replace("~Chips", "{C:chips}+#" + count.ToString() + "#{C:inactive} Chips");
                count++; 
            }
            if (Jvars.includeChipMod.Checked)
            {
                if (ChipsModNum == 0) { ChipsModNum = count; }
                toReplace = toReplace.Replace("*ModChip", "{C:chips}+#" + count.ToString() + "#{} Chips");
                count++;
            }
            if (Jvars.includeXmult.Checked)
            {
                if (XmultNum == 0) { XmultNum = count; }
                toReplace = toReplace.Replace("*Xmult", "{X:red,C:white}X#" + count.ToString() + "#{} Mult");
                toReplace = toReplace.Replace("~Xmult", "{X:red,C:white}X#" + count.ToString() + "#{C:inactive} Mult");
                count++;
            }
            if (Jvars.includeXmultMod.Checked)
            {
                if (XmultModNum == 0) { XmultModNum = count; }
                toReplace = toReplace.Replace("*ModXmult", "{X:red,C:white}X#" + count.ToString() + "#{} Mult");
                count++;
            }
            if (Jvars.includeMoney.Checked)
            {
                if (MoneyNum == 0) { MoneyNum = count; }
                toReplace = toReplace.Replace("*Money", "{C:money}$#" + count.ToString() + "#{}");
                toReplace = toReplace.Replace("~Money", "{C:money}$#" + count.ToString() + "#{C:inactive}");
                count++;
            }
            if (Jvars.includeOdds.Checked)
            {
                if (OddsNum == 0) { OddsNum = count; }
                toReplace = toReplace.Replace("*Odds", "{C: green}#" + (count + 1).ToString() + "# in #" + count.ToString() + "#{}");
                count += 2;
            }
            if (Jvars.includeRetriggers.Checked)
            {
                if (RetriggersNum == 0) { RetriggersNum = count; }
                toReplace = toReplace.Replace("*Retrigger", "{C:attention}#" + count.ToString() + "#{} times");
                count++;
            }
            if (Jvars.includeRounds.Checked)
            {
                if (RoundsNum == 0) { RoundsNum = count; }
                toReplace = toReplace.Replace("*Rounds", "{C:inactive}(Evolves after {C:attention}#" + count.ToString() + "#{C:inactive} rounds)");
                count++;
            }
            return toReplace;
        }
    }
}
