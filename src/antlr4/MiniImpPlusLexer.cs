//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.10.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from .\MiniImpPlus.g4 by ANTLR 4.10.1

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using System;
using System.IO;
using System.Text;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.10.1")]
[System.CLSCompliant(false)]
public partial class MiniImpPlusLexer : Lexer {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		T__0=1, T__1=2, T__2=3, T__3=4, T__4=5, T__5=6, T__6=7, T__7=8, T__8=9, 
		T__9=10, T__10=11, T__11=12, T__12=13, T__13=14, T__14=15, T__15=16, T__16=17, 
		T__17=18, T__18=19, T__19=20, T__20=21, T__21=22, T__22=23, T__23=24, 
		String=25, Identifier=26, Number=27, WS=28;
	public static string[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"T__0", "T__1", "T__2", "T__3", "T__4", "T__5", "T__6", "T__7", "T__8", 
		"T__9", "T__10", "T__11", "T__12", "T__13", "T__14", "T__15", "T__16", 
		"T__17", "T__18", "T__19", "T__20", "T__21", "T__22", "T__23", "Digit", 
		"Letter", "Escape", "String", "Identifier", "Number", "WS"
	};


	public MiniImpPlusLexer(ICharStream input)
	: this(input, Console.Out, Console.Error) { }

	public MiniImpPlusLexer(ICharStream input, TextWriter output, TextWriter errorOutput)
	: base(input, output, errorOutput)
	{
		Interpreter = new LexerATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	private static readonly string[] _LiteralNames = {
		null, "'true'", "'false'", "'not'", "'is'", "'and'", "'or'", "'+'", "'-'", 
		"'*'", "'/'", "'('", "')'", "'if'", "'then'", "'else'", "'while'", "'set'", 
		"'='", "';'", "'write'", "'var'", "'begin'", "'end.'", "'program'"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, null, null, null, null, null, null, null, null, null, null, 
		null, null, null, null, null, null, null, null, null, null, null, null, 
		null, "String", "Identifier", "Number", "WS"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "MiniImpPlus.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ChannelNames { get { return channelNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override int[] SerializedAtn { get { return _serializedATN; } }

	static MiniImpPlusLexer() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}
	private static int[] _serializedATN = {
		4,0,28,199,6,-1,2,0,7,0,2,1,7,1,2,2,7,2,2,3,7,3,2,4,7,4,2,5,7,5,2,6,7,
		6,2,7,7,7,2,8,7,8,2,9,7,9,2,10,7,10,2,11,7,11,2,12,7,12,2,13,7,13,2,14,
		7,14,2,15,7,15,2,16,7,16,2,17,7,17,2,18,7,18,2,19,7,19,2,20,7,20,2,21,
		7,21,2,22,7,22,2,23,7,23,2,24,7,24,2,25,7,25,2,26,7,26,2,27,7,27,2,28,
		7,28,2,29,7,29,2,30,7,30,1,0,1,0,1,0,1,0,1,0,1,1,1,1,1,1,1,1,1,1,1,1,1,
		2,1,2,1,2,1,2,1,3,1,3,1,3,1,4,1,4,1,4,1,4,1,5,1,5,1,5,1,6,1,6,1,7,1,7,
		1,8,1,8,1,9,1,9,1,10,1,10,1,11,1,11,1,12,1,12,1,12,1,13,1,13,1,13,1,13,
		1,13,1,14,1,14,1,14,1,14,1,14,1,15,1,15,1,15,1,15,1,15,1,15,1,16,1,16,
		1,16,1,16,1,17,1,17,1,18,1,18,1,19,1,19,1,19,1,19,1,19,1,19,1,20,1,20,
		1,20,1,20,1,21,1,21,1,21,1,21,1,21,1,21,1,22,1,22,1,22,1,22,1,22,1,23,
		1,23,1,23,1,23,1,23,1,23,1,23,1,23,1,24,1,24,1,25,1,25,1,26,1,26,1,26,
		1,26,3,26,165,8,26,1,27,1,27,1,27,5,27,170,8,27,10,27,12,27,173,9,27,1,
		27,1,27,1,28,1,28,1,28,1,28,5,28,181,8,28,10,28,12,28,184,9,28,1,29,1,
		29,5,29,188,8,29,10,29,12,29,191,9,29,1,30,4,30,194,8,30,11,30,12,30,195,
		1,30,1,30,1,171,0,31,1,1,3,2,5,3,7,4,9,5,11,6,13,7,15,8,17,9,19,10,21,
		11,23,12,25,13,27,14,29,15,31,16,33,17,35,18,37,19,39,20,41,21,43,22,45,
		23,47,24,49,0,51,0,53,0,55,25,57,26,59,27,61,28,1,0,2,1,0,65,90,3,0,9,
		10,13,13,32,32,203,0,1,1,0,0,0,0,3,1,0,0,0,0,5,1,0,0,0,0,7,1,0,0,0,0,9,
		1,0,0,0,0,11,1,0,0,0,0,13,1,0,0,0,0,15,1,0,0,0,0,17,1,0,0,0,0,19,1,0,0,
		0,0,21,1,0,0,0,0,23,1,0,0,0,0,25,1,0,0,0,0,27,1,0,0,0,0,29,1,0,0,0,0,31,
		1,0,0,0,0,33,1,0,0,0,0,35,1,0,0,0,0,37,1,0,0,0,0,39,1,0,0,0,0,41,1,0,0,
		0,0,43,1,0,0,0,0,45,1,0,0,0,0,47,1,0,0,0,0,55,1,0,0,0,0,57,1,0,0,0,0,59,
		1,0,0,0,0,61,1,0,0,0,1,63,1,0,0,0,3,68,1,0,0,0,5,74,1,0,0,0,7,78,1,0,0,
		0,9,81,1,0,0,0,11,85,1,0,0,0,13,88,1,0,0,0,15,90,1,0,0,0,17,92,1,0,0,0,
		19,94,1,0,0,0,21,96,1,0,0,0,23,98,1,0,0,0,25,100,1,0,0,0,27,103,1,0,0,
		0,29,108,1,0,0,0,31,113,1,0,0,0,33,119,1,0,0,0,35,123,1,0,0,0,37,125,1,
		0,0,0,39,127,1,0,0,0,41,133,1,0,0,0,43,137,1,0,0,0,45,143,1,0,0,0,47,148,
		1,0,0,0,49,156,1,0,0,0,51,158,1,0,0,0,53,164,1,0,0,0,55,166,1,0,0,0,57,
		176,1,0,0,0,59,185,1,0,0,0,61,193,1,0,0,0,63,64,5,116,0,0,64,65,5,114,
		0,0,65,66,5,117,0,0,66,67,5,101,0,0,67,2,1,0,0,0,68,69,5,102,0,0,69,70,
		5,97,0,0,70,71,5,108,0,0,71,72,5,115,0,0,72,73,5,101,0,0,73,4,1,0,0,0,
		74,75,5,110,0,0,75,76,5,111,0,0,76,77,5,116,0,0,77,6,1,0,0,0,78,79,5,105,
		0,0,79,80,5,115,0,0,80,8,1,0,0,0,81,82,5,97,0,0,82,83,5,110,0,0,83,84,
		5,100,0,0,84,10,1,0,0,0,85,86,5,111,0,0,86,87,5,114,0,0,87,12,1,0,0,0,
		88,89,5,43,0,0,89,14,1,0,0,0,90,91,5,45,0,0,91,16,1,0,0,0,92,93,5,42,0,
		0,93,18,1,0,0,0,94,95,5,47,0,0,95,20,1,0,0,0,96,97,5,40,0,0,97,22,1,0,
		0,0,98,99,5,41,0,0,99,24,1,0,0,0,100,101,5,105,0,0,101,102,5,102,0,0,102,
		26,1,0,0,0,103,104,5,116,0,0,104,105,5,104,0,0,105,106,5,101,0,0,106,107,
		5,110,0,0,107,28,1,0,0,0,108,109,5,101,0,0,109,110,5,108,0,0,110,111,5,
		115,0,0,111,112,5,101,0,0,112,30,1,0,0,0,113,114,5,119,0,0,114,115,5,104,
		0,0,115,116,5,105,0,0,116,117,5,108,0,0,117,118,5,101,0,0,118,32,1,0,0,
		0,119,120,5,115,0,0,120,121,5,101,0,0,121,122,5,116,0,0,122,34,1,0,0,0,
		123,124,5,61,0,0,124,36,1,0,0,0,125,126,5,59,0,0,126,38,1,0,0,0,127,128,
		5,119,0,0,128,129,5,114,0,0,129,130,5,105,0,0,130,131,5,116,0,0,131,132,
		5,101,0,0,132,40,1,0,0,0,133,134,5,118,0,0,134,135,5,97,0,0,135,136,5,
		114,0,0,136,42,1,0,0,0,137,138,5,98,0,0,138,139,5,101,0,0,139,140,5,103,
		0,0,140,141,5,105,0,0,141,142,5,110,0,0,142,44,1,0,0,0,143,144,5,101,0,
		0,144,145,5,110,0,0,145,146,5,100,0,0,146,147,5,46,0,0,147,46,1,0,0,0,
		148,149,5,112,0,0,149,150,5,114,0,0,150,151,5,111,0,0,151,152,5,103,0,
		0,152,153,5,114,0,0,153,154,5,97,0,0,154,155,5,109,0,0,155,48,1,0,0,0,
		156,157,2,48,57,0,157,50,1,0,0,0,158,159,7,0,0,0,159,52,1,0,0,0,160,161,
		5,92,0,0,161,165,5,34,0,0,162,163,5,92,0,0,163,165,5,92,0,0,164,160,1,
		0,0,0,164,162,1,0,0,0,165,54,1,0,0,0,166,171,5,34,0,0,167,170,3,53,26,
		0,168,170,9,0,0,0,169,167,1,0,0,0,169,168,1,0,0,0,170,173,1,0,0,0,171,
		172,1,0,0,0,171,169,1,0,0,0,172,174,1,0,0,0,173,171,1,0,0,0,174,175,5,
		34,0,0,175,56,1,0,0,0,176,182,3,51,25,0,177,181,3,51,25,0,178,181,3,49,
		24,0,179,181,5,95,0,0,180,177,1,0,0,0,180,178,1,0,0,0,180,179,1,0,0,0,
		181,184,1,0,0,0,182,180,1,0,0,0,182,183,1,0,0,0,183,58,1,0,0,0,184,182,
		1,0,0,0,185,189,3,49,24,0,186,188,3,49,24,0,187,186,1,0,0,0,188,191,1,
		0,0,0,189,187,1,0,0,0,189,190,1,0,0,0,190,60,1,0,0,0,191,189,1,0,0,0,192,
		194,7,1,0,0,193,192,1,0,0,0,194,195,1,0,0,0,195,193,1,0,0,0,195,196,1,
		0,0,0,196,197,1,0,0,0,197,198,6,30,0,0,198,62,1,0,0,0,8,0,164,169,171,
		180,182,189,195,1,6,0,0
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
