using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StreetLight : MonoBehaviour {


    public Light lit;

    private void Start()
    {
        lit = GetComponentInChildren<Light>();
    }

    public void OnLight()
    {
        lit.enabled = true;
        Debug.Log("Done");
    }

    public void OffLight()
    {
        lit.enabled = false;
    }
}
