using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockScript : MonoBehaviour {

    public float StartingSpin;
    public Rigidbody2D rb2;
    public float move;
    public GameObject splosion;
    public GameObject powerUp;
    public int spawnChance;
    
    public HighScore scoreScript;

    void Start () {
        GetComponent<Rigidbody2D>().AddTorque(Random.Range(-StartingSpin,StartingSpin),ForceMode2D.Impulse);
        rb2 = GetComponent<Rigidbody2D>();
        rb2.AddForce(Random.onUnitSphere * move);
        scoreScript = FindObjectOfType<HighScore>();

    }


   

    private void OnCollisionEnter2D(Collision2D collision)
    {
       

        if (collision.gameObject.name == "Laser(Clone)")
        {
           
           
            Instantiate(splosion, transform.position, Quaternion.identity);   
            IncrementScore();
            PowerUpSpawn();
            Destroy(this.gameObject);
            
        } 
        
      else if (collision.gameObject.name == "Player")
        {
             collision.gameObject.GetComponent<Health>().invrementalHealth(-1);
            Instantiate(splosion, transform.position, Quaternion.identity);
            Destroy(this.gameObject);
        }
           
        
    }
    private void IncrementScore()
    {
       scoreScript.ScoreBoard(10);
    }

   private void PowerUpSpawn()
    {
        spawnChance = Random.Range(1, 30);
      

        if (spawnChance == 1)
        {
            Instantiate(powerUp, transform.position, Quaternion.identity);
        }

    }

   
}
