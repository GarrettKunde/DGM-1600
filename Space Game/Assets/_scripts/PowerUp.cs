using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour {

    public enum Type { health , speed};
    public Type powerUptype;
    public Sprite [] images;

    public int set;

	// Use this for initialization
	void Start () {

        set = Random.Range(1, 3);
        switch (set)
        {
            case 1:
                powerUptype = Type.health;
                break;

            case 2:
                powerUptype = Type.speed;
                break;
        }
        switch (powerUptype)
        {
            
            case Type.health:
                gameObject.GetComponent<SpriteRenderer>().sprite = images[1];
                break;
            
            case Type.speed:
                gameObject.GetComponent<SpriteRenderer>().sprite = images [0];
                break;
        }

	}

    // Update is called once per frame
    void Update() {
    }


        void OnTriggerEnter2D (Collider2D other)
    {

        switch (powerUptype)
        {
            
            case Type.health:
                other.GetComponent<Health>().invrementalHealth(+1);
                Destroy(this.gameObject);
                break;
                
            case Type.speed:
                other.GetComponent<PlayerContoler>().thrust *= 2;
                other.GetComponent<PlayerContoler>().tooFast = true;
                Destroy(this.gameObject);
                break;
            
        }


        

    }
}
