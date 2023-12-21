using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameD : MonoBehaviour
{
    GameObject hpGauge;
    [Tooltip("게임 오버 팝업창 입니다")]
    public GameObject gameOver;

    // Start is called before the first frame update
    void Start()
    {
        hpGauge = GameObject.Find("hpGauge");
    }

    public void DecreaseHp()
    {
        hpGauge.GetComponent<Image>().fillAmount -= 0.1f;
        if(hpGauge.GetComponent<Image>().fillAmount == 0)
        {
            gameOver.SetActive(true);
            Time.timeScale = 0;
        }
    }
    [Tooltip("다시 시작 버튼 입니다")]
    public void Restart()
    {
        hpGauge.GetComponent<Image>().fillAmount = 1;
        gameOver.SetActive(false);
        Time.timeScale = 1;
    }

}
