﻿using UnityEngine;
using System.Collections;

public class Column2 : MonoBehaviour 
{
	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.GetComponent<Uni>() != null)
		{
			//If the uni hits the trigger collider in between the columns then
			//tell the game control that the uni scored.
			GameControl2.instance.UniScored();
		}
	}
}