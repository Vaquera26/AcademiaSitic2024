using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ListLINQ.Program;

namespace ListLINQ
{
    class Program
    {
        // Listas con LINQ

        #region Classes

       

        public class People
        {

            #region Properties
                public string Name { get; set; }
                public int Age { get; set; }
                public eGender Gender { get; set; }
                // "Femenino" / "Masculino" / "Indefinido"
            #endregion

            #region Methods

            public override string ToString()
                {
                return $"Nombre: {Name}, Edad: {Age}, Genero: {this.GetStringGender(Gender)}";
                }

            private string GetStringGender(eGender gender)
            {

                string genderString;

                //if(gender == eGender.Undefined)
                //{
                //    genderString = "Indefenido";
                //} else if ( gender  == eGender.Female)
                //{
                //    genderString = "Femenino";
                //} else
                //{
                //    genderString = "Masculino";
                //}

                //switch (gender)
                //{
                //    case eGender.Undefined:
                //        genderString = "Indefenido";
                //        break;
                //    case eGender.Female:
                //        genderString = "Femenino";
                //        break;
                //    case eGender.Male:
                //        genderString = "Masculino";
                //        break;
                //    default:
                //        genderString = "No Valido";
                //        break;
                //}

                #region Switch Lambda

                genderString = gender switch
                {
                    eGender.Undefined => "Indefinido",
                    eGender.Male => "Masculino",
                    eGender.Female => "Femenino",
                    _ => "No Valido"
                };

                #endregion
                return genderString;
            }
            #endregion

            #region Constructor
            public People() { }

                public People(string name, int age, eGender gender)
                {
                    Name = name;
                    Age = age;
                    Gender = gender;
                }


            #endregion
        }

        #endregion

        #region Enums
        public enum eGender
            {
                Undefined, 
                Female,
                Male,

            }
        #endregion
        static void Main(string[] args)
        {
            List<People> employeers = new()
            {

            };


            if (employeers != null)
            {
                employeers.Add(new("ALayla", 18, eGender.Female));
                employeers.Add(new("MEJN", 72, eGender.Male));
                employeers.Add(new("AVaquera", 18, eGender.Male));
                employeers.Add(new("AMiriam", 94, eGender.Female));
            }

            List<People> students = new()
            {
                new("Iris", 23, eGender.Female),
                new("Jeses", 26, eGender.Male),
                new("Andres", 33, eGender.Male),
                new("America", 22, eGender.Female),
                new("Paola", 22, eGender.Female),
                new("Christian", 22, eGender.Undefined)
            };

            #region Where

            // Ejemplo 1: Filtrar nombres que comiencen con la letra 'A"
            // Lista de empleados

            Console.WriteLine("\nWHERE - Filtrar empleados que comiencen con la letra 'A'");
            List<People> filteredEmployeers = employeers.Where(employeers => employeers.Name.StartsWith("A")).ToList();

            WriteLine(filteredEmployeers);

            Console.WriteLine("\nWHERE - Filtrar epleados mayores a 30");
            filteredEmployeers = employeers.Where(employeers => employeers.Age > 30).ToList();

            WriteLine(filteredEmployeers);

            #endregion

            #region Select

            Console.WriteLine("\nSelect -Tomar el nombre (sirve para selecciona una propiedad en especifico).");

            List<string> filteredEmployeersNames = employeers.Select(employeers => employeers.Name).ToList();

            foreach (string name in filteredEmployeersNames)
            {
                Console.WriteLine(name);
            }

            #endregion

            #region OrderBy & OrderByDescending

            Console.WriteLine("\nOrderBy -Ordenamiento por nombre vs la diferencia de la lista original.");

            List<People> filteredStudents = students.OrderBy(student => student.Name).ToList();

            var i = 0;
            People originalStudent;

            foreach (var student in filteredStudents)
            {
                originalStudent = students[i++];
                Console.WriteLine($"{student.Name} - {originalStudent.Name}" );
            }

            Console.WriteLine("\nOrderByDescending -Ordenamiento por edad vs la diferencia de la lista original.");

            filteredStudents = students.OrderBy(student => student.Age).ToList();

            i = 0;
            originalStudent = null;

            foreach (var student in filteredStudents)
            {
                originalStudent = students[i++];
                Console.WriteLine($"{student.Name} {student.Age} - {originalStudent.Name} {originalStudent.Age} ");
            }

            #endregion

            #region GroupBy

                Console.WriteLine("\nGROUPBY - Agrupamiento por genero");
                var groupedByGender = students.GroupBy(student => student.Age);

                foreach (var group in groupedByGender)
                {
                    Console.WriteLine($"Genero (grupo): {group.Key}");
                    foreach (var person in group)
                    {
                        Console.WriteLine($"{person.Name}");
                    }               
                }

                Console.WriteLine("\nGROUPBY - Agrupamiento por edades\n");
                var groupedByAge = employeers.GroupBy(employeers => employeers.Age);

          

                foreach (var group in groupedByAge)
                {
                    Console.WriteLine($"Edad (grupo): {group.Key}");
                    foreach (var person in group)
                    {
                     
                        Console.WriteLine($"{person.Name}");
                    
                    }

                Console.WriteLine($"TOTAL con edad {group.Key} : {group.Count()} \n");

                }

            #endregion

            #region Any
                Console.WriteLine("\nANY - VERIFICA SI HAY VALORES O NO DENTRO DE LA LISTA");
                Console.WriteLine($"Existe: {employeers.Any()}");
                Console.WriteLine($"Existe empleados mayores de 30: {employeers.Any(i => i.Age > 30) }");
            #endregion

            //foreach (People employee in employeers)
            //{
            //    Console.WriteLine($"Name: {employee.Name}");
            //    Console.WriteLine($"Age: {employee.Age}");
            //    Console.WriteLine($"Gender: {employee.Gender}\n");

            //}
            Console.ReadKey();
        }

        private static void WriteLine(List<People> peopleList)
        {
            foreach (People people in peopleList)
            {

                Console.WriteLine(people.ToString());

            }
        }
    }
}
