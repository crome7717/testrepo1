using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEditor.Experimental.GraphView;


public class UIManager : MonoBehaviour
{
    //배열
    //같은 데이터 타입을 가지는 여러 값을 저장해줌
    //근데 배열은 크기가 정해져 있음

    // 배열 선언 방법
    // dataType[] 배열 이름 = new dataType[size];
    // dataType[] 배열 이름 = {요소1, 요소2, 요소3, ....};




    [SerializeField]
    int descNum;

    public TextMeshProUGUI descText;
    public Button StartButton;
    public GameObject TextBG;
    [SerializeField]
    string[] descTextList =
    {"후 너무 힘들댜",
    "아주 기가 막히게 힘드내 ?",
    "느어어어어어어어",
    "넘모 피곤해요오오",
    "그래도 열심히 해야지"
    };

    GameObject[] testGame = new GameObject[10];
    Image[] testImage = new Image[10];



    [SerializeField]
    int[] testarray = new int[5];
        //위에 놈은 5칸의 배열임.
        // 그래서 따로 값 안넣어주면 임
        // 그래서
        // 퀘스트 때 안쓸거면 0 or -1 로 넣어준 거임
        // 없으면 문제가 생기니까.
        // 코드 상 판단을 할 때 값으로 판단하니까

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

    public void ChangeDesc()
    {
        if (descNum == 0)
        {
            TextBG.SetActive(true);
            StartButton.gameObject.SetActive(false);
            descText.text = "후 너무 힘들댜";
        }
        else if (descNum == 1)
        {
            descText.text = "아주 기가 막히게 힘드내 ?";
        }
        else if (descNum == 2)
        {
            descText.text = "느어어어어어어어";
        }
        else if (descNum == 3)
        {
            descText.text = "넘모 피곤해요오오";
        }
        else if (descNum == 4)
        {
            descText.text = "그래도 열심히 해야지";


        }
        else
        {
            StartButton.gameObject.SetActive(true);
            TextBG.SetActive(false);

        }
        if (descNum == 5)
        {
            descNum = 0;
        }
        else
        {
           // descText.text = descTextList[descNum];
            //descTextList 라는 배열의 descNum번째에 해당 하는 값을 descText.text에 넣겠다
            descNum++;
        }




        //private void Start()
        {
            //   Debug.Log(testValue);
            //  DefaultBG = BG.sprite;

        }
        /*public void ChangeColor()
        {
            // if(!isChanged)
            {
                BG.sprite = ChangeBG;
                titleText.text = "마을 중앙";
                isChanged = true;
            }
            //else
            {
                BG.sprite = DefaultBG;
                titleText.text = "슬레인의 도장";
                isChanged = false;
        
            }

        }

    }*/
    }
}
