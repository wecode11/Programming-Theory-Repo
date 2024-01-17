using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Shape : MonoBehaviour
{
    [SerializeField]
    private TMP_Text shapeText;
    protected Renderer shapeRenderer { get; private set; } // ENCAPSULATION  (get/set)

    private void Start() // ABSTRACTION
    {
        shapeRenderer = GetComponent<Renderer>();
        SetColor();
    }

    private void Update() // ABSTRACTION
    {
        transform.Rotate(GetRotateAxis() * 10.0f * Time.deltaTime);
    }

    private void OnMouseDown() // ABSTRACTION
    {
        shapeText.text = $"{GetShapeType()}";
    }

    protected virtual void SetColor() { }

    protected virtual Vector3 GetRotateAxis()
    {
        return Vector3.zero;
    }

    protected virtual string GetShapeType()
    {
        return null;
    }
}
