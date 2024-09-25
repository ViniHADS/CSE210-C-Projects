using System;

public class resume
{
    public string _name;
    public List <Job> _jobs =  new List<Job>();
    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.Write("Jobs:");

        Console.WriteLine();

        foreach (Job job in _jobs)
        {
            job.Display();
        }
    }
}