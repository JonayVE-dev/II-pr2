using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Ejer3 : MonoBehaviour
{
    public Vector3 myVector1 = new Vector3(0.0f, 0.0f, 0.0f);
    public Vector3 myVector2 = new Vector3(0.0f, 0.0f, 0.0f);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Magnitud del myVector1: " + myVector1.magnitude);
        Debug.Log("Magnitud del myVector2: " + myVector2.magnitude);
        Debug.Log("Ángulo: " + Vector3.Angle(myVector1, myVector2));
        Debug.Log("Distancia Vector1 a Vector2: " + Vector3.Distance(myVector1, myVector2));
        Debug.Log("Vector3 a mayor altura: " + ((myVector1.y > myVector2.y) ? "myVector1" : "myVector2" ));
    }
}
