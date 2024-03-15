using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RuntoGo : MonoBehaviour
{
    public int speed = 15;
    private void FixedUpdate()
    {
        Moving();
    }
    void Moving()
    {
        transform.rotation = new Quaternion(0, 0, 0, 0);
        transform.position += new Vector3(0, 0, speed * Time.deltaTime);
        gameObject.GetComponent<Animator>().SetBool("_isSprint", true);
    }
}
