using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace HosptialSystem
{
    class InputOutput
    {
        public void writeToXML(Person incomingObject)
        {
            var filePath = "C:\\Users\\Robert Moon\\Documents\\Class\\GitHub\\HosptialSystem\\HosptialSystem\\PeopleDatabase.json";
            var jsonFile = System.IO.File.ReadAllText(filePath);
            var peopleDataList = JsonConvert.DeserializeObject<List<Person>>(jsonFile) ?? new List<Person>();
            peopleDataList.Add(incomingObject);
            jsonFile = JsonConvert.SerializeObject(peopleDataList);
            System.IO.File.WriteAllText(filePath, jsonFile);
        }
        public Person readFromXML(string searchTerm)
        {
            var filePath = "C:\\Users\\Robert Moon\\Documents\\Class\\GitHub\\HosptialSystem\\HosptialSystem\\PeopleDatabase.json";
            var jsonFile = File.ReadAllText(filePath);
            var personDB = (JObject)JsonConvert.DeserializeObject(jsonFile);
            Person person = personDB[searchTerm].Value<Person>();
            return person;
        }
    }
}