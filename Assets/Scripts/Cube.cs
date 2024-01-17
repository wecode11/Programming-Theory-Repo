using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : Shape // INHERITANCE
{
    protected override void SetColor() // POLYMORPHISM
    {
        shapeRenderer.material.color = Color.green;
    }

    protected override Vector3 GetRotateAxis() // POLYMORPHISM
    {
        return Vector3.up;
    }

    protected override string GetShapeType()
    {
        return "Cube";
    }
}
