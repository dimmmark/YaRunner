using UnityEngine;

public class PlayerModifier : MonoBehaviour
{
    [SerializeField] int _width;
    [SerializeField] int _height;

    float _widthMultiplier = 0.0005f;
    float _heightMultiplier = 0.01f;

    [SerializeField] Renderer _renderer;

    [SerializeField] Transform _topSpine;
    [SerializeField] Transform _bottomSpine;
    [SerializeField] Transform _ColliderTransform;

    [SerializeField] AudioSource _increaseSound;

    private void Start()
    {
        SetWidth(Progress.Instance.PlayerInfo.Width);
        SetHeight(Progress.Instance.PlayerInfo.Height);
    }
    void Update()
    {
        float offsetY = _height * _heightMultiplier + 0.17f;
        _topSpine.position = _bottomSpine.position + new Vector3(0, offsetY, 0);
        _ColliderTransform.localScale = new Vector3(1, 1.84f + _height * _heightMultiplier, 1);

    }

    public void AddWidth(int value)
    {
        _width += value;
        UpdateWidth();
        if (value > 0)
        {
            _increaseSound.Play();
        }
    }

    public void AddHeight(int value)
    {
        _height += value;
        if (value > 0)
        {
            _increaseSound.Play();
        }
    }

    public void SetWidth(int value)
    {
        _width = value;
        UpdateWidth();
    }
    public void SetHeight(int value)
    {
        _height = value;
    }



    public void HitBarrier()
    {
        if (_height > 0)
        {
            _height -= 50;
        }
        else if (_width > 0)
        {
            _width -= 50;
            UpdateWidth();
        }
        else
        {
            Die();
        }
    }
    void UpdateWidth()
    {
        _renderer.material.SetFloat("_PushValue", _width * _widthMultiplier);
    }
    void Die()
    {
        Destroy(gameObject);
        FindObjectOfType<GameManager>().ShowFinishWindow();
    }
}
