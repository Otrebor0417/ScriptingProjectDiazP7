using UnityEngine;
using System.Collections;
using UnityEditor;

public class CheckState : MonoBehaviour
{
    public GameObject myObject;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Active Self: " + myObject.activeSelf);
        Debug.Log("Active in Hierarchy" + myObject.activeInHierarchy);
    }
}
 