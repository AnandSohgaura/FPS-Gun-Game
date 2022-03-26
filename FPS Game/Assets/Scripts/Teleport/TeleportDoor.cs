using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TeleportDoor : GazePointer
{
    public GameObject player;
    public GameObject teleportTO; 
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
    }
}
