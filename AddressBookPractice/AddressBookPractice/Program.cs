namespace AddressBookPractice
{
    class Program
    {
        public static void Main(string[] args)
        {

            //UC-14
            MultipleAddressBooks multipleAddressBooks = new MultipleAddressBooks();

            //adding address books and contacts
            multipleAddressBooks.addAddressBook();
            multipleAddressBooks.addContact();
            multipleAddressBooks.addAddressBook();
            multipleAddressBooks.addContact();

            //writing to csv file
            multipleAddressBooks.WriteToCSVFile();

            //reading from csv file
            MultipleAddressBooks.ReadFromCsvFile();



        }
    }
}