using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Graph : MonoBehaviour
{
    [SerializeField]
    Transform pointPrefab;

    [SerializeField, Range(10, 100)]
    int resolution = 10;

    Transform[] points;

    // Start is called before the first frame update
    void Start()
    {
    }

    void Awake()
    {
        float step = 2f / resolution;
        points = new Transform[resolution];
        for (int i = 0; i < points.Length; i++)
        {
            float x = ((float)i + 0.5f) * step - 1f;
            Transform point = points[i] = Instantiate(pointPrefab);
            point.localScale = Vector3.one * step;
            point.localPosition = new Vector3(x, 0, 0);
            point.SetParent(transform, false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < points.Length; i++) {
            Vector3 position = points[i].localPosition;
            position.y = Mathf.Sin((position.x + Time.time) * Mathf.PI);
            points[i].localPosition = position;
        }
    }
}
