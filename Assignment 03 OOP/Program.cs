namespace Assignment_03_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part01
            //Employees employee1 = new Employees(123, "Omar", 5000, new HireDate { day = 1, month = 12, year = 2025 }, Gender.Male, SecurityLevel.DBA);
            //Console.WriteLine(employee1); 

            //Employees[] EmpArr = new Employees[3];
            //EmpArr[0] = new Employees(123, "Nada", 5000, new HireDate { day = 1, month = 12, year = 2022 }, Gender.Female, SecurityLevel.DBA);
            //EmpArr[1] = new Employees(124, "Ahmed", 10000, new HireDate { day = 1, month = 12, year = 2020 },Gender.Male, SecurityLevel.guest);
            //EmpArr[2] = new Employees(125, "Ali", 15000, new HireDate { day = 1, month = 12, year = 2019 },Gender.Male, SecurityLevel.secretary);
            ////for (int i = 0; i < EmpArr.Length; i++)
            //{
            //    Console.WriteLine(EmpArr[i]);
            //    Console.WriteLine("========================================");

            //}

            //Array.Sort(EmpArr,Employees.CompareByHireDate);
            //Console.WriteLine("After Sorting");
            //for (int i = 0; i < EmpArr.Length; i++)
            //{
            //    Console.WriteLine(EmpArr[i]);
            //    Console.WriteLine("========================================");
            //}

            //Array.Sort(EmpArr, (e1, e2) => e1.hiredate.year.CompareTo(e2.hiredate.year));
            //foreach (Employees employee in EmpArr)
            //{
            //    Console.WriteLine(employee);
            //      Console.WriteLine("========================================");

            //}


            //int boxingCount = 0;
            //foreach (Employees employee in EmpArr)
            //{
            //    object obj = employee; // Boxing
            //    Employees unboxed = (Employees)obj; // Unboxing
            //    boxingCount++;
            //}

            //Console.WriteLine($"Boxing/UnBoxing occured {boxingCount} Times");

            #endregion
            #region Part02
            //Library A1 = new Library();
            //A1.Title = "C#";
            //A1.Author = "Ali";
            //A1.ISBN = "123456";
            //Console.WriteLine(A1);

            //Console.WriteLine("=========================");

            //EBook E1 = new EBook();
            //E1.Title = "Java";
            //E1.Author = "Ahmed";
            //E1.ISBN = "654321";
            //E1.FileSize = 100;
            //Console.WriteLine(E1);
            //Console.WriteLine("=========================");


            //PrintedBook P1 = new PrintedBook();
            //P1.Title = "Python";
            //P1.Author = "Omar";
            //P1.ISBN = "456789";
            //P1.PageCount = 200;
            //Console.WriteLine(P1);
            //Console.WriteLine("=========================");

            #endregion

        }
    }
}
