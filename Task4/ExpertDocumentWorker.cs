namespace Task4;

/*
 * Створіть похідний клас ExpertDocumentWorker від базового класу ProDocumentWorker.
   Перевизначте відповідний спосіб. 
   При викликі даного методу необхідно виводити на екран "Документ збережений у новому форматі".
 */
public class ExpertDocumentWorker : ProDocumentWorker
{
    public override void SaveDocument()
    {
        Console.WriteLine("The document is saved in the new format.");
    }
}