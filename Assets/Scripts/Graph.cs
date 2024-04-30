using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Graph : MonoBehaviour
{
    [SerializeField]
    Transform pointPrefab;

    // Start is called before the first frame update
    void Start()
    {
    }

    void Awake()
    {
        for (int i = -100; i < 100; i++)
        {
            int x = i;
            int y = (x * x * x) / 400;
            Transform point = Instantiate(pointPrefab);
            point.localPosition = new Vector3(x, y, 0);
        }
    }

    // Update is called once per frame
    void Update()
    {
    }
}
