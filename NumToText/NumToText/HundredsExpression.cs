using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NumToText
{
    class HundredsExpression : Expression
    {
        public override void Interpret(Context context)
        {
            if (context.Input.Length == 0)
                return;
            else if (context.Input.EndsWith(Zero()))
            {
                context.Output += "";
                context.Input = context.Input.Substring(0, context.Input.Length - 1);
            }
            else if (context.Input.EndsWith(One()))
            {
                if (context.Output.Length == 0)
                {
                    context.Output = "one hundred";
                }
                else
                {
                    context.Output = "one hundred " + context.Output;
                }
                context.Input = context.Input.Substring(0, context.Input.Length - 1);
            }
            else if (context.Input.EndsWith(Two()))
            {
                if (context.Output.Length == 0)
                {
                    context.Output = "two hundred";
                }
                else
                {
                    context.Output = "two hundred " + context.Output;
                }
                context.Input = context.Input.Substring(0, context.Input.Length - 1);
            }
            else if (context.Input.EndsWith(Three()))
            {
                if (context.Output.Length == 0)
                {
                    context.Output = "three hundred";
                }
                else
                {
                    context.Output = "three hundred " + context.Output;
                }
                context.Input = context.Input.Substring(0, context.Input.Length - 1);
            }
            else if (context.Input.EndsWith(Four()))
            {
                if (context.Output.Length == 0)
                {
                    context.Output = "four hundred";
                }
                else
                {
                    context.Output = "four hundred " + context.Output;
                }
                context.Input = context.Input.Substring(0, context.Input.Length - 1);
            }
            else if (context.Input.EndsWith(Five()))
            {
                if (context.Output.Length == 0)
                {
                    context.Output = "five hundred";
                }
                else
                {
                    context.Output = "five hundred " + context.Output;
                }
                context.Input = context.Input.Substring(0, context.Input.Length - 1);
            }
            else if (context.Input.EndsWith(Six()))
            {
                if (context.Output.Length == 0)
                {
                    context.Output = "six hundred";
                }
                else
                {
                    context.Output = "six hundred " + context.Output;
                }
                context.Input = context.Input.Substring(0, context.Input.Length - 1);
            }
            else if (context.Input.EndsWith(Seven()))
            {
                if (context.Output.Length == 0)
                {
                    context.Output = "seven hundred";
                }
                else
                {
                    context.Output = "seven hundred " + context.Output;
                }
                context.Input = context.Input.Substring(0, context.Input.Length - 1);
            }
            else if (context.Input.EndsWith(Eight()))
            {
                if (context.Output.Length == 0)
                {
                    context.Output = "eight hundred";
                }
                else
                {
                    context.Output = "eight hundred " + context.Output;
                }
                context.Input = context.Input.Substring(0, context.Input.Length - 1);
            }
            else if (context.Input.EndsWith(Nine()))
            {
                if (context.Output.Length == 0)
                {
                    context.Output = "nine hundred";
                }
                else
                {
                    context.Output = "nine hundred " + context.Output;
                }
                context.Input = context.Input.Substring(0, context.Input.Length - 1);
            }
        }
    }
}
