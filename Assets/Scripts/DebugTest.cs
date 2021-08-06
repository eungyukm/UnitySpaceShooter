using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int a = 1;
        int b = 2;
        int c = 0;

        c = a + b;
        Debug.Log("결과 값 : " + c);

        string name = "김은규";
        Debug.Log("이름 출력 : " + name);

        int x = 3;
        int y = 7;
        if(x > y)
        {
            Debug.Log("x는 y보다 큽니다.");
        }
        else
        {
            Debug.Log("y는 x보다 큽니다.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
