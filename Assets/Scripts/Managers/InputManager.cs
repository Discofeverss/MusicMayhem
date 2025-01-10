using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    // static is not tied to this instance of a script, so one is able to call it from this class by calling InputManager.Movement
    public static Vector2 Movement;

    private InputAction moveAction;
    private PlayerInput playerInput;

    private void Awake()
    {
        //The component added to player, comes with InputSystem package
        playerInput = GetComponent<PlayerInput>();

        //the string in Input Actions. The action map is Player, you create the controls by right clicking inside assets folder - create - input actions
        moveAction = playerInput.actions["Move"];
    }

    private void Update()
    {
        Movement = moveAction.ReadValue<Vector2>(); 
    }

}
