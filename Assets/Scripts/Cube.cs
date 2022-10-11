using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    private float speed;
    private float distance;
    private Vector3 startPosition;

    public void Initialization(float speed, float distance)
    {
        this.speed = speed;
        this.distance = distance;
        startPosition = transform.position;
    }

    private void Update()
    {
        if ((transform.position - startPosition).magnitude < distance)
            transform.position += Vector3.right * speed * Time.deltaTime;
        else
            Deactivation();
    }

    private void Deactivation()
    {
        gameObject.SetActive(false);
    }
}
