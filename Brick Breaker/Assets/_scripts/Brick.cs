using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour {

    public int Health;
    public Sprite cracked;
    public Sprite broke;
    private LevelManager levelManager;

    private void Start()
    {
     levelManager = FindObjectOfType<LevelManager>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Health -= 1;

        if (Health == 2)
        {
            GetComponent<SpriteRenderer>().sprite = cracked;
        }

        if (Health == 1)
        {
            GetComponent<SpriteRenderer>().sprite = broke;
        }

        else if (Health <= 0)
        {
            LevelManager.BrickCount --;
            Destroy(gameObject);
            levelManager.CheckBrickCount();
        }

    }


}
