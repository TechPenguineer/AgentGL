using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgentGL.Syntax.Expression
{
    public enum Classifier
    {
        Root,
        With,
        VariableDeclaration,
        IntLiteral,
        BoolLiteral,
        StringLiteral,
        DecLiteral,
        Call,
        Identifier,
        Operation,
        NullCondition,
        Exception,
        Lambda,
        Put,
        Function,
        While,
        Command,
        ValueCall,
        Assignment,
        For,
        LeftHand,
        RightHand,
        Misc,
        ListLiteral,
        NullLiteral,
        MultiDimensionalArrayAccess,
        InlineIf,
        Pipeline,
        Placeholder,
        If,
        TryCatch,
        Class,
        Match,
        ArrayAccess,
        Struct
    }
}
