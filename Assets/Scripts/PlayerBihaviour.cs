using UnityEngine;

public class PlayerBihaviour : MonoBehaviour
{
    [SerializeField] PlayerMove _playerMove;
    [SerializeField] PreFinishBehavior _preFinishBehavior;
    [SerializeField] Animator _animator;
    void Start()
    {
        _playerMove.enabled = false;
        _preFinishBehavior.enabled = false;
    }

    public void Play()
    {
        _playerMove.enabled = true;
    }
    public void StartPreFinishBehavior()
    {
        _playerMove.enabled = false;
        _preFinishBehavior.enabled = true;
    }

    public void StartFinishBehavior()
    {
        _preFinishBehavior.enabled = false;
        _animator.SetTrigger("Dance");
    }
}
