using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbController : MonoBehaviour
{
    private void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        // Debug.Log("You can pick up the Orb now");
        GameManager.instance.orbInRange = this.gameObject;
    }

    private void OnTriggerExit(Collider other)
    {
        // Debug.Log("Orb is too far away!");
        GameManager.instance.orbInRange = null;
    }
}
