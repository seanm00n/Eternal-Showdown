using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;
using UnityEngine.UIElements;

public class GameMananger : MonoBehaviour
{
    public static GameMananger Instance;
    public IObjectPool<RandomBox> pool;

    [SerializeField]
    GameObject randomBox;

    [SerializeField]
    List<Vector3> boxSpawnPoint;

    private void Awake()
    {
        Instance = this;
        pool = new ObjectPool<RandomBox>(CreateBox, OnGetBox, OnReleaseBox, OnDestroyBox, maxSize: 20);
    }

    private void Start()
    {
        SpawnBox(new Vector3());
    }

    // ------------------------------------------------------------------------------------------------------- //

    RandomBox CreateBox()
    {
        RandomBox box = Instantiate(randomBox, transform).GetComponent<RandomBox>();
        return box;
    }

    void OnGetBox(RandomBox box)
    {
        box.gameObject.SetActive(true);
    }

    void OnReleaseBox(RandomBox box)
    {
        box.gameObject.SetActive(false);
    }

    void OnDestroyBox(RandomBox box)
    {
        Destroy(box.gameObject);
    }

    public void SpawnBox(Vector3 exception)
    {
        int index;

        if (boxSpawnPoint.Count == 0 || (boxSpawnPoint.Count == 1 && boxSpawnPoint[0] == exception))
        {
            throw new System.InvalidOperationException("No valid spawn points available.");
        }

        do
        {
            index = Random.Range(0, boxSpawnPoint.Count);
        }
        while (boxSpawnPoint[index] == exception);

        var box = pool.Get();
        box.transform.position = boxSpawnPoint[index];
    }
}
