using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollision : MonoBehaviour {
    private Vector3 spawn;
    public GameObject deathParticles;
	// Use this for initialization
	void Start () {
        spawn = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		if(transform.position.y < 0.5)
        {
            transform.position = spawn;
            Instantiate(deathParticles, spawn, Quaternion.identity);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Enemy")
        {
            transform.position = spawn;
            Instantiate(deathParticles, spawn, Quaternion.identity);
            GameManager.deaths++;
        }
    }
}
