using System;
using System.Text;
using System.Collections;
using System.Text.RegularExpressions;



namespace HelloWorld
{

    //public interface IText
    //{
    //    void Print();

    //}
    //class Format : IText
    //{
    //    public void Print()
    //    {
    //        Console.WriteLine("live a life");

    //    }
    //}
    //public class ConstructorInjection
    //{
    //    private readonly IText fg;
    //    public ConstructorInjection(IText t1)
    //    {
    //        this.fg = t1;
    //    }
    //    public void Print()
    //    {
    //        fg.Print();
    //    }
    //}
    //class Constructor
    //{
    //    static void Main(string[] args)
    //    {
    //        ConstructorInjection df = new ConstructorInjection(BinaryWriter Format());
    //        df.Print();
    //        Console.ReadKey();

    //    }
    //}
    //public interface INotificationAction
    //{
    //    void ActionONNotification(string message);
    //}
    //class Simple
    //{
    //    INotificationAction task = null;
    //    public void notify(INotificationAction at, string messages)
    //    {
    //        this.task = at;
    //        task.ActionONNotification(messages);
    //    }
    //}
    //class EventlogWriter: INotificationAction 
    //{
    //    public void ActONNOtification (string message)
    //    {
    //        Console.WriteLine("what are you waiting for");

    //    }
    //}
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        EventlogWriter gh1 = new EventlogWriter();
    //        Simple gh = new Simple();
    //        gh.notify(gh1, "property injection"
    //            );
    //        Console.ReadKey();

    //    }
    //}
    internal class User
    {
        private ConsoleNotifiaction NotificationService;
        public User()
        {
            // Just created to run the Value and reference type check up 
        }
        public User (string uname)
        {
            UserName = uname;
            NotificationService = new ConsoleNotifiaction();


        }
        public string UserName { get; private set; }
        public void ChangeUserName(string newunmae)
        {
            UserName = newunmae;
            NotificationService.NotifyUserNameChanged(this);
        }
        public dynamic ValueAndReferenceType( dynamic x ) //method created to check valu <=> reference type and dynamic callig returning 
        {
            string  d = "Damien";
            int  d1 = 12;
            return ( d1, d ); // to the shock its returning both the output
        }
    }
    internal class ConsoleNotifiaction
    {
        public void NotifyUserNameChanged(User user)
        {
            Console.WriteLine($"The User Name has been changed:{user.UserName}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //var user1 = new User("Tim");
            //user1.ChangeUserName("Robert");

            //Console.ReadKey();

            /* to check the data type 
            var fg = 100.559m;
            Console.WriteLine("fg datatype is {0}", fg.GetType());
            
            var fg = new FileInfo("My File"); //[] { 0, 1, 2, 3 }; //{ name = "string" };
            Console.WriteLine("fg datatype is {0}", fg.GetType());
            */

            /* SIMPLE TYPE CONVERSION 
            int i = 2000; char fg = 'a';
            float j = i, h = fg; // IMPLICIT TYPE CONVERSION AND RETURN Single DATATYPE
            decimal m= default ;
            decimal g = (decimal)j; // EXPLICIT TYPE CONVERSION AND RETURN SAME (DECALARED) DATATYPE

            Console.WriteLine(" float declaration of integer i is {0} " +
                "\n  its type after declaration {1} and \n before delacaration {2} " +
                "\n the char datatype is {3} ", j,j.GetType(), i.GetType(),h.GetType());
            Console.WriteLine("{0}{1}", m.GetType(), g.GetType());
            */

            // Number type and its maximum, minimum value
            /*
            Console.WriteLine(Byte.MaxValue); Console.WriteLine( byte.MaxValue);
            Console.WriteLine( Byte.MinValue);
            Console.WriteLine( Int16.MaxValue );
            Console.WriteLine(float.MaxValue);
            Console.WriteLine(decimal.MaxValue);
            */
            // Hexadecimal and Binary numbers in INT datatype
            /*
             int hex = 0x100F;
             int binary = 0b_1000_1111_1111;


             Console.WriteLine(hex);
             Console.WriteLine(binary);
            */

            //string vs String
            /*
            string str1 = "Hello";
            String str2 = "World!";

            Console.WriteLine(str1.GetType()); // System.String
            Console.WriteLine(str2.GetType()); // System.String
            */

            //String type conversion from Char
            /*
            char[] fg = { 'a', 'b', 'c' };
            // string fg2 = fg; //implicit conversion didnt work
            //string fg1 = (string)fg; //explicit conversion also didnt work
            string fg3 = new string(fg); //non-type conversion works
            Console.WriteLine(" the char array  is {2} \n the data type of char after conversion is {0}," +
                "\n and its string is {1}", fg3.GetType(),fg3, fg );
            Console.WriteLine(" the char array is: " + fg );
            */

            //string with special quotes
            /*

            string text = "This is a \"string\" in C#.";
            string str = "xyzdef\\rabc";
            string path = "\\\\mypc\\ shared\\project";
            Console.WriteLine( text+"\t"+ str+"\t"+path+"\t" + text );
            Console.WriteLine("===========================================");
            string str1 = @"xyzdef\rabc";
            string path1 = @"\\mypc\shared\project";
            string email = @"test@test.com";
            Console.WriteLine(str1+"\t"+ path1+"\t"+ email);
            Console.WriteLine("===========================================");
            string str2 = "this is a \n" +
        "multi line \n" +
        "string";

            // Verbatim string
            string str3 = @"this is
a multi line
string";
            Console.WriteLine( str2+"\n=============="+"\n"+str3);
            Console.WriteLine("===========================================");
            string text0 = "This is a \"string\" in C#."; // valid
            //string text1 = @"This is a "string." in C#."; // error
            //string text2 = @"This is a \"string\" in C#."; // error
            string text3 = @"This is a ""string"" in C#."; // valid

            Console.WriteLine("===========================================");
            string firstName = "James";
            string lastName = "Bond";
            string code = "007";

            string name = "Mr." + "James " + "Bond" + ", Code: 007"; // string concatation with static string

            string agent = "Mr." + firstName + " " + lastName + ", Code: " + code;// string concatation between static and variables 
            // also called as implicity type conversion

            string fullName = $"Mr. {firstName} {lastName}, Code: {code}"; // string interpolation between static string and string variables
                                                                           // NOTE: string variables are give in {} bracket
            Console.WriteLine($" cancated static string is {name} \n concatation between static and variable string {agent} \n interploates sttring between static and variable is {fullName}");
            Console.WriteLine("========================================\n++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("{0}\t{1}\t{2}\t{3}",name.GetType (), agent.GetType (), fullName.GetType (),text3.GetType ());

            */

            //DateTime Handson

            /*
            //assigns default value 01/01/0001 00:00:00
            DateTime dt1 = new DateTime();

            //assigns year, month, day
            //checked
            
                DateTime dt2 = new DateTime(2015, 12, 30);
            

            //assigns year, month, day, hour, min, seconds
            DateTime dt3 = new DateTime(2015, 12, 31, 5, 10, 20);

            //assigns year, month, day, hour, min, seconds, UTC timezone
            DateTime dt4 = new DateTime(2015, 12, 31, 5, 10, 20, DateTimeKind.Unspecified );
            Console.WriteLine("{0}\n{1}\n{2}\n{3}",dt1 ,dt2, dt3, dt4);
            //Console.WriteLine(checked(dt2));
            Console.WriteLine("-------------------------------------");
            DateTime dt = new DateTime(2022,01,01,20,59,59,999);
            //DateTime.MinValue.Ticks;  //min value of ticks
            //DateTime.MaxValue.Ticks; // max value of ticks
            TimeSpan ts = new TimeSpan(25, 20, 55);

            DateTime newDate = dt.Add(ts);
            newDate = dt.Subtract(ts);

            Console.WriteLine(newDate);
            Console.WriteLine(dt);

            */

            //string to datetime conversion
            /*
            var dtc = "59/59/23/31/12/2022";
            DateTime dt;
            var isDTCValid = DateTime.TryParse(dtc, out dt);
            if (isDTCValid)
                Console.WriteLine(dt);
            else
                Console.WriteLine($"{dtc} string cannot be converted to valid datetime format");
            */

            //String builders 
            /*
            StringBuilder sb = new StringBuilder("Hello World!",30);
            sb.Append("Extra string added");

            for (int i = 0; i < sb.Length; i++)
                Console.Write(sb[i]);
            sb.Replace("Hello World!", "Extra string added    ");
            sb.Remove(3, 7);

            Console.WriteLine("the removes SB is :"+sb);

            Console.WriteLine("------------------------");
            Console.WriteLine("the string builder is :"+sb);
            */

            //Explicit Type COnversion
            /*
            int i = -2000000000;
            uint ui = (uint)i;
            char d = 'g';
            //string gh = new string(d);
            string gh3;
            string gh1 = Convert.ToString(d);
            string gh2=gh1.ToUpper();
            DateTime dt = new DateTime(1995, 03, 29, 07, 16, 45);
            gh3 = Convert.ToString(dt);
            DateTime dt1 = new DateTime();
            var dt2 = DateTime.TryParse(gh3, out dt1 );
            Console.WriteLine("{0} is negative integer \n {1} is explixitly converted \n {2} and {3}\n {4}", i, ui, gh3,gh3.GetType(), dt1.GetType () );
            */

            //Value and reference type
            /*
            int i = 100;
            string fg = "ghjk";
            Console.WriteLine(i);
            User fgh = new User();
            fgh.ValueAndReferenceType(i);
            fgh.ValueAndReferenceType(fg);
            Console.WriteLine(i + " " +/* fgh.GetType() +-*/  /* " " + fgh.ValueAndReferenceType(i) + "" +
                "\n " + fg + " " + fgh.ValueAndReferenceType(fg));
            */

            //Exceptions

            /*
            Student newStudent = null;

            try
            {
                newStudent = new Student();
                newStudent.StudentName = "James007";

                ValidateStudent(newStudent);
            }
            catch //(Exception ex)//(InvalidStudentNameException ex)
            {
                Console.WriteLine("ex.Message");
            }


            Console.ReadKey();
        }

        private static void ValidateStudent(Student std)
        {
            Regex regex = new Regex("^[a-zA-Z]+$");

            if (!regex.IsMatch(std.StudentName))
                throw new InvalidStudentNameException(std.StudentName);
            */

            //Tenary Operator
            //Mistake : 
            //didnt have the idea to compare it with Zero as ternary operator checks true or false 
            /*
            Console.WriteLine("enter the number: ");
            var x = Convert.ToInt32(Console.ReadLine());
            var result = (x % 2==0) ? "Even" : "odd";
            Console.WriteLine($"The Given Valus is {result} ");
            */

            //Simple problem using for and if 
            //Mistake: 
            //FOund the logic of for loop 
            //Never interate the initializer

            /*
            int i = 0, j = i + 3;
            for (Console.WriteLine($"Initializer: i={i}, j={j}");
                 i++ < j--;
                 Console.WriteLine($"Iterator: i={i}, j={j}"), j = i + 3)
            {
                if (i > 3)
                    break;
            }
            */
            //Check with this problem
            /*
            int j = 3, i = j + 3;
            for (Console.WriteLine($"Initializer: i={i}, j={j}");
                 i-- > j++;
                 Console.WriteLine($"Iterator: i={j+3}, j={j}"))
            {
                if (i >= 21)
                    break;
            }
            */
            int x ,y,z;
            for (x=0;x<10;x++)
                for(y=0;y<10;y++)
                    for(z=10;z>0;z--)
                    { Console.ReadKey();
                     Console.Beep();
                        Console.WriteLine("the printed values of \n x is {0} \n y is {1} \n z is {2}",x, y , z);}
                    
             int r = 3;
            dynamic r1 =3;
            Console.WriteLine( "============== \n the value is {0} and {1}",r, r1);



        }

    }
    class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
    }

    [Serializable]
    class InvalidStudentNameException : Exception
    {
        public InvalidStudentNameException() { }

        public InvalidStudentNameException(string name)
            : base(String.Format("Invalid Student Name: {0}", name))
        {
            
        }
    }



}
