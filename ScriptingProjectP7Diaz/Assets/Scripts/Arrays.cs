using UnityEngine;
using System.Collections;
public class Arrays : MonoBehaviour
{
    public GameObject[] players;
    // Start is called before the first frame update
    void Start()
    {
        players = GameObject.FindGameObjectsWithTag("Player");

        for(int i = 0; i < players.Length; i++)
        {
            Debug.Log("Player Number"+(i+1)+" is named" + players[i].name);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
