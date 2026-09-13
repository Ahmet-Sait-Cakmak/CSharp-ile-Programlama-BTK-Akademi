// dizi tanimlama
int[] grades = new int[3];

// do - while dongusu kullanarak grades dizisine deger atama
int i = 0;

do
{
    System.Console.Write($"{i + 1}. ogrencinin notunu giriniz: ");
    grades[i] = Convert.ToInt32(System.Console.ReadLine());
    i++;

}while(i < grades.Length);

// foreach dongusu kullanarak grades dizisinin elemanlarini ekrana yazdirma
System.Console.WriteLine("\nGrades dizisinin elemanlari:");

foreach (var g in grades)
{
    System.Console.WriteLine(g);
}

Console.ReadKey();

