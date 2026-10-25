using Survey.Domain.Entities;
using Survey.Domain.Enums;
using System.Collections.ObjectModel;



//var p = new Person("amir", "123456", Role.Admin);

////Console.WriteLine(p.Role);

//var q1 = new Question("Which backend topic do you like most?", 1, new List<Option>()
//{
//    new Option("Linq"),
//    new Option("EF Core"),
//    new Option("OOP"),
//    new Option("ASP.Net"),
//});


//var option = (List<Option>)q1.Options;

//option.Add(new Option("asasa"));

//foreach (var op in q1.Options)
//{
//    Console.WriteLine(op.Text);
//}


SurveyStatus status = (SurveyStatus)0;

var s = new SurveyAgg("abcd", status);
Console.WriteLine(s.SurveyStatus);

Console.ReadKey();