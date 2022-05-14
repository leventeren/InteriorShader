using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        List<Transform> childs = this.transform.GetAllChildren();

        foreach (var childs_item in childs)
        {
            childs_item.GetComponent<MeshRenderer>().material.SetTextureOffset("_RoomTex", new Vector2(Random.Range(0, 8), Random.Range(0, 8))); //Random.Range(0,8)
        }
    }
}

public static class TransformExtension
{
    public static List<Transform> GetAllChildren(this Transform parent, List<Transform> transformList = null)
    {
        if (transformList == null) transformList = new List<Transform>();

        foreach (Transform child in parent)
        {
            transformList.Add(child);
            child.GetAllChildren(transformList);
        }
        return transformList;
    }
}