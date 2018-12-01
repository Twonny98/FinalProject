using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnPiPlayerBullet : MonoBehaviour {

    public float speed;

    public float lifetime;
    public int damage;

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        lifetime -= Time.deltaTime;

        if (lifetime <= 0)
            Destroy(gameObject);
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            other.gameObject.GetComponent<AnPiEnemyHealth>().HurtEnemy(damage);
            Destroy(gameObject);
        }

        if (other.gameObject.tag == "wall")
        {
            Destroy(gameObject);
        }

        
    }
}
