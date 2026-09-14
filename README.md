# C# ile Programlama - BTK Akademi

Bu depo, BTK Akademi C# ile Programlama eğitimi süresince geliştirilen uygulamaları, programlama temellerini, Nesne Yönelimli Programlama (OOP) prensiplerini, temel veri yapılarını, koleksiyonları ve hata yönetimi mekanizmalarını içeren kapsamlı bir eğitim ve başvuru kaynağıdır.

Depo içerisinde yer alan her bölüm; ilgili konunun teorik temelini, pratik kod implementasyonlarını ve nesne yönelimli mimariyi modelleyen UML sınıf diyagramlarını barındırmaktadır.

---

## Proje Dizini ve Tam Müfredat

### Bölüm 01: C# ve .NET Ortamına Giriş
* **Kapsam:** .NET çalışma zamanı (CLR) mimarisi, SDK yapısı, Visual Studio/VS Code ortamı, `Console.WriteLine` ve temel konsol girdi/çıktı işlemleri.

### Bölüm 02: Değişkenler ve Temel Veri Tipleri
* **Kapsam:** Değer tipleri (`int`, `double`, `decimal`, `char`, `bool`), metinsel tipler (`string`), değişken tanımlama kuralları ve tip dönüşümleri (*type casting / parsing*).

### Bölüm 03: Operatörler ve İfadeler
* **Kapsam:** Aritmetik, ilişkisel, mantıksal ve atama operatörleri; işlem önceliği ve kısa devre (*short-circuit*) mantığı.

### Bölüm 04: Karar Yapıları ve Akış Kontrolü
* **Kapsam:** `if`, `else if`, `else` blokları, iç içe koşullar, `switch-case` yapıları ve modern desen eşleme (*pattern matching*).

### Bölüm 05: Döngüler (Loops)
* **Kapsam:** `for`, `while`, `do-while` döngüleri, sayaç mantığı, `break` ve `continue` ifadeleri ile akış yönetimi.

### Bölüm 06: Diziler (Arrays)
* **Kapsam:** Tek boyutlu diziler, çok boyutlu diziler (*multi-dimensional*), düzensiz diziler (*jagged arrays*), dizi boyutlandırma ve `foreach` iterasyonu.

### Bölüm 07: Metotlar ve Fonksiyonel Programlama
* **Kapsam:** Metot tanımlama, parametre aktarımı, `return` mekanizması, `ref`, `out`, `params` anahtar sözcükleri ve metot aşırı yükleme (*method overloading*).

---

### Bölüm 08: Kalıtım (Inheritance)
* **Kapsam:** Temel ve türetilmiş sınıflar (`base` / `derived`), `virtual` ve `override` anahtar sözcükleri, polimorfizmin temelleri.
* **Öne Çıkan Uygulamalar:** Çok seviyeli ve hiyerarşik kalıtım modelleri (`Document` ve `Logger` mimarileri).

### Bölüm 09: Arayüzler (Interfaces)
* **Kapsam:** Sözleşme tabanlı programlama (*contract-based programming*), çoklu arayüz kalıtımı, yerleşik arayüzler (`IComparable`).
* **Öne Çıkan Uygulamalar:** Akıllı cihaz mimarisi (`IRechargeable`, `IConnectable`, `Smartphone`).

### Bölüm 10: Soyut Sınıflar (Abstract Classes)
* **Kapsam:** Soyut sınıf ve soyut metot kavramları, soyutlama ile arayüz farkları, şablon metot deseni.
* **Öne Çıkan Uygulamalar:** Arama algoritmaları polimorfik hiyerarşisi (`SearchAlgorithm`, `LinearSearch`, `BinarySearch`).

### Bölüm 11: Erişim Belirteçleri ve Kapsülleme (Access Modifiers & Encapsulation)
* **Kapsam:** `public`, `internal`, `protected`, `private` erişim belirteçleri, Assembly bazlı erişim yönetimi, Facade tasarım deseni, dinamik dizilere giriş.
* **Öne Çıkan Uygulamalar:** 
  * `CoreLib` kütüphanesi ve `InternalUtilityFacade` üzerinden `internal` sınıf erişimi.
  * `DeviceBase` ve `DerivedPhone` ile `protected` üye kontrolü.
  * `ArrayList` temel işlemleri (Ekleme, Araya Ekleme, Silme, Güncelleme) ve OOP ile kapsüllenmiş `StudentManager`.

### Bölüm 12: Yapıcı Metotlar, Değer ve Referans Tipleri (Constructors, Value & Reference Types)
* **Kapsam:** Parametresiz ve parametreli yapıcı metotlar, yapıcı zincirleme (`this()`, `base()`), Stack ve Heap bellek yönetimi, `struct` vs `class` farkı, Kutulama / Kutudan Çıkarma (*Boxing/Unboxing*), `static` sınıflar ve üyeler.
* **Öne Çıkan Uygulamalar:**
  * `Student` ve `StudentManager` yapıcı blok zincirlemeleri.
  * `ValPoint` (`struct`) ile değer kopyalama vs `RefPoint` (`class`) ile referans kopyalama davranış analizi.
  * `MathHelper` (statik sınıf/yardımcı metotlar) ve `Counter` (ortak durum takibi).

### Bölüm 13: Koleksiyonlar I & Veri Yapıları (Collections I & Generics)
* **Kapsam:** Generic mimarisi, parametrik çokbiçimlilik (*Parametric Polymorphism*), tip güvenliği (*Type Safety*), Generic kısıtları (`where T : struct`, `class`, `new()`), yaygın veri yapıları.
* **Öne Çıkan Uygulamalar:**
  * `List<T>` ve `CityManager` şehir yönetim sistemi.
  * `GenericRepository<T>` deposu ve Generic metotlar (`PrintWithMessage<U>`).
  * `LinkedList<T>`: Çift yönlü bağlı liste üzerinde tarayıcı geçmişi simülasyonu (`BrowserHistory` - `VisitPage`, `Back`, `Forward`, `ShowHistory`).
  * `Stack<T>`: LIFO prensibi ile matematiksel parantez dengeleme denetleyicisi (`BracketChecker`).
  * `Queue<T>`: FIFO prensibi ile müşteri destek masası bilet sistemi (`ServiceDesk`, `Ticket`, `Customer`).

### Bölüm 14: Koleksiyonlar II (Collections II)
* **Kapsam:** Anahtar-değer çiftleri, sıralı koleksiyonlar, matematiksel küme yapıları ve olay tabanlı gözlemlenebilir koleksiyonlar.
* **Öne Çıkan Uygulamalar:**
  * `Dictionary<TKey, TValue>`: $O(1)$ erişim karmaşıklığı ile `StudentManager` öğrenci dizinleme uygulaması.
  * `SortedList<TKey, TValue>`: Anahtara göre sıralı saklama ve indeks tabanlı erişim ile `LibraryService` kütüphane otomasyonu (`Book`, `ILibraryService`, `Library`).
  * `ObservableCollection<T>`: Olay güdümlü (`CollectionChanged`, `PropertyChanged`) dinamik UI/veri takip mimarisi.
  * `HashSet<T>`: Benzersiz eleman yönetimi, nesnelerde `Equals` ve `GetHashCode` override kuralları, küme operasyonları (`UnionWith`, `IntersectWith`, `ExceptWith` ile `EventManager`).

### Bölüm 15: Hata Yönetimi (Exception Handling)
* **Kapsam:** Çalışma zamanı hataları, `try-catch-finally` akış şemaları, `System.Exception` mimarisi, özel hata (*Custom Exception*) geliştirme standartları.
* **Öne Çıkan Uygulamalar:**
  * Çoklu `catch` blokları (`FormatException`, `DivideByZeroException`, genel `Exception`).
  * `InvalidAgeException`: `Exception` sınıfından türetilen 4 standart yapıcıya sahip özel istisna sınıfı.
  * `Person` sınıfında Kapsülleme (Encapsulation) aracılığıyla `Age` set bloğu içerisinde iş kuralı doğrulaması ve özel istisna fırlatma.

---

## Kullanılan Teknolojiler ve Standartlar

* **Dil:** C#
* **Geliştirme Ortamı:** Visual Studio Code / Visual Studio
* **Modelleme & Dokümantasyon:** UML Sınıf Diyagramları, Akış Şemaları, PlantUML
* **Temel Prensipler:** SOLID, Temiz Kod (Clean Code), OOP (Kapsülleme, Kalıtım, Polimorfizm, Soyutlama)

---

## Kurulum ve Çalıştırma

Projeyi yerel makinenize klonlamak ve çalıştırmak için:

```bash
# Depoyu klonlayın
git clone [https://github.com/Ahmet-Sait-Cakmak/CSharp-ile-Programlama-BTK-Akademi.git](https://github.com/Ahmet-Sait-Cakmak/CSharp-ile-Programlama-BTK-Akademi.git)

# Proje dizinine gidin
cd CSharp-ile-Programlama-BTK-Akademi

# İlgili çözüm (solution) veya proje dizinine geçiş yapın (Örn: Solution13)
cd Solution13/13_04_Generic

# Projeyi derleyin ve çalıştırın
dotnet run
