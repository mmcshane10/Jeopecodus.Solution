using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JeopicodusAPI.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FillInTheBlank",
                columns: table => new
                {
                    FillInTheBlankId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Category = table.Column<string>(nullable: true),
                    Difficulty = table.Column<string>(nullable: true),
                    Prompt = table.Column<string>(nullable: true),
                    Answer = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FillInTheBlank", x => x.FillInTheBlankId);
                });

            migrationBuilder.CreateTable(
                name: "MultipleChoice",
                columns: table => new
                {
                    MultipleChoiceId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Category = table.Column<string>(nullable: true),
                    Difficulty = table.Column<string>(nullable: true),
                    Prompt = table.Column<string>(nullable: true),
                    Answer = table.Column<string>(nullable: true),
                    Wrong1 = table.Column<string>(nullable: true),
                    Wrong2 = table.Column<string>(nullable: true),
                    Wrong3 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MultipleChoice", x => x.MultipleChoiceId);
                });

            migrationBuilder.InsertData(
                table: "FillInTheBlank",
                columns: new[] { "FillInTheBlankId", "Answer", "Category", "Difficulty", "Prompt" },
                values: new object[,]
                {
                    { 1, "operators", "General", "Easy", "+, -, *, /, and % are called _________. They are special characters that indicate an action to be performed." },
                    { 34, "api key", "JavaScript", "Easy", "An _________ is a special code that gives us permission to request API data, and ties any requests we make in our application to an account we own" },
                    { 36, "c#", "C#", "Easy", "_________ is a strictly-typed compiled language developed by Microsoft." },
                    { 37, "core", "C#", "Medium", ".NET _________ is an open-source, light-weight version of the full .NET Framework." },
                    { 38, "namespace", "C#", "Medium", "A _________ is used to group interrelated and independent classes together. It is a keyword used to ID sets of classes. " },
                    { 39, "using", "C#", "Medium", "The keyword '_________' is called a directive. It tells C# that the code in this file will be implementing code that isn't contained in this file or in this file's namespace." },
                    { 40, "static", "C#", "Medium", "_________ methods are methods that are called on the class itself, rather than an instance." },
                    { 41, "refactoring", "General", "Easy", "_________ is the process of restructuring existing code without changing its external behavior and with the purpose of improving its readability and reducing its complexity." },
                    { 42, "casting", "C#", "Medium", "_________ is the act of turning one variable type into another variable type" },
                    { 43, "teardown", "Testing", "Hard", "A _________ method is used to reset data between each test, ensuring one's test results aren't affected by earlier results." },
                    { 44, "exception handling", "General", "Hard", "_________ refers to the act of coding a program to handle exceptions in a manner that doesn't lead to the application crashing." },
                    { 45, "interface", "C#", "Hard", "An _________ is a blueprint of things (such as declarations, properties and methods) that must be included within any class that utiliizes this." },
                    { 46, "abstract", "C#", "Hard", "An _________ class is never intended to be instantiated directly and are typically used to define a base class in the class heirarchy." },
                    { 47, "overloaded", "C#", "Hard", "When we define two or more constructors in a class, constructors that differ from the original are called _________ constructors." },
                    { 48, "client", "General", "Medium", "A _________ is usually a web browser, like Chrome or Firefox, but can be anything that facilitates interaction with the web." },
                    { 49, "server", "General", "Medium", "A _________ is a machine that contains resources (like web pages and files) that can be requested by a client." },
                    { 50, "response", "General", "Medium", "When a server receives a request from a client, it contructs and sends a _________ containing the resources necessary for that specific page." },
                    { 51, "encapsulation", "C#", "Hard", "Allowing a class to have total control over its own fields, preventing other classes from accessing and altering fields, and making code more maintainable are all benefits of _________." },
                    { 52, "property", "C#", "Medium", "A _________ is a member of a class that provides a flexible mechanism to read, write, or compute the value of a private field." },
                    { 53, "abstraction", "C#", "Medium", "In object-oriented programming, _________ is the process of hiding and encapsulating complex code so that it's easier to use." },
                    { 54, "edge cases", "Testing", "Hard", "Good testing should cover not just expected inputs but also _________, which are extreme or unusual parameters passed into a method." },
                    { 55, "csproj", "C#", "Easy", "Anytime we update a ._________ file, we need to run dotnet restore to download and install updated packages." },
                    { 56, "try/catch", "Testing", "Hard", "We can manually add code to tell our application how to handle exceptions by using _________/_________ blocks." },
                    { 57, "try/catch", "Testing", "Hard", "We can manually add code to tell our application how to handle exceptions by using _________/_________ blocks." },
                    { 58, "model", "C#", "Easy", "In the MVC framework, a _________ represents the application's data." },
                    { 59, "view", "C#", "Easy", "In the MVC framework, a _________ represents the user interface of the application." },
                    { 60, "controller", "C#", "Medium", "In the MVC framework, a _________ acts as the bridge between the data and the user interface." },
                    { 61, "razor", "C#", "Medium", "The _________ templating engine allows us to add C# logic to our views using models we created." },
                    { 33, "timeout", "JavaScript", "Medium", "set_________() calls a piece of code once, after a set duration of time." },
                    { 32, "interval", "JavaScript", "Medium", "set_________() calls a piece of code multiple times, with a specific amount of time between each call." },
                    { 35, "json", "JavaScript", "Medium", "A _________ object is mostly a collection of nested key-value pairs, and is commonly used for transmitting data in web applications." },
                    { 30, "let", "JavaScript", "Easy", "We should use _________ when we want to declare a variable that changes." },
                    { 2, "modulo", "General", "Easy", "9 % 2; returns the remainder of 9 divided by 2. % is called _________." },
                    { 3, "arguments", "JavaScript", "Easy", "Some methods take one or more _________ that provide the method with additional information to help it perform its action." },
                    { 4, "DOM", "General", "Easy", "The _________ is your browser's interpretation of the HTML it reads." },
                    { 5, "global", "JavaScript", "Easy", "Variables declared outside of functions have _________ scope which means that all code and functions can access them." },
                    { 6, "local", "JavaScript", "Easy", "Variables with _________ scope only exist and are available during the execution of the function in which they are defined." },
                    { 7, "business", "JavaScript", "Easy", "_________ logic handles calculations and manipulation of data 'behind the scenes'." },
                    { 8, "user interface", "JavaScript", "Easy", "_________ logic handles interacting with the user, including gathering user input, updating and displaying information on the page, etc.." },
                    { 9, "branching", "JavaScript", "Easy", "Determining the flow of your code based on certain conditions is called _________. (ie: If something is true, do one thing. If this same thing is false, do a different thing.)" },
                    { 10, "primitive", "JavaScript", "Easy", "A boolean, integer, and string are a few of types of _________ data types" },
                    { 11, "falsey", "JavaScript", "Easy", "Empty strings, the number 0, NaN, undefined, null, and false itself are all types of _________ values" },
                    { 31, "lexical", "JavaScript", "Easy", "_________ scoping means a variable can only be called in the block where it’s defined." },
                    { 13, "don't repeat yourself", "General", "Easy", "DRY stands for _________ and refers to code that is well-refactored and efficient, instead of redundant. DRY code has many benefits, including being easier to maintain and update, and easier to debug when issues occur." },
                    { 14, "mapping", "JavaScript", "Medium", "Array _________ creates a new array with the results of calling the provided function on every element of the original array." },
                    { 15, "", "JavaScript", "Easy", "" },
                    { 12, "Looping", "JavaScript", "Easy", "_________ allows JavaScript to repeat an action until some condition is met." },
                    { 17, "Behavior Driven Development", "Testing", "Easy", "What does BDD stand for?" },
                    { 29, "syntactic sugar", "JavaScript", "Medium", "_________ is a term developers use for added functionality in a programming language that makes it easier to write and read." },
                    { 28, "prototypal", "JavaScript", "Medium", "With _________ inheritance, objects inherit from other objects." },
                    { 16, "specs", "Testing", "Easy", "In Behavior-Driven Development, _________ are examples of small, isolated behaviors a program should demonstrate, including input and output examples." },
                    { 27, "classical", "JavaScript", "Medium", "_________ inheritance simply means that one class inherits from another class." },
                    { 26, "ECMAscript", "JavaScript", "Easy", "What is the official name for Javascript?" },
                    { 24, "const", "JavaScript", "Easy", "We should use _________ when we want to declare a variable that does not change." },
                    { 25, "gitignore", "Git", "Easy", "You create this file so that it isn't trackable by Github. " },
                    { 22, "entry point", "JavaScript", "Medium", "In webpack, the Main.js file is an example of this, the 'door leading into our application'." },
                    { 21, "node package manager", "JavaScript", "Easy", "NPM is used to add open-source JavaScript libraries to your application. What does it stand for?" },
                    { 20, "prototypes", "JavaScript", "Medium", "JavaScript employs _________, which are just objects from which other objects inherit methods." },
                    { 19, "constructor", "JavaScript", "Medium", "A _________ is a function that can be invoked using the 'new' keyword to create new objects." },
                    { 18, "Test Driven Development", "Testing", "Easy", "What does TDD stand for?" },
                    { 23, "refactor", "Testing", "Easy", "The BDD workflow is known as red, green, _________" }
                });

            migrationBuilder.InsertData(
                table: "MultipleChoice",
                columns: new[] { "MultipleChoiceId", "Answer", "Category", "Difficulty", "Prompt", "Wrong1", "Wrong2", "Wrong3" },
                values: new object[,]
                {
                    { 5, "Associate", "C#", "Medium", "To help keep organized, we break down individual tests into three sections. Which one of the following is NOT one of those?", "Act", "Assert", "Arrange" },
                    { 6, "Identify the simplest possible behavior of the program.", "Testing", "Easy", "Which of the following is step one of the BDD process when testing code?", "Check if code can be refactored.", "Implement the behavior with the least amount of code possible.", "Write a coded test." },
                    { 4, "Completed", "JavaScript", "Medium", "A promise can have three states. Which one of the following is NOT one of those?", "Pending", "Fulfilled", "Rejected" },
                    { 7, "Encapsulation", "General", "Medium", "The idea of bundling attributes and methods that work on that data within one unit (i.e. a class in JavaScript or C#) is called what?", "Abstraction", "Modularization", "Privatizing" },
                    { 2, "Asynchronous JavaScript And XML", "General", "Hard", "When retrieving API data, we use something called AJAX to make our web requests. What does AJAX stand for?", "Asynchronous JSON And XML", "Application JSON And XML", "Application JavaScript And XML" },
                    { 1, "read-evaluate-print-loop", "C#", "Hard", "Dotnet script is a REPL tool. What does REPL stand for?", "refactor-exchange-print-loop", "refactor-evaluate-print-locate", "read-exchange-print-locate" },
                    { 9, "", "", "", "", "", "", "" },
                    { 3, "Single-threaded and non-blocking", "JavaScript", "Hard", "The JavaScript language is considered:", "Single-threaded and blocking", "Multi-threaded and non-blocking", "Multi-threaded and blocking" },
                    { 8, "Abstraction", "General", "Medium", "One of the key concepts of object-oriented programming languages is this, the act of reducing complexity by hiding unnecessary details from the user.", "Encapsulation", "Modularization", "Obscuration" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FillInTheBlank");

            migrationBuilder.DropTable(
                name: "MultipleChoice");
        }
    }
}
