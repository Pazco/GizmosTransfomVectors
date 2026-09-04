using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TranslacionLuna : MonoBehaviour
{
    private Transform Tierra;
    public int Velocidad;

    // Start is called before the first frame update
    void Start()
    {

        Tierra = GameObject.Find("Tierra").transform;

    }

    // Update is called once per frame
    void Update()
    {
        
        transform.RotateAround(Tierra.position,Vector3.up, Velocidad * Time.deltaTime);

    }
}
