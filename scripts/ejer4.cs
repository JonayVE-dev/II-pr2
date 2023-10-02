
using UnityEngine;

public class Ejer4 : MonoBehaviour
{
    Vector3 spherePosition;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        spherePosition = gameObject.transform.position;
        Debug.Log("Posiciones de la esfera: " + spherePosition);
    }
}
