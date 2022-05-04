namespace MiniImpPlus.Utilities {
	using System;

	internal class Log {
		private static bool isVerbose;

		public static void Init(bool verbose) {
			isVerbose = verbose;
		}

		internal static void Error(string message = "") {
			Console.WriteLine(message);
		}

		internal static void Info(string message = "") {
			if(isVerbose) {
				Console.WriteLine(message);
			}
		}

		internal static void Warning(string message = "") {
			if(isVerbose) {
				Console.WriteLine(message);
			}
		}
	}
}