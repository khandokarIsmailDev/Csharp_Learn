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

// class MainProgram{
//     public static void Main(string[] args){
//         string str = "there is a cat";
//         string str2 = "     there is    ";
//         int strIndex = str.IndexOf("s");
//         int lastIndex = str.LastIndexOf("a");
//         bool isHere = str.EndsWith("at");
//         bool startWi = str.StartsWith("the");
//         bool equality =  str.Equals("there is a ca"); //icca kore vul disi t missing
//         bool contentWord = str.Contains("is a");
//         string removeSpace = str2.Trim();
//         string firstRemoveSpace = str2.TrimStart();
//         string lastRemoveSpace = str2.TrimEnd();
//         string copyStr = str.Substring(3,5); //str the 3-index por 4 ta index copy korbe

//         Console.WriteLine(strIndex);
//         Console.WriteLine(lastIndex);
//         Console.WriteLine(isHere);
//         Console.WriteLine(startWi);
//         Console.WriteLine(equality);
//         Console.WriteLine(contentWord);
//         Console.WriteLine(removeSpace);
//         Console.WriteLine(firstRemoveSpace);
//         Console.WriteLine(lastRemoveSpace);
//         Console.WriteLine(copyStr);
//     }
// }


//practise to remove
// class MainProgram{
//     public static void Main(string[] arg){
//         int num = 10;
//         string age = "Your Age";
//         Console.WriteLine("{0} is {1}",age,num);
//     }
// }

// class MyPrograme{
//     public static void Main(string[] args){
//         int num1 = 100;
//         float num2 = 100.045f;
//         long num3 = 1424214;
//         Console.WriteLine("{0},{1},{2}",num1,num2,num3);
//     }
// }


// class MyPrograme{
//     public static void Main(string[] args){
//         string name = "ismail";
//         int age = 27;
//         bool jobholder = true;

//         Console.WriteLine("My name is {0}.I am {1} years old. am i jobholder? {2}",name,age,jobholder);
//     }
// }

// class MyPrograme{
//     public static void Main(string[] args){
//         string str = "112";
//         string str2 = str;
//         Console.WriteLine(str2);
//     }
// }

// using System.Reflection.Metadata;

// class MyPrograme{
//     public static void Main(string[] args){
//         string str = "ismail";
//         bool isTrue = false;
//         char aa = 'a';
//         string str2 = str;

//         Console.WriteLine("{0},{1},{2},{3}",str,isTrue,aa,str2);

//     }
// }

// class MyPrograme{
//     public static void Main(string[] args){
//         string str = "114";
//         int num = Convert.ToInt32(str);
//         Console.WriteLine("{0}{1}",str,num);
//         Console.WriteLine(num.GetType());
//     }
// }

// class MainProgram{
//     public static void Main(string[] args){
//         string str = "19";
//         int num = Convert.ToInt32(str);
//         Console.WriteLine(num);


//         decimal num11 = 12.49234241m;
//         int num12 = Convert.ToInt32(str);
//         Console.WriteLine(num12);
//         Console.WriteLine(num12.GetType());

//         bool checkNum = Convert.ToBoolean(num);
//         Console.WriteLine(checkNum);
//     }
// }


// class MainProgram{
//     public static void Main(string[] args){
//         Console.Write("Enter Your Name: ");
//         string data = Console.ReadLine();

//         Console.WriteLine(data);
        
//     }
// }

// class MainProgram{
//     public static void Main(string[] args){
//         string name = "Enter Your Name: ";
//         Console.Write(name);

//         string data = Console.ReadLine();
//         Console.Write(data);

//         string age = "Enter Your Age: ";
//         Console.Write(age);

//         string result = Console.ReadLine();
//         // Console.Write(result);


//     }
// }

// class MainProgram {
//     public static void Main(string[] args){
//         string name = "ismail";
//         string upper = name.ToUpper();
//         string lower = name.ToLower();

//         Console.WriteLine(name);
//         Console.WriteLine(upper);
//         Console.WriteLine(lower);
//     }
// }


// class MainProgram {
//     public static void Main(string[] args){
//         string name = "i am ismail";
//         string nameReplace = name.Replace("i","44");
//         Console.WriteLine(nameReplace);
//     }
// }


// class MainProgram {
//     public static void Main(string[] args){
//         string name = "i am sino";
//         string nameAdd = name.Insert(0,"Mr. ");
//         // Console.WriteLine(nameAdd);
//         string name2Add = name.Insert(1,"34");
//         // Console.WriteLine(name2Add);
//         string name3Add = name.Insert(name.Length,".com");
//         // Console.WriteLine(name3Add);

//     }
// }


// class MainProgram{
//     public static void Main(string[] args){
//         string name ="  there is a tom   ";
//         int nameIndex = name.IndexOf("i");
//         Console.WriteLine(nameIndex);

//         bool enddWith = name.EndsWith("tom  ");
//         Console.WriteLine(enddWith);

//     }
// }

// class MainProgram {
//     public static void Main(string[] args){
//         string name = "tinko";
//         int age = 12;
//         Console.WriteLine("name is {0} & age is {1}",age,name);
//     }
// }




// class MainProgram{
//     public static void Main(string[] args){
//         int num1 = 1213;
//         float num2 =234.3424f;
//         decimal num3 = 2342;
//         char  charecter = 'a';
//         bool isnumber = Convert.ToBoolean(0);

//         Console.WriteLine("{0},{1},{2},{3}{4}",num1,num2,num3,charecter,isnumber);

//     }
// }



// class MainProgram {
//     public static void Main(string[] args){
//         string str = "there is code";
//         string str2 = "there is code 2";
//         int strIndex = str.IndexOf("s");
//         int lastInde = str.LastIndexOf("e");

//         Console.WriteLine(lastInde);

//         Console.WriteLine(strIndex);
//     }
// }


// class MainProgram{
//     public static void Main(string[] args){
//         string str = "this is cup";
//         bool isHere = str.StartsWith("is");
//         bool isLast = str.EndsWith("cup");
//         Console.WriteLine(isLast);
//         Console.WriteLine(isHere);
//     }
// }


// class MainProgram{
//     public static void Main(string[] args){
//         string[] strs = new string[5];
        
//         //arrays
//         strs[0] = "one";
//         strs[1]="two";
//         strs[2] = "three";
//         strs[3] = "four";
//         strs[4] = "five";

//         for(int i=0; i<strs.Length; i++){
//             Console.WriteLine($"Element at index {i} : {strs[i]}"); // $ sign na dile kaj korbe na
//         };
//     }
// }



// class MainProgram{
//     public static void Main(string[] args){
//         int[] numbers = new int[7];

//         //arrays
//         numbers[0] = 10;
//         numbers[1] = 20;
//         numbers[2] = 30;
//         numbers[3] = 40;
//         numbers[4] = 50;
//         numbers[5] = 60;
//         numbers[6] = 70;

//         for(int i=0; i<numbers.Length; i++){
//             Console.WriteLine($"{i} : {numbers[i]}");
//         };
//     }
// }

// class MainProgram{
//     public static void Main(string[] args){
//         bool a = true;
//         string str1 = "ismail";
//         char c = 'A';
//         string str2 = str1;

//         Console.WriteLine("a:{0},str1:{1},str2:{2},str2:{3}",a,str1,c,str2);
//     }
// }


// class MainProgram{
//     public static void Main(string[] args){
//         int[] numbers = new int[] {2,3,4};
//         Console.Write("one:{0}",numbers);
//     }
// }

// class MainProgram{
//     public static void Main (string[] args){
//         int one = 1;
//         int two = 2;
//         string firstName ="khandokar";
//         string lastName = "ismail";

//         Console.WriteLine("one:{0},two:{1},firstName:{2},lastName:{3}",one,two,lastName,firstName);
//     }
// }

// class MainProgram{
//     public static void Main(string[] args){
//         string name = "ismail";
//         Int32 age = 27;
//         bool MariedStatus = true;

//         Console.WriteLine("name:{0},age:{1},MariedStatus:{2}",name,age,MariedStatus);
//     }
// }

// class MainProgram{
//     public static void Main(string[] args){
//         string name = "ismail";
//         int age = 27;
//         string location = "dhaka";

//         Console.WriteLine("my name is :{0},i am :{1} years old, i live in :{2}",name,age,location);
//     }
// }

// class MainProgram{
//     public static void Main(string[] args){
//         string name = "ismail";
//         string doing = "eating";
//         Int32 age = 27;
//         bool maried = true;
//         char c = 'B';
//         string nameDuplicate = name;

//         Console.WriteLine("name:{0},doing:{1},age:{2},maried:{3},c:{4},nameDuplicate:{5}",name,doing,maried,age,c,nameDuplicate);
//     }
// }