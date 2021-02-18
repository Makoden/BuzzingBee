using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndPlayOnCollision : MonoBehaviour
{
    public Game game;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Bee")
        {
            OVRInput.SetControllerVibration(.05f, .05f, OVRInput.Controller.RTouch);
            Debug.Log("Hit Obstacle");
            game.EndPlay();
        }
    }
}
