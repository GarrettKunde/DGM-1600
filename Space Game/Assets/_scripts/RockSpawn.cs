using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockSpawn : MonoBehaviour {

    public Vector3 center;
    public Vector3 size;
    public GameObject rockPrefab;

    public static int rockCount;

	// Use this for initialization
	void Start () {
        
        rockCount = FindObjectsOfType<RockScript>().Length;
       
    }
	
	// Update is called once per frame
	void Update () {

        rockCount = FindObjectsOfType<RockScript>().Length;

        if (rockCount <= 40)
        {
         SpawnRock();
        }
         
    }

    public void SpawnRock()
    {
        Vector3 pos = center + new Vector3(Random.Range(-size.x / 2, size.x / 2), Random.Range(-size.y / 2, size.y / 2),(size.z));

        Instantiate(rockPrefab, pos, Quaternion.identity);
    }



    private void OnDrawGizmosSelected()
    {
        Gizmos.color = new Color(1, 00, 00, 0.5f);
        Gizmos.DrawCube(center, size);
    }
}
