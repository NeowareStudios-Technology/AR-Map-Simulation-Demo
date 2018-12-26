using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mapbox.Examples;
using Mapbox.Utils;
using Mapbox.Unity.Map;
using Mapbox.Unity.MeshGeneration.Factories;
using Mapbox.Unity.Utilities;
using System.Collections.Generic;

public class MarkerPaths : MonoBehaviour {

    public SpawnOnMap spawnOnMap;
    public LineRenderer lineRenderer;

    public int curMarker1;
    public int curMarker2;
	// Use this for initialization
	void Start ()
    {
        curMarker1 = 0;
        curMarker2 = 1;

       new WaitForSeconds(1);
	}
	
	// Update is called once per frame
	void Update ()
    {
        SetPath();
	}

    public void SetPath()
    {

        lineRenderer.SetPosition(0, spawnOnMap._spawnedObjects[curMarker1].transform.localPosition);
        lineRenderer.SetPosition(1, spawnOnMap._spawnedObjects[curMarker2].transform.localPosition);
    }

    public void ChangePath()
    {
        curMarker1++;

        if (curMarker1 >= spawnOnMap._spawnedObjects.Count)
            curMarker1 = 0;

        curMarker2++;

        if (curMarker2 >= spawnOnMap._spawnedObjects.Count)
            curMarker2 = 0;

        SetPath();
    }
}
