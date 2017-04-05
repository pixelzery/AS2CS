﻿using PygmentSharp.Core.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS2CS.Nodes
{
    public class Parameter : Node
    {
        public bool initialised = false;
        public Parameter(TokenStream tokenStream) : base(tokenStream)
        {
        }

        public override Node Select()
        {
            if (!Accept(new TokenNode(ts, TokenTypes.Name))) return null;
            if (!Accept(new TokenNode(ts, TokenTypes.Punctuation, ":"))) return null;
            if (!Accept(new TokenNode(ts, TokenTypes.Keyword.Type))) return null;

            if (Accept(new TokenNode(ts, TokenTypes.Operator, "=")))
            {
                initialised = true;
                if (!Expect<Expression>()) return null;
            }
            return this;
        }
    }
}
