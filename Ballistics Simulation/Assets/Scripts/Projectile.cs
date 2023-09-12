using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Projectile : MonoBehaviour
{
    public ProjectileProperties ProjectileProperties;
    public BallisticSettings BallisticSettings;

    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        BallisticSettings = GetComponent<BallisticSettings>();
        Destroy(gameObject, ProjectileProperties.liveTime);
    }

    private void FixedUpdate()
    {
        Debug.Log(GetHeight());
    }

    private float GetHeight()
    {
        return transform.position.y;
    }

    private float CalculateDrag()
    {
        return 0f;
    }

    private float CalculateWind()
    {
        return 0f;
    }

    private float CalculateGravity()
    {
        return (Physics.gravity.y * ProjectileProperties.Mass);
    }
}
