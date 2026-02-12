using System;
using UnityEngine;

public class ParallaxController : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Vector3 _offset;
    [SerializeField] private Transform previewRef;

    [ExecuteAlways]
    private void Awake()
    {
        
    }

    void Update()
    {
#if UNITY_EDITOR
        if (!Application.isPlaying)
        {
            transform.localPosition = _offset + previewRef.transform.position * _speed;
            return;
        }

    }
}