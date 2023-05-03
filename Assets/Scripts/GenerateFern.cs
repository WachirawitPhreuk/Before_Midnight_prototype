using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateFern : MonoBehaviour
{
    public int numPoints = 5000;
    public float scale = 5f;

    private Vector3 position = Vector3.zero;
    private Vector3 lastPosition = Vector3.zero;

    private void Start()
    {
        for (int i = 0; i < numPoints; i++)
        {
            float rand = Random.Range(0f, 1f);

            if (rand < 0.01f)
            {
                position = new Vector3(0f, 0.16f * lastPosition.y, 0f);
            }
            else if (rand < 0.86f)
            {
                position = new Vector3(0.85f * lastPosition.x + 0.04f * lastPosition.y, 
                    -0.04f * lastPosition.x + 0.85f * lastPosition.y + 1.6f, 0f);
            }
            else if (rand < 0.93f)
            {
                position = new Vector3(0.2f * lastPosition.x - 0.26f * lastPosition.y, 
                    0.23f * lastPosition.x + 0.22f * lastPosition.y + 1.6f, 0f);
            }
            else
            {
                position = new Vector3(-0.15f * lastPosition.x + 0.28f * lastPosition.y, 
                    0.26f * lastPosition.x + 0.24f * lastPosition.y + 0.44f, 0f);
            }

            lastPosition = position;
            GameObject newPoint = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            newPoint.transform.position = position * scale;
            newPoint.transform.parent = transform; // Set the new point as a child of the GameObject with this script
        }
    }
}
