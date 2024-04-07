using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Code_01 : MonoBehaviour
{
    void Start()
    {
		//Vector3 vec = new Vector3(5, 5, 5);
		//transform.Translate(vec);
    }
    void Update()
    {
		//Vector3 vec = new Vector3(0, 0.1f, 0);
		//transform.Translate(vec);

		//Vector3 vec = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
		//transform.Translate(vec);

		Vector3 vec = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), 0);
		transform.Translate(vec);
	}
}
