using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed;
    public float distance;

    private void Start()
    {
        distance += transform.position.z;
    }

    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);

        if(transform.position.z >= distance)
        {
            Destroy(this.gameObject);
        }
    }
}
