
using UnityEngine;
using UnityEngine.InputSystem;

public class KeyboardMouseControllerInput : MonoBehaviour, IControllerInput
{
    [SerializeField]
    private bool isLeftController;

    public Transform GetTransform()
    {
        return transform;
    }

    public bool IsColorSwitchPressed()
    {
        if (isLeftController)
        {
            return Keyboard.current.qKey.isPressed;
        }
        else
        {
            return Keyboard.current.eKey.isPressed;
        }
    }

    public bool IsTriggerPressed()
    {
        if (isLeftController)
        {
            return Mouse.current.leftButton.isPressed;
        } 
        else
        {
            return Mouse.current.rightButton.isPressed;
        }
    }
}
