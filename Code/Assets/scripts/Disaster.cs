using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disaster : MonoBehaviour {


    public GameObject[] LightMods;
    GameObject[] HouseMods;
    public StreetLightController[] strtarry;
	// Use this for initialization
	void Start () {
        strtarry = new StreetLightController[10];
        LightMods = GameObject.FindGameObjectsWithTag("LightMod");
        HouseMods = GameObject.FindGameObjectsWithTag("HouseMod");
        init();
        StartCoroutine(RandomDisaster());
	}
    void init()
    {
        for(int i=0;i<LightMods.Length;i++)
        {
            strtarry[i] = LightMods[i].GetComponent<StreetLightController>();
        }
    }

    
	
	IEnumerator RandomDisaster()
    {
        yield return new WaitForSeconds(10);
        int line = (int)Random.Range(0, LightMods.Length);
        strtarry[line].OffLights();
        StartCoroutine(FixLine(line));
        StartCoroutine(RandomDisaster());
    }
    IEnumerator FixLine(int line)
    {
        yield return new WaitForSeconds(Random.Range(15, 25));
        strtarry[line].OnLights();
    }
}
