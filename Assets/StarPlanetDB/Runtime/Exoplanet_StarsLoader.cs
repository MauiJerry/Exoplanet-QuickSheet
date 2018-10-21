using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exoplanet_StarsLoader : MonoBehaviour {
    public Exoplanet_StarsUnique2 stars;

	// Use this for initialization
	void Start () {
        Debug.LogFormat("Star {0}", stars.dataArray[0].Pl_hostname);
	}
	
}
