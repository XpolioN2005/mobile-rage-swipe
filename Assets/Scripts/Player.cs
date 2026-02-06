using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Player2D : MonoBehaviour {
    [SerializeField] float maxSpeed = 12f;
    [SerializeField] float dampingWhilePress = 10f;

    [SerializeField] float slowTimeScale = 0.3f;

    [SerializeField] GameInput gi;

    Rigidbody2D rb;

    void Awake() {
        Setup();
    }

    void Setup() {
        rb = GetComponent<Rigidbody2D>();
        rb.linearDamping = 0f;
        rb.gravityScale = 0f;
    }

    void OnEnable() {
        gi.OnPressState += OnPress;
        gi.OnSwipeAngle += OnSwipe;
    }

    void OnDisable() {
        gi.OnPressState -= OnPress;
        gi.OnSwipeAngle -= OnSwipe;
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
        rb.linearDamping = 0f;

        float rad = angle * Mathf.Deg2Rad;
        Vector2 dir = new Vector2(Mathf.Cos(rad), Mathf.Sin(rad));

        rb.linearVelocity = dir * maxSpeed;
    }
}
