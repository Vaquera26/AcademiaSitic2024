using System;
using System.Diagnostics.SymbolStore;

namespace Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string  courseName      = "Academia SITIC" ;

            String  courseName2     = "Academia SITIC 2" ;

            int     studentsCount   = 28 ;

            bool    isStartingNow   = true ;
           
            int?   age              = null ;

            /*
             
            // 1
            Console.WriteLine (    age != null ? age : 0    );

            // 2
            if (age != null)
            {
                Console.WriteLine(age);
            }
            else
            {
                Console.WriteLine(0);
            }

            // 3
            Console.WriteLine ( age.GetValueOrDefault ( 0 ) );

            Console.ReadKey();

            */

            User user = new();
            Employer emp = new();

            

     
        }

        public class User
        {
            private int _idUser;
            private string _name;
            private string _password;

            public string Password { get => _password; set => _password = value; }

            
            /*
            //Short Size
            public int IdUser { get; set; }

            // Medium Size
            private string _password;

            public string Password
            {
                get
                {
                    return _password;
                }

                set
                {
                    _password = value;  
                }

            }

            // Large Size
            public string GetName()
            {
                return _name;
            }

            public void SetName(string name )
            {
                _name = name;
            }

            */

        }

        public class Person
        {
            public int PersonId { get; set; }
            public string Name { get; set; }

        }

        public class Employer : Person
        {

            public DateTime StarDate { get; set; }

        }


    }
}
