using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class littlerock : MonoBehaviour
{
    public GameObject sRock;

    private void OnCollisionEnter2D(Collision2D collision)
    {


        if (collision.gameObject.name == "Laser(Clone)")
        {
            Instantiate(sRock, transform.position, Quaternion.identity);
            Instantiate(sRock, transform.position, Quaternion.identity);
            Instantiate(sRock, transform.position, Quaternion.identity);

        }
    }
}