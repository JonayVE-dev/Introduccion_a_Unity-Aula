using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class miScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
  
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Hola, soy un " + gameObject.name + " y mi tag es " + gameObject.tag);
    }
}
