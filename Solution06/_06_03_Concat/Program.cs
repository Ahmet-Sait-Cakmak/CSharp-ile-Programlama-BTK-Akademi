Console.WriteLine("Lutfen adinizi giriniz:");
string firstname = Console.ReadLine();

Console.WriteLine(" ");

Console.WriteLine("Lutfen soyadinizi giriniz:");
string lastname = Console.ReadLine();

Console.WriteLine(" ");

// + operatoru ile birlestirme
string welcome1 = "Merhaba " + firstname + " " + lastname + ", sisteme hosgeldiniz!";


// concat metodu ile birlestirme
string welcome2 = String.Concat("Sayin ", firstname, " ", lastname, ", sisteme girisiniz basariyla gerceklesti.");


// string interpolation ile birlestirme
string welcome3 = $"Hosgeldiniz {firstname} {lastname?.ToUpper()}, {DateTime.Now:dd.MM.yyyy} tarihinde sisteme giris yaptiniz.";


// birlestirilmis stringleri ekrana yazdirma
Console.WriteLine(welcome1);
Console.WriteLine(welcome2);
Console.WriteLine(welcome3);

Console.ReadKey();

