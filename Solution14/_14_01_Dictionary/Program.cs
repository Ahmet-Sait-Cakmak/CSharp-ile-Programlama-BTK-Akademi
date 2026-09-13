var manager = new StudentManager();

System.Console.WriteLine();

manager.AddStudent(new Student(1, "Ali", 3.2));
manager.AddStudent(new Student(2, "Aylin", 2.2));
manager.AddStudent(new Student(3, "Zeynep", 3.6));

manager.PrintAll();

System.Console.WriteLine();

manager.FindStudent(2);

System.Console.WriteLine();

manager.RemoveStudent(1);

System.Console.WriteLine();

manager.PrintAll();

Console.ReadKey();