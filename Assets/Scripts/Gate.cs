using UnityEngine;

public class Gate : MonoBehaviour
{
    [SerializeField] int _value;

    [SerializeField] DeformationType _deformationType;
    [SerializeField] GateAppearaence _gateAppearaence;

    private void OnValidate()
    {
        _gateAppearaence.UpdateVisual(_deformationType, _value);
    }
    private void OnTriggerEnter(Collider other)
    {
        PlayerModifier playerModifier = other.attachedRigidbody.GetComponent<PlayerModifier>();
        if (playerModifier != null)
        {
            if (_deformationType == DeformationType.Height)
            {
                playerModifier.AddHeight(_value);
            }
            else if (_deformationType != DeformationType.Height)
            {
                playerModifier.AddWidth(_value);
            }
            Destroy(gameObject);
        }
    }
}
