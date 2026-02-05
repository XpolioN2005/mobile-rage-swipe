using UnityEngine;
using UnityEngine.InputSystem;
using System;

public class GameInput : MonoBehaviour {
    private InputActions playerInput;
    private Vector2 startPos;
    private bool isSwiping = false;

    public event Action<float> OnSwipeAngle;   // Fires when swipe ends
    public event Action<bool> OnPressState;    // Fires true when press starts

    private void Awake() {
        playerInput = new InputActions();
    }

    private void OnEnable() {
        playerInput.Player.Enable();

        // Press start
        playerInput.Player.Press.started += ctx => {
            startPos = playerInput.Player.Position.ReadValue<Vector2>();
            isSwiping = true;
            OnPressState?.Invoke(isSwiping);
        };

        // Press end
        playerInput.Player.Press.canceled += ctx => {
            if (!isSwiping) return;

            Vector2 endPos = playerInput.Player.Position.ReadValue<Vector2>();
            Vector2 delta = endPos - startPos;

            if (delta.magnitude > 0) {
                float angle = Mathf.Atan2(delta.y, delta.x) * Mathf.Rad2Deg;
                if (angle < 0) angle += 360;

                OnSwipeAngle?.Invoke(angle);
            }

            isSwiping = false;
        };
    }

    private void OnDisable() {
        playerInput.Player.Press.started -= ctx => { };
        playerInput.Player.Press.canceled -= ctx => { };
        playerInput.Player.Disable();
    }
}
