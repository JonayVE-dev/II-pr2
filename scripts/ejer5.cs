using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejer5 : MonoBehaviour
{
    GameObject blueCube;
    GameObject red_cilinder;

    void Start() {
        blueCube = GameObject.FindWithTag("blue_cube");
        red_cilinder = GameObject.FindWithTag("red_cilinder");
    }

    // Update is called once per frame
    void Update()
  
    {
        Debug.Log(gameObject.name + " distance to " + red_cilinder.name + " is " + Vector3.Distance(gameObject.transform.position, red_cilinder.transform.position));
        Debug.Log(gameObject.name + " distance to " + blueCube.name + " is " + Vector3.Distance(gameObject.transform.position, blueCube.transform.position));
    }
}
