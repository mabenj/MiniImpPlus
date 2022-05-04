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

using Antlr4.Runtime.Misc;
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="MiniImpPlusParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.10.1")]
[System.CLSCompliant(false)]
public interface IMiniImpPlusListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="MiniImpPlusParser.truth"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTruth([NotNull] MiniImpPlusParser.TruthContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MiniImpPlusParser.truth"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTruth([NotNull] MiniImpPlusParser.TruthContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MiniImpPlusParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExpr([NotNull] MiniImpPlusParser.ExprContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MiniImpPlusParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExpr([NotNull] MiniImpPlusParser.ExprContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MiniImpPlusParser.term"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTerm([NotNull] MiniImpPlusParser.TermContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MiniImpPlusParser.term"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTerm([NotNull] MiniImpPlusParser.TermContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MiniImpPlusParser.factor"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFactor([NotNull] MiniImpPlusParser.FactorContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MiniImpPlusParser.factor"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFactor([NotNull] MiniImpPlusParser.FactorContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MiniImpPlusParser.stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStmt([NotNull] MiniImpPlusParser.StmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MiniImpPlusParser.stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStmt([NotNull] MiniImpPlusParser.StmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MiniImpPlusParser.select"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSelect([NotNull] MiniImpPlusParser.SelectContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MiniImpPlusParser.select"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSelect([NotNull] MiniImpPlusParser.SelectContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MiniImpPlusParser.iterat"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIterat([NotNull] MiniImpPlusParser.IteratContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MiniImpPlusParser.iterat"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIterat([NotNull] MiniImpPlusParser.IteratContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MiniImpPlusParser.set"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSet([NotNull] MiniImpPlusParser.SetContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MiniImpPlusParser.set"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSet([NotNull] MiniImpPlusParser.SetContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MiniImpPlusParser.write"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterWrite([NotNull] MiniImpPlusParser.WriteContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MiniImpPlusParser.write"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitWrite([NotNull] MiniImpPlusParser.WriteContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MiniImpPlusParser.read"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRead([NotNull] MiniImpPlusParser.ReadContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MiniImpPlusParser.read"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRead([NotNull] MiniImpPlusParser.ReadContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MiniImpPlusParser.asInt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAsInt([NotNull] MiniImpPlusParser.AsIntContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MiniImpPlusParser.asInt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAsInt([NotNull] MiniImpPlusParser.AsIntContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MiniImpPlusParser.asStr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAsStr([NotNull] MiniImpPlusParser.AsStrContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MiniImpPlusParser.asStr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAsStr([NotNull] MiniImpPlusParser.AsStrContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MiniImpPlusParser.decl"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDecl([NotNull] MiniImpPlusParser.DeclContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MiniImpPlusParser.decl"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDecl([NotNull] MiniImpPlusParser.DeclContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MiniImpPlusParser.variable"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterVariable([NotNull] MiniImpPlusParser.VariableContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MiniImpPlusParser.variable"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitVariable([NotNull] MiniImpPlusParser.VariableContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MiniImpPlusParser.stmts"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStmts([NotNull] MiniImpPlusParser.StmtsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MiniImpPlusParser.stmts"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStmts([NotNull] MiniImpPlusParser.StmtsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MiniImpPlusParser.decls"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDecls([NotNull] MiniImpPlusParser.DeclsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MiniImpPlusParser.decls"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDecls([NotNull] MiniImpPlusParser.DeclsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MiniImpPlusParser.scope"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterScope([NotNull] MiniImpPlusParser.ScopeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MiniImpPlusParser.scope"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitScope([NotNull] MiniImpPlusParser.ScopeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MiniImpPlusParser.init"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInit([NotNull] MiniImpPlusParser.InitContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MiniImpPlusParser.init"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInit([NotNull] MiniImpPlusParser.InitContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MiniImpPlusParser.prog"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterProg([NotNull] MiniImpPlusParser.ProgContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MiniImpPlusParser.prog"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitProg([NotNull] MiniImpPlusParser.ProgContext context);
}
