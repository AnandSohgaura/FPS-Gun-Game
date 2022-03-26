using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class HealthTank : GazePointer
{
    public GameObject player;
    public AudioClip healthSound;
    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
         audioSource = gameObject.GetComponent<AudioSource>();
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     public override void OnPointerDown(PointerEventData eventData)
    {
        base.OnPointerDown(eventData);
        if(PlayerManger1.playerHealth < 1)
        {
         PlayerManger1.playerHealth += 0.5f;
         audioSource.PlayOneShot(healthSound);
        }
    }
}