using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NumToText
{
    class NumToText
    {
        internal string ChangeNumToText(string Num)
        {
            string[] Groups;
            string[] GroupNames = { "", " thousand ", " million ", " billion ", " trillion ", " quadrillion ", " quintillion ", " sextillion ", " septillion ", " octillion ", " nonillion ", " decillion ", " undecillion ", " duodecillion ", " tredecillion ", " quattuordecillion ", " quindecillion ", " sexdecillion ", " septendecillion ", " octodecillion ", " novemdecillion ", " vigintillion ", " unvigintillion ", " duovigintillion ", " tresvigintillion ", " quattuorvigintillion ", " quinquavigintillion ", " sesvigintillion ", " septemvigintillion ", " octovigintillion ", " novemvigintillion ", " trigintillion ", " untrigintillion ", " duotrigintillion ", " trestrigintillion ", " quattuortrigintillion ", " quinquatrigintillion ", " sestrigintillion ", " septentrigintillion ", " octotrigintillion ", " novemtrigintillion ", " quadragintillion " };
            string textValue = string.Empty;

            Groups = SplitGroups(Num);
            for (int x = 0; x < Groups.Length; x++)
            {
                Groups[x] = ParsePart(Groups[x]);
            }

            for (int x = 0; x < Groups.Length; x++)
            {
                if (Groups[x] == "" & x > 0)
                {

                }
                else
                {
                    textValue = Groups[x] + GroupNames[x] + textValue;
                }
            }

            return textValue;
        }
        private string[] SplitGroups(string Num)
        {
            string[] Groups;
            int addCount;
            int currentGroup;

            Groups = new string[0];
            addCount = 0;

            if(Num.Length % 3 > 0) addCount = 1;

            Array.Resize(ref Groups, (Num.Length / 3) + addCount);

            currentGroup = 0;
            while (Num.Length > 0)
            {
                if (Num.Length < 3)
                {
                    Groups[currentGroup] = Num;
                    Num = "";
                }
                else
                {
                    Groups[currentGroup] = Num.Substring(Num.Length - 3, 3);
                    Num = Num.Substring(0, Num.Length - 3);
                }
                currentGroup++;
            }
            
            return Groups;

        }
        private string ParsePart(string Num)
        {
            Context context = new Context(Num);

            // Build the 'parse tree'
            List<Expression> tree = new List<Expression>();
            tree.Add(new OnesExpression());
            tree.Add(new TensExpression());
            tree.Add(new HundredsExpression());

            // Interpret
            foreach (Expression exp in tree)
            {
                exp.Interpret(context);
            }
            return context.Output; 
        }
    }
}
