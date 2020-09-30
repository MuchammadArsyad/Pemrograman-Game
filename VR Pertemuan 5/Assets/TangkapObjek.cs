// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class TangkapObjek : MonoBehaviour
// {
//     public GameObject bola;
//     public GameObject tangan;
//     // Start is called before the first frame update
//     void Start()
//     {
        
//     }

//     // Update is called once per frame
//     void Update()
//     {
//         if(input.GetButtonDown("Fire1"))
//         {
//             bola.transform.SetParent(tangan.transform);
//             bola.transform.localPosition=tangan.transform.localPosition;
//         }
//     }
// }A

public GameObject bola;
    public GameObject tangan;
    bool tertangkap = false;
    Vector3 posisiBola;

    void Start()
    {
        posisiBola = bola.transform.position;
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if (!tertangkap)
            {
                bola.transform.SetParent(tangan.transform);
                bola.transform.localPosition = new Vector3(0f, -672f, 0f);
                tertangkap = true;
   
            }
            else if (tertangkap)
            {
                bola.transform.SetParent(null);
                bola.transform.localPosition = posisiBola;
                tertangkap = false;
            }
        }
    }