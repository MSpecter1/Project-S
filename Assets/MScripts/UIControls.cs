using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class UIControls : MonoBehaviour
{
    [SerializeField] private CharInputSystem Controls;

    private void OnEnable()
    {
        //Controls.MenuControls.Select.performed += handleMovement;
        //Controls.MenuControls.Select.Enable();
    }

    private void OnDisable()
    {
        //Controls.MenuControls.Select.performed -= handleMovement;
        //Controls.MenuControls.Select.Disable();
    }

    private void handleMovement(InputAction.CallbackContext context)
    {
        Debug.Log("Move");
    }
}
