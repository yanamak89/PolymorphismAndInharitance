using System;
using Task2;

class Program
{
    static void Main(string[] args)
    {
        Pupil pupil1 = new ExcelentPupil();
        Pupil pupil2 = new GoodPupil();
        Pupil pupil3 = new BadPupil();
        // можливість передати 2 або 3 аргументи
        Pupil pupil4 = new ExcelentPupil();
        ClassRoom classRoom = new ClassRoom(pupil1, pupil2, pupil3, pupil4);
        classRoom.ShowClassroomInfo();

    }
}