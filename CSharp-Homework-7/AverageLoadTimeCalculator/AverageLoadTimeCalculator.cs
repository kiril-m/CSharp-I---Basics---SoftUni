//We have a report that holds dates, web site URLs and load times (in seconds) in the same format like in the examples below. Your tasks is to calculate the average load time for each URL. Print the URLs in the same order as they first appear in the input report. Print the output in the format given below. Use double floating-point precision. Examples:
//Input	
//2014-Mar-02 11:33 http://softuni.bg 8.37725
//2014-Mar-02 11:34 http://www.google.com 1.335
//2014-Mar-03 21:03 http://softuni.bg 7.25
//2014-Mar-03 22:00 http://www.google.com 2.44
//2014-Mar-03 22:01 http://www.google.com 2.45
//2014-Mar-03 22:01 http://www.google.com 2.77

//Output
//http://softuni.bg -> 7.813625
//http://www.google.com -> 2.24875
//Input
//2014-Apr-01 02:01 http://softuni.bg 8.37725
//2014-Apr-01 02:05 http://www.nakov.com 11.622
//2014-Apr-01 02:06 http://softuni.bg 4.33
//2014-Apr-01 02:11 http://www.google.com 1.94
//2014-Apr-01 02:11 http://www.google.com 2.011
//2014-Apr-01 02:12 http://www.google.com 4.882
//2014-Apr-01 02:34 http://softuni.bg 4.885
//2014-Apr-01 02:36 http://www.nakov.com 10.74
//2014-Apr-01 02:36 http://www.nakov.com 11.75
//2014-Apr-01 02:38 http://softuni.bg 3.886
//2014-Apr-01 02:44 http://www.google.com 1.04
//2014-Apr-01 02:48 http://www.google.com 1.4555
//2014-Apr-01 02:55 http://www.google.com 1.977
//Output
//http://softuni.bg -> 5.3695625
//http://www.nakov.com -> 11.3706666666667
//http://www.google.com -> 2.21758333333333


using System;
using System.Collections.Generic;
using System.Linq;

class AverageLoadTimeCalculator
{

    class LogLine
    {
        public DateTime Time;
        public string Website;
        public double LoadingTime;
    }

    static void Main()
    {
        System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
        customCulture.NumberFormat.NumberDecimalSeparator = ".";

        System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
    start:
        Console.Write("Please enter the number of logs: ");
        int n = int.Parse(Console.ReadLine());

        List<string> output = new List<string>();

        List<string> firstset = new List<string>();

        //DATE, time, website, average loading time(avg)
        List<DateTime> date = new List<DateTime>();
        List<DateTime> hours = new List<DateTime>();
        List<string> website = new List<string>();
        List<double> loadingtimes = new List<double>();


        var logLines = new List<LogLine>(); 

        Console.WriteLine("Please, enter the logs: ");
        for (int i = 0, numberoflist = 0; i < n; i++)
        {
            var logLine = new LogLine();
            string input = Console.ReadLine();
         
            do
            {
                int namelength = input.IndexOf(' ');
                if (namelength == -1)
                {
                 
                    var time = double.Parse(input);
                    loadingtimes.Add(time);

                    logLine.LoadingTime = time;

                    numberoflist = 0;
                    break;
                }
                string inputletters = input.Substring(0, namelength);
                numberoflist++;
                if (numberoflist == 1)
                {
                    date.Add(DateTime.Parse(inputletters));
                }
                if (numberoflist == 2)
                {
                    hours.Add(DateTime.Parse(inputletters));
                }
                if (numberoflist == 3)
                {
                    website.Add(inputletters);

                    logLine.Website = inputletters;
                }
                input = input.Substring(namelength + 1, input.Length - namelength - 1);

            } while (input.Length != 0);

            logLines.Add(logLine);
        }

        List<string> outputwebsites = new List<string>();
        for (int i = 0; i < website.Count; i++)
        {
            if (output.Contains(website[i]) == false)
            {
                output.Add(website[i]);
            }
        }


        //one way is using dictionaries
        var Websiteplusloadingtimes = new Dictionary<string, double>();

        var loadingTimesCombined = new Dictionary<string, List<double>>();

        foreach (var line in logLines)
        {
            if (!loadingTimesCombined.ContainsKey(line.Website))
            {
                loadingTimesCombined.Add(line.Website, new List<double>());
            }

            loadingTimesCombined[line.Website].Add(line.LoadingTime);
        }
        Console.WriteLine();
        Console.WriteLine("Using dictionaries solution: ");
        foreach (var websiteInfo in loadingTimesCombined)
        {
            Console.WriteLine(string.Format("{0} -> {1} ms", websiteInfo.Key, websiteInfo.Value.Average()));
        }

        //another way of doing it is with lambda expressions, which is much shorter 
        Console.WriteLine();
        Console.WriteLine("Lambda expressions solution: ");
        var averageLoadTimes = logLines.GroupBy(l => l.Website).ToDictionary(g => g.Key, g => g.Average(l => l.LoadingTime));

        averageLoadTimes.ToList().ForEach(kvp => Console.WriteLine(string.Format("{0} -> {1} ms", kvp.Key, kvp.Value)));

        Console.ReadLine();
        goto start;
    }
}

