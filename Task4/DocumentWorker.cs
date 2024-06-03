namespace Task4;

/*
 * У тілі класу створіть три методи OpenDocument(), EditDocument(), SaveDocument(). 
   У тіло кожного з методів додайте виведення на екран відповідних рядків:
   "Документ відкритий", "Редагування документа у версії Про", "Збереження документа у версії Про".
 */
public class DocumentWorker
{
    public virtual void OpenDocument()
    {
        Console.WriteLine("Document opened.");
    }
    public virtual void EditDocument()
    {
        Console.WriteLine("Document edited in Pro version.");
    }
    
    public virtual void SaveDocument()
    {
        Console.WriteLine("Document saved in Pro version.");
    }
    
    
}