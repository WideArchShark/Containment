using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    private GameObject objectCurrentlyHeld;

    public GameObject orbInRange;
    public GameObject container;
    public bool isCarryingOrb = false;
    public bool inContainerRange = false;

    private void Awake()
    {
        if (instance == null) {
            instance = this;
        }
    }


    public void OnInteract()
    {
        if (orbInRange != null && !isCarryingOrb)
        {
            orbInRange.transform.SetParent(this.gameObject.transform);
            orbInRange.transform.localPosition= new Vector3(0f, 1f, 0.5f);
            orbInRange.transform.localRotation = Quaternion.identity;
            isCarryingOrb = true;
        }

        if (isCarryingOrb && inContainerRange)
        {
            Debug.Log("You did it!");
            orbInRange.transform.SetParent(container.transform);
            orbInRange.transform.localPosition = new Vector3(0f, 0.25f, 0f);
            orbInRange.transform.localRotation = Quaternion.identity;
            isCarryingOrb = false;
        }
    }
}
