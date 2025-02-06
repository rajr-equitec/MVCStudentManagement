using ConsoleApp3;

internal class Program
{
    private static void Main(string[] args)
    {  //Question1
        StringReverse.Reverse();
        //Question2
        SwapUsingDel.SwapNum<int> sw = SwapUsingDel.WithoutThird;
           int a1 = 10;
           int b1 = 20;
           sw(ref a1 , ref b1);

        SwapUsingDel.SwapNum<int> swap = SwapUsingDel.WithThird;
           int a = 10;
           int b = 20;
           swap(ref a,ref b);
           Console.ReadLine(); 

        //Question3
        CreateString.Disp();
        //Question4
     
        
        
            List<Student> students = new List<Student>
           {
new Student("Alice", "123 Main St", 1),
new Student("Bob", "456 Elm St", 2),
new Student("Charlie", "789 Oak St", 3)
};




            Console.WriteLine("Displaying students using foreach loop:"); foreach (var student in students)
            {
                student.DisplayStudentDetails();
            }




            Console.WriteLine("\nDisplaying students using for loop:"); for (int i = 0; i < students.Count; i++)
            {
                students[i].DisplayStudentDetails();

                if (students.Count > 0)
                {
                    Console.WriteLine("\nLast student in the list:"); students[students.Count - 1].DisplayStudentDetails();
                }
                else
                {
                    Console.WriteLine("The list is empty.");
                }
            }


        //Question5
        DispList.Disp();
        //Question6
        Dict.Dictionary();
        //Question7
        DispDictWithoutAdd.Disp();



    }
}
