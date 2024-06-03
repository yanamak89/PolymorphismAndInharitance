namespace Task4;

/*
 * Створіть похідний клас ProDocumentWorker. 
   Перевизначте відповідні методи, при перевизначенні методів виводьте наступні рядки:
   "Документ відредаговано", "Документ збережено у старому форматі, збереження в інших форматах є у версії Експерт".
 */
public class ProDocumentWorker : DocumentWorker
{
    public override void OpenDocument()
    {
        Console.WriteLine("Document opened.");
    }
    public override void EditDocument()
    {
        Console.WriteLine("Document edited.");
    }
    
    public override void SaveDocument()
    {
        Console.WriteLine("The document is saved in the old format, saved in other formats in the Expert version.");
    }
}