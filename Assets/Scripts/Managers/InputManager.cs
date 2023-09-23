using System.Runtime.InteropServices;
using UnityEngine;

public static class InputManager
{
    private static PlayerControls controls;

    public static void Init(Player myPlayer)
    {
        controls = new PlayerControls();

        controls.PlayingGame.Movement.performed += ctx => 
        {
            myPlayer.SetMoveDirection(ctx.ReadValue<Vector3>());
        };

        controls.Permenant.Enable();
    }

    public static void GameMode()
    {
        controls.PlayingGame.Enable();
        controls.UIMode.Disable();
    }

    public static void UIMode()
    {
        controls.PlayingGame.Disable();
        controls.UIMode.Enable();
    }
}
