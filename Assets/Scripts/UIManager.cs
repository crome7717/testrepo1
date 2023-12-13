using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{

    //루아는 따로 정의 안하면 글로 (아무데서나 접근)이었음 ㅇㅇ ?
    // 지역 변수(local) 따로 해줬을 거임
    [HideInInspector]
    public int testValue = 1;

    public Image BG;

        [SerializeField]
    Color basicColor;


    bool isChanged;
    
    Sprite DefaultBG;//기본 배경 화면 이미지

    [SerializeField]
    Sprite ChangeBG; //변깅 된 배경 화면 이미지

    [SerializeField]
    TextMeshProUGUI titleText;

    string descId;

    private void Start()
    {
        //   Debug.Log(testValue);
        DefaultBG = BG.sprite;

    }
    public void ChangeColor()
    {
        if(!isChanged)
        {
            BG.sprite = ChangeBG;
            titleText.text = "Sunset";
            isChanged = true;
        }
        else
        {
            BG.sprite = DefaultBG;
            titleText.text = "Retro";
            isChanged = false;
        }
        
    }
    
}
