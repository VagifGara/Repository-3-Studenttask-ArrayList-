using System.Collections;

namespace StudentTask
{
    internal class Program
    {

        static ArrayList students = new ArrayList();
        static void Main(string[] args)
        {

            int choice;

            while (true)
            {
                {
                    Console.WriteLine("1 - Add Student");
                    Console.WriteLine("2 - Update Student");
                    Console.WriteLine("3 - Delete Student");
                    Console.WriteLine("4 - Display Students");
                    Console.WriteLine("5 - Search by Student name");
                    Console.WriteLine("6 - Exit Program");

                    Console.Write("Seciminizi daxil edin: ");
                    if (int.TryParse(Console.ReadLine(), out choice))
                    {
                        switch (choice)
                        {
                            case 1:
                                AddStudent();
                                break;
                            case 2:
                                UpdateStudent();
                                break;
                            case 3:
                                DeleteStudent();
                                break;
                            case 4:
                                DisplayStudents();
                                break;
                            case 5:
                                SearchStudent();
                                break;
                            case 6:
                                Console.WriteLine("Goodbye!,Mata xanim bizi secdiyiniz ucun tewekkurler");
                                break;
                            default:
                                Console.WriteLine("Sehv secim.Secimi duzgun edin");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Sehv secim.Secimi duzgun edin");
                    }
                    if (choice == 6)
                    {
                        break;
                    }
                }


            }
        }

        static void AddStudent()
        {
            Console.Write("Telebeni daxil edin ");
            object name = Console.ReadLine();
            students.Add(name);
            Console.WriteLine("Telebe elave olundu");

            DisplayStudents();
        }

        static void UpdateStudent()
        {
            Console.Write("Telebenin id sini daxil edin ");
            if (int.TryParse(Console.ReadLine(), out int id) && id >= 1 && id <= students.Count)
            {
                Console.Write("Telebenin yeni adini daxil edin ");
                string newName = Console.ReadLine();
                students[id - 1] = newName;
                Console.WriteLine("Telebe update olundu");
            }
            else
            {
                Console.WriteLine("Bele id qeydiyyat adinda telebe yoxdu");
            }
        }

        static void DeleteStudent()
        {
            
            if (students.Count != 0)
            {
                Console.Write("Silmey istediyiniz telebenin id - sini daxil edin: ");
                if (int.TryParse(Console.ReadLine(), out int id) && id > 0 && id <= students.Count)
                {
                    students.RemoveAt(id - 1);
                    Console.WriteLine("Telebe silindi.");
                }
                else
                {
                    Console.WriteLine("Bele telebe yoxdur");
                }
            }
            else if(students.Count == 0)
            {
                Console.WriteLine("Siyahi bowdur");
            }
           
            
        }

        static void DisplayStudents()
        {
            Console.WriteLine("Telebelerin siyahisi:");
            for (int i = 0; i < students.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {students[i]}");
                
            }
            if (students.Count==0)
            {
                Console.WriteLine("Bu siyahida telebe yoxdur");
            }
        }

        static void SearchStudent()
        {
            Console.Write("Axtariw edeceyiniz telebeni daxil edin: ");
            string searchName = Console.ReadLine();
            bool found = false;

            foreach (var student in students)
            {
                if (student.ToString() == searchName)
                {
                    Console.WriteLine($"Telebe tapildi: {student}");
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                Console.WriteLine("Bele bir telebe yoxdur");
            }
        }
    }
}