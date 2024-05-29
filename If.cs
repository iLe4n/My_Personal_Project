using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class If : MonoBehaviour
{
    public bool isAlive;

    // Start is called before the first frame update
    void Start()
    {
        if (isAlive == true)
        {
            Debug.Log("You're alive!");
        }
        else
        {
            Debug.Log("No, you're dead!");
        }
        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Debug.Log("Eita, voou!");

            }

        }
    }
}
