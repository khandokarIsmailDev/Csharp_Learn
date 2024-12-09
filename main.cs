// class Ami{
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


class MainProgram{
    public static void Main(string[] args){
        Console.Write("Enter your name: ");
        string data = Console.ReadLine();

        Console.WriteLine(data);

    }
}