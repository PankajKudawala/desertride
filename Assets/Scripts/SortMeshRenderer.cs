﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SortMeshRenderer : MonoBehaviour {

	public Renderer MyRenderer;
	public string MySortingLayer;
	public int MySortingOrderInLayer;

	// Use this for initialization
	void Start () {
		if (MyRenderer == null) {
			MyRenderer = this.GetComponent<Renderer>();
		}
		MySortingLayer = "Platform";

		SetLayer();
	}


	public void SetLayer() {
		if (MyRenderer == null) {
			MyRenderer = this.GetComponent<Renderer>();
		}

		MyRenderer.sortingLayerName = MySortingLayer;
		MyRenderer.sortingOrder = MySortingOrderInLayer;

		//Debug.Log(MyRenderer.sortingLayerName + " " + MyRenderer.sortingOrder);
	}
}
