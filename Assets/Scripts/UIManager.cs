using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEditor.Experimental.GraphView;

public class    r : MonoBehaviour
{
    //�迭
    //���� ������ Ÿ���� ������ ���� ���� ��������
    //�ٵ� �迭�� ũ�Ⱑ ������ ����

    // �迭 ���� ���
    // dataType[] �迭 �̸� = new dataType[size];
    // dataType[] �迭 �̸� = {���1, ���2, ���3, ....};




    [SerializeField]
    int descNum;

    public TextMeshProUGUI descText;
    public Button StartButton;
    public GameObject TextBG;
    [SerializeField]
    string[] descTextList =
    {"�� �ʹ� �����",
    "���� �Ⱑ ������ ���峻 ?",
    "����������",
    "�Ѹ� �ǰ��ؿ����",
    "�׷��� ������ �ؾ���"
    };

    GameObject[] testGame = new GameObject[10];
    Image[] testImage = new Image[10];



    [SerializeField]
    int[] testarray = new int[5];
        //���� ���� 5ĭ�� �迭��.
        // �׷��� ���� �� �ȳ־��ָ� ��
        // �׷���
        // ����Ʈ �� �Ⱦ��Ÿ� 0 or -1 �� �־��� ����
        // ������ ������ ����ϱ�.
        // �ڵ� �� �Ǵ��� �� �� ������ �Ǵ��ϴϱ�

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



    List<string> monlist = new List<string> { "ghost", "small_ghost", "big_ghost" };
    private void Start()
    {
        //Debug.Log(monlist[0]);
        
    }

    string descId;

    public void ChangeDesc()
    {
        if (descNum == 0)
        {
            TextBG.SetActive(true);
            StartButton.gameObject.SetActive(false);
            descText.text = "�� �ʹ� �����";
        }
        else if (descNum == 1)
        {
            descText.text = "���� �Ⱑ ������ ���峻 ?";
        }
        else if (descNum == 2)
        {
            descText.text = "����������";
        }
        else if (descNum == 3)
        {
            descText.text = "�Ѹ� �ǰ��ؿ����";
        }
        else if (descNum == 4)
        {
            descText.text = "�׷��� ������ �ؾ���";


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
            //descTextList ��� �迭�� descNum��°�� �ش� �ϴ� ���� descText.text�� �ְڴ�
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
                titleText.text = "���� �߾�";
                isChanged = true;
            }
            //else
            {
                BG.sprite = DefaultBG;
                titleText.text = "�������� ����";
                isChanged = false;
        
            }

        }

    }*/
    }
}



//UI(�̹���) ä��� ��
/*Image testImage;
void Testvoid()
{
    testImage.fillAmount = 0; // 0(00%)
    //��ä���.
    testImage.fillAmount = 1; // 1(00%)
    //���� ä���.

    //������ ���� �ٲ㼭 ����ϱ�
    //int, int => int ��� ���� ����.
    //float�� ��������
    // int value = 100 / 30 (�̷��� 3�� ����)
    // float �̿��� ���ϴ� �� (3.33)�� �ȳ��� ��
    // �� �� �ϴ°� (������)��(��) ��ȯ
    // int hun = 100;
    // int thi = 30; �̶�� �� ��
    // hun / thi �� ���� float���� ��� �ʹٸ� ?
    // ������ �� �� ����
    // float testValue = (float)hun / (float)thi
    // �̷��� int ���� ���� (float)�� �ٿ��ָ� ��
    // float�� int�� �ٲٰ� ������ (int)�� �տ� ���̸� ��

} 

*/



