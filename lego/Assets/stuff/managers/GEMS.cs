using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GEMS : MonoBehaviour
{

    public bool player2Enabled;

    // Start is called before the first frame update
    void Start()
    {

    }

    public void AddPlayer2()
    {
        Debug.Log("PLAYER 2 HAS JOINED");
    }

    public void RemovePlayer2()
    {
        Debug.Log("PLAYER 2 HAS LEFT");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
