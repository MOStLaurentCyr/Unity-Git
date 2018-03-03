using UnityEngine;
using System.Collections;
using System.Collections;
using System.Collections.Generic;
public class OnClickInstantiate : MonoBehaviour
{
    public GameObject Prefab;
    public int InstantiateType;
    private string[] InstantiateTypeNames = {"Mine", "Scene"};
    public GameObject equipPrefab;

    public List<GameObject> createdObjects = new List<GameObject>();

    public bool showGui;

    void OnClick()
    {

        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        Vector3 vectotPos = new Vector3(200, 200.5F, 0200);
        cube.transform.localScale = new Vector3(100, 100, 100);
        Instantiate(cube, vectotPos, Quaternion.identity );

        switch (InstantiateType)
        {
            case 0:
                PhotonNetwork.Instantiate(Prefab.name, InputToEvent.inputHitPos + new Vector3(0, 5f, 0), Quaternion.identity, 0);
                break;
            case 1:
                PhotonNetwork.InstantiateSceneObject(Prefab.name, InputToEvent.inputHitPos + new Vector3(0, 5f, 0), Quaternion.identity, 0, null);
                break;
        }
    }

    void OnGUI()
    {
        if (showGui)
        {
            GUILayout.BeginArea(new Rect(Screen.width - 180, 0, 180, 50));
            InstantiateType = GUILayout.Toolbar(InstantiateType, InstantiateTypeNames);
            GUILayout.EndArea();
        }
    }


}
