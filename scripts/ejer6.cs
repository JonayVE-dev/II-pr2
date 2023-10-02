using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejer6 : MonoBehaviour
{
    GameObject blueCube;
    GameObject red_cilinder;
    // Start is called before the first frame update
    void Start()
    {
        blueCube = GameObject.FindWithTag("blue_cube");
        red_cilinder = GameObject.FindWithTag("red_cilinder");
    }

    // Update is called once per frame
    void Update()
    {
        blueCube.transform.position = new Vector3(gameObject.transform.position.x + 5, blueCube.transform.position.y, blueCube.transform.position.z);
        red_cilinder.transform.position = new Vector3(gameObject.transform.position.x - 5, red_cilinder.transform.position.y, red_cilinder.transform.position.z);
    }
}
