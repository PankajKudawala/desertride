using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;

public class AdManager : MonoBehaviour {

	public string InterstetialId;

	InterstitialAd myad;

	void Start(){
		myad = new InterstitialAd (InterstetialId);
	}

	public void LoadAdd(){
		AdRequest request = new AdRequest.Builder ().Build();
		myad.LoadAd (request);
	}

	public void showADD(){
		if (myad.IsLoaded()) {
			myad.Show ();
		} else {
			LoadAdd ();
		}
	}
}
