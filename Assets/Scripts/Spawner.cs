using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Enemy _prefab;
    [SerializeField] private float _delay;
    [SerializeField] Transform[] _spawnPoints;

    private void Start()
    {
        StartCoroutine(Spawn());
    }

    private IEnumerator Spawn()
    {
        var wait = new WaitForSeconds(_delay);
        while (true)
        {
            int spawnPointNumber = Random.Range(0, _spawnPoints.Length);
            Instantiate(_prefab, _spawnPoints[spawnPointNumber]);
            yield return wait;
        }
    }
}
