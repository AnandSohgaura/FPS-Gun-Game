using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class EnemyControler : GazePointer
{
    public static float enemyHealth;
    public Image enemyHealthImg;
    public GameObject particleEffect;
    public Animator enemyModels;
    public float Speed;

    Vector3 endPos;
    BulletManager bulletSpawner;
    // Start is called before the first frame update
    void Start()
    {
        endPos = 2.5f * (transform.position - Vector3.zero).normalized;
        bulletSpawner = GameObject.FindObjectOfType<BulletManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if(enemyHealth <= 0)
           Death();
        enemyHealthImg.fillAmount = enemyHealth;
        transform.position = Vector3.Lerp(transform.position, endPos, Speed * Time.deltaTime);
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
        PlayerManger1.currentScore += 100;
    }

     private void OnTriggerEnter(Collider Other)
    {
        if (Other.CompareTag("Player"))
        {
            Attack();
        }
        else if (Other.CompareTag("Enemy"))
        {
            Death();
        }  
    }
        public void Attack()
    {
        enemyModels.SetTrigger("attack");
        PlayerManger1.playerHealth -= 0.2f;
    }
}

