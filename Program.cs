using System;

// Обобщенный класс
class GenericClass<T>
{
    // Закрытое поле обобщенного типа
    private T _value;

    // Свойство обобщенного типа
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
        // Пример с int
        GenericClass<int> intContainer = new GenericClass<int>();
        intContainer.Value = 42;
        Console.WriteLine($"Значение int: {intContainer.Value}");

        // Пример с string
        GenericClass<string> stringContainer = new GenericClass<string>();
        stringContainer.Value = "Hello, World!";
        Console.WriteLine($"Значение string: {stringContainer.Value}");

        // Пример с double
        GenericClass<double> doubleContainer = new GenericClass<double>();
        doubleContainer.Value = 3.14159;
        Console.WriteLine($"Значение double: {doubleContainer.Value}");
    }
}