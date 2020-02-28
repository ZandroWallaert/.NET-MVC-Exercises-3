using System;
using System.Linq;
using System.Collections.Generic;
using System.IO;
//using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using BusinessLogic.Linq;


// REFERENCE: https://docs.microsoft.com/en-us/dotnet/framework/data/adonet/ef/language-reference/supported-and-unsupported-linq-methods-linq-to-entities

namespace linq_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            runNumbersHandler();
            runStudentHandler();
            runCardHandler();
        }


        private static void runNumbersHandler()
        {
            NumbersHandler handler = new NumbersHandler();
            handler.DivisibleBy(5);
            handler.DivisibleByAndOrderedAsc(5);
            handler.BiggestNumber();
            handler.SecondLastNumber();
            handler.SecondLargest();
        }
        
        private static void runStudentHandler()
        {
            StudentHandler handler = new StudentHandler();
            handler.StudentOrderByFirstName();
            handler.StartsWithSameCharInFirstNameAndLastName();
            handler.AverageAgeFemaleStudents();
            handler.StudentLargestCodeByFormula();
        }
        private static void runCardHandler()
        {
            CardHandler handler = new CardHandler();
            handler.CountCards();
            handler.CardWithNumber(350);
            handler.CardsStartingWith("A");
            handler.CardsStartingWithUnique("A");
            handler.CovertedManaCostGreaterThen6();
            handler.allCreatureCardsWithRarity("Rare");
            handler.allPosibleTypes();
            //handler.TranslationsOrderByNumberTop(3);
            handler.InPrintings("USG");
        }
    }
}
