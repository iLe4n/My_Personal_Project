using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScamAnim : MonoBehaviour
{
    private Scam scam;
    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        scam = GetComponent<Scam>();
        anim = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        OnMove();
        OnRun();
    }

    #region Movement 

    void OnMove()
    {
        if (scam.direction.sqrMagnitude > 0)
        {
            if (scam.isRolling)
            {
                anim.SetTrigger("isRoll");
            }
            else
            {
                anim.SetInteger("transition", 1);
            }
        }
        else
        {
            anim.SetInteger("transition", 0);
        }

        if (scam.direction.x > 0)
        {
            transform.eulerAngles = new Vector2(0, 0);
        }

        if (scam.direction.x < 0)
        {
            transform.eulerAngles = new Vector2(0, 180);
        }

    }

    void OnRun()
    {
        if (scam.isRunning)
        {
            anim.SetInteger("transition", 2);
        }
    }

    #endregion
}
