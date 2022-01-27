using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

[RequireComponent(typeof(LineRenderer))]
public class Tail : MonoBehaviour
{
    public float pointSpacing = .1f;

    List<Vector2> points;

    LineRenderer line;
    // Start is called before the first frame update
    void Start()
    {
        line = GetComponent<LineRenderer>();

        points = new List<Vector2>();

        SetPoints();
    }

    // Update is called once per frame
    void Update()
    {
        SetPoints();
    }

    void SetPoints()
    {
        points.Add(transform.position);

        line.numPositions = points.Count;
        line.SetPosition(points.Count - 1, transform.position);
    }
}
