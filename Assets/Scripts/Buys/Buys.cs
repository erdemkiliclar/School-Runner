using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buys : MonoBehaviour
{
    public static bool _buy1 = false;
    public static bool _buy2 = false;
    public static bool _buy3 = false;
    public static bool _buy4 = false;
    public static bool _buy5 = false;
    public static bool _bonus = false;


    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("Buy1"))
        {
            _buy1 = true;

        }
        else
        {
            _buy1 = false;
        }
        if (collision.gameObject.CompareTag("Buy2"))
        {
            _buy2 = true;

        }
        else
        {
            _buy2 = false;
        }
        if (collision.gameObject.CompareTag("Buy3"))
        {
            _buy3 = true;

        }
        else
        {
            _buy3 = false;
        }
        if (collision.gameObject.CompareTag("Buy4"))
        {
            _buy4 = true;

        }
        else
        {
            _buy4 = false;
        }
        if (collision.gameObject.CompareTag("Buy5"))
        {
            _buy5 = true;

        }
        else
        {
            _buy5 = false;
        }
        if (collision.gameObject.CompareTag("Bonus"))
        {
            _bonus = true;

        }
        else
        {
            _bonus = false;
        }

    }


}
