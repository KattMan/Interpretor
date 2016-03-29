using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NumToText
{
    class TensExpression: Expression        
    {
        public override void Interpret(Context context)
        {
            if (context.Input.Length == 0)
                return;
            else if (context.Input.EndsWith(Zero()))
            {
                if (context.Output == "zero")
                {
                    context.Output = "";
                }
                context.Input = context.Input.Substring(0, context.Input.Length - 1);
            }
            else if (context.Input.EndsWith(One()))
            {
                switch (context.Output)
                {
                    case "zero":
                        context.Output = "ten";
                        break;
                    case "one":
                        context.Output = "eleven";
                        break;
                    case "two":
                        context.Output = "twelve";
                        break;
                    case "three":
                        context.Output = "thirteen";
                        break;
                    case "five":
                        context.Output = "fifteen";
                        break;
                    default:
                        context.Output += "teen";
                        break;
                }
                context.Input = context.Input.Substring(0, context.Input.Length - 1);
            }
            else if (context.Input.EndsWith(Two()))
            {
                if (context.Output == "zero")
                {
                    context.Output = "twenty";
                }
                else
                {
                    context.Output = "twenty-" + context.Output;
                }
                context.Input = context.Input.Substring(0, context.Input.Length - 1);
            }
            else if (context.Input.EndsWith(Three()))
            {
                if (context.Output == "zero")
                {
                    context.Output = "thirty";
                }
                else
                {
                    context.Output = "thirty-" + context.Output;
                }
                context.Input = context.Input.Substring(0, context.Input.Length - 1);
            }
            else if (context.Input.EndsWith(Four()))
            {
                if (context.Output == "zero")
                {
                    context.Output = "forty";
                }
                else
                {
                    context.Output = "forty-" + context.Output;
                }
                context.Input = context.Input.Substring(0, context.Input.Length - 1);
            }
            else if (context.Input.EndsWith(Five()))
            {
                if (context.Output == "zero")
                {
                    context.Output = "fifty";
                }
                else
                {
                    context.Output = "fifty-" + context.Output;
                }
                context.Input = context.Input.Substring(0, context.Input.Length - 1);
            }
            else if (context.Input.EndsWith(Six()))
            {
                if (context.Output == "zero")
                {
                    context.Output = "sixty";
                }
                else
                {
                    context.Output = "sixty-" + context.Output;
                }
                context.Input = context.Input.Substring(0, context.Input.Length - 1);
            }
            else if (context.Input.EndsWith(Seven()))
            {
                if (context.Output == "zero")
                {
                    context.Output = "seventy";
                }
                else
                {
                    context.Output = "seventy-" + context.Output;
                }
                context.Input = context.Input.Substring(0, context.Input.Length - 1);
            }
            else if (context.Input.EndsWith(Eight()))
            {
                if (context.Output == "zero")
                {
                    context.Output = "eightty";
                }
                else
                {
                    context.Output = "eightty-" + context.Output;
                }
                context.Input = context.Input.Substring(0, context.Input.Length - 1);
            }
            else if (context.Input.EndsWith(Nine()))
            {
                if (context.Output == "zero")
                {
                    context.Output = "ninety";
                }
                else
                {
                    context.Output = "ninety-" + context.Output;
                }
                context.Input = context.Input.Substring(0, context.Input.Length - 1);
            }
        }
    }
}
