using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnPiEnemyShooter : MonoBehaviour
{

    public bool isFiring;

    public AnPiEnemyBullet bullet;

    public float speed;
    public float timeBetweenShot;
    private float shotCounter;

    public Transform firePoint;


    // Update is called once per frame
    void Update()
    {
        if (isFiring)
        {
            shotCounter -= Time.deltaTime;
            if (shotCounter <= 0)
            {
                shotCounter = timeBetweenShot;
                AnPiEnemyBullet newBullet = Instantiate(bullet, firePoint.position, firePoint.rotation) as AnPiEnemyBullet;
                newBullet.speed = speed;

            }
        }
        else
        {
            shotCounter = 0;
        }
    }
}
