using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class PipePool : MonoBehaviour
{
    [SerializeField] private GameObject _spawningObject;
    [SerializeField] private int _capacity;
    [SerializeField] private float _spawnDelay;
    [SerializeField] private Transform _container;
    [SerializeField] private float _spawnSpreadY;

    private List<GameObject> _spawningObjects = new List<GameObject>();
    private float _elapcedTime = 0;

    private void Awake()
    {
        Initialize();
    }

    private void Update()
    {
        if(_elapcedTime > _spawnDelay)
        {
            TrySpawnObject();
            TryDisableObjectAbroadScreen();
            _elapcedTime = 0;
        }

        _elapcedTime += Time.deltaTime;
    }

    private void Initialize()
    {
        for(int i = 0; i < _capacity; i++)
        {
            GameObject spawnedObject = Instantiate(_spawningObject, _container);
            _spawningObjects.Add(spawnedObject);
            spawnedObject.SetActive(false);
        }
    }

    private void TrySpawnObject()
    {
        foreach (var item in _spawningObjects)
        {
            if (!item.activeSelf)
            {
                item.transform.position = new Vector3(transform.position.x, transform.position.y + Random.Range(-_spawnSpreadY, _spawnSpreadY));
                item.SetActive(true);
                break;
            }
        }
    }

    private void TryDisableObjectAbroadScreen()
    {
        Vector3 disablePoint = Camera.main.ScreenToWorldPoint(new Vector3(0, 0));

        foreach (var item in _spawningObjects)
        {
            if (item.activeSelf && item.transform.position.x <= disablePoint.x)
            {
                item.SetActive(false);
            }
        }
    }
}
