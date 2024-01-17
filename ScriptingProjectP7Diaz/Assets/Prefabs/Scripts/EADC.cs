using UnityEngine;
using System.Collections;


public class EADC : MonoBehaviour
{
    private Light myLight;


    void Start ()
    {
        myLight = GetComponent<Light>();
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.Space))
        {
            myLight.enabled = !myLight.enabled;
        }
        
    }
}
