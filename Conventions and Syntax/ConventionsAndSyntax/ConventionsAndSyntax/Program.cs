// File Prologue
// Name: Jonathan Franklin
// Project: Conventions and Syntax
// Date: January 31, 2017


// I declare that the following source code was written by me, or provided
// by the instructor for this project. I understand that copying 
// source code from any other source constitutes cheating, and that I will
// receive a zero grade on this project if I am found in violation of
// this policy.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// This program will provide a brief overview of the basic principles of 
// convention and syntax within C#. This will include both single line
// and multiline comments, dot operators, semicolons, and indentation.

/********************************************************************************/

// EXAMPLE ONE:

/* Here we have a program demonstrating the principles outlined in the DGM1600
 * course module "Conventions and Syntax". Here, we can see one form of comment,
 * the multiline comment */

/********************************************************************************/

// EXAMPLE TWO:

// Here we have a single line comment.

/********************************************************************************/

// FURTHER EXPLANATION REGARDING COMMENTS:

/* Comments are useful for providing information on what specific classes, methods,
 * or even lines of code mean. They provide a means of interpretation for the human
 * reader, rather than the machine reader. This may or may not be a given, but 
 * any text entered within a comment is ignored by the interpreter or compiler.
 * Given this functionality, one may use comments to deactivate segments of code,
 * which can be critical when attempting to debug a program. */

/********************************************************************************/

//EXAMPLE THREE:
/* This example will focus on indentation. Indentation makes code readable for humans,
 * and is entirely unnecessary for the computer to read, at least in C#. Different
 * levels of indentation indicate different levels of code, for example, at the top 
 * level, we have our namespace ConventionsAndSyntax. Within this namespace, we have
 * our class, Program. And within Program, we have our method, Main. */

// Here we have our ConventionAndSyntax namespace, which will hold our Program class.
namespace ConventionsAndSyntax
{
    // This is our Program class. Within here, we will create a number of methods
    // in order to demonstrate the basic principles of C# Conventions and Syntax.
    class Program
    {
        static void Main(string[] args)
        {
            /* EXAMPLE FOUR:
             * 
             * Here we have an example of the dot operator. Here we see a period
             * between Console and WriteLine. The dot operator indicates that you
             * are accessing information within something larger, to put it overly
             * simply. To go into more detail, let's go ahead and write out the full
             * path. That would be System.Console.WriteLine. Each progressive identifier
             * indicates a smaller subset within the preceding identifier. First we have
             * System, which is a namespace. Console is a class within the System 
             * namespace. and WriteLine is a method/function within the Console class. 
             * To tie things off, we have an argument within parenthesis. This is because
             * the WriteLine method requires an input string in order to perform its function
             * and output something, in this case, outputting a constant or variable to 
             * the console. */
            Console.WriteLine("Hello World!");
            
            // EXAMPLE FIVE:

            /* Finally, we can take a look at the semicolon. The semicolon indicates the end
             * of a code statement. A statement can occupy multiple lines, but must be ended
             * with a semicolon so that the interpreter knows to move on to the next command.
             * Forgetting to semicolon is similar to forgetting to period. If you forget to 
             * period, sentences all mush together and it become impossible to read from a 
             * grammatical standpoint. */

            Console.ReadLine();
        }
    }
}
