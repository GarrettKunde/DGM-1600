using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {


    public int health;
    public GameObject splosion;

    public GameObject[] hearts;

    private void Start()
    {
        ShowHearts();
    }

    public void invrementalHealth(int damage)
    {
        health += damage;
        if (health <= 0)
        {
            Destroy(gameObject);
            Instantiate(splosion, transform.position, Quaternion.identity);

        }
        ShowHearts();
    }

    private void ShowHearts()
    {
        for (int i =0; i < hearts.Length; i++)
         {
            hearts[i].SetActive(false);
         }

        for(int i = 0; i < health; i++)
        {
            hearts[i].SetActive(true);
        }
    }

}
