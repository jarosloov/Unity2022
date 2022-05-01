using UnityEngine;

public class Force : MonoBehaviour
{
    [SerializeField] private float F, R, impForce;
    [SerializeField] private Vector3 pos;
    [SerializeField] private Rigidbody rb, c_rb;
    [SerializeField] private GameObject obj, E;

    private void Awake()
    {
        var per = new Vector3(transform.position.y, -transform.position.x, 0);
        c_rb = E.GetComponent<Rigidbody>();
        F = (float)(c_rb.mass * 6.67418479 * 0.00000001);
        rb.AddForce(per.normalized * impForce, ForceMode.Impulse);
    }

    private void Update()
    {
        pos = obj.transform.position;
        R = transform.position.magnitude;
        pos = (transform.position.normalized * F) / (R * R);
        rb.AddForce(-transform.position, ForceMode.Force);
    }
}
