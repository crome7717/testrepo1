using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;
using System.Diagnostics.CodeAnalysis;
using System.Collections.Generic;

public class CombatManager : MonoBehaviour
{
    public Monster monster;
    public Monster monster01;
    public Monster monster02;
    public Monster monster03;
    public User user;
    public TextMeshProUGUI resultText;
    public TextMeshProUGUI userHp;
    public TextMeshProUGUI monHp;
    public TextMeshProUGUI Turn;
    public List<Monster> monlist;
    public Monster[] monsterList;
    public Slider userHpBar;
    public Slider monHpBar;
    int monsterCount = 0;

    int turn = 1;

    private void Start()
    {
        // ���Ϳ� ���� ��ü ����
        monster01 = new Monster(0, "ghost", 50, 5, 2);
        monster02 = new Monster(1, "small_ghost", 30, 4, 2);
        monster03 = new Monster(2, "Big_ghost", 70, 8, 2);

        //List<Monster> monlist = new List<Monster> { monster01, monster02, monster03 };
        monsterList = new Monster[3] { monster01, monster02, monster03 };
        monster = monsterList[0];

        user = new User(1, "Woorr", 300f, 20f, 5f, 10f, 2f);

        // ����� ǥ���� �ؽ�Ʈ UI ���
        resultText = GameObject.Find("ResultText").GetComponent<TextMeshProUGUI>();
        // �ش� ���� = GameObject���� ã�ƶ�. () �̸��� ��Ҹ� �� ������Ʈ �ض� <>�ȿ� �Ӽ��� ����
        userHp = GameObject.Find("userHp").GetComponent<TextMeshProUGUI>();
        userHp.text = user.userCurHp.ToString();
        monHp = GameObject.Find("monHp").GetComponent<TextMeshProUGUI>();
        monHp.text = monster.monCurHp.ToString();
        Turn = GameObject.Find("turn_count").GetComponent<TextMeshProUGUI>();
        Turn.text = turn.ToString();
        monHpBar.value = 1;
        userHpBar.value = 1;
    }
    
    public void AttackButtonClicked()
    {
        // ������ ���ݷ¸�ŭ ������ ü���� ���ҽ�Ŵ
        monster.monCurHp -= user.userAtk;
        // ������ ���ݷ� ��ŭ ������ ü���� ���ҽ�Ŵ
        user.userCurHp -= monster.monAtk;
        // ���� ��� Ȯ��
        CheckBattleResult();
    }

    void CheckBattleResult()
    {
        turn++;
        Turn.text = "Turn" + turn.ToString();
        userHp.text = user.userCurHp.ToString();
        monHp.text = monster.monCurHp.ToString();
        monHpBar.value = monster.monCurHp / monster.monHp;
        userHpBar.value = user.userCurHp / user.userHp;


        if (user.userCurHp < 0)
        {
            resultText.text = "����� �й� �߽��ϴ�.";
            // ���� ü���� 0�� �Ǿ��� ��
            return;

        }
        if (monster.monCurHp <= 0){
            resultText.text = "���͸� �����ƽ��ϴ�!";

            if (monsterCount == 2)
                monsterCount = 0;
            else
                monsterCount++;
            monster = monsterList[monsterCount];
            monHp.text = monster.monCurHp.ToString();
            monHpBar.value = 1;

            return;
            // ���͸� �������� �� �߰� �۾� ����
        }
        else
        {
            // ���Ͱ� ����ִ� ���, ������ �ݰ� �� �߰� �۾� ����

            resultText.text = "������ ü��: " + monster.monCurHp.ToString() + "\n ����� ü���� " + user.userCurHp.ToString();
        }
    }
}