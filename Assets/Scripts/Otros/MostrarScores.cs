using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MostrarScores : MonoBehaviour
{
    public Text txt;
    public UtilsXML db;
    private Dictionary<int, PlayerDB> map;
    private List<PlayerDB> listP;

    void Start()
    {
        ArrayList players = db.LoadByXML();
        
        if (players.Count == 0)
        {
            txt.text = "No hay puntajes para mostrar";
            return;
        }

        foreach (PlayerDB obj in players)
        {
            Debug.Log(obj);
            listP.Add(obj);
        }

        listP.Sort(
            (x, y) => x.playerScore.CompareTo(y.playerScore));

        int i = 0;
        foreach (PlayerDB obj in listP)
        {
            i++;
            map.Add(i, obj);
        }
        string res = "";
        foreach (KeyValuePair<int, PlayerDB> obj in map)
        {
            
            res = $"{obj.Key}. {obj.Value.PlayerName} --- {obj.Value.playerTime} - {obj.Value.playerTime} \n";
            Debug.Log(res);
        }

        txt.text = res;
    }



}
