namespace MiniImpPlus.CodeGen {
	using System;
	using System.Text;

	using Antlr4.Runtime.Tree;

	public class PythonGenerator: MiniImpPlusBaseVisitor<string> {
		private readonly string newline = Environment.NewLine;
		private int identLevel = 0;

		public string Indent => new string(' ', this.identLevel * 4);

		public string Start(MiniImpPlusParser.ProgContext ctx) {
			return this.VisitProg(ctx);
		}

		public override string VisitAsInt(MiniImpPlusParser.AsIntContext context) {
			var expr = this.Visit(context.expr());
			return $"int({expr})";
		}

		public override string VisitAsStr(MiniImpPlusParser.AsStrContext context) {
			var expr = this.Visit(context.expr());
			return $"str({expr})";
		}

		public override string VisitChildren(IRuleNode node) {
			var code = new StringBuilder();
			for(var i = 0; i < node.ChildCount; i++) {
				var line = this.Visit(node.GetChild(i));
				code.Append(line);
			}
			return code.ToString();
		}

		public override string VisitExpr(MiniImpPlusParser.ExprContext context) {
			var expression = new StringBuilder(this.Visit(context.GetChild(0)));
			for(var i = 1; i < context.ChildCount; i++) {
				expression.AppendJoin(" ", this.Visit(context.GetChild(i)));
			}
			return expression.ToString();
		}

		public override string VisitInit(MiniImpPlusParser.InitContext context) {
			return $"def {this.Visit(context.Identifier())}():{this.newline}";
		}

		// ReSharper disable once IdentifierTypo
		public override string VisitIterat(MiniImpPlusParser.IteratContext context) {
			var testExpression = this.Visit(context.expr());
			var scope = this.Visit(context.scope());
			return $"while {testExpression}{scope}";
		}

		// ReSharper disable once IdentifierTypo
		public override string VisitProg(MiniImpPlusParser.ProgContext context) {
			var programName = this.Visit(context.init().Identifier());
			var mainScope = this.Visit(context.scope());
			return $"def {programName}()"
				+ $"{mainScope}"
				+ $"{programName}()";
		}

		public override string VisitRead(MiniImpPlusParser.ReadContext context) {
			var expression = context.expr();
			var message = expression != null ? this.Visit(expression) : null;
			return $"input({message})";
		}

		public override string VisitScope(MiniImpPlusParser.ScopeContext context) {
			this.identLevel++;
			var scope = new StringBuilder(":" + this.newline);

			var declarations = context.decls()?.decl();
			if(declarations != null) {
				foreach(var declaration in declarations) {
					scope.Append(this.Indent + this.Visit(declaration) + this.newline);
				}
			}

			var statements = context.stmts()?.stmt();
			if(statements != null) {
				foreach(var statement in statements) {
					scope.Append(this.Indent + this.Visit(statement) + this.newline);
				}
			}

			this.identLevel--;
			return scope.ToString();
		}

		public override string VisitSelect(MiniImpPlusParser.SelectContext context) {
			var select = new StringBuilder();

			var testExpression = this.Visit(context.expr());
			var ifScope = this.Visit(context.scope(0));
			var elseScope = context.scope().Length > 1 ? this.Visit(context.scope(1)) : string.Empty;

			select.Append($"if {testExpression}");
			select.Append($"{ifScope}");
			if(!string.IsNullOrWhiteSpace(elseScope)) {
				select.Append($"{this.Indent}else");
				select.Append($"{elseScope}");
			}

			return select.ToString();
		}

		public override string VisitSet(MiniImpPlusParser.SetContext context) {
			return $"{this.Visit(context.Identifier())} = {this.Visit(context.expr())}";
		}

		public override string VisitTerm(MiniImpPlusParser.TermContext context) {
			var term = new StringBuilder(this.Visit(context.GetChild(0)));
			for(var i = 1; i < context.ChildCount; i++) {
				term.Append(" " + this.Visit(context.GetChild(i)));
			}
			return term.ToString();
		}

		public override string VisitTerminal(ITerminalNode node) {
			return node.GetText();
		}

		public override string VisitTruth(MiniImpPlusParser.TruthContext context) {
			var expression = new StringBuilder();
			for(var i = 0; i < context.ChildCount; i++) {
				var part = this.Visit(context.GetChild(i));
				switch(part) {
				case "true": {
					expression.AppendJoin(' ', "True");
					break;
				}
				case "false": {
					expression.AppendJoin(' ', "False");
					break;
				}
				case "is": {
					if(i + 2 >= context.ChildCount) {
						//TODO: throw error?
						break;
					}
					var left = this.Visit(context.GetChild(i + 1));
					var right = this.Visit(context.GetChild(i + 2));
					expression.AppendJoin(' ', $"{left} == {right}");
					break;
				}
				case "not": {
					if(i + 1 >= context.ChildCount) {
						//TODO: throw error?
						break;
					}
					var right = this.Visit(context.GetChild(i + 1));
					expression.AppendJoin(' ', $"not {right}");
					break;
				}
				case "or":
				case "and": {
					if(i - 1 < 0) {
						//TODO: throw error?
						break;
					}
					if(i + 1 >= context.ChildCount) {
						//TODO: throw error?
						break;
					}
					var left = this.Visit(context.GetChild(i - 1));
					var right = this.Visit(context.GetChild(i + 1));
					expression.AppendJoin(' ', $"{left} {part} {right}");
					break;
				}
				default:
					// TODO: throw error?
					break;
				}
			}
			return expression.ToString();
		}

		public override string VisitVariable(MiniImpPlusParser.VariableContext context) {
			var identifier = this.Visit(context.Identifier());
			var expression = context.expr();
			var value = expression != null ? this.Visit(expression) : null;
			return string.IsNullOrWhiteSpace(value) ? $"{identifier} = None" : $"{identifier} = {value}";
		}

		public override string VisitWrite(MiniImpPlusParser.WriteContext context) {
			return $"print({this.Visit(context.expr())})";
		}
	}
}