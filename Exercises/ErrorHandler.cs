using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    internal class ErrorHandler
    {
        #region Properties

            private static List<User> UserList { get; set; } = GetUsers();
        #endregion

        #region Variables

            private const int MIN_AGE = 10;
            private const int MAX_AGE = 100;

        #endregion

        #region Classes
        public class User
            {
                #region Properties
                    public int UserId { get; set; }
                    public string Username { get; set; }

                    public string Password { get; set; }

                #endregion

                #region Constructors
                    public User() { }

                    public User(int userId, string userName, string password)
                    {

                        UserId = userId;
                        Username = userName;
                        Password = password;
                    }

                    public User(string userName, string password)
                    {

                        Username = userName;
                        Password = password;

                    } 
                #endregion
            } 
        #endregion

        private static List<User> GetUsers()
        {
            return new()
            {
                new(1, "admin", "admin"),
                new(2, "sa", "1234"),
                new(3, "vaquera", "1234"),
                new(4, "miriam", "4321")
            };
        }
        public static void Main(string[] args)
        {

            const string username = "VaqueraElPro";
            const string password = "EL+Pro";
            Console.ReadKey();
        }

        public static int RegisterUSerWithoutValidations(string username, string password, string ageInput)
        {
            int userId, age;

            Console.WriteLine("Conexion a la base de datos");
            Console.WriteLine("Abrimos transaccion");

            age = Convert.ToInt32(ageInput);

            Console.WriteLine("Ejecutamos acciones en la base de datos");

            if(!IsExistingUser(username))
            {
                InsertUser(new(username, password ));
            }

            return userId;
        }

        public static bool IsExistingUser(string username)
        {
            return (UserList?.Any(user => user.Username == username)).GetValueOrDefault();

        }

        public static bool InsertUser(User user)
        {
            user.UserId = UserList != null ? ( UserList.Max ( user => user.UserId ) + 1 ) : 1 ;

            if (UserList == null)
                UserList = new();


            UserList.Add(user);
           
            

            Console.WriteLine("Accion ejecutada en base de datos => Usuario insertado correcrammente");

            return true;
        }
    }
}
