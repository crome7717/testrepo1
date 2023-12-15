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
        // 몬스터와 유저 객체 생성
        monster01 = new Monster(0, "ghost", 50, 5, 2);
        monster02 = new Monster(1, "small_ghost", 30, 4, 2);
        monster03 = new Monster(2, "Big_ghost", 70, 8, 2);

        //List<Monster> monlist = new List<Monster> { monster01, monster02, monster03 };
        monsterList = new Monster[3] { monster01, monster02, monster03 };
        monster = monsterList[0];

        user = new User(1, "Woorr", 300f, 20f, 5f, 10f, 2f);

        // 결과를 표시할 텍스트 UI 요소
        resultText = GameObject.Find("ResultText").GetComponent<TextMeshProUGUI>();
        // 해당 변수 = GameObject에서 찾아라. () 이름의 요소를 겟 컴포넌트 해라 <>안에 속성을 가진
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
        // 유저의 공격력만큼 몬스터의 체력을 감소시킴
        monster.monCurHp -= user.userAtk;
        // 몬스터의 공격력 만큼 유저의 체력을 감소시킴
        user.userCurHp -= monster.monAtk;
        // 전투 결과 확인
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
            resultText.text = "당신은 패배 했습니다.";
            // 유저 체력이 0이 되었을 때
            return;

        }
        if (monster.monCurHp <= 0){
            resultText.text = "몬스터를 물리쳤습니다!";

            if (monsterCount == 2)
                monsterCount = 0;
            else
                monsterCount++;
            monster = monsterList[monsterCount];
            monHp.text = monster.monCurHp.ToString();
            monHpBar.value = 1;

            return;
            // 몬스터를 물리쳤을 때 추가 작업 가능
        }
        else
        {
            // 몬스터가 살아있는 경우, 몬스터의 반격 등 추가 작업 가능

            resultText.text = "몬스터의 체력: " + monster.monCurHp.ToString() + "\n 당신의 체력은 " + user.userCurHp.ToString();
        }
    }
}