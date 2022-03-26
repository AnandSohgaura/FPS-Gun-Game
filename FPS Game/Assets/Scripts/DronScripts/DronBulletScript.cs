using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DronBulletScript : MonoBehaviour
{
    public GameObject bulletModel;
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<PlayerManger1>())
        {
            PlayerManger1.playerHealth -= 0.02f;
            Destroy(gameObject);
        }
        
    }
}
