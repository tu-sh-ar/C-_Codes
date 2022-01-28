using System;
using System.Collections.Generic;

namespace App_DateCompare;
class DateCompare
{
    
    
    static void Main(string[] args)
    {
        string flag = "";

        do
        {
            Console.WriteLine("--------Please Enter Date in  \"DDMMYY\" Format--------");
            Console.WriteLine("******Enter First Date*******");
            string userInput1 = Console.ReadLine().Trim();
            Console.WriteLine("******Enter Second Date*******");
            string userInput2 = Console.ReadLine().Trim();

            List<int> list1 = new List<int>();
            List<int> list2 = new List<int>();
            DateCompare dateCompare = new DateCompare();
            list1 = dateCompare.Check_Convert(userInput1);
            list2 = dateCompare.Check_Convert(userInput2);
            if (list1.Count != 0)
            {
                Console.WriteLine(dateCompare.FindDiff(list1, list2));
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
            Console.WriteLine("Do you want to print Again? press y/n");
            flag = Console.ReadLine();
        }
        while (flag=="y");
    }

    internal List<int> Check_Convert(string data)
    {
        List<int> list = new List<int>();
        try
        {
            int day = int.Parse(data.Substring(0, 2).Trim());
            day = Math.Abs(day);
            
            int month = int.Parse(data.Substring(2, 2).Trim());
            month = Math.Abs(month);
            int year = int.Parse(data.Substring(4, 4).Trim());
            month = Math.Abs(month);
            if (day < 32 && month < 13 && day!=0 && month!=0 && year!=0) 
            {
                if(month==2 && day >= 30)
                {
                    throw new Exception();
                }
                list.Add(day);
                list.Add(month);
                list.Add(year);
            }
            else
            {
                throw new Exception();
            }
        }
        catch (Exception ex) {
            
            return list;
        }
        return list;
    }

    internal string FindDiff(List<int> list1,List<int> list2) {
        var day = "Diff In Day=" + Math.Abs(list1[0] - list2[0]);
        var month = " Month=" + Math.Abs(list1[1] - list2[1]);
        var year = " year=" + Math.Abs(list1[2] - list2[2]);
        string diff = day+month+year;

        return diff;
    
    }

   

    
  
    
}
