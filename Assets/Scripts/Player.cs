using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Player2D : MonoBehaviour {
    [SerializeField] float maxSpeed = 25f;
    [SerializeField] float impluseSpeed = 15f;
    [SerializeField] float dampingWhilePress = 5f;

    [SerializeField] float slowTimeScale = 0.3f;

    [SerializeField] GameInput gameInput;

    Rigidbody2D rb;

    void Awake() {
        Setup();
    }

    void Setup() {
        rb = GetComponent<Rigidbody2D>();
    }

    void OnEnable() {
        gameInput.OnPressState += OnPress;
        gameInput.OnSwipeAngle += OnSwipe;
    }

    void OnDisable() {
        gameInput.OnPressState -= OnPress;
        gameInput.OnSwipeAngle -= OnSwipe;
    }

    void FixedUpdate() {
        CapVelocity();
    }

    void CapVelocity() {
        if (rb.linearVelocity.magnitude > maxSpeed) {
            rb.linearVelocity = rb.linearVelocity.normalized * maxSpeed;
        }
    }

    void OnPress(bool pressed) {

        if (pressed) {
            rb.linearDamping = dampingWhilePress;
            Time.timeScale = slowTimeScale;
        } else {
            rb.linearDamping = 0f;
            Time.timeScale = 1f;
        }
    }

    void OnSwipe(float angle) {
        if (angle < 5f || angle > 175f)
            return;

        Time.timeScale = 1f;

        float rad = angle * Mathf.Deg2Rad;
        Vector2 dir = new Vector2(Mathf.Cos(rad), Mathf.Sin(rad));

        rb.linearVelocity = dir * impluseSpeed;
    }

}
