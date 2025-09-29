using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScriptEngineContract
{
    /// <summary>
    /// A contract for script evaluation and execution.
    /// </summary>
    public interface IScriptEngine
    {

      //  void SetGlobals(Dictionary<string, object> globals);
        /// <summary>
        /// Evaluates an expression and returns its result.
        /// Example: "2 + 3 * 4" => 14
        /// </summary>
        object Evaluate(string expression);

        /// <summary>
        /// Executes a block of script code.
        /// This may not return a value, but can perform actions.
        /// </summary>
        object Execute(string code);
    }
}
