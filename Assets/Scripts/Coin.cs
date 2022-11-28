using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] GameObject _effectPrefab;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 300 * Time.deltaTime, 0);

    }
    private void OnTriggerEnter(Collider other)
    {
        FindObjectOfType<CoinManager>().AddOne();
        Destroy(gameObject);
        Instantiate(_effectPrefab, transform.position, transform.rotation);
    }
}
