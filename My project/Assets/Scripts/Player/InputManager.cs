using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public static InputManager instance;
    public static PlayerInputs inputs;

    [Header("Player")]
    public Vector2 movement;
    public Vector2 mouse;
    public Vector2 mouseScroll;
    public bool jump;   
    public bool crouching;
    public bool sprinting;

    [Header("Keys")]
    public bool shift;
    public bool crouch;
    public bool alt;
    public bool R;
    public bool T;

    private void Awake() 
    {
        instance = this;
        inputs = new PlayerInputs();
    }

    private void OnEnable() 
    {
        inputs.Enable();
    }

    private void OnDisable() 
    {
        inputs.Disable();
    }

    void Update()
    {
        movement = inputs.Player.Walking.ReadValue<Vector2>();        
        mouse = inputs.Player.Mouse.ReadValue<Vector2>();
        mouseScroll = inputs.Player.MoveSpeedChange.ReadValue<Vector2>();

        inputs.Player.Sprint.performed += _sprt => sprinting = true;
        inputs.Player.Sprint.canceled += _sprt => sprinting = false;

        inputs.Player.Crouch.performed += _crch => crouching = true;
        inputs.Player.Crouch.canceled += _crch => crouching = false;

        inputs.Player.Jump.performed += _jmp => sprinting = true;
        inputs.Player.Jump.canceled += _jmp => sprinting = jump;
        //Debug.Log(mouseScroll);
    }
}
