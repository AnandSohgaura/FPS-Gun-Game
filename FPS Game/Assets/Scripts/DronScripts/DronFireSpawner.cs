using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DronFireSpawner : MonoBehaviour
{
    public  float speed = 1;

    public GameObject dronBullet;

    void Update()
    {
    }

    public void ShootDronBullet()
    {
        var dronBulletInstance = Instantiate(dronBullet);
        dronBulletInstance.transform.position = transform.position;
        dronBulletInstance.GetComponent<Rigidbody>().velocity = transform.forward * speed;
    }
}
