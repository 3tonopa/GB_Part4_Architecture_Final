using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Snake
{
public class Launcher : MonoBehaviour
{
    public float targetDelay = 0;
    public bool deploy = true;
    
    void Start()
    {
        new CreateLevel();
        new CreatePlayer();
    }
   
    void Update()
    {
        if(deploy)
        {
            new CreateTarget();
            deploy = false;
        }
    }
}
}