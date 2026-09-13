using System;

namespace _08_01_OOPBasics;

class Number {

    // ctor
    // Yapici metod -> Referans

    private int _singleNumber = 3;  // field (alan)

    private int[] _innerArray = { 10, 20, 30, 40, 50 }; // field (alan)

    private String? _description;

    public Number()
    {
        System.Console.WriteLine("Number sinifindan bir ornek (intance) uretildi.");
        System.Console.WriteLine($"Number: {_singleNumber:N0}");
    }

    public Number(int singleNumber, string description, int count = -1)
    {
        SingleNumber = singleNumber;
        Description = description;
        Count = count;
    }

    public Number(int[] arr)
    {
        _innerArray = new int[arr.Length];

        for (int i = 0; i < arr.Length; i++)
        {
            _innerArray[i] = arr[i];
        }
    }

    public int SingleNumber  // Full Property
    {
        get 
        { 
            return _singleNumber; 
        }

        set 
        {
             if (value < 0) 
                _singleNumber = 0;
             else
                _singleNumber = value; 
        }
    }

    public String? Description
    {
        get { return _description; }
        set { _description = value; }
    }
    
    public int Count { get; set; } // Auto Property

    public int Min
    {
        get { return FindMin(); }
    }

    public int Max => FindMax();
    
    private int FindMin() {

    int min = _innerArray[0];

    for (int i = 0; i < _innerArray.Length; i++) {

        if (_innerArray[i] < min) {

            min = _innerArray[i];
        }
    }

    return min;
    }

    private int FindMax() {

    int max = _innerArray[0];

    for (int i = 0; i < _innerArray.Length; i++) {

        if (_innerArray[i] > max) {

            max = _innerArray[i];
        }
    }

    return max;
    }

    public int Find(int key) {

    for (int i = 0; i < _innerArray.Length; i++) {

        if (_innerArray[i] == key) {

            return i;
        }
    }

    return -1; // key degeri arr dizisinin icinde bulunamazsa Find metodu -1 dondurur
    }

}
