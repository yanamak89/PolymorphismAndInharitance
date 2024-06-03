namespace Task2;

public class BadPupil : Pupil
{
    public override void Study()
    {
        Console.WriteLine("Study: bad level");
    }
    
    public override void Read()
    {
        Console.WriteLine("Read: bad level");
    }
    
    public override void Write()
    {
        Console.WriteLine("Write: bad level");
    }
    
    public override void Relax()
    {
        Console.WriteLine("Relax: bad level");
    }

}