
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class Box_GotCha : MonoBehaviour
{



    public void Gotcha()
    {
        
        /*
                int emerald = 0;
                int gold = 0;
                int ruby = 0;
                int rewardType;

                for (int i = 0; i < 100; i++)
                {
                    rewardType = Random.Range(0, 3);
                    switch (rewardType)
                    {
                        case 0:
                            gold += Random.Range(1, 101);
                            break;

                        case 1:
                            emerald += Random.Range(1, 101);
                            break;
                        case 2:
                            ruby += Random.Range(1, 101);
                            break;
                    }
                }
                        Debug.Log("���:"+gold+" ���޶���:"+emerald+" ���:"+ruby);
        */
        int grade1 = 0;
        int grade2 = 0;
        int grade3 = 0;
        int grade4 = 0;
        int grade5 = 0;

        int randompersent;
        int lastpan= 1;
        
        for (int i = 1; i < 31; i++) 
        {
            randompersent = Random.Range(1, 101);
            if (lastpan >= 30)
            {

            }
            else if (randompersent < 21)
            {
                grade1 += Random.Range(20, 31);
                lastpan++;
            }
            else if (randompersent > 21 && randompersent < 51)
            {
                grade2 += Random.Range(15, 26);
                lastpan++;
            }
            else if (randompersent > 51 && randompersent < 91)
            {
                grade3 += Random.Range(10, 21);
                lastpan++;
            }
            else if (randompersent > 91 && randompersent < 99)
            {
                grade4 += Random.Range(5, 11);
                lastpan++;
            }
            else if     (randompersent > 98 && randompersent < 101)
            {
                grade5 += Random.Range(1, 6);
                lastpan = 1;
            }

                
            
                
        }
        Debug.Log("1����� "+ grade1 + ", "+ "2����� "+grade2+", "+"3����� "+grade3+", "+"4����� "+grade4+", "+"5����� "+grade5 +" �Դϴ�." );
        if (grade5 == 0)
        {
            Debug.Log("30ȸ ���� 5����� ���� ���� 1���� Ȯ�������� �帳�ϴ�.");
            grade5 += 1;
        Debug.Log("1����� " + grade1 + ", " + "2����� " + grade2 + ", " + "3����� " + grade3 + ", " + "4����� " + grade4 + ", " + "5����� " + grade5 + " �Դϴ�.");
        }
        else
        {
            Debug.Log("�̱⸦ ���� �մϴ�.");
        }   
    }
}




