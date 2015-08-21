




//AUTOGENERATED, DO NOTMODIFY.
//Do not edit this file directly.

// ReSharper disable CheckNamespace

using RethinkDb.Driver.Ast;
using RethinkDb.Driver.Model;
using RethinkDb.Driver.Proto;

namespace RethinkDb.Driver.Ast {
    public class Polygon : ReqlQuery {
    
        public Polygon (object arg) : this(new Arguments(arg), null) {
        }
        public Polygon (Arguments args, OptArgs optargs) : this(null, args, optargs) {
        }
        public Polygon (ReqlAst prev, Arguments args, OptArgs optargs)
             : this(prev, TermType.POLYGON, args, optargs) {
        }

        protected Polygon (ReqlAst previous, TermType termType, Arguments args, OptArgs optargs) : base(previous, termType, args, optargs)
        {
        }

    /* Static Factories */
        public static Polygon FromArgs(params object[] args){
               return new Polygon (new Arguments(args), null);
        }

    /* Special Methods */

    }
}