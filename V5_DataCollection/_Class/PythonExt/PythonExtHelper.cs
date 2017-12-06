using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using IronPython.Hosting;
using Microsoft.Scripting.Hosting;

namespace V5_DataCollection._Class.PythonExt {
    /// <summary>
    /// 执行python脚本
    /// </summary>
    public class PythonExtHelper {

        public delegate void OutWrite(string msg);
        public static event OutWrite OutWriteHandler;
        /// <summary>
        /// 运行Python脚本
        /// </summary>
        /// <param name="pythonFile"></param>
        /// <returns></returns>
        public static string RunPython(string pythonFile, object[] inputObj) {

            ScriptEngine _engine = Python.CreateEngine();

            string fileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, pythonFile);

            #region 字符串
            var code = @"import sys" + "\n" +
                @"from System.IO import Path" + "\n" +
                @"sys.path.append("".\pythonlib.zip"")" + "\n" +
                @"import clr" + "\n" +
                @"execfile(Path.GetFullPath(r'" + pythonFile + @"'))";
            var source = _engine.CreateScriptSourceFromString(code);

            var scope = _engine.CreateScope();
            source.Execute(scope);
            #endregion

            #region 文件
            //var source = _engine.CreateScriptSourceFromFile(fileName, Encoding.Default, SourceCodeKind.Statements);

            //CompiledCode _code = source.Compile();

            //var scope = _engine.CreateScope();

            //_code.Execute(scope);
            #endregion

            var main = scope.GetVariable<Func<object[], string>>("start");

            return main(inputObj);

        }

        public static void RunScriptPython(string pythonContent, object[] inputObj) {
            ScriptEngine _engine = Python.CreateEngine();

            #region 字符串
            var code = @"import sys" + "\n" +
                @"import clr" + "\n" +
                @"sys.path.append("".\pythonlib.zip"")" + "\n" +
                @"sys.stdout=my" + "\n" +
                @pythonContent;
            var source = _engine.CreateScriptSourceFromString(code);

            var scope = _engine.CreateScope();
            scope.SetVariable("my", new Test());
            source.Execute(scope);
            #endregion

            var main = scope.GetVariable<Func<object[], string>>("start");

            var s = main(inputObj);

            OutWriteHandler?.Invoke("返回结果:" + s);
        }

        public class Test {
            public void write(string s) {
                OutWriteHandler?.Invoke(s);
            }
        }
    }


}
