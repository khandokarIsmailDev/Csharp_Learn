﻿// class Ami{
//     public static void Main(string[] args){  
//         int number = 10;
//         long number2 = 1000000000000000000;
//         float number3 = 10.5f;
//         uint number4 = 10;

//         // একাধিক মান প্রিন্ট করতে ফরম্যাট স্ট্রিং ব্যবহার করুন
//         Console.WriteLine("number:{0},number2:{1},number3:{2},number4:{3}",number,number2,number3,number4);
//     }
// }

// class MainProgram{
//     public static void Main(string[] args){
//         bool a = true;
//         string str1 = "hello";
//         char c = 'a'; //single character
//         string str2 = str1 ;

//         Console.WriteLine("str1:{0},str2:{1},a:{2},c:{3}",str1,str2,a,c);

//     }
// }


// class MainProgram{
//     public static void Main(string[] args){
//         const int number = 10;
//         Console.WriteLine(number);
//     }
// }


// class MainProgram{
//     public static void Main(string[] args){
//         string str = "114";
//         string str2 = "114.987654321";
//         float number3 = float.Parse(str2);
//         int number = int.Parse(str);
//         Console.WriteLine(number);
//         Console.WriteLine(number.GetType());
//         Console.WriteLine(number3);
//         Console.WriteLine(number3.GetType());
//     }
// }

// class MainProgram{
//     public static void Main(string[] args){
//         decimal number = 114.34342434m;
//         int number2 = Convert.ToInt32(number);  //convert deci to int (32 bit)
//         bool a = Convert.ToBoolean(number);
//         Console.WriteLine(number2);
//         Console.WriteLine(number2.GetType());
//         Console.WriteLine(a);
//     }
// }


// class MainProgram{
//     public static void Main(string[] args){
//         Console.Write("Enter your name: ");
//         string data = Console.ReadLine();

//         Console.Write("Enter your age: ");
//         int age = int.Parse(Console.ReadLine());

//         Console.WriteLine(age);
//         Console.WriteLine(data);

//         Console.WriteLine("Your name is {0} and your age is {1}",data,age);

//     }
// } 


// class MainProgram{
//     public static void Main(string[] args){
//         string name = "ismail";
//         string nameAdd = name.Insert(0,"Mr.");
//         string nameAdd2 = name.Insert(name.Length,".com");
//         string nameAdd3 = name.Insert(2,"55");

//         Console.WriteLine(nameAdd);
//         Console.WriteLine(nameAdd2);
//         Console.WriteLine(nameAdd3);
//     }
// }

class MainProgram{
    public static void Main(string[] args){
        string str = "there is a cat";
        string str2 = "     there is    ";
        int strIndex = str.IndexOf("s");
        int lastIndex = str.LastIndexOf("a");
        bool isHere = str.EndsWith("at");
        bool startWi = str.StartsWith("the");
        bool equality =  str.Equals("there is a ca"); //icca kore vul disi t missing
        bool contentWord = str.Contains("is a");
        string removeSpace = str2.Trim();
        string firstRemoveSpace = str2.TrimStart();
        string lastRemoveSpace = str2.TrimEnd();
        string copyStr = str.Substring(3,5); //str the 3-index por 4 ta index copy korbe

        Console.WriteLine(strIndex);
        Console.WriteLine(lastIndex);
        Console.WriteLine(isHere);
        Console.WriteLine(startWi);
        Console.WriteLine(equality);
        Console.WriteLine(contentWord);
        Console.WriteLine(removeSpace);
        Console.WriteLine(firstRemoveSpace);
        Console.WriteLine(lastRemoveSpace);
        Console.WriteLine(copyStr);
    }
}