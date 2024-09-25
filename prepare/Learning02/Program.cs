using System;

class Program
{
     static void Main(string[] args)
    {
        Job j1 = new Job();
        j1._jobTitle = "ALIMENTADOR DE LINHA DE PRODUÇÃO";
        j1._company = "YAPP BRASIL LTDA";
        j1._startYear = 2019;
        j1._endYear = 2021;

        Console.WriteLine();

        Job j2 = new Job();
        j2._jobTitle = "ALIMENTADOR DE LINHA DE PRODUÇÃO";
        j2._company = "PERTO S.A PERIFÉRICOS PARA AUTOMAÇÃO";
        j2._startYear = 2021;
        j2._endYear = 2024;

        Console.WriteLine();

        resume myResume = new resume();
        myResume._name = "Vinicius Araujo";
        myResume._jobs.Add(j1);
        myResume._jobs.Add(j2);

        myResume.Display();
    }
}