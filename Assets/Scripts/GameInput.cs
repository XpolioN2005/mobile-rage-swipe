using UnityEngine;
using UnityEngine.InputSystem;
using System;

public class GameInput : MonoBehaviour {
    private InputActions playerInput;
    private Vector2 startPos;
    private bool isSwiping;

    public event Action<float> OnSwipeAngle;
    public event Action<bool> OnPressState;

    void Awake() {
        playerInput = new InputActions();
    }

    void OnEnable() {
        playerInput.Player.Enable();

        playerInput.Player.Press.started += PressStarted;
        playerInput.Player.Press.canceled += PressCanceled;
    }

    void OnDisable() {
        playerInput.Player.Press.started -= PressStarted;
        playerInput.Player.Press.canceled -= PressCanceled;
        playerInput.Player.Disable();
    }

    void PressStarted(InputAction.CallbackContext ctx) {
        startPos = playerInput.Player.Position.ReadValue<Vector2>();
        isSwiping = true;
        OnPressState?.Invoke(true);
    }

    void PressCanceled(InputAction.CallbackContext ctx) {
        if (!isSwiping) return;

        Vector2 endPos = playerInput.Player.Position.ReadValue<Vector2>();
        Vector2 delta = endPos - startPos;

        if (delta.sqrMagnitude > 25f) {
            float angle = Mathf.Atan2(delta.y, delta.x) * Mathf.Rad2Deg;
            if (angle < 0) angle += 360f;
            OnSwipeAngle?.Invoke(angle);
        }

        isSwiping = false;
        OnPressState?.Invoke(false);
    }
}
