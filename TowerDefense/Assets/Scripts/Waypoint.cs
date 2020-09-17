﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoint : MonoBehaviour
{
    Vector2Int gridPos;

    const int gridSize = 10;
    // Start is called before the first frame update
  
    public int GetGridSize()
    {
        return gridSize;
    }

    public Vector2 GetGridPos()
    {
       return new Vector2Int(
            Mathf.RoundToInt(transform.position.x / gridSize) * gridSize, // x  
            Mathf.RoundToInt(transform.position.z / gridSize) * gridSize  // y
        );
    }
 
}