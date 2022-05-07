# MiniImp+

MiniImp+ is a simple and minimal imperative programming language that is a superset of the MiniImp language that was presented in the _Programming Paradigms in Practise (2022)_ course.

Currently, this particular implementation of MiniImp+ compiler/transpiler takes a program written in MiniImp+ as input and produces a Python program as output.

This implemenation of MiniImp+ is built using .NET Core (C#) and [ANTLR v4](https://github.com/antlr/antlr4). ANTLR is used to generate the parser and lexer classes, whereas .NET Core is used for the rest, like handling the command line arguments and code generation (MiniImp+ to Python).

## Example

Input MiniImp+ source (calculator.mip)

```
program CALCULATOR begin
  var PI = 3;
  var ANSWER = PI;
  var X = 9;

  while not is X PI begin
    set ANSWER = ANSWER + X;
    set X = X - 1;
  end.

  write ANSWER;
end.
```

Output Python source (calculator.py)

```Python
def CALCULATOR():
    PI = 3
    ANSWER = PI
    X = 9
    while not X == PI:
        ANSWER = ANSWER+X
        X = X-1
    print(ANSWER)
CALCULATOR()
```

```
$ py calculator.py
42
```

### Rock, Paper, Scissors Test Program

[rock_paper_scissors.mip](examples/rock_paper_scissors.mip) contains a simple demo application that implements a _rock, paper, scissors_ game between two players.

## Language Constructs

This MiniImp+ implementation consists of the following language constructs:

-   literals: numbers, truth values
-   arithmetic operators: +, -, \*, /
-   boolean operators: not
-   equivalence test: is
-   control flow constructs: while, if
-   I/O: write
-   variable (re)definitions and references
-   boolean operators: and, or
-   literals: strings
-   type casts: from int to string, from string to int
-   I/O: read (results in a string value)

# Usage

## Prerequisites

-   [.NET Core 3.1 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/3.1)
-   git

## Running

1. `git clone`
2. `cd MiniImpPlus`
3. `dotnet build`
4. `dotnet run -- <params>`

Example:

`dotnet run -- examples/rock_paper_scissors.mip -o output/`

Alternatively, the MiniImp+ compiler can also be downloaded as a standalone CLI from [releases](https://github.com/mabenj/MiniImpPlus/releases) page (Windows and Linux supported).

## Development

1. Open the MiniImpPlus project in Visual Studio (or Visual Studio Code)
2. Start coding

Note: After modifying the grammar file `src/antlr4/MiniImpPlus.g4`, the parser and lexer classes must be updated as well by running the following command:

`java -jar .\src\antlr4\antlr-4.10.1-complete.jar -Dlanguage=CSharp -visitor .\src\antlr4\MiniImpPlus.g4`
