using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejer8 : MonoBehaviour
{
    float[] distances = new float[3];
    GameObject[] spheres = new GameObject[3];
    public int displacement = 1;
    // Start is called before the first frame update
    void Start()
    {
        spheres = GameObject.FindGameObjectsWithTag("group2");
    }

    // Update is called once per frame
    void Update()
    {
        UpdateDistances();
        MoveNearestSphere();
        if (Input.GetKeyDown(KeyCode.Space)) {
            ChangeFurthestSphereColor();
        }
         
    }

    void UpdateDistances() {
        for (int i = 0; i < spheres.Length; i++) {
            distances[i] = Vector3.Distance(gameObject.transform.position, spheres[i].transform.position);
        }
    }

    int GetNearestSphere() {
        int index = 0;
        float min = distances[0];
        for (int i = 1; i < distances.Length; i++) {
            if (distances[i] < min) {
                min = distances[i];
                index = i;
            }
        }
        return index;
        
    }

    int GetFurthestSphere() {
        int index = 0;
        float max = distances[0];
        for (int i = 1; i < distances.Length; i++) {
            if (distances[i] > max) {
                max = distances[i];
                index = i;
            }
        }
        return index;
    }

    void MoveNearestSphere() {
        int index = GetNearestSphere();
        float y = spheres[index].transform.position.y + displacement * Time.deltaTime;
        spheres[index].transform.position = new Vector3(spheres[index].transform.position.x, y, spheres[index].transform.position.z);
    }

    void ChangeFurthestSphereColor() {
        int index = GetFurthestSphere();
        spheres[index].GetComponent<Renderer>().material.color = new Color(Random.value, Random.value, Random.value, Random.value);
    }
}
