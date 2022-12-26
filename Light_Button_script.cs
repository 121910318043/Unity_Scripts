using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonTrigger : MonoBehaviour
{
    public bool state = false;
    public Light[] Light1;
    // Start is called before the first frame update
    public void TakeInput(bool Action)
    {
        if(state == Action)
        {
            state = false;
            for(int i=0;i<Light1.Length;i++)
            { 
                Light1[i].enabled = false;
            }
            Switch1(state);
        }
        else
        {
            state = true;
            for (int i = 0; i < Light1.Length; i++)
            {
                Light1[i].enabled = true;
            }
            Switch1(state);
        }
    }
    
    //To animate the Switch
    public void Switch1(bool state)
    { 
        if(state)
        {
            transform.Rotate(2*6.8f, 0, 0);
        }else
        {
            transform.Rotate(-2*6.8f, 0, 0);
        }
    }
}