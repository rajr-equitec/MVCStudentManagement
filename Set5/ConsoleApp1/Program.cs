using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        //Question1


            Stack<int> stack = new Stack<int>(); bool continueProgram = true;

            while (continueProgram)
            {
                Console.WriteLine("\nChoose an option:"); Console.WriteLine("A. Add new element (Push)"); Console.WriteLine("B. Remove an element (Pop)"); Console.WriteLine("C. Find the top element (Peek)"); Console.WriteLine("D. Display all elements"); Console.WriteLine("E. Exit");
                Console.Write("Enter your choice: ");
                char choice = char.ToUpper(Console.ReadKey().KeyChar); Console.WriteLine();

                switch (choice)
                {
                    case 'A':
                        Console.Write("Enter the element to add: ");
                        if (int.TryParse(Console.ReadLine(), out int newElement))

                        {
                            stack.Push(newElement);
                            Console.WriteLine($"{newElement} has been added to the stack.");
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please enter a valid number.");
                        }
                        break;


                    case 'B':
                        if (stack.Count > 0)
                        {
                            int removedElement = stack.Pop();
                            Console.WriteLine($"{removedElement} has been removed from the stack.");
                        }
                        else
                        {
                            Console.WriteLine("The stack is empty. Nothing to remove.");
                        }
                        break;


                    case 'C':
                        if (stack.Count > 0)
                        {
                            int topElement = stack.Peek();

                            Console.WriteLine($"The top element is: {topElement}");
                        }
                        else
                        {
                            Console.WriteLine("The stack is empty. No top element.");
                        }
                        break;


                    case 'D':
                        if (stack.Count > 0)
                        {
                            Console.WriteLine("Stack elements are:"); foreach (int element in stack)
                            {
                                Console.WriteLine(element);
                            }
                        }
                        else
                        {
                            Console.WriteLine("The stack is empty. No elements to display.");
                        }
                        break;


                    case 'E':
                        continueProgram = false; Console.WriteLine("Exiting the program.");

                        break;


                    default:
                        Console.WriteLine("Invalid choice. Please select a valid option."); break;
                }
            }

        //Question2

        SortedList sortedList = new SortedList();


        sortedList.Add(1, "Apple"); sortedList.Add(2, "Banana"); sortedList.Add(3, "Cherry"); sortedList.Add(4, "Date"); sortedList.Add(5, "Elderberry");

        bool continueProgram = true;

        while (continueProgram)
        {
            Console.WriteLine("\nChoose an option:"); Console.WriteLine("A. Display the list");
            Console.WriteLine("B. Check if a value is in the list. If present, remove it.");
            Console.WriteLine("C. Check if an element is in the list using a value. If present, remove it.");
            Console.WriteLine("D. Check if an element is in the list using a key. If present, removeit.");
            



            Console.WriteLine("E. Remove an element with a key"); Console.WriteLine("F. Exit");
            Console.Write("Enter your choice: ");
            char choice = char.ToUpper(Console.ReadKey().KeyChar); Console.WriteLine();

            switch (choice)
            {

                case 'A':
                    Console.WriteLine("\nSortedList Elements:"); if (sortedList.Count > 0)
                    {
                        foreach (DictionaryEntry entry in sortedList)
                        {
                            Console.WriteLine($"Key: {entry.Key}, Value: {entry.Value}");
                        }
                    }

                    else
                    {
                        Console.WriteLine("The list is empty.");
                    }
                    break;


                case 'B':
                    Console.Write("Enter a value to check: "); string valueToCheck = Console.ReadLine(); bool valueFound = false;

                    foreach (DictionaryEntry entry in sortedList)
                    {
                        if (entry.Value.ToString().Equals(valueToCheck, StringComparison.OrdinalIgnoreCase))
                        {
                            sortedList.Remove(entry.Key);
                            Console.WriteLine($"Value '{valueToCheck}' found and removed."); valueFound = true;
                            break;
                        }
                    }


                    if (!valueFound)
                    {
                        Console.WriteLine($"Value '{valueToCheck}' not present.");

                    }
                    break;


                case 'C':
                    Console.Write("Enter the value to check: "); string valueToRemove = Console.ReadLine(); valueFound = false;

                    foreach (DictionaryEntry entry in sortedList)
                    {
                        if (entry.Value.ToString().Equals(valueToRemove, StringComparison.OrdinalIgnoreCase))
                        {
                            sortedList.Remove(entry.Key);
                            Console.WriteLine($"Value '{valueToRemove}' found and removed."); valueFound = true;
                            break;
                        }
                    }


                    if (!valueFound)
                    {
                        Console.WriteLine($"Value '{valueToRemove}' not present.");
                    }
                    break;

                case 'D':
                    Console.Write("Enter the key to check: ");
                    if (int.TryParse(Console.ReadLine(), out int keyToCheck))
                    {
                        if (sortedList.ContainsKey(keyToCheck))
                        {
                            sortedList.Remove(keyToCheck);
                            Console.WriteLine($"Key '{keyToCheck}' found and removed.");
                        }
                        else
                        {
                            Console.WriteLine($"Key '{keyToCheck}' not present.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid key. Please enter a numeric key.");
                    }
                    break;


                case 'E':
                    Console.Write("Enter the key to remove: ");
                    if (int.TryParse(Console.ReadLine(), out int keyToRemove))
                    {
                        if (sortedList.ContainsKey(keyToRemove))
                        {

                            sortedList.Remove(keyToRemove);
                            Console.WriteLine($"Element with key '{keyToRemove}' removed.");
                        }
                        else
                        {
                            Console.WriteLine($"Key '{keyToRemove}' not present.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid key. Please enter a numeric key.");
                    }
                    break;


                case 'F':
                    continueProgram = false; Console.WriteLine("Exiting the program."); break;

                default:
                    Console.WriteLine("Invalid choice. Please select a valid option."); break;
            }
        }


        //Question3

        string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        string errorLogFolder = Path.Combine(documentsPath, "ErrorLog"); string errorLogFile = Path.Combine(errorLogFolder, "error.txt");

        try
        {

            if (!Directory.Exists(errorLogFolder))
            {
                Directory.CreateDirectory(errorLogFolder);
            }

            if (!File.Exists(errorLogFile))
            {
                File.Create(errorLogFile).Close();
            }


            Console.Write("Enter the first number: "); string input1 = Console.ReadLine(); Console.Write("Enter the second number: "); string input2 = Console.ReadLine();

            if (!int.TryParse(input1, out int number1) || !int.TryParse(input2, out int number2))
            {
                throw new FormatException("Input is not a valid number.");
            }

            if (number1 == 0 || number2 == 0)
            {
                throw new DivideByZeroException("Division by zero is not allowed.");
            }

            int largest = Math.Max(number1, number2); int smallest = Math.Min(number1, number2);

            double result = (double)largest / smallest;


            Console.WriteLine($"\nThe result of dividing {largest} by {smallest} is: {result:F2}");
        }
        catch (Exception ex)
        {

            File.AppendAllText(errorLogFile, $"[{DateTime.Now}] Error:{ ex.Message}{ Environment.NewLine}");
        

Console.WriteLine("An error occurred. Please check the error log for more details.");
        }
        //Question4

        
            string filePath = @"C:\Desktop\example.txt";

            try
            {

                File.WriteAllText(filePath, "Hello, this is a test message written to the file.");

                Console.WriteLine("Content has been written to the file."); string fileContent = File.ReadAllText(filePath);

                Console.WriteLine("\nContents of the file:"); Console.WriteLine(fileContent);
            }
            catch (Exception ex)
            {

                Console.WriteLine("An error occurred: " + ex.Message);
            }
        //Question5


        string originalFilePath = @"C:\Desktop\originalFile.txt"; string copiedFilePath = @"C:\Desktop\copiedFile.txt"; try
        {


            using (FileStream fs = new FileStream(originalFilePath, FileMode.Create, FileAccess.Write))
            {
                byte[] contentToWrite = System.Text.Encoding.UTF8.GetBytes("Hello, this is a test message written using FileStream.");

                fs.Write(contentToWrite, 0, contentToWrite.Length);
            }




            string originalFileContent = File.ReadAllText(originalFilePath); Console.WriteLine("Contents of the original file:"); Console.WriteLine(originalFileContent);



            File.Copy(originalFilePath, copiedFilePath, true);




            string copiedFileContent = File.ReadAllText(copiedFilePath); Console.WriteLine("\nContents of the copied file:"); Console.WriteLine(copiedFileContent);
        }
        catch (Exception ex)
        {


            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }

}

    
