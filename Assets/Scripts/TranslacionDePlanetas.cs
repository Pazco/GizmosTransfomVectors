using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TranslacionDePlanetas : MonoBehaviour
{
    private Transform Sol;
    public int Velocidad;

    // Start is called before the first frame update
    void Start()
    {

        Sol = GameObject.Find("Sol").transform;
        GameObject.Find("Mercurio");
        GameObject.Find("Venus");
        GameObject.Find("Tierra");
        GameObject.Find("Luna");
        GameObject.Find("Marte");
        GameObject.Find("Jupiter");
        GameObject.Find("Saturno");
        GameObject.Find("Urano");
        GameObject.Find("Neptuno");
    }

    // Update is called once per frame
    void Update()
    {

       transform.RotateAround(Sol.position, Vector3.up, Velocidad * Time.deltaTime); 
       
    }
}
