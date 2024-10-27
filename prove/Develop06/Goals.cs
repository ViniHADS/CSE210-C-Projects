public class Goal
{
    public string Name { get; set; }
    public string Description { get; set; }
    public bool IsCompleted { get; set; }

    public Goal(string name, string description)
    {
        Name = name;
        Description = description;
        IsCompleted = false; // Inicialmente não concluído
    }
}
