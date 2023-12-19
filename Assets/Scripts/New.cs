using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class New : MonoBehaviour
{

    public void weapon()
    {
        
    }
    public void OnDamage(int DPS)
    {

    }
    public string DamageResult (long money)
    {
        string Result = null;
        int cash;
        if (money > 1000000000)
        {
            cash = (int)(money / 100000000);
            Result = cash.ToString();
            Result = cash + "B";
        }

        else if (money > 100000)
        {
            cash = (int)((money / 100000));
            Result = cash.ToString();
            Result = cash + "M";
        }
        return Result;
    }


}
