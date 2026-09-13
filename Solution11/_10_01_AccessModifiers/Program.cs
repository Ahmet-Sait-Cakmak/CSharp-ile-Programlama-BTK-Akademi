using CoreLib;

Console.WriteLine("=== Erisim Belirtecleri ===\n");

var access = new AccessShowcase();

Console.WriteLine($"Public: {access.PublicInfo}");

Console.WriteLine($"Private (sinif icinde): {access.ReadPrivateInside()}");


Console.WriteLine();


var phone = new DerivedPhone();

Console.WriteLine($"Sarj seviyesi: {phone.GetBattery()}");

phone.Use();

Console.WriteLine($"Kullanim sonrasi sarj seviyesi: {phone.GetBattery()}");


Console.WriteLine();


var facade = new InternalUtilityFacade();

Console.WriteLine($"Facade araciligiyla: {facade.UseInternal()}");

Console.WriteLine("Program tamamlandi.");
