using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml.Serialization;

//[XmlRoot("Sound")]
    public class XMLSettings 
{   
  //  [XmlAnyElement("audioSettings")]  //, XmlArrayItem("Sound")
    public bool audioSettings;
    public List<string> toogleName;
}
