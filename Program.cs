using System;

/* 
 Задача 1
class GenericClass<T>
{
   
    private T _value;

    
    public T Value
    {
        get { return _value; }
        set { _value = value; }
    }
}

class Program
{
    static void Main()
    {
      
        GenericClass<int> intContainer = new GenericClass<int>();
        intContainer.Value = 42;
        Console.WriteLine($"Значение int: {intContainer.Value}");

  
        GenericClass<string> stringContainer = new GenericClass<string>();
        stringContainer.Value = "Hello, World!";
        Console.WriteLine($"Значение string: {stringContainer.Value}");

     
        GenericClass<double> doubleContainer = new GenericClass<double>();
        doubleContainer.Value = 3.14159;
        Console.WriteLine($"Значение double: {doubleContainer.Value}");
    }
}



Задача 2


using System;

class Program
{
    static T FindMax<T>(T[] array) where T : IComparable<T>
    {
        if (array == null || array.Length == 0)
            throw new ArgumentException("Массив не может быть пустым");

        T max = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i].CompareTo(max) > 0)
                max = array[i];
        }
        return max;
    }

    static void Main()
    {
        int[] intArray = { 3, 7, 2, 9, 5 };
        Console.WriteLine($"Максимальное int: {FindMax(intArray)}");

        double[] doubleArray = { 1.5, 2.7, 3.1, 0.9 };
        Console.WriteLine($"Максимальное double: {FindMax(doubleArray)}");

        string[] stringArray = { "a", "b", "c", "d" };
        Console.WriteLine($"Максимальное string: {FindMax(stringArray)}");
    }
}







Задача 3





using System;

class GenericArray<T>
{
    private T[] array;

    public GenericArray(T[] arr)
    {
        array = arr;
    }

    public T[] Array => array;

    public static GenericArray<T> operator +(GenericArray<T> a, GenericArray<T> b)
    {
        T[] newArray = new T[a.array.Length + b.array.Length];
        a.array.CopyTo(newArray, 0);
        b.array.CopyTo(newArray, a.array.Length);
        return new GenericArray<T>(newArray);
    }

    public void Print()
    {
        Console.WriteLine(string.Join(", ", array));
    }
}

class Program
{
    static void Main()
    {
        GenericArray<int> intArr1 = new GenericArray<int>(new int[] { 1, 2, 3 });
        GenericArray<int> intArr2 = new GenericArray<int>(new int[] { 4, 5, 6 });
        GenericArray<int> intResult = intArr1 + intArr2;
        intResult.Print();

        GenericArray<string> strArr1 = new GenericArray<string>(new string[] { "a", "b" });
        GenericArray<string> strArr2 = new GenericArray<string>(new string[] { "c", "d", "e" });
        GenericArray<string> strResult = strArr1 + strArr2;
        strResult.Print();
    }
}




Задача 4 

using System;

class GenericStorage<T>
{
    private T[] items = Array.Empty<T>();

    public void Add(T item)
    {
        Array.Resize(ref items, items.Length + 1);
        items[^1] = item;
    }

    public bool Remove(T item)
    {
        int index = Array.IndexOf(items, item);
        if (index < 0) return false;

        T[] newArray = new T[items.Length - 1];
        Array.Copy(items, 0, newArray, 0, index);
        Array.Copy(items, index + 1, newArray, index, items.Length - index - 1);
        items = newArray;
        return true;
    }

    public T Get(int index)
    {
        if (index < 0 || index >= items.Length)
            throw new IndexOutOfRangeException();
        return items[index];
    }

    public int Length => items.Length;
}

class Program
{
    static void Main()
    {
        GenericStorage<int> intStorage = new GenericStorage<int>();
        intStorage.Add(10);
        intStorage.Add(20);
        intStorage.Add(30);
        Console.WriteLine($"Length: {intStorage.Length}");
        Console.WriteLine($"Element at 1: {intStorage.Get(1)}");
        intStorage.Remove(20);
        Console.WriteLine($"Length after remove: {intStorage.Length}");

        GenericStorage<string> stringStorage = new GenericStorage<string>();
        stringStorage.Add("first");
        stringStorage.Add("second");
        Console.WriteLine($"Element at 0: {stringStorage.Get(0)}");
    }
}

*/
