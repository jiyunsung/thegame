﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Card : MonoBehaviour {

	private int _rank;
	public int Rank { get { return _rank; } }

	private GameObject _card;

	void Start () 
	{
		transform.position = new Vector3(0, 0, 0);
	}

	public Card(int rank) {
		
		string assetName = string.Format("Card_{0}", rank);  // Example:  "Card_2" is card with number 2: 2 to 99
		GameObject asset = GameObject.Find(assetName);
		if (asset == null) {
			Debug.LogError("Asset '" + assetName + "' could not be found.");
		} else {
			_rank = rank;
		}
	}
	void OnMouseDrag()
	{
		Vector3 newPosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10.0f);
		transform.position = Camera.main.ScreenToWorldPoint(newPosition);
	}
}
