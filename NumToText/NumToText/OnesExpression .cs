using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NumToText
{
    class OnesExpression : Expression
    {
        public override void Interpret(Context context)
        {
            if (context.Input.Length == 0)
                return;
            else if (context.Input.EndsWith(Zero()))
            {
                context.Output += "zero";
                context.Input = context.Input.Substring(0, context.Input.Length - 1);
            }
            else if (context.Input.EndsWith(One()))
            {
                context.Output += "one";
                context.Input = context.Input.Substring(0, context.Input.Length - 1);
            }
            else if (context.Input.EndsWith(Two()))
            {
                context.Output += "two";
                context.Input = context.Input.Substring(0, context.Input.Length - 1);
            }
            else if (context.Input.EndsWith(Three()))
            {
                context.Output += "three";
                context.Input = context.Input.Substring(0, context.Input.Length - 1);
            }
            else if (context.Input.EndsWith(Four()))
            {
                context.Output += "four";
                context.Input = context.Input.Substring(0, context.Input.Length - 1);
            }
            else if (context.Input.EndsWith(Five()))
            {
                context.Output += "five";
                context.Input = context.Input.Substring(0, context.Input.Length - 1);
            }
            else if (context.Input.EndsWith(Six()))
            {
                context.Output += "six";
                context.Input = context.Input.Substring(0, context.Input.Length - 1);
            }
            else if (context.Input.EndsWith(Seven()))
            {
                context.Output += "seven";
                context.Input = context.Input.Substring(0, context.Input.Length - 1);
            }
            else if (context.Input.EndsWith(Eight()))
            {
                context.Output += "eight";
                context.Input = context.Input.Substring(0, context.Input.Length - 1);
            }
            else if (context.Input.EndsWith(Nine()))
            {
                context.Output += "nine";
                context.Input = context.Input.Substring(0, context.Input.Length - 1);
            }
        }
    }
}
