using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class G923Test : MonoBehaviour
{
    [Header("Input Action Asset")]
    [SerializeField] private InputActionAsset g923Controls;

    private InputAction steerAction;
    private InputAction gasAction;
    private InputAction breakAction;
    private InputAction clutchAction;

    private InputAction wAction;
    
    private void Awake()
    {
        steerAction = g923Controls.FindAction("Steering");
        gasAction = g923Controls.FindAction("Gas");
        breakAction = g923Controls.FindAction("Break");
        clutchAction = g923Controls.FindAction("Clutch");

        Register();
    }

    void Register()
    {
        steerAction.performed += Steer;
        gasAction.performed += Gas;
        breakAction.performed += Break;
        clutchAction.performed += Clutch;
    }
    private void OnEnable()
    {
        steerAction.Enable();
        gasAction.Enable();
        breakAction.Enable();
        clutchAction.Enable();
    }
    private void OnDisable()
    {
        steerAction.Disable();
        gasAction.Disable();
        breakAction.Disable();
        clutchAction.Disable();
    }
    private void Steer(InputAction.CallbackContext context)
    {
        Debug.Log($"Steering!: {context.ReadValue<float>()}");
    }
    private void Gas(InputAction.CallbackContext context)
    {
        Debug.Log($"Gas pedal pressed!: {context.ReadValue<float>()}");
    }
    private void Break(InputAction.CallbackContext context)
    {
        Debug.Log($"Break pedal pressed!: {context.ReadValue<float>()}");
    }
    private void Clutch(InputAction.CallbackContext context)
    {
        Debug.Log($"Clutch pedal pressed!: {context.ReadValue<float>()}");
    }
}
