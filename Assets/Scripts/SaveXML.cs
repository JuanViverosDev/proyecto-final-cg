using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.Runtime.Serialization.Formatters.Binary;//If you want to use the BinaryFormatter class, must type this namespace first
using System.IO;//If you want to use the FIle class and FileStream class, you have to use this namespace
//IO: Input / Output

using System.Xml;

public class SaveXML : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.O))
        {
            SaveByXML();
        }
    }

    private void SaveByXML()
    {
        XmlDocument xmlDocument = new XmlDocument();

        #region Create XMLDocument Elements
        XmlElement root = xmlDocument.CreateElement("Save");
        root.SetAttribute("FileName", "File_01");

        XmlElement PoisonsNumElement = xmlDocument.CreateElement("PoisonsNum");
        //MARKER Gets or sets the concatenated 串联值 values of the node and all its child nodes.
        PoisonsNumElement.InnerText = "32";//Return string type
        root.AppendChild(PoisonsNumElement);

        
        XmlElement CoinsNumElement = xmlDocument.CreateElement("PoisonsNum");
        //MARKER Gets or sets the concatenated 串联值 values of the node and all its child nodes.
        CoinsNumElement.InnerText = "12";//Return string type
        root.AppendChild(CoinsNumElement);

        
        XmlElement LifesNumElement = xmlDocument.CreateElement("PoisonsNum");
        //MARKER Gets or sets the concatenated 串联值 values of the node and all its child nodes.
        LifesNumElement.InnerText = "3";//Return string type
        root.AppendChild(LifesNumElement);

        #endregion

        xmlDocument.AppendChild(root);
        xmlDocument.Save(Application.dataPath + "/Data.text");

        if (File.Exists(Application.dataPath + "/Data.text"))
        {
            Debug.Log("XML FILED SAVED");
        }
    }
}
