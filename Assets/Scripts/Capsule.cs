using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Capsule : Shape // INHERITANCE
{
    protected override void SetColor() // POLYMORPHISM
    {
        shapeRenderer.material.color = Color.yellow;
    }

    protected override Vector3 GetRotateAxis() // POLYMORPHISM
    {
        return Vector3.right;
    }

    protected override string GetShapeType()
    {
        return "Capsule";
    }
}
