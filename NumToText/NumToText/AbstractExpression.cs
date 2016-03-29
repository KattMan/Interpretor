using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NumToText
{
    /// <summary>
    /// The 'AbstractExpression' abstract class
    /// </summary>
    abstract class Expression
    {
        public abstract void Interpret(Context context);
        public string Zero() { return "0"; }
        public string One() { return "1"; }
        public string Two() { return "2"; }
        public string Three() { return "3"; }
        public string Four() { return "4"; }
        public string Five() { return "5"; }
        public string Six() { return "6"; }
        public string Seven() { return "7"; }
        public string Eight() { return "8"; }
        public string Nine() { return "9"; }
    }
}
