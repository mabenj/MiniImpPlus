namespace MiniImpPlus.Options {
	using CommandLine;

	public class Options {
		[Value(0, Required = true, HelpText = "The MiniImp+ file to be compiled")]
		public string InputFile {
			get;
			set;
		}

		[Option('v', "verbose", Required = false, HelpText = "Enable verbose output", Default = false)]
		public bool IsVerbose {
			get;
			set;
		}

		[Option('o', "output", Required = false, HelpText = "Directory where to output the compiled file", Default = "")]
		public string OutputDirectory {
			get;
			set;
		}
	}
}