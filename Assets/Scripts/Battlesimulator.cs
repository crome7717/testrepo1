using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Globalization;
using Unity.VisualScripting;
using TMPro;
using static Battlesimulator;
using System.Threading;
using JetBrains.Annotations;



// �ð��� ���� �ϴ� ��� (�÷��� Ÿ��)
// �ð��� ����� �ϰ� �־�� ��

public class Monster : MonoBehaviour
{
    public int monID;
    public string monName;
    public float monHp;
    public float monAtk;
    public float monDef;
    public float monCurHp;

    public Monster()
    {
        monID = 0;
        monName = "ghost";
        monHp = 50f;
        monAtk = 5f;
        monDef = 2f;
        monCurHp = 50f;

    }
    public Monster(int ID, string name, float Hp, float Atk, float Def)
    {
        monID = ID;
        monName = name;
        monHp = Hp;
        monAtk = Atk;
        monDef = Def;
        monCurHp = Hp;
    }
}

//User Ŭ���� ����
public class User : MonoBehaviour
{
    // Ŭ���� �Ӽ�
    public int userID;
    public string userName;
    public float userHp;
    public float userAtk;
    public float userDef;
    public float userCriChance;
    public float userCriMul;
    public float userCurHp;


    public User()
    {
        //User Ŭ������ �⺻��
        userID = 0;
        userName = "Woorr";
        userHp = 300f;
        userAtk = 20f;
        userDef = 5f;
        userCriChance = 10f;
        userCriMul = 2f;
        userCurHp = 300f;

    }
    public User(int id, string username, float userHP, float Atk, float userDEF, float userCriticalChance, float userCriticalMul)
    {

        userID = id;
        userName = username;
        userHp = userHP;
        userAtk = Atk;
        userDef = userDEF;
        userCriChance = userCriticalChance;
        userCriMul = userCriticalMul;
        userCurHp = userHP;

    }



}
public class Battlesimulator : MonoBehaviour
{

    [SerializeField]
    public Button atk_btn;

    // Start is called before the first frame update
    public void atk_button(Monster monster, User user)
    {
        monster.monCurHp -= user.userAtk;
    }   
    
    

    int Turn = 1;
    public void Awake()
    {
    }




   
    void Start()
    {

        //Debug.Log(user01.userName);

        

    }
    /*
    float timeStemp;
    void Update()
    {
        timeStemp += Time.deltaTime;
        Debug.Log(timeStemp);
    }
    */

}
