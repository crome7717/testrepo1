using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CatController : MonoBehaviour
{
    Rigidbody2D rig;
    float jumpForce = 680f;
    float walkFoce = 30f;
    float maxWalkSpeed = 2.0f;
    public SpriteRenderer flipChanger;
    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        flipChanger = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)&& rig.velocity.y ==0)
        // Escape = ����Ʈ�� �� ��ư
        {
           rig.AddForce(transform.up * jumpForce);
        }

        //�¿� �̵�
        int key = 0;
        if (Input.GetKey(KeyCode.RightArrow))
        {
            key = 1;
            //flipChanger.flipX = false;

        }
        if (Input.GetKey(KeyCode.LeftArrow)) 
        { 
            key = -1;
            //flipChanger.flipX = true;
        }

        
        // �÷��̾� �ӵ�
        float speedx = Mathf.Abs(rig.velocity.x);
        // ���ǵ� ����
        if (speedx < maxWalkSpeed)
        {
            rig.AddForce(transform.right * key * walkFoce);
        }
        if(key != 0)
        {
            transform.localScale = new Vector3(key, 1, 1);
           /* if(key == -1)
            {
                flipChanger.flipX = true;
            }
            else if(key == 1)
            {
                flipChanger.flipX= false;
            }*/
        }

        // �÷��̾� �ӵ��� ���� �ִϸ��̼� �ӵ��� �ٲ۴�.
        animator.speed = speedx / 2.0f;

    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        //Destroy(this.gameObject);
        SceneManager.LoadScene("goyang_06_Clear");   
    }
}
