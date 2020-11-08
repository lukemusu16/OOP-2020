using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise4
{
    class Child2 : Kid
    {
        public override string PrintMessage()
        {
            base.PrintMessage();
            return "This is the message for the Child2 Class";
        }
    }
}
