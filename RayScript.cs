using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayPlayer : MonoBehaviour
{
    public bool Trigger = true;
    public float range = 20.0f;
    public Camera fpsCam;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Click();
        }
    }
    void Click()
    {
        RaycastHit hit;
        if(Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);
            ButtonTrigger button = hit.transform.GetComponent<ButtonTrigger>();
            if(button!=null)
            {
                button.TakeInput(true);
            }
        }
    }
}