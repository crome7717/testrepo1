using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonData : MonoBehaviour
{
    public GameObject monsterprefab;
    public TextAsset montbl;
    List<Dictionary<string, object>> monInformation = new List<Dictionary<string, object>>();
    public List<MonClass> monlist;
    void Start()
    {
       
        monInformation = CSVReader.Read(montbl);
        
            GameObject monster01 = Instantiate(monsterprefab);
            MonClass monster = monster01.GetComponent<MonClass>();

        Debug.Log(montbl);
        for(var i = 0; i < monInformation.Count; i++)
        {
        monster.id = (int)monInformation[i]["id"];
        monster.name= (string)monInformation[i]["name"];
        monster.type= (string)monInformation[i]["type"];
        monster.cha = (string)monInformation[i]["cha"];
        monster.hp = (int)monInformation[i]["hp"];
        monster.atk = (int)monInformation[i]["atk"];
        monster.def = (int)monInformation[i]["def"];
        monlist.Add(monster);
            // Debug.Log("id " + (i).ToString() + " : " +monInformation[i]["name"]+ monInformation[i]["cha"]);
        }
    }
}
