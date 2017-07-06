using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StreetLightController : MonoBehaviour {

    public GameObject[] StreetLightArray;
    public string LineName;
    bool on;
    bool off;
    public void OnLights()
    {
        int i = 0;
        for(i = 0;i<StreetLightArray.Length;i++)
        {
            StreetLightArray[i].GetComponent<StreetLight>().OnLight();
        }
        Debug.Log("Line \"" + LineName + "\" Is Online Now......");
        StartCoroutine(ShowFix());
    }
    IEnumerator ShowFix()
    {
        on = true;
        yield return new WaitForSeconds(4);
        on = false;
    }
    IEnumerator ShowFail()
    {
        off = true;
        yield return new WaitForSeconds(4);
        off = false;
    }
    private void OnGUI()
    {
        if (on)  GUI.Label(new Rect(10, 10, 1000, 20), "Line \"" + LineName + "\" Is Online Now......");
        if (off) GUI.Label(new Rect(10, 50, 1000, 20), "Line \"" + LineName + "\" Has Failed, Calling Support Team......");

    }
    public void OffLights()
    {
        int i = 0;
        for (i = 0; i < StreetLightArray.Length; i++)
        {
            StreetLightArray[i].GetComponent<StreetLight>().OffLight();
        }
        Debug.Log("Line \"" + LineName + "\" Has Failed, Calling Support Team......");
        StartCoroutine(ShowFail());
    }
    
}
