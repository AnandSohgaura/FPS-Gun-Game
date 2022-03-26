using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TeleportDoor2 : GazePointer
{
    public GameObject player;
    public GameObject teleportTO, Level1, Level2, Level3; 
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     public override void OnPointerDown(PointerEventData eventData)
    {
        base.OnPointerDown(eventData);

        player.transform.position = teleportTO.transform.position;
        Level1.SetActive(false);
        Level2.SetActive(false);
        Level3.SetActive(true);

    }
}