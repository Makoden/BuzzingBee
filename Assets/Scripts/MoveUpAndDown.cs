using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveUpAndDown : MonoBehaviour
{
    public float minY = .1f;
    public float maxY = .2f;
    public float speed = 0.5f;
    public float offset = 0f;
 
    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x, minY + (maxY - minY)*Mathf.PingPong(Time.time * speed + offset, 1), transform.position.z);
    }
}
