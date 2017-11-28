using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour {

    public enum Type {lasor, shield, pillBomb, Speed};
    public Type powerUptype;
    public Sprite [] images;

	// Use this for initialization
	void Start () {
		switch (powerUptype)
        {
            case Type.lasor:
                gameObject.GetComponent<SpriteRenderer>().sprite = images[1];
                break;
            case Type.shield:
                gameObject.GetComponent<SpriteRenderer>().sprite = images[2];
                break;
            case Type.pillBomb:
                gameObject.GetComponent<SpriteRenderer>().sprite = images[3];
                break;
            case Type.Speed:
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
            case Type.lasor:
                break;
            case Type.shield:
                break;
            case Type.pillBomb:
                break;
            case Type.Speed:
                other.GetComponent<PlayerContoler>().thrust *= 2;
                Destroy(this.gameObject);
                break;
            
        }


        

    }
}
