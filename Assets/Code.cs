using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Code : MonoBehaviour
{
    void Update()
    {
        if(Input.anyKeyDown)
        {
            Debug.Log("�÷��̾�� �ƹ� Ű�� �������ϴ�.");
			//anyKeyDown ��ɾ�� ����Ƽ ������Ʈ�� ����� ���� �÷��̾ �ϳ� �̻��� Ű�� ������ ����ȴ�.
		}
		if (Input.anyKey)
		{
			Debug.Log("�÷��̾�� �ƹ� Ű�� ������ �ֽ��ϴ�.");
			//anyKeyDown ��ɾ�� ����Ƽ ������Ʈ�� ����� ���� �÷��̾ �ϳ� �̻��� Ű�� ��� ������ �ִٸ� ����ȴ�.
		}
		if (Input.GetKeyDown(KeyCode.Return))
		{
			Debug.Log("�������� �����Ͽ����ϴ�.");
		}

		if (Input.GetKey(KeyCode.LeftArrow))
		{
			Debug.Log("�������� �̵� ��");
		}
		if (Input.GetKeyUp(KeyCode.RightArrow))
		{
			Debug.Log("������ �̵��� ������ϴ�.");
		}

		if (Input.GetMouseButtonDown(0))
		{
			Debug.Log("�̻��� �߻�!");
		}
		if (Input.GetMouseButton(0))
		{
			Debug.Log("�̻��� ������ ��...");
		}
		if (Input.GetMouseButtonUp(0))
		{
			Debug.Log("���� �̻��� �߻�!!");
		}

		if (Input.GetButtonDown("Jump"))
		{
			Debug.Log("����!");
		}
		if (Input.GetButton("Jump"))
		{
			Debug.Log("���� ������ ��...");
		}
		if (Input.GetButtonUp("Jump"))
		{
			Debug.Log("���� ����!!");
		}

		if (Input.GetButtonDown("SuperFire"))
		{
			Debug.Log("�ʻ��!");
		}
		if (Input.GetButton("Fire1"))
		{
			Debug.Log("���� ������ ��...");
		}
		if (Input.GetButtonUp("Fire1"))
		{
			Debug.Log("���� ����!!");
		}

		if (Input.GetButton("Horizontal"))
		{
			Debug.Log("Ⱦ �̵���..." + input.GetAxis("Horizontal"));
			Debug.Log("Ⱦ �̵���..." + input.GetAxisRaw("Horizontal"));
		}
		if (Input.GetButton("Vertical"))
		{
			Debug.Log("Ⱦ �̵���..." + input.GetAxis("Vertical"));
			Debug.Log("Ⱦ �̵���..." + input.GetAxisRaw("Vertical"));
		}
	}
}
