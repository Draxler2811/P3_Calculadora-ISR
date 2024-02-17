using System;
using ISR.Core.Entities;
using ISR.Core.Managers;
using ISR.Core.Services;


namespace ISR.App;

public static class Program{

    public static void Main(String[] args ){
        decimal dinero = 0;

        System.Console.WriteLine("Ingresa tu dinero: ");
        Decimal.TryParse(System.Console.ReadLine(), out dinero);

    
        // var bmi = new Bmi();
        var salario = new Person{Salario = dinero};

        var service = new IsrService();
        var managers = new IsrManager(service);

        Isr isr = managers.GetIsr(salario);

        System.Console.WriteLine($"Tu Isr es: {isr.Index}");
    }
}


