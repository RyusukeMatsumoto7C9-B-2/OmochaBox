using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Turret : MonoBehaviour
{


    private Transform _targetTransform;

    public bool IsTargetExists => _targetTransform != null;
    
    
    private void Start()
    {
        
    }

    private void Update()
    {
        
    }
    
    
    public void SetTarget(Transform target)
    {
        _targetTransform = target;
    }

}
