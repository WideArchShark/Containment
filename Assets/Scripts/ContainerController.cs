using UnityEngine;

public class ContainerController : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        Debug.Log("In container range");
        GameManager.instance.inContainerRange = true;
    }

    public void OnTriggerExit(Collider other)
    {
        GameManager.instance.inContainerRange = false;
    }
}
