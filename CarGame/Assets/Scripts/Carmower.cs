using UnityEngine;
using UnityEngine.Tilemaps;

public class Carmower : MonoBehaviour
{

    public Transform SelfTransform;
    public Tilemap Map;

    private Vector3 _forse;


    public TileBase GroungTail;
    private bool _isAselireted;

    public float GetForce()
    {
        return _forse.magnitude;
    }

    public void Accelerate()
    {
        _forse += (SelfTransform.up * Time.deltaTime) * 0.1f;
        _isAselireted = true;
    }

    public void RotateRith()
    {
        SelfTransform.Rotate(0, 0, -5);
    }

    public void RotateLeft()
    {
        SelfTransform.Rotate(0, 0, 5);
    }

    void LateUpdate()
    {

        if (!_isAselireted)
        {
            _forse = Vector3.Lerp(_forse, Vector3.zero, Time.deltaTime);

        }

        if (GroungTail == Map.GetTile(Map.WorldToCell(SelfTransform.position)))
        {
            _forse *= 1f;
        }

        SelfTransform.position += _forse;

        _isAselireted = false;
    }

}
