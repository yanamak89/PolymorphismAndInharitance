/*
 * У тілі методу Main() реалізуйте можливість прийому від користувача номер ключа доступу pro і exp. 
   Якщо користувач не вводить ключ, він може користуватися лише безкоштовною версією 
   (створюється екземпляр базового класу), 
   якщо користувач ввів номери ключа доступу pro і exp, то повинен створити екземпляр відповідної версії класу, 
   наведений до базового - DocumentWorker.
 */


using Task4;

class Program
{
    static void Main(string[] args)
    {
        string proKey = "pro2024";
        string expKey = "exp2024";
        DocumentWorker documentWorker = new DocumentWorker();
        ExpertDocumentWorker expertDocumentWorker = new ExpertDocumentWorker();
        ProDocumentWorker proDocumentWorker = new ProDocumentWorker();
        
        
        Console.WriteLine("Please enter your access key number pro or exp:");
        string key = Console.ReadLine(); // Read user input

        if (key == proKey)
        {
            Console.WriteLine("You have access to Pro version. \nAvailable functionality is:");
            proDocumentWorker.OpenDocument();
            proDocumentWorker.EditDocument();
            proDocumentWorker.SaveDocument();
        } else if (key == expKey)
        {
            Console.WriteLine("You have access to Expert version. \nAvailable functionality is:");
            expertDocumentWorker.OpenDocument();
            expertDocumentWorker.SaveDocument();
            expertDocumentWorker.EditDocument();
        } else 
        {
            Console.WriteLine("You have access to Free version. \nAvailable functionality is: ");
            documentWorker.OpenDocument();
            documentWorker.EditDocument();
            documentWorker.SaveDocument();
        }
    }
}