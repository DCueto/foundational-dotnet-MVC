﻿using NetUniversity.CSharp.CollectionsAndLists;
using NetUniversity.CSharp.OOP;
using NetUniversity.CSharp.Interfaces;
using System.ComponentModel;
using NetUniversity.CSharp.Generics;
using NetUniversity.CSharp.Reflection;

namespace NetUniversity.CSharp;

public static class Runner
{
    public static void RunReflection()
    {
        ReflectionExample.Execute();
    }

    public static void RunGenerics()
    {
        IPersonRepository<Student> studentRepository = new StudentRepository();
        StudentPrinterService studentService = new StudentPrinterService(studentRepository);
        studentService.PrintStudents(5);
        
        IRepository<Author> authorRepository = new AuthorRepository();
        AuthorPrinterService printerService = new AuthorPrinterService(authorRepository);
        printerService.PrintAuthors();
    }

    public static void RunClassWithInterfaces()
    {
        Document document = new Document("Daniel Cueto");
        document.Load();
        document.Save();
        Console.WriteLine($"Document needs to save? Answer: {document.HasToSave()}");

        // Validating and Casting
        if (document is IOperations)
        {
            Console.WriteLine($"Document has IOperations interface");
            document.Save();
        }

        IOperations iop = document as IOperations;
        if (iop is not null)
        {
            Console.WriteLine($"Cast 'iop' from 'Document' instance to 'IOperations' was successful");
            iop.Save();
        }

        document.SendEmail();
        document.SendTextMessage();
        document.SendNotification();

        IMessaging imessaging = document as IMessaging;
        imessaging?.SendNotification();

        // Dotnet interface method
        document.PropertyChanged += (object? sender, PropertyChangedEventArgs eArgs) =>
        {
            Console.WriteLine($"Document {sender?.GetType()} property changed is {eArgs.PropertyName}");
        };

        document.DocumentName = "Software Engineering";
    }

    public static void RunEvents()
    {
        Events.RunEvents();
    }

    public static void RunDelegates()
    {
        Delegates.RunDelegates();
    }

    public static void RunDictionaries()
    {
        Dictionaries.RunDictionaries();
    }

    public static void RunLists()
    {
        //Lists.RunLists();
        //Lists.RunLinkedLists();
        //Lists.RunStacks();
        Lists.RunQueues();
    }
    
    public static void RunOOPSimpleBook()
    {
        SimpleBook hobbitSimpleBook = new SimpleBook("The Hobbit", "J.R.R. Tolkien", 312);
        Console.WriteLine(hobbitSimpleBook.GetBookDetails());

        SimpleBook donQuijoteSimpleBook = new SimpleBook("Don Quijote", "Miguel de Cervantes", 1000);
        Console.WriteLine(donQuijoteSimpleBook.GetBookDetails());

        donQuijoteSimpleBook.Name = "Don Quijote de la Mancha";

        Console.WriteLine($"{donQuijoteSimpleBook.Name} by {donQuijoteSimpleBook.Author} with {donQuijoteSimpleBook.NumberPages} pages");
        donQuijoteSimpleBook.NumberPages = 3000;

        Console.WriteLine($"{donQuijoteSimpleBook.RandomProperty}");
        donQuijoteSimpleBook.RandomProperty = "hehe";
        Console.WriteLine($"{donQuijoteSimpleBook.RandomProperty}");
    }

    public static void RunOOP()
    {
        Book donQuijote = new Book("Don Quijote de la Mancha", "Miguel de Cervantes", 3000, 20.50m);
        Console.WriteLine(donQuijote.GetDetails());

        Magazine timesMagazine = new Magazine("Daniel Cueto", "Times", 50, 10.25m);
        Console.WriteLine(timesMagazine.GetDetails());
    }

    public static void RunMethods()
    {
        Methods.PrintText("Hola desde el metodo PrintText");

        Console.WriteLine("Ingrese el número de veces a generar números aleatoros:");
        Methods.PrintRandomNumber(int.Parse(Console.ReadLine()!), "El numero aleatorio es:");
        Methods.PrintRandomNumber(2);
        Methods.PrintRandomNumber(message: "Random num:", rangeNumber: 4);

        int totalSalary = 0;
        Methods.CalcTotalSalary(salary: 1000, tax: 210, healthInsurance: 100, out totalSalary);
        Console.WriteLine($"My total salary is: {totalSalary}$");

        string ageMessage = Methods.GetMessageByAge(29);
        Console.WriteLine(ageMessage);

        Methods.ManageTuples(true);

        var newProduct = Methods.GetNewShopProduct();
        Console.WriteLine($"New product data \n" +
            $"Product name: {newProduct.productName} \n" +
            $"Product final price: {newProduct.productPrice}$ \n" +
            $"Product stock: {newProduct.productStock}");
    }

    public static void RunExceptions()
    {
        Exceptions.RunAcumWithException();
    }
}
