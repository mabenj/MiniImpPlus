namespace MiniImpPlus {
	using System;
	using System.IO;

	using Antlr4.Runtime;

	using CommandLine;

	using MiniImpPlus.CodeGen;
	using MiniImpPlus.Utilities;

	using Parser = CommandLine.Parser;

	internal class Program {
		//TODO:
		// type casts: int <-> string

		private static int Execute(Options.Options options) {
			Log.Init(options.IsVerbose);

			if(!File.Exists(options.InputFile)) {
				Log.Error($"Could not find file '{options.InputFile}'");
				return 1;
			}

			string output;

			try {
				var input = File.ReadAllText(options.InputFile);

				var chars = new AntlrInputStream(input);
				var lexer = new MiniImpPlusLexer(chars);
				var tokens = new CommonTokenStream(lexer);
				var parser = new MiniImpPlusParser(tokens) {
					BuildParseTree = true
				};
				var tree = parser.prog();
				output = new PythonGenerator().Start(tree);

				Log.Info("######### Input #########");
				Log.Info(input);
				Log.Info();
				Log.Info("######### Output ########");
				Log.Info(output);
				Log.Info();
			} catch(Exception e) {
				Log.Error($"Error while compiling: {e}");
				return 1;
			}

			try {
				var filename = Path.GetFileNameWithoutExtension(options.InputFile) + ".py";
				var outputPath = Path.Combine(options.OutputDirectory, filename);

				Log.Info($"Writing output to '{outputPath}'");
				File.WriteAllText(outputPath, output);
			} catch(Exception e) {
				Log.Error($"Error while writing output: {e}");
				return 1;
			}

			return 0;
		}

		private static int Main(string[] args) {
			return Parser.Default.ParseArguments<Options.Options>(args).MapResult(Execute, _ => 1);
		}
	}
}