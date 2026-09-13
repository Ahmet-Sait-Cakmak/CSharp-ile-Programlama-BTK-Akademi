var intRepo = new GenericRepository<int>();

intRepo.Add(1);
intRepo.Add(2);
intRepo.Add(3);

intRepo.PrintWithMessage("Tam sayi listesi: \n");


var strRepo = new GenericRepository<String>();

strRepo.Add("Ahmet");
strRepo.Add("Can");
strRepo.Add("Filiz");

strRepo.PrintWithMessage("Tam sayi listesi: \n");

Console.ReadKey();