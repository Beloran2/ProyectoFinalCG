using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicFeet : MonoBehaviour
{
    public MovErik personajeMov;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        personajeMov.canJump=true;
    }

    private void OnTriggerExit(Collider other)
    {
        personajeMov.canJump=false; 
    }
}
