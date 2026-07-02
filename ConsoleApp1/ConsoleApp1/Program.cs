using System;
using System.Collections.Generic;
using System.Globalization;

namespace ConsoleApp1;

// task 1
// interface ICalc
// {
//     int Less(int valueToCompare);
//     int Greater(int valueToCompare);
// }
//
//
// class MyArray : ICalc
// {
//    private List<int> _elements;
//
//    public MyArray(List<int> elements)
//    {
//        _elements = elements;
//    }
//    
//    
//    
//    public int Less(int valueToCompare)
//     {
//         int sum = 0;
//         foreach (var VARIABLE in _elements)
//         {
//             if (VARIABLE < valueToCompare)
//             {
//                 sum++;
//             }
//         }
//
//         return sum;
//     }
//
//     public int Greater(int valueToCompare)
//     {
//         int sum2 = 0;
//         foreach (var VARIABLE in _elements)
//         {
//             if (VARIABLE > valueToCompare)
//             {
//                 sum2++;
//             }
//             
//         }
//         return sum2;
//     }
//
//     public void show()
//     {
//         foreach (var VARIABLE in _elements)
//         {
//             Console.Write(VARIABLE  + " ");
//       
//         }
//
//         Console.WriteLine();
//         
//     }
//     
// }
//
//
// class Program
// {
//     static void Main(string[] args)
//     {
//         
//         List<int> arr = new List<int> {100,33,5,35,73,7,345,234,55 }; 
//         MyArray MYarray = new MyArray(arr);
//
//         Console.Write("Siyahı elementləri: ");
//         MYarray.show();
//         int target = 34;
//         Console.WriteLine($"{target} ədədindən kiçiklərin sayı: " + MYarray.Less(target));
//         Console.WriteLine($"{target} ədədindən böyüklərin sayı: " + MYarray.Greater(target));
//
//
//
//     }
// }





// task 2

//
// interface IOutput2
// {
//     void ShowEven();
//     void ShowOdd();
// }
//
//
// class MyArray : IOutput2
// {
//    private List<int> _elements;
//    private IOutput2 _calc2Implementation;
//
//    public MyArray(List<int> elements)
//    {
//        _elements = elements;
//    }
//    
//    
//    
//    public void ShowEven()
//     {
//         foreach (var VARIABLE in _elements)
//         {
//             if (VARIABLE % 2==0)
//             {
//                 Console.Write(VARIABLE +" ");  
//             }
//         }
//         Console.WriteLine();
//         
//     }
//
//     public void ShowOdd()
//     {
//         
//         foreach (var VARIABLE in _elements)
//         {
//             if (VARIABLE % 2!=0)
//             {
//                 Console.Write(VARIABLE +" ");
//             }
//         }
//         Console.WriteLine();
//     }
//
//     public void show()
//     {
//         foreach (var VARIABLE in _elements)
//         {
//             Console.Write(VARIABLE + " ");
//      
//         }
//
//         Console.WriteLine();
//         
//     }
//
//
//   
// }
//
//
// class Program
// {
//     static void Main(string[] args)
//     {
//         List<int> arr = new List<int> { 100, 33, 5, 35, 7, 234, 55 }; 
//         MyArray MYarray = new MyArray(arr);
//
//         Console.Write("Siyahı elementləri: ");
//         MYarray.show();
//         Console.WriteLine("-----------------------------------");
//
//         Console.Write("Cüt elementlər: ");
//         MYarray.ShowEven();
//
//         Console.Write("Tək elementlər: ");
//         MYarray.ShowOdd();
//         
//
//     }
// }






// task 3

interface ICalc2
{
    int CountDistinct();
    int EqualToValue(int valueToCompare);
}

class MyArray : ICalc2
{
    private List<int> _elements;

    public MyArray(List<int> elements)
    {
        _elements = elements;
    }

    
    public int CountDistinct()
    {
        List<int> uniqueElements = new List<int>();

        foreach (var VARIABLE in _elements)
        {
           
            if (!uniqueElements.Contains(VARIABLE))
            {
                uniqueElements.Add(VARIABLE);
            }
        }

        return uniqueElements.Count;
    }

 
    public int EqualToValue(int valueToCompare)
    {
        int sum = 0;
        foreach (var VARIABLE in _elements)
        {
            if (VARIABLE == valueToCompare)
            {
                sum++;
            }
        }
        return sum;
    }

    public void show()
    {
        foreach (var VARIABLE in _elements)
        {
            Console.Write(VARIABLE + " ");
        }
        Console.WriteLine();
    }
}

class Program
{
    static void Main(string[] args)
    {

        List<int> arr = new List<int> { 10, 20, 10, 30, 20, 40, 50, 10 }; 
        MyArray MYarray = new MyArray(arr);

        Console.Write("Siyahı elementləri: ");
        MYarray.show();
        Console.WriteLine("-----------------------------------");
        
        Console.WriteLine($"Unikal elementlərin sayı: " + MYarray.CountDistinct());
        
        int target = 10;
        Console.WriteLine($"{target} ədədinə bərabər olanların sayı: " + MYarray.EqualToValue(target));

    }
}