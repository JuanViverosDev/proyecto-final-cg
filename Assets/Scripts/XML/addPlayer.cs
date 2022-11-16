using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class addPlayer : MonoBehaviour
{
    public InputField txt;
    public UtilsXML db;
    public Text alert;

    public void AddP(string Nombreescena)
    {
        string name = txt.text;
        string test = name;

        while(test.Contains(" "))
        {
            test = test.Replace(" ", "");
        }

        if (test.Equals("")){
            alert.text = "No dejes el campo vacio";
            return;
        }


        if (db.existNameinXML(name))
        {
            alert.text = "Ya existe un usuario con este nombre, intenta con otro";
        }
        else
        {
            alert.text = "";
            db.CreateNewPlayer(name, 1, "");
            db.SaveByXML();
            SceneManager.LoadScene(Nombreescena);
        }
    }
}
