using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SpiderEnemy : GazePointer
{
    public static float dronHealth;
    public Image dronHealthImg;
    public GameObject particleEffect;
    public Animator spiderModels;
    BulletManager bulletSpawner;
    // Start is called before the first frame update
    void Start()
    {
        bulletSpawner = GameObject.FindObjectOfType<BulletManager>();
        dronHealth = 1;
    }

    // Update is called once per frame
    void Update()
    {
        // SpiderModels.SetTrigger("Fire");
         if(dronHealth <= 0)
           Death();
        dronHealthImg.fillAmount = dronHealth;
    }
    public override void OnPointerDown(PointerEventData eventData)
    {
        base.OnPointerDown(eventData);

        bulletSpawner.ShootBullet();
       // Death();
    }
     public void Death()
    {
        particleEffect.SetActive(true);
        particleEffect.transform.SetParent(null);
        Destroy(gameObject);
        PlayerManger1.currentScore += 20;
    }
      
}