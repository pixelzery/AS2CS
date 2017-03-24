﻿using PygmentSharp.Core.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS2CS.Nodes
{
    public class InExpression : Node
    {
        public InExpression(TokenStream tokenStream) : base(tokenStream)
        {
        }

        public override Node Select()
        {
            if (!Accept<Variable>(false)) return null;//problem fixed
            if (!Accept(new TokenNode(ts, TokenTypes.Keyword, "in"))) return null;
            if (!Accept<Expression>()) return null;
            return this;
        }
    }
}
