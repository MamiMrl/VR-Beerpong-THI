using UnityEngine;

public class BallTrail : MonoBehaviour
{
    public float lineWidth = 0.1f;
    public Color lineColor = Color.white;
    public int maxPoints = 50;

    private LineRenderer lineRenderer;
    private Vector3[] points;
    private int currentPoint = 0;

    void Start()
    {
        lineRenderer = gameObject.AddComponent<LineRenderer>();
        if (lineRenderer == null)
            lineRenderer = gameObject.AddComponent<LineRenderer>();
        lineRenderer.startWidth = lineWidth;
        lineRenderer.endWidth = lineWidth;
        lineRenderer.material = new Material(Shader.Find("Sprites/Default"));
        lineRenderer.startColor = lineColor;
        lineRenderer.endColor = lineColor;
        lineRenderer.numCapVertices = 5;
        points = new Vector3[maxPoints];
    }

    void Update()
    {
        if (currentPoint >= maxPoints)
        {
            currentPoint = 0;
        }
        points[currentPoint] = transform.position;
        lineRenderer.positionCount = currentPoint + 1;
        lineRenderer.SetPositions(points);
        currentPoint++;
    }
}
