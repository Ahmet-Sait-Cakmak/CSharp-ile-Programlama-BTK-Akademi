// manager nesnesi olusturma
var manager = new EventManager();

// ogrenci sinifina ait instance'lar uretme
var student1 = new Student(1, "Ali");
var student2 = new Student(2, "Ayse");
var student3 = new Student(3, "Mehmet");
var student4 = new Student(4, "Zeynep");

// ogrenci sinifina ait instance'lari EventManager sinifina ait manager instance'ina ekleme
manager.AddAttendee(student1);
manager.AddAttendee(student2);
manager.AddAttendee(student3);
manager.AddAttendee(student4);

// sertifika alan ogrencileri EventManager sinifina ait manager instance'ina ekleme
manager.AddCertified(student2);
manager.AddCertified(student4);

// raporlama
manager.PrintAllStudents();

System.Console.WriteLine();

manager.PrintCertifiedAttendess();

System.Console.WriteLine();

manager.PrintNotCertified();


Console.ReadKey();