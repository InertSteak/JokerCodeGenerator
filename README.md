# Joker CodeGenerator
This is a simple tool for generating Steamodded api based Joker code. I made it to help myself with my Pokermon mod, but it is general enough to be used by any Steamodded mod.

Everything should be pretty straightforward, but the Text field has some special replacement logic. 

Use *Mult in the text window and it will be replaced with a Balatro var reference and color wrapper
Use *ModMult for Mult Mod
The pattern repeates for each variable (*Chips, *ModChip, etc)
You can also use -Mult and -MultMod to be replaced within a reminder text line
