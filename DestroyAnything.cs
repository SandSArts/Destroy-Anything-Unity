//Programmed by Shashank.S - creator of SandS Arts , Mail me at sandsarts.developer@gmail.com
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAnything : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
      Destroy(this.GetComponent<BoxCollider>(),2f);    //Destroying BoxCollider attached to this game object after 2 seconds
      Destroy(this,3f);                                //Destroying this script after 3 seconds
      Destroy(this.GetComponent<ScriptName>());        //Destroying Script called ScriptName attached to this game object immediately after hitting play
      Destroy(this.gameObject);        //Destroying this game object immediately after hitting play
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
