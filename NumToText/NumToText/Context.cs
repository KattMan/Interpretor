using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NumToText
{
    /// <summary>
    /// The 'Context' class
    /// </summary>
    class Context
    {
        private string _input;
        private string _output;

        // Constructor
        public Context(string input)
        {
            this._input = input;
        }

        // Gets or sets input
        public string Input
        {
            get { return _input; }
            set { _input = value; }
        }

        // Gets or sets output
        public string Output
        {
            get { return _output; }
            set { _output = value; }
        }
    }
}
