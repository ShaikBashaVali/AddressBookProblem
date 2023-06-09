﻿using System;
using System.Collections.Generic;

namespace AddressBookProblems
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            List<Contacts> Person = new List<Contacts>();
            Console.WriteLine("*****----Welcome to Address Book Program----*****\n");
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Please select given options:---\n--------------------");
                Console.WriteLine("1.AddContacts\n" +
                    "2.DisplayDetails\n" +
                    "3.EditPersonDetails\n" +
                    "4.DeletePersonByUsingPersonName\n" +
                    "5.AddMultiplePerson\n" +
                    "6.CreateDictionaryContacts\n" +
                    "7.DisplayDictionaryList\n" +
                    "8.CheckDuplicateEntryOfSamePersonByPersonNameInList\n" +
                    "9.SearchPersonByCityOrStateInDictionaryAB\n" +
                    "10.ViewPersonByCityOrStateInDictionaryAB\n" +
                    "11.GetNumberOfContactPersonsThatIsCounrByCityOrStateInList\n" +
                    "12.SortEntriesInAddressBookByPersonsNameInList\n" +
                    "13.SortPersonByCityStateOrZipInList\n" +
                    "14.ReadOrWritePersonsContactIntoFileUsingFileIO\n" +
                    "15.ReadOrWritePersonsContactAsCSVFile\n" +
                    "16.ReadOrWritePersonsContactAsJsonFile\n" +
                    "17.Exit\n");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        AddressBookMain.AddContacts();
                        Console.Clear();
                        break;
                    case 2:
                        AddressBookMain.DisplayDetails();
                        Console.Clear();
                        break;
                    case 3:
                        AddressBookMain.EditPersonDetails();
                        Console.Clear();
                        break;
                    case 4:
                        AddressBookMain.DeletePersonByUsingPersonName();
                        Console.Clear();
                        break;
                    case 5:
                        AddressBookMain.AddMultiplePerson();
                        Console.Clear();
                        break;
                    case 6:
                        AddressBookMain.CreateDictionaryContacts();
                        Console.Clear();
                        break;
                    case 7:
                        AddressBookMain.DisplayDictionaryList();
                        Console.Clear();
                        break;
                    case 8:
                        AddressBookMain.CheckDuplicateEntryOfSamePersonByName();
                        Console.Clear();
                        break;
                    case 9:
                        AddressBookMain.SearchPersonByCityOrState();
                        Console.Clear();
                        break;
                    case 10:
                        AddressBookMain.ViewPersonByCityOrState();
                        Console.Clear();
                        break;
                    case 11:
                        AddressBookMain.CountCityOrState();
                        Console.Clear();
                        break;
                    case 12:
                        AddressBookMain.SortPersonsName();
                        Console.Clear();
                        break;
                    case 13:
                        AddressBookMain.SortPersonByCityStateOrZip();
                        Console.Clear();
                        break;
                    case 14:
                        Console.Clear();
                        Console.WriteLine("Data is write in file successfully......");
                        Console.WriteLine("\nNow Reading Details of Persons In Address Book by using FileIO:\n-----------------------------------------------");
                        AddressBookMain.ReadWritePersonContactsByUsingFileIO();
                        Console.WriteLine("Press any key to continue.");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 15:
                        Console.Clear();
                        Console.WriteLine("Data is write in Csv file successfully......");
                        Console.WriteLine("\nNow Reading Details of Persons In Address Book from csv file:\n-----------------------------------------------------------");
                        AddressBookMain.ReadWritePersonContactsAsCSVFile();
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 16:
                        Console.Clear();
                        Console.WriteLine("Data is write in Json file successfully......");
                        Console.WriteLine("\nNow Reading Details of Persons In Address Book from Json file:\n-----------------------------------------------------------");
                        AddressBookMain.ReadWritePersonContactsAsJSONFile();
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    default:

                        flag = false;
                        Console.ReadLine();
                        break;
                }
            }
        }
    }
}
