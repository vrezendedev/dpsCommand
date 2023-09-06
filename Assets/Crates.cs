using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Crates : MonoBehaviour
{
    public GameObject[] AllCrates;
    private List<Tuple<Vector3, Quaternion>> CratesOriginalTransforms = new List<Tuple<Vector3, Quaternion>>();

    void Awake()
    {
        foreach (var obj in AllCrates)
        {
            CratesOriginalTransforms.Add(new Tuple<Vector3, Quaternion>(obj.transform.position, obj.transform.rotation));
        };
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            for (int i = 0; i < AllCrates.Length; i++)
            {
                AllCrates[i].transform.position = CratesOriginalTransforms[i].Item1;
                AllCrates[i].transform.rotation = CratesOriginalTransforms[i].Item2;
                AllCrates[i].gameObject.GetComponent<Rigidbody>().Sleep();
            }
        }
    }
}
