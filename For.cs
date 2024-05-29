using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class For : MonoBehaviour
{

    public int[] arrayInt = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    // Start is called before the first frame update
    void Start()
    {
        // for (int i = 0; i < 10; i++)
        // {
        //     Debug.Log(i);
        // }

        foreach (int value in arrayInt)
        {
            Debug.Log(value);
        }


    }

    // Update is called once per frame
    void Update()
    {

    }
}
