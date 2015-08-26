﻿using UnityEngine;
using System.Collections;

public class GridElement : MonoBehaviour {

	public Vector2i gridIndex;
	public SpriteRenderer myRenderer;
	public Color baseColor;
	public Color highlightColor;

	void Awake() 
	{
		myRenderer = GetComponent<SpriteRenderer>();
		baseColor = myRenderer.color;
	}

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void OnMouseEnter ()
	{
		myRenderer.color = highlightColor;
	}

	void OnMouseExit () 
	{
		myRenderer.color = baseColor;
	}
}