
using PatikaWeek4PrtaikIlkSinifimiziOlusturuyoruz;
class Program
{
    public static void Main(string[] args)
    {
        Person student1 = new Person();//Nesne oluşturma
        //Tanımlamaların yapılması
        student1.Name = "Ahmet";
        student1.Surname = "Çavuş";
        student1.BirthDate = "12.12.1995";
        student1.Role = "Öğrenci";

        Person student2 = new Person();//Nesne oluşturma
        //Tanımlamaların yapılması
        student2.Name = "Ayşe";
        student2.Surname = "Yolgezen";
        student2.BirthDate = "24.07.1995";
        student2.Role = "Öğrenci";

        Person teacher1 = new Person();//Nesne oluşturma
        //Tanımlamaların yapılması
        teacher1.Name = "Gülsüm";
        teacher1.Surname = "Bakır";
        teacher1.BirthDate = "13.05.1970";
        teacher1.Role = "Öğretmen";
        //Method yardımı ile konsola yazdırma
        student1.Display();
        student2.Display();
        teacher1.Display();
    }
}
