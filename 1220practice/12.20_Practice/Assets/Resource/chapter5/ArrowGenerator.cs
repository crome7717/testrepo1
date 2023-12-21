using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowGenerator : MonoBehaviour
{
    public GameObject arrowPrefab;
    // ȭ�� ���� �ֱ�, ������ ȭ�� ���� ��Ÿ��
    float span = 1.0f;
    // ���� �ֱ⸦ üũ�ϴ� ���� 
    float delta = 0;


    // Update is called once per frame
    void Update()
    {
        delta += Time.deltaTime;
        if (delta > span)
        {
            delta = 0;
            GameObject go = Instantiate(arrowPrefab);
            int px = Random.Range(-6, 7);
            go.transform.position = new Vector3(px, 7, 0);

        }
    }
}
