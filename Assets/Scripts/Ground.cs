using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
    public static bool _isJumpActive;



    private void Update()
    {
        Jump();

    }



    void Jump()
    {
        if (_isJumpActive == true)
        {
            GetComponent<Animator>().SetBool("_isJump", true);
        }
        else
        {
            GetComponent<Animator>().SetBool("_isJump", false);
        }
    }

}
