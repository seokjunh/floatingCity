using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrowOnOff : MonoBehaviour
{
    public GameObject objectToDeactivate;
    private float cnt = 1;
    public void arrowOnClick()
    {
        if (cnt % 2 == 0)
        {
            objectToDeactivate.SetActive(false);
            cnt++;
        }
        else
        {
            objectToDeactivate.SetActive(true);
            cnt++;
        }
    }
}
