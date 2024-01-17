using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cylinder : Shape // INHERITANCE
{
    protected override void SetColor() // POLYMORPHISM
    {
        shapeRenderer.material.color = Color.blue;
    }

    protected override Vector3 GetRotateAxis() // POLYMORPHISM
    {
        return Vector3.forward;
    }

    protected override string GetShapeType()
    {
        return "Cylinder";
    }
}
