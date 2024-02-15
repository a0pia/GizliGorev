using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class PlaneController : MonoBehaviour
{

    public float throttleIncrement = 0.1f;
    public float maxThrust = 300f;
    public float responsiveness = 10f;
    public float lift = 135f;

    private float throttle;
    private float roll;
    private float pitch;
    private float yaw;

    private float responseModifier
    {
        get
        {
            return (rb.mass / 5f) * responsiveness;
        }
    }
    Rigidbody rb;
    [SerializeField] TextMeshProUGUI hud;
    [SerializeField] Transform propella;
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void HandleInputs()
    {
        roll = Input.GetAxis("Roll");
        pitch = Input.GetAxis("Pitch");
        yaw = Input.GetAxis("Yaw");

        if (Input.GetKey(KeyCode.Space)) throttle += throttleIncrement;
        else if (Input.GetKey(KeyCode.LeftControl)) throttle -= throttleIncrement;

        throttle = Mathf.Clamp(throttle, 0f, 100f);
    }
    private void Update()
    {
        HandleInputs();
        UpdateHud();

        propella.Rotate(Vector3.up * throttle);

    }
    private void FixedUpdate()
    {
        rb.AddForce(transform.forward * maxThrust * throttle);
        rb.AddTorque(transform.up * yaw * responseModifier);
        rb.AddTorque(transform.right * pitch * responseModifier);
        rb.AddTorque(-transform.forward * roll * responseModifier);

        rb.AddForce(Vector3.up * rb.velocity.magnitude * lift);


    }

    private void UpdateHud()
    {
        hud.text = "Throttle " + throttle.ToString("F0") + "%\n";
        hud.text += "Airspeed: " + (rb.velocity.magnitude * 3.6f).ToString("F0") + "km/h\n";
        hud.text += "Altitude: " + transform.position.y.ToString("F0") + " m";
    }
}
