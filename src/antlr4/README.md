### To update lexer and parser after updating the grammar file
`java -jar .\antlr-4.10.1-complete.jar -Dlanguage=CSharp .\MiniImpPlus.g4 -visitor`