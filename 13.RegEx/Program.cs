using System.Data;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

string s = "Python is a fun programming language";

DateTime start_time = DateTime.Now;

foreach(int i in Enumerable.Range(0,10000000))
    s.IndexOf("fun");

Console.WriteLine(string.Format("s.find: {0} sec", (DateTime.Now - start_time).TotalSeconds ));

start_time = DateTime.Now;
Regex r = new Regex(@"fun", RegexOptions.Compiled);

foreach(int i in Enumerable.Range(0,10000000))
    r.Match(s);

Console.WriteLine(string.Format("s.find: {0} sec", (DateTime.Now - start_time).TotalSeconds ));