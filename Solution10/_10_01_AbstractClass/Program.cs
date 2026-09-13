// var searchAlgorithm = new SearchAlgorithm(10, 20, 30, 40, 50, 60);

SearchAlgorithm searcher;


searcher = new LinearSearch([3, 7, 15, 20, 28, 35, 42]);

System.Console.WriteLine("\nDogrusal Arama:\n");

int indeks1 = searcher.Search(20);

searcher.PrintResult(indeks1, 20);


searcher = new BinarySearch([10, 20, 30, 40, 50, 60, 70, 80, 90]);

System.Console.WriteLine("\n\nIkili Arama:\n");

int indeks2 = searcher.Search(100);

searcher.PrintResult(indeks2, 10);
