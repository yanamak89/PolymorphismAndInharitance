namespace Task2;

/*
 * Конструктор класу ClassRoom приймає аргументи типу Pupil, 
   клас має складатися із 4 учнів. 
   Передбачте можливість, що користувач може передати 2 або 3 аргументи.
   
   Виведіть інформацію про те, як усі учні екземпляра класу ClassRoom вміють вчитися, читати, писати, відпочивати. 
 */
public class ClassRoom
{
    private Pupil[] pupils;

    public ClassRoom(Pupil pupil1, Pupil pupil2, Pupil pupil3, Pupil pupil4 = null)
    {
        pupils = new Pupil[4];
        pupils[0] = pupil1;
        pupils[1] = pupil2;
        pupils[2] = pupil3;
        pupils[3] = pupil4;
    }

    public void ShowClassroomInfo()
    {
        foreach (var pupil in pupils)
        {
            Console.WriteLine($"Pupil {Array.IndexOf(pupils, pupil) + 1}: ");
            Console.WriteLine("------------");
            if (pupil != null)
            {
                pupil.Study();
                pupil.Read();
                pupil.Write();
                pupil.Relax();
            }
        }
    }
}