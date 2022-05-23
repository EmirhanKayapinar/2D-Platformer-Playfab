using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IMove 
{

    public float Horizontal { get; }
    public float Vertical { get; }
    public float Jump { get; }

}
