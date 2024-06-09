using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public void SayHello()
    {
        Debug.Log("Hello, my name is " + Name + " and I am " + Age + " years old.");
    }
}

public class Allin : MonoBehaviour
{
    // UI-Textfeld für die Ausgabe (Aufgabe 13) mit TextMeshPro
    public TextMeshProUGUI personText;

    // Aufgabe 3: Funktion AddNumbers
    int AddNumbers(int a, int b)
    {
        return a + b;
    }

    // Aufgabe 4: Funktion PrintMessage
    void PrintMessage(string message)
    {
        Debug.Log(message);
    }

    void Start()
    {
        // Aufgabe 1: Deklarieren und Initialisieren von Variablen
        int integerVariable = 10;
        float floatVariable = 20.5f;
        string stringVariable = "Hello, Unity!";
        bool boolVariable = true;

        // Aufgabe 1a: Deklarieren von Variablen
        int maxValue;
        float minValue;
        string msgHello;

        // Aufgabe 2: Einfache Berechnungen mit Variablen
        int a = 5;
        int b = 10;
        int sum = a + b;
        float division = (float)a / b;
        Debug.Log("Summe: " + sum);
        Debug.Log("Division: " + division);

        // Aufgabe 5: Erstellen und Verwenden der Klasse Person
        Person person = new Person();
        person.Name = "Alice";
        person.Age = 30;
        person.SayHello();

        // Aufgabe 6: if-else Statement für den Score
        int score = 85;
        if (score >= 90)
        {
            Debug.Log("Grade: A");
        }
        else if (score >= 80)
        {
            Debug.Log("Grade: B");
        }
        else if (score >= 70)
        {
            Debug.Log("Grade: C");
        }
        else
        {
            Debug.Log("Grade: F");
        }

        // Aufgabe 7: Arbeiten mit Arrays
        int[] numbers = { 1, 2, 3, 4, 5 };
        foreach (int Number in numbers)
        {
            Debug.Log(Number);
        }

        // Aufgabe 8: Arbeiten mit Listen
        List<string> fruits = new List<string> { "Apple", "Banana", "Cherry" };
        foreach (string fruit in fruits)
        {
            Debug.Log(fruit);
        }
        fruits.Add("Dragonfruit");
        Debug.Log("Anzahl der Elemente in der Liste: " + fruits.Count);

        // Aufgabe 9: for-Schleife
        for (int i = 0; i < 10; i++)
        {
            Debug.Log(i);
        }

        // Aufgabe 10: while-Schleife
        int counter = 0;
        while (counter < 5)
        {
            Debug.Log(counter);
            counter++;
        }

        // Aufgabe 11: foreach-Schleife
        string[] names = { "Alice", "Bob", "Charlie" };
        foreach (string name in names)
        {
            Debug.Log(name);
        }

        // Aufgabe 12: do-while-Schleife
        int number = 0;
        do
        {
            Debug.Log(number);
            number++;
        } while (number < 3);

        // Aufgabe 13: Integration aller Konzepte
        List<Person> people = new List<Person>
        {
            new Person { Name = "Alice", Age = 30 },
            new Person { Name = "Bob", Age = 25 },
            new Person { Name = "Charlie", Age = 35 }
        };

        string displayText = "";
        foreach (Person p in people)
        {
            p.SayHello();
            displayText += "Hello, my name is " + p.Name + " and I am " + p.Age + " years old.\n";
        }

        personText.text = displayText;

        // Arbeiten mit Scores
        int[] scores = { 95, 82, 76, 60 };
        foreach (int s in scores)
        {
            if (s >= 90)
            {
                Debug.Log("Grade: A");
            }
            else if (s >= 80)
            {
                Debug.Log("Grade: B");
            }
            else if (s >= 70)
            {
                Debug.Log("Grade: C");
            }
            else
            {
                Debug.Log("Grade: F");
            }
        }
    }

    // Variablen sind Funktionen die bestimmte anweisungen und Daten von Objekten in Unity enthalten.
    // Datentypen definieren die Art von Dateb die in einer Variable gespeichert werden können.

    // Bei der Deklaration können einer Variablen auch schon Werte zugewiesen werden,
    // d.h. eine Initialisierung der Variablen ist bereits möglich.
    // Zusammen mit der De- klaration gilt die Variable dann als definiert.
}







