using UnityEngine;

public class TankTurret : MonoBehaviour
{
    [SerializeField] private Transform turret;
    [SerializeField] private Transform canon;
    [SerializeField] private float rotationPerSecond;
    [SerializeField] private float canonElevationPerSecond;
    [SerializeField] private float minElevationAngle;
    [SerializeField] private float maxElevationAngle;
    private float _elevationPercentage;
    private Quaternion _minCanonRotation;
    private Quaternion _maxCanonRotation;

    private void Awake()
    {
        _minCanonRotation = Quaternion.AngleAxis(minElevationAngle, Vector3.left);
        _maxCanonRotation = Quaternion.AngleAxis(maxElevationAngle, Vector3.left);
    }

    private void Update()
    {
        var hInput = Input.GetAxis("Horizontal");
        var vInput = Input.GetAxis("Vertical");
        var angle = hInput * rotationPerSecond * Time.deltaTime;
        var rise = vInput * Time.deltaTime;
        _elevationPercentage = Mathf.Clamp01(_elevationPercentage + rise);
        turret.Rotate(Vector3.up, angle, Space.Self);
        var newCanonRotation = Quaternion.Slerp(_minCanonRotation, _maxCanonRotation, _elevationPercentage);
        canon.rotation = turret.rotation * newCanonRotation;
    }
}
