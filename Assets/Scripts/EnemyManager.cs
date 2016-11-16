using UnityEngine;
using System.Collections;

public class EnemyManager : MonoBehaviour {

    public int Health = 100;


	// Use this for initialization
	void Start () {
	
	}

    public void TakeDamage (int damage)
    {
        Health -= damage;
        if (Health <= 0)
            Destroy(gameObject);
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
