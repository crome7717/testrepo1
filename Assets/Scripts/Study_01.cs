using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/* using UnityEditor ��� �ڵ��� �� �� �ִ� ��
�̴� ���� ���� �� �� �ִ�. �� ������ ������ �Ű�ü�� �ڵ����̱� ������
����Ƽ �����Ͱ� �۵� ���� �ʴ´�. ���� �ش� �ڵ带 �߰� ���� ��� ���� �ؾ� �Ѵ٤�������
*/


public class Study_01 : MonoBehaviour

{
    // Start is called before the first frame update
    void Awake()//�갡 ��ŸƮ���� ���� 1ȸ ����
    {
        Debug.LogError("Awake");

    }
    /*void Update()
        {
            Debug.Log("Update");
        }
    }*/
    /*void FixedUpdate()
    {
        Debug.LogWarning("FixedUpdate");
    }

    private void LateUpdate()
    {
        Debug.LogError("LateUpdate");

    }*/



    void Start()
    {
        Debug.Log("Start");
        /*
        Debug.Log("�ȳ�? ��ũ���尡 �׸���?");
        // �ּ� ��ȣ
        
        *
        *�ּ� 
        *���� �� 
        *��� �� ��
        
        
        int level = 5;
        float strength = 1.0f;
        string playerName = "��������";
        bool isFullLevel = false;

        Debug.Log(level);
        
       
        Debug.Log("���");
        Debug.LogWarning("���");
        Debug.LogError("���");
        */
       
        //������ ���� ���� ���� ��� �⺻ ���� 0

        // lua = nil
        // C# = null
        /*
        Debug.Log(test);
        test ++;
        Debug.Log(test);
        test = test += 1;
        Debug.Log(test);
        test = test + 1;
        Debug.Log(test);
        */
    }

    void OnDestroy()//������ ���簡 ����� �� ����
    {
        Debug.Log("����! ������ �ڹμ�...");
    }
    /*
    void OnApplicationPause(bool pause)
    {
        
    }

    private void OnApplicationQuit()
    {
        
    }

    private void OnApplicationFocus(bool focus)
    {
        
    }
    */
    void OnEnable()//Ȱ��ȭ �� �� �ѹ� ���� �Ǵ� �Լ�
                   //������Ʈ�� Ȱ��ȭ �� ��
    {
        Debug.Log("������.");
    }

    private void OnDisable()//��Ȱ��ȭ �� �� �ѹ� ���� �Ǵ� �Լ�

    {
        Debug.Log("������.");
    }
}
// Update is called once per frame

//int[] ssh = new int[3];
//�߰� ������ ������� �˻��� �����ϴ�

//List<int> yyw = new List<int>(3);
//�߰� ������ ���� ������ �˻��� �ټ� ��ƴ�

//�迭�� remove�� ���� 3��° ĭ�� �����͸� ���� �� �� �ִ�
//List�� �ƿ� ����° ��Ҹ� ���� �Ѵ�

