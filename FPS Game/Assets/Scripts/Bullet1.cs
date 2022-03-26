using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet1 : MonoBehaviour
{
    public GameObject bulletModel;
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<EnemyControler>())
        {
            EnemyControler.enemyHealth -= 0.4f;
            Destroy(gameObject);
        }
        if (other.GetComponent<DronEnemy>())
        {
            DronEnemy.dronHealth -= 0.3f;
            Destroy(gameObject);
        }
        if (other.GetComponent<DronEnemy1>())
        {
            DronEnemy1.dronHealth -= 0.3f;
            Destroy(gameObject);
        }
        if (other.GetComponent<DronEnemy2>())
        {
            DronEnemy2.dronHealth -= 0.3f;
            Destroy(gameObject);
        }
        if (other.GetComponent<DronEnemy3>())
        {
            DronEnemy3.dronHealth -= 0.3f;
            Destroy(gameObject);
        }
        if (other.GetComponent<DronEnemy4>())
        {
            DronEnemy4.dronHealth -= 0.3f;
            Destroy(gameObject);
        }
        if (other.GetComponent<SpiderEnemy>())
        {
            SpiderEnemy.dronHealth -= 0.3f;
            Destroy(gameObject);
        }
        if (other.GetComponent<SpiderEnemy1>())
        {
            SpiderEnemy1.dronHealth -= 0.3f;
            Destroy(gameObject);
        }
        if (other.GetComponent<SpiderEnemy3>())
        {
            SpiderEnemy3.dronHealth -= 0.1f;
            Destroy(gameObject);
        }
        if (other.GetComponent<EnemyController2>())
        {
            EnemyController2.enemyHealth -= 0.1f;
            Destroy(gameObject);
        }
    }
}
