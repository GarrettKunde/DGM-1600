using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockScript : MonoBehaviour {

    public float StartingSpin;
    public Rigidbody2D rb2;
    public float move;
    public GameObject Splosion;


    void Start () {
        GetComponent<Rigidbody2D>().AddTorque(Random.Range(-StartingSpin,StartingSpin),ForceMode2D.Impulse);
        rb2 = GetComponent<Rigidbody2D>();
        rb2.AddForce(Random.onUnitSphere * move);
        
    }


   

    private void OnCollisionEnter2D(Collision2D collision)
    {
       

        if (collision.gameObject.name == "Laser(Clone)")
        {
            collision.gameObject.GetComponent<HighScore>().number += 10;
            Instantiate(Splosion, transform.position, Quaternion.identity);           
            Destroy(this.gameObject);
        } 

      else if (collision.gameObject.name == "Player")
        {
             collision.gameObject.GetComponent<Health>().invrementalHealth(-1);
        }
           
        
    }

   
}
