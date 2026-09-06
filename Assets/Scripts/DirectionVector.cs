using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirectionVector1 : MonoBehaviour
{
    //Public Attributes
    public Transform finalTransform;
    public Transform initialTransform;
    public float speed = 1;

    //Private Attributes
    private Vector3 _directionVector;

    // Start is called before the first frame update
    void Start()
    {


    }
     
    // Update is called once per frame
    void Update()
    {

        _directionVector = finalTransform.position - initialTransform.position;
        _directionVector.Normalize();

        Debug.DrawRay(initialTransform.position, _directionVector);

        initialTransform.Translate(_directionVector * Time.deltaTime * speed);

        float Distance = Vector3.Distance(initialTransform.position, finalTransform.position);

        print("Magnitude: " + _directionVector.magnitude);
        print("Distance; " + Distance);

        if (Distance < 10 || Distance > 20)
            speed *= -1;


    }
}
