using System.Data;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

//string s = "Python is a fun programming language";
Random rnd = new Random();
double randomValue = 0;



/*
start_time = DateTime.Now;
foreach (int i in Enumerable.Range(0, 100000000))
    randomValue = new Random().NextDouble() * 100;
Console.WriteLine(string.Format("Total: {0} sec", (DateTime.Now - start_time).TotalSeconds));
*/


DateTime start_time = DateTime.Now;


double max_range = 10.5;
double min_range = 0;
foreach (int i in Enumerable.Range(0, 100000000))
    randomValue = rnd.NextDouble() * (max_range - min_range) + min_range;
Console.WriteLine(string.Format("Total: {0} sec", (DateTime.Now - start_time).TotalSeconds));

start_time = DateTime.Now;
foreach (int i in Enumerable.Range(0, 100000000))
    randomValue = rnd.NextDouble();
Console.WriteLine(string.Format("Total: {0} sec", (DateTime.Now - start_time).TotalSeconds));


start_time = DateTime.Now;
foreach (int i in Enumerable.Range(0, 100000000))
    randomValue = rnd.NextDouble() * 100;
Console.WriteLine(string.Format("Total: {0} sec", (DateTime.Now - start_time).TotalSeconds));

start_time = DateTime.Now;
foreach (int i in Enumerable.Range(0, 100000000))
    randomValue = rnd.NextDouble() + rnd.Next();
Console.WriteLine(string.Format("Total: {0} sec", (DateTime.Now - start_time).TotalSeconds));

