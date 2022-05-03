namespace MiniImpPlus {
	using System;
	using System.IO;

	using Antlr4.Runtime;

	internal class Program {
		private static int Main(string[] args) {
			if(args == null || args.Length < 1) {
				Console.WriteLine(
					"Specify input MiniImp+ file as the first parameter. "
					+ "You can also specify an optional second parameter "
					+ "for the output Python file.");
				return 1;
			}
			var filename = Path.GetFileNameWithoutExtension(args[0]);
			var input = File.ReadAllText(args[0]);

			var chars = new AntlrInputStream(input);
			var lexer = new MiniImpPlusLexer(chars);
			var tokens = new CommonTokenStream(lexer);
			var parser = new MiniImpPlusParser(tokens) {
				BuildParseTree = true
			};
			var tree = parser.prog();
			var output = new PythonGenerator().Start(tree);

			Console.WriteLine("######### Input #########");
			Console.WriteLine();
			Console.WriteLine(input);
			Console.WriteLine();
			Console.WriteLine("######### Output ########");
			Console.WriteLine();
			Console.WriteLine(output);
			Console.WriteLine();

			var outputPath = args.Length > 1 ? args[1] : $"{filename}.py";

			Console.WriteLine($"Writing output to '{outputPath}'");
			File.WriteAllText(outputPath, output);
			return 0;
		}
	}
}