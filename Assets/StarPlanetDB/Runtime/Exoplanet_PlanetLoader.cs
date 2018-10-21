using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exoplanet_PlanetLoader : MonoBehaviour {
    public Exoplanet_Data_Planets planets;

	// Use this for initialization
	void Start () {
        Debug.LogFormat("Planet {0}", planets.dataArray[0].Pl_name);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
