using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnPiShooter : MonoBehaviour {

    public bool isFiring;

    public AnPiPlayerBullet bullet;
    public float speed;
    public float timeBetweenShot;
    private float shotCounter;

    public Transform firePoint;
	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		if (isFiring)
        {
            shotCounter -= Time.deltaTime;
            if(shotCounter <= 0)
            {
                shotCounter = timeBetweenShot;
                AnPiPlayerBullet newBullet = Instantiate(bullet, firePoint.position, firePoint.rotation) as AnPiPlayerBullet;
                newBullet.speed = speed;

            }
        }
        else
        {
            shotCounter = 0;
        }
	}
}
