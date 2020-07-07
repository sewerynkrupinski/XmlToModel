using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XmlToModel.Models
{
    public class XmlPattern
    {
        [Serializable]
        [System.Xml.Serialization.XmlRoot("Cars")]
        public class Cars
        {
            [System.Xml.Serialization.XmlElement("Car")]
            public Car[] Car { get; set; }
        }

        [Serializable]
        public class Car
        {
            [System.Xml.Serialization.XmlElement("Id")]
            public string Id { get; set; }
            [System.Xml.Serialization.XmlElement("Make")]
            public Make Make { get; set; }
            [System.Xml.Serialization.XmlElement("Engine")]
            public Engine Engine { get; set; }
        }

        public class Make
        {
            [System.Xml.Serialization.XmlElement("Name")]
            public string Name { get; set; }
            [System.Xml.Serialization.XmlElement("Model")]
            public Model Model { get; set; }
        }

        public class Model
        {
            [System.Xml.Serialization.XmlElement("Name")]
            public string Name { get; set; }
            [System.Xml.Serialization.XmlElement("Option")]
            public string Option { get; set; }
        }

        public class Engine
        {
            [System.Xml.Serialization.XmlElement("FuelType")]
            public string FuelType { get; set; }
            [System.Xml.Serialization.XmlElement("Power")]
            public Power Power { get; set; }
            [System.Xml.Serialization.XmlElement("Capacity")]
            public string Capacity { get; set; }
            [System.Xml.Serialization.XmlElement("Transmission")]
            public string Transmission { get; set; }
        }

        public class Power
        {
            [System.Xml.Serialization.XmlElement("HP")]
            public string Hp { get; set; }
            [System.Xml.Serialization.XmlElement("kW")]
            public string KW { get; set; }
        }
    }
}
