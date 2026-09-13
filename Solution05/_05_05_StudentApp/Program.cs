namespace _05_05_StudentApp;

class Program
{
    static void Main(string[] args)
    {
        // dizi tanimlama
        int[] grades = { 70, 85, 90, 60, 100, 75, 83, 92, 55, 78 };

        // ortalama hesaplama
        double average = CalculateAverage(grades);

        // minimum ve maksimum degerleri hesaplama
        (int minGrade, int maxGrade) = FindMinMax(grades);

        // ortalamanin uzerindeki toplam not sayisini hesaplama
        int count = AboveAverageCount(grades, average);

        // notlari ekrana yazdirma
        System.Console.WriteLine($"\nNotlar: {string.Join(", ", grades)}");

        // notlarin ortalamasini ekrana yazdirma
        System.Console.WriteLine($"Ortalama: {average:F2}");

        // en duduk notu ekrana yazdirma
        System.Console.WriteLine($"Minimum Not: {minGrade:F2}");

        // en yuksek notu ekrana yazdirma
        System.Console.WriteLine($"Maximum Not: {maxGrade:F2}");

        // ortalamanin uzerindeki not sayisini ekrana yazdirma
        System.Console.WriteLine($"Ortalamanin Uzerindeki Not Sayisi: {count}");
    }

   
    private static double CalculateAverage(int[] grades)
    {
        // kontrol
        if (grades == null || grades.Length == 0)
        {
            return 0; // veya uygun bir hata dondurme islemi yapilabilir
        }

        int sum = 0;

        for (int i = 0; i < grades.Length; i++)
        {
            sum += grades[i];
        }

        return (double)sum / grades.Length;
    }

     private static (int minGrade, int maxGrade) FindMinMax(int[] grades)
    {
        int min = grades[0];
        int max = grades[0];

        foreach (var grade in grades)
        {
            if (grade < min)
            {
                min = grade;
            }
            if (grade > max)
            {
                max = grade;
            }
        }

        return (min, max);
    }

     private static int AboveAverageCount(int[] grades, double average)
    {
        int count = 0;
        int i = 0;

        while (i < grades.Length)
        {
            if (grades[i] > average)
            {
                count++;
            }

            i++;
        }

        return count;
    }
}
