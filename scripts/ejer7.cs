using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejer7 : MonoBehaviour
{
    Material m_Material;
    public KeyCode keyCode;

    // Start is called before the first frame update
    void Start()
    {
        m_Material = GetComponent<Renderer>().material;    
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(keyCode))
        {
            m_Material.color = new Color(Random.value, Random.value, Random.value, Random.value);
        }

    }
}
