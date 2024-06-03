namespace Task2;

public class GoodPupil : Pupil
{
    public override void Study()
    {
        Console.WriteLine("Study: good level");
    }
    
    public override void Read()
    {
        Console.WriteLine("Read: good level");
    }
    
    public override void Write()
    {
        Console.WriteLine("Write: good level");
    }
    
    public override void Relax()
    {
        Console.WriteLine("Relax: good level");
    }
}