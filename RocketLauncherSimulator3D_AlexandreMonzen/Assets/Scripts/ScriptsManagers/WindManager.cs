using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class WindManager : MonoBehaviour
{
    [Header("Default")]
    [SerializeField] public Vector2 _globalWindVector;
    
    [Header("Configurable")]
    [SerializeField] private bool _randomWind;
    [SerializeField] private float minX;
    [SerializeField] private float maxX;
    [SerializeField] private float minY;
    [SerializeField] private float maxY;

    public Vector2 globalWindVector { get => _globalWindVector; private set => _globalWindVector = value; }
}
