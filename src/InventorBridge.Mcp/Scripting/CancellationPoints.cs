using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace InventorBridge.Mcp.Scripting;

/// <summary>
/// Adds a cancellation check at the start of every loop body of a script, so script_cancel can stop a script
/// that loops over thousands of occurrences. Roslyn scripts cannot be interrupted from outside otherwise.
/// </summary>
/// <remarks>
/// The check goes on the line where the body starts, without new lines, so the line numbers in compilation and
/// runtime errors still match the agent's code. A single long Inventor call (an update, a save) still runs to its end.
/// </remarks>
internal static class CancellationPoints
{
    public const string CheckMethod = nameof(ScriptGlobals.InventorBridgeCheckCancel);

    private static readonly CSharpParseOptions ScriptParseOptions = CSharpParseOptions.Default.WithKind(SourceCodeKind.Script);

    public static string Add(string code)
    {
        var tree = CSharpSyntaxTree.ParseText(code, ScriptParseOptions);
        return new Rewriter().Visit(tree.GetRoot()).ToFullString();
    }

    private sealed class Rewriter : CSharpSyntaxRewriter
    {
        public override SyntaxNode? VisitForStatement(ForStatementSyntax node)
        {
            var visited = (ForStatementSyntax)base.VisitForStatement(node)!;
            return visited.WithStatement(WithCheck(visited.Statement));
        }

        public override SyntaxNode? VisitForEachStatement(ForEachStatementSyntax node)
        {
            var visited = (ForEachStatementSyntax)base.VisitForEachStatement(node)!;
            return visited.WithStatement(WithCheck(visited.Statement));
        }

        public override SyntaxNode? VisitForEachVariableStatement(ForEachVariableStatementSyntax node)
        {
            var visited = (ForEachVariableStatementSyntax)base.VisitForEachVariableStatement(node)!;
            return visited.WithStatement(WithCheck(visited.Statement));
        }

        public override SyntaxNode? VisitWhileStatement(WhileStatementSyntax node)
        {
            var visited = (WhileStatementSyntax)base.VisitWhileStatement(node)!;
            return visited.WithStatement(WithCheck(visited.Statement));
        }

        public override SyntaxNode? VisitDoStatement(DoStatementSyntax node)
        {
            var visited = (DoStatementSyntax)base.VisitDoStatement(node)!;
            return visited.WithStatement(WithCheck(visited.Statement));
        }

        private static StatementSyntax WithCheck(StatementSyntax body)
        {
            var check = SyntaxFactory.ParseStatement($"{CheckMethod}(); ");
            if (body is BlockSyntax block)
            {
                return block.WithStatements(block.Statements.Insert(0, check));
            }

            // "{ check; body }" on the body's own line: the braces carry no line breaks.
            return SyntaxFactory.Block(check, body.WithoutLeadingTrivia().WithoutTrailingTrivia())
                .WithLeadingTrivia(body.GetLeadingTrivia())
                .WithTrailingTrivia(body.GetTrailingTrivia());
        }
    }
}
