using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Graph : MonoBehaviour
{
    [SerializeField]
    Transform pointPrefab;

    [SerializeField, Range(10, 100)]
    int resolution = 10;

    // Start is called before the first frame update
    void Start()
    {
    }

    void Awake()
    {
        float step = 2f / resolution;
        for (int i = 0; i < resolution; i++)
        {
            float x = ((float)i + 0.5f) * step - 1f;
            float y = (x * x);
            Transform point = Instantiate(pointPrefab);
            point.localScale = Vector3.one * step;
            point.localPosition = new Vector3(x, y, 0);
            point.SetParent(transform, false);
        }
    }

    // Update is called once per frame
    void Update()
    {
    }
}
