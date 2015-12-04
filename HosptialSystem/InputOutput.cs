using Newtonsoft.Json;
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
            Console.WriteLine(jsonFile);
            var peopleDataList = JsonConvert.DeserializeObject<List<Person>>(jsonFile) ?? new List<Person>();
            peopleDataList.Add(incomingObject);

            jsonFile = JsonConvert.SerializeObject(peopleDataList);
            System.IO.File.WriteAllText(filePath, jsonFile);
        }
        public void readFromXML()
        {

        }
      
    }
}