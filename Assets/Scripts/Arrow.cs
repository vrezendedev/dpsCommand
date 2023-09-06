using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Arrow : MonoBehaviour
{
    [Header("Required")]
    [SerializeField] private Rigidbody _rigidbody;


    [Space(1.5f), Header("Shot Attributes")]
    public float ShootForce;
    public float PushForce;

    private Vector3 _startPosition;
    private Quaternion _startRotation;

    void Awake()
    {
        _startPosition = this.transform.position;
        _startRotation = this.transform.rotation;
    }

    public void Shoot()
    {
        TextEvent.UpdateText("Shoot method executed... Class: " + typeof(Arrow).Name);
        _rigidbody.velocity = transform.forward * ShootForce / _rigidbody.mass;
        _rigidbody.AddRelativeTorque(Vector3.right * PushForce, ForceMode.Force);
    }

    public void Reload()
    {
        TextEvent.UpdateText("Reload method executed... Class: " + typeof(Arrow).Name);
        _rigidbody.velocity = Vector3.zero;
        _rigidbody.Sleep();
        this.transform.position = _startPosition;
        this.transform.rotation = _startRotation;
    }
}
