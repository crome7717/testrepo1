using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Study_02 : MonoBehaviour
{

    // List ����
    // List <������ Ÿ��> ����Ʈ �̸� = new List <������ Ÿ��>();
    // ũ�⸦ �����ϰ� ����� ���� ����
    // List<DataType> name = new List <DataType>(new DataType[size])
    // �� ��� size ¥�� ����Ʈ�� ����.

    // List�� ������ ���ÿ� �ʱ�ȭ �ؼ� ���� ����
    // List<string> ssh = new List<string>(){"�ż�ȣ,"�ٺ�"};
    // �� �̷��� ssh ����Ʈ �ȿ� 0��°�� "�ż�ȣ", 1��°�� "�ٺ�"
    // ssh[0] = "�ż�ȣ", ssh[1] = "�ٺ�"
    // ����Ʈ�� �ٸ� ����Ʈ�� �޾Ƽ� ���� �� �� ����
    // List<string> yyw = new List<string>(ssh);
    // �� yyw = ssh
    // ����Ʈ�� ������ �߰� �ϴ� ���
    // Add �Լ��� �̿�
    // ��� ����Ʈ�� �� �ڿ� �߰� �ϴ� �����

    [SerializeField]
    List<string> ssh = new List<string>() { "God��ȣ", "Good" };
    //List<string> ssh = List<string>();
    private void Awake()
    {

        Debug.Log(ssh[0]);
    }

    private void Start()
    {
        ssh.Add(" �� �� ȣ �� ");
        Debug.Log(ssh[1]);
        // ���⼭�� ssh �ʱ�ȭ �� ������ ���� �ȳ־���
        // size �� 0�� (�ƹ� �͵� ����)
        // �׷��� "�� �� ȣ ��" �� ssh[0]�� ��
        ssh.Add(" �� �� ȣ �� ");
        Debug.Log(ssh[2]);
        // �߰��� " �� �� ȣ �� " �� ssh[1]�� ��ġ

        // insert �Լ� �̿� ���
        // �� �״�� ���� �ִ� �����
        // ���� �����ϱ� ������ �ִ� �ֵ��� �ڷ� �и�

        ssh.Insert(1, " �� �� �� �� ");
        Debug.Log(ssh[1]);
        // �̷��� ssh �� ?
        // [God��ȣ, �� �� �� �� , Good, �� �� ȣ �� , �� �� ȣ ��]

        // �迭, ����Ʈ�� ũ�⸦ ���ϴ� ���
        // �迭 �� ���
        // �迭 �̸�.Length;
        // ����Ʈ�� ���
        // ����Ʈ�̸�.Count;
        // �迭�� ����Ʈ�� ũ�⸦ ���ϴ� ����� �ٸ�
        // ����� �ٸ��� ����Ʈ�� �迭�� �̸��� ����ϰ� ������ ?
        // �迭�̸�.Count; �̷��� �Ϸ��� �ؼ� ������ ���� ����

        // ����Ʈ���� �����͸� ���� �ϴ� ���
        // - Remove �Լ�
        // ���ϴ� "��"�� ã�Ƽ� ����
        // ���� ���� �������� �� ó�� ���� ����µ�...
        // ���� ID�� ������ 3���� �� 2��°�� ������ �ϴ� ��Ȳ������ ?


        // -RemoveAt �Լ� ���
        // ��� �ε��� ������ ����.
        // �迭�� �����ϰ� 0���� ����

        // �̰� ���� RemoveAll, Clear �Լ��� ����.
        // �ٵ� �� ����
        // ����Ʈ�̸�.RemoveAll(x => x == "yyw");
        // x => x == "yyw" �� �κ��� ���ٽ��̶� �ϴ� ��....
        // ���� ��.
        // ������ x �� yyw �� �ָ� ��� ����ٴ� ����

        //
        ssh.Remove(" �� �� �� �� ");
        Debug.Log(ssh[1]);
        // Lua ������ �����
        // for i = 1, i <= 9 do
        //      for s = 1, s<=9 do
        //           print i * s
        //      end
        // end

        // C#�� �߰�ȣ{}�� ������
        // for ����
        for (int i = 0; i < 9; i++)
        {
            // i�� 0���� ����.
            // i < 9 : 9���� ���� ������
            // i++ :i�� 1�� ���� 
        }

        // int test = 4/8;
        // test
        int sum = 0;// �հ踦 ���� ������ ����
        int odd = 0; // Ȧ �� ������ ���� ������ ����

        for (int i =2; i < 10 ; i++)
        {
            for (int j = 1; j < 10 ; j++)
            {

                int result = i * j;
                Debug.Log( i + " X " + j + " = " + result);
                sum += result;
                if (result % 2 == 1)
                {
                    odd++;
                    Debug.Log(odd);
                }
            }
        }
    int randValue;
    randValue = Random.Range(0,3);
    //int �� �� �� �� ���� ����

    }
}

// ����ġ 
// �굵 ���ǿ� ���� ����� (if�� ���)
// �ٵ� ��� �ϳ��� ���� �����ؼ� ��ġ �ϴ� ��쿡��
// �ش� ��ɾ �����ϴ� ���
// ��, �� ���� �Ұ�
// ��Ȯ�� ��ġ�ϴ� ���� �־�� �� �� ����


/*switch (�񱳰�)
{
    case ��ġ��1:
          ������ ��ɾ�
        break;
    case ��ġ��2:
          ������ ��ɾ�
        break;
    case ��ġ��3:
          ������ ��ɾ�
        break;
    default;
        ��ġ ���� ���� �� ������ ����
        if�� ġ�� else�� �ش�
        break;

}*/

// ������ 
// Item ID 101,102,103
// 