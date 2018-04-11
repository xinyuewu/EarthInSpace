using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour
{
    public float degreesPerSecond = 20;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.down * Time.deltaTime * this.degreesPerSecond);
    }

    public void flipSpin()
    {
        this.degreesPerSecond = -this.degreesPerSecond;
    }
}
