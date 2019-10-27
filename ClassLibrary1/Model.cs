using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace TestTaskLibrary
{
    public class Model
    {
        public Diagram Diagram;
        //private string PathXML { get; set; }

        public Model(string path)
        {
            Diagram = InputXmlDiagram(path);

        }

        public static Diagram InputXmlDiagram(string path)
        {
            TestTaskLibrary.Diagram diagram;
            XmlSerializer formatter = new XmlSerializer(typeof(Diagram));
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                diagram = (Diagram) formatter.Deserialize(fs);
            }

            return diagram;
        }

        public static void OutputXML(string path, Diagram diagram)
        {
            using (FileStream fs = new FileStream("output.xml", FileMode.OpenOrCreate))
            {
                XmlSerializer formatter = new XmlSerializer(typeof(Diagram));
                formatter.Serialize(fs, diagram);
            }
        }
    }
}
