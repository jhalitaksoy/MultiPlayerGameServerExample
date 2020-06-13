using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiPlayerTest : MonoBehaviour
{

    MultiPlayer MultiPlayer;

    // Start is called before the first frame update
    void Start()
    {
        MultiPlayer = GetComponent<MultiPlayer>();

        MultiPlayer.StartGame();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
