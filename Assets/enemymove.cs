using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour {

    public float speed = 3.0f;
    private Transform target;
    private int wavepointindex = 0;
   
    void Start()
    {
        target = WayPoint.point[0];
    }
    void Update()
    {
        Vector3 dir = target.position - transform.position;
        transform.Translate(dir.normalized * speed * Time.deltaTime,Space.World);

        if (Vector3.Distance(transform.position, target.position) <= 0.2f)
        {
            getnextwaypoint();
        }
    }

    void getnextwaypoint()
    {
        if(wavepointindex>=WayPoint.point.Length-1)
        {
            wavepointindex = 0;
            target = WayPoint.point[wavepointindex];
            return;
        }
        wavepointindex++;
        target = WayPoint.point[wavepointindex];
    }
}
