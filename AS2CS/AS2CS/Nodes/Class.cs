﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS2CS.Nodes
{
    public class Class : Node
    {
        public Class(TokenStream tokenStream) : base(tokenStream)
        {
        }

        public override Node Select()
        {
            while (true)
            {
                if (!Accept<Method>() && !Accept<Constructor>() && !Accept<Variable>())
                {
                    break;
                }
            }
            //TODO: methods and stuff
            return this;
        }
    }
}
