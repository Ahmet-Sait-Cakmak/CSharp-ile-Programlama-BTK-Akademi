Console.WriteLine("Yasinizi giriniz: ");
int? age = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Saglik raporunuz var mi? (evet/hayir)");
string? healthReport = Console.ReadLine().ToLower();
bool hasHealthReport = healthReport == "evet";

if (age >= 18 && hasHealthReport)
{
    Console.WriteLine("Ehliyet alabilirsiniz.");
}
else
{
    Console.WriteLine("Ehliyet alamazsiniz.");
}

if (age >= 18 || hasHealthReport)
{
    Console.WriteLine("Kosullardan en az birini sagliyorsunuz.");
}
else
{
    Console.WriteLine("Kosullardan hicbirini saglamıyorsunuz.");
}