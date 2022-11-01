using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace WindowsFormsApp1
{
    class PeriodicTableHandler
    {
        const string jsonPath = "../PeriodicTableJSON.json";
        List<Element> elements;


        private void SetPeriodicTable()
        {
            string jsonContent = File.ReadAllText(jsonPath);
            elements = JsonConvert.DeserializeObject<List<Element>>(jsonContent);            
        }

        public PeriodicTableHandler()
        {
            SetPeriodicTable();
            Console.WriteLine("AfterSet");
        }

        public List<Element> GetElementsTable()
        {
            return elements;
        }
    }
}
