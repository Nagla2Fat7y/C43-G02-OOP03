namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 3
            /// Create array of Employees with size three 
            //Employees[] EmpArr = new Employees[3];

            //EmpArr[0] = new Employees(10, "Naglaa", 10000, Security.Developer, Gender.M, new Hiring_Date_Data(10, 6, 2022));
            //EmpArr[1] = new Employees(11, "Ahmed", 11000, Security.Guest, Gender.M, new Hiring_Date_Data(15, 8, 2021));
            //EmpArr[2] = new Employees(12, "Aya", 12000, Security.DBA, Gender.F, new Hiring_Date_Data(23, 10, 2020));

            //Console.WriteLine("Before Sorting\n");
            //for (int i = 0; i < EmpArr.Length; i++)
            //{
            //    Console.WriteLine(EmpArr[i].ToString());
            //    Console.WriteLine("********************");
            //}

            #endregion

            #region Question 4
               /// Sort the employees based on their hire date 
            //for (int i = 0; i < EmpArr.Length - 1; i++)
            //{
            //    int index = i;
            //    for (int j = i + 1; j < EmpArr.Length; j++)
            //    {
            //        if (EmpArr[j].HiringDate.Year < EmpArr[index].HiringDate.Year)
            //            index = j;
            //        else if (EmpArr[i].HiringDate.Month > EmpArr[index].HiringDate.Month)
            //            index = j;
            //        else if (EmpArr[i].HiringDate.Day > EmpArr[index].HiringDate.Day)
            //            index = j;

            //        if (index != i)
            //        {
            //            Employees temp = EmpArr[i];
            //            EmpArr[i] = EmpArr[index];
            //            EmpArr[index] = temp;
            //        }
            //    }
            //}

            //Console.WriteLine("\nAfter Sorting\n");
            //for (int i = 0; i < EmpArr.Length; i++)
            //{
            //    Console.WriteLine(EmpArr[i].ToString());
            //    Console.WriteLine("********************");
            //}
            #endregion

            #region Question 5
            //EBook ebook = new EBook("Digital Transformation", "John Doe", "123-4567891234", 2.5);


            //PrintedBook printedBook = new PrintedBook("C# Programming", "Jane Smith", "987-6543219876", 350);
             

            //// Display details of the books
            // Console.WriteLine("EBook Details:");
            //  ebook.DisplayDetails();

            //Console.WriteLine("\nPrinted Book Details:");
            //printedBook.DisplayDetails();
            #endregion


        }

    }
}
