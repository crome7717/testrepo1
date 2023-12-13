using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{

    //��ƴ� ���� ���� ���ϸ� �۷� (�ƹ������� ����)�̾��� ���� ?
    // ���� ����(local) ���� ������ ����
    [HideInInspector]
    public int testValue = 1;

    public Image BG;

        [SerializeField]
    Color basicColor;


    bool isChanged;
    
    Sprite DefaultBG;//�⺻ ��� ȭ�� �̹���

    [SerializeField]
    Sprite ChangeBG; //���� �� ��� ȭ�� �̹���

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
