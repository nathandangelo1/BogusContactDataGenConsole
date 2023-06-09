
using CsvHelper;
using System.Globalization;

namespace BogusContactDataGenConsole;
class Program
{
    static List<ContactModel> contacts = new();

    static void Main(string[] args)
    {
        LoadData();
    }
    static void LoadData()
    {
        DataGenerator dg = new();
        var results = dg.GenerateContacts().Take(50);
        contacts.AddRange(results);
        WriteToCsv(contacts);
    }

    static void WriteToCsv(List<ContactModel> contacts)
    {
        using (var writer = new StreamWriter(@"C:\Users\POBOYINSAMSARA\Desktop\contacts.csv"))
        using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
        {
            csv.WriteRecords(contacts);
        }
    }
}
