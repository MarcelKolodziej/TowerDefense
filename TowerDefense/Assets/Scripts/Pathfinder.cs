using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pathfinder : MonoBehaviour
{
    Dictionary<Vector2, Waypoint> grid = new Dictionary<Vector2, Waypoint>();
    [SerializeField] Waypoint startPoint, endPoint;

    void Start()
    {
        LoadBlocks();
        StartAndEnd();
    }

    private void LoadBlocks()
    {
        var waypoints = FindObjectsOfType<Waypoint>();
        foreach (Waypoint waypoint in waypoints)
        {
            var gridPos = waypoint.GetGridPos();
            if (grid.ContainsKey(gridPos))
            {
                Debug.LogWarning("Skipping overlapping block" + waypoint);
            }
            else
            {
                    grid.Add(waypoint.GetGridPos(), waypoint);
            } 
        }
    }

    public void StartAndEnd()
    {
        startPoint.SetTopColor(Color.yellow);
        endPoint.SetTopColor(Color.red);
    }
}
