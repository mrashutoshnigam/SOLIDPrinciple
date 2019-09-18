using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace DesignPatterns.AdapterPattern
{
    class Adapter : ITarget
    {
        Adaptee adaptee;
        public Adapter(Adaptee adaptee)
        {
            this.adaptee = adaptee;
        }
        public string GetEmployeeInXML()
        {
            using (var stringwriter = new System.IO.StringWriter())
            {
                var serializer = new XmlSerializer(typeof(Employee));
                serializer.Serialize(stringwriter, this.adaptee.GetEmployee());
                return stringwriter.ToString();
            }
        }
    }
}
