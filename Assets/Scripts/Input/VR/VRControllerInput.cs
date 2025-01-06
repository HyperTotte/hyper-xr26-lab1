using UnityEngine;

public class VRControllerInput : MonoBehaviour, IControllerInput
{
    [SerializeField]
    private OVRInput.Controller controllerType;

    public Transform GetTransform()
    {
        return transform;
    }

    public bool IsColorSwitchPressed()
    {
       return OVRInput.Get(OVRInput.Button.???) //fortsätt, ska vara så att A på ena controllen byter färg.
    }

    public bool IsTriggerPressed()
    {
        return OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger, controllerType);
    }
}