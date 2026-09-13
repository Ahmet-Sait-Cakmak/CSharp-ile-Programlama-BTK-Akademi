// Oturum bilgileri
using System.Text;

string userEmail = "comertzafer@gmail.com";
String[] endpoints = { "/home", "/products/usb-c-cable", "/cart", "/checkout" };

// ilk raporu uretme
string report1 = BuildSessionReport(userEmail, endpoints, sessionID: "S-1001");

System.Console.WriteLine("\n");

System.Console.WriteLine(report1);

System.Console.WriteLine("\n");

// ikinci raporu uretme
string report2 = BuildSessionReport("zeynep.dag@gmail.com", new[] { "/home", "/search" }, sessionID:"S-1002");

System.Console.WriteLine(report2);

System.Console.ReadKey();

string BuildSessionReport(string userEmail, string[] endpoints, string sessionID)
{
    // StringBuilder nesnesi olusturma
    StringBuilder sb = new StringBuilder(capacity: 256);

    // AppendLine ve Append metodlarinin kullanimi
    sb.AppendLine($"User Email: {userEmail}");
    sb.AppendLine($"Session ID: {sessionID}");
    sb.Append("Visited Endpoints:");

    foreach (var item in endpoints)
    {
        sb.Append(item).Append(", ");
    }

    // fazladan virgülü temizleme
    if (endpoints.Length > 0)
    {
        sb.Remove(sb.Length - 2, 2); // son iki karakteri sil (", ")
    }

    // yeni satir ekleme
    sb.AppendLine(); 

    // tarih ve saat bilgisini ekleme
    sb.AppendLine($"Login Time: {DateTime.Now:yyyy-MM-dd HH:mm:ss}"); 

    // replace metodunu kullanarak email adresininin güvenligini arttırma
    sb.Replace("@gmail.com", "@domain.local");

    // raporun basina header satiri ekleme
    string header = $"SESSION LOG {DateTime.Now:yyyy-MM-dd}\n";
    sb.Insert(0, header);

    string report = sb.ToString();

    return report;
}

System.Console.ReadKey();

