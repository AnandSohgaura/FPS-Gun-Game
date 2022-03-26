using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class HealthDecriese : GazePointer
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void OnPointerDown(PointerEventData eventData)
    {
        base.OnPointerDown(eventData);
        StartCoroutine(HealthDce());

       
    }

    public IEnumerator HealthDce()
    {
        yield return new WaitForSeconds(5);
        PlayerManger1.playerHealth -= 0.06f;
        StartCoroutine(HealthDce());
    }
}
