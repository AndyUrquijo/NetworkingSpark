using UnityEngine;
using System.Collections;


#if UNITY_EDITOR
using UnityEditor;
[CustomEditor(typeof(CircleDistribute))]
public class CircleDistributeEditor : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();
        CircleDistribute circle = (CircleDistribute)target;
        if (GUILayout.Button("Distribute"))
            circle.Distribute();

    }
}
#endif
public class CircleDistribute : MonoBehaviour 
{
    public float Radius = 1;
    public int Amount = 4;
    public GameObject Copy;

    public void Distribute()
    {
        if (!Copy)
            return;

        for (int i = 0; i < Amount; i++)
        {
            GameObject instance = GameObject.Instantiate(Copy);
            instance.transform.parent = transform;
            Vector3 position = Vector3.zero;
            float angle = 2 * Mathf.PI * (float)i / Amount;
            position.x = Radius * Mathf.Sin(angle);
            position.z = Radius * Mathf.Cos(angle);
            instance.transform.localPosition = position;
            instance.name = Copy.name;
        }
    }
}

