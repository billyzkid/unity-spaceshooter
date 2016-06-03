﻿using UnityEngine;

public class BGScroller : MonoBehaviour
{
    public float scrollSpeed;
    public float tileSizeZ;

    private Vector3 startPosition;

    private void Start()
    {
        startPosition = transform.position;
    }

    private void Update()
    {
        var newPosition = Mathf.Repeat(Time.time * scrollSpeed, tileSizeZ);

        transform.position = startPosition + Vector3.forward * newPosition;
    }
}