using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] List<Waypoint> path;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(FollowPath());
    }

    IEnumerator FollowPath()
    {
        foreach (Waypoint waypoint in path)
        {
            print("Start patrolling...");
            transform.position = waypoint.transform.position;
            print("Visiting block" + waypoint);
            yield return new WaitForSeconds(1f);
        }
        print("ending patrol");
    }

    // Update is called once per frame
    void Update() {
  
    }
    
}
