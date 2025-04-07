using GeniusIdiotConsoleApp;
using GeniusIdiotConsoleApp.Data;
using GeniusIdiotConsoleApp.Data.XML;
using System.Linq;

int[] Numbers = [-11, - 12, 13, 14];

var M = Numbers.Where(numbers => numbers % 2 == 1);

Console.WriteLine(string.Join(" ", M));

// Questionnaire.FormFilling(); // Data/XML/XMLFiles/DATA.xml
