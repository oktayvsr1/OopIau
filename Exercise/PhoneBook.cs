using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class PhoneBook
    {
        List<Contact> contacts = new List<Contact>();
        public string getString(string messge)
        {
            Console.WriteLine(messge);
            return Console.ReadLine();
        }

        public int getInt(string message)
        {
            Console.WriteLine(message);
            return Convert.ToInt32(Console.ReadLine());
        }
        

        public void newContact()
        {
            Contact contact = new Contact();
            contact.name = getString("Contact name?");
            contact.surname = getString("Conact surname?");
            contact.id = getInt("Contact ıd?");
            contact.city = getString("Contact city?");
            contact.Numbers = new List<int>(getInt("Contact numbers?"));
            contacts.Add(contact);
        }
        public void getContacts()
        {
            //foreach (Contact contact in contacts)
            //{
            //    Console.WriteLine(contact.name+" "+contact.surname+" "+contact.id+" "+contact.Numbers);
            //}

            contacts.ForEach(c =>
            {
                Console.WriteLine(c.name + " " + c.surname + " " + c.id + " " + c.city);
                c.Numbers.ForEach(n => Console.WriteLine(n));


            }) ;
           
        }
        public void getContact(int id)
        {
            //foreach(Contact contact in contacts)
            //{
            //    if(contact.id == id)
            //    {
            //        Console.WriteLine(contact.name + " " + contact.surname + " " + contact.id  + " " + contact.Numbers);
            //    }
            //    else
            //    {
            //        Console.WriteLine("there is no contact with this "+id);
            //    }
            //}

            if(contacts.Exists(c => c.id == id))
            {
                contacts.FindAll(c => c.id == id).ForEach(c =>
                {
                    Console.WriteLine(c.name + " " + c.surname + " " + c.id + " " + c.city);
                    c.Numbers.ForEach(n => Console.WriteLine(n));
                });
            }
            else
            {
                Console.WriteLine("No contact with this Id"+id);
            }
        }

        public void getContacts(string city)
        {
            //foreach(Contact contact in contacts)
            //{
            //    if (contact.city == city)
            //    {
            //        Console.WriteLine(contact.name + " " + contact.surname + " " + contact.id+" "+city + " " + contact.Numbers);
            //    }
            //}
            if (contacts.Exists(c => c.city.Equals(city)))
            {
                contacts.FindAll(c => c.city.Equals(city)).ForEach(c =>
                {
                    Console.WriteLine(c.name + " " + c.surname + " " + c.id + " " + c.city);
                    c.Numbers.ForEach(n => Console.WriteLine(n));
                
                });

            }
            else
            {
                Console.WriteLine("No contact with this City" + city);
            }
        }

        public void deleteContact(int id)
        {
            //foreach( Contact contact in contacts)
            //{
            //    if (contact.id == id)
            //    {
            //        var deletedContact = contact;
            //        contacts.Remove(deletedContact);
            //        Console.WriteLine(deletedContact.name+" is deleted");
            //    }
            //}

            if (contacts.Exists(c => c.id == id))
            {
                contacts.FindAll(c => c.id == id).ForEach(c =>
                {
                    contacts.Remove(c);
                    Console.WriteLine(c.name + " " + c.surname + " " + c.id + " " + c.city);
                    c.Numbers.ForEach(n => Console.WriteLine(n));

                });
            }

        }

        public void addNumber(int id, int number)
        {
            if (contacts.Any(c => c.id == id))
            {
                contacts.Find(c=>c.id== id).Numbers.Add(number);
            }
            else
            {
                Console.WriteLine("No contact with this ıd "+id);
            }



        }
    }
}
