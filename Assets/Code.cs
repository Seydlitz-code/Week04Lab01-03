using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Code : MonoBehaviour
{
    void Update()
    {
        if(Input.anyKeyDown)
        {
            Debug.Log("플레이어아 아무 키를 눌렀습니다.");
			//anyKeyDown 명령어는 유니티 프로젝트가 실행된 이후 플레이어가 하나 이상의 키를 누르면 실행된다.
		}
		if (Input.anyKey)
		{
			Debug.Log("플레이어아 아무 키를 누르고 있습니다.");
			//anyKeyDown 명령어는 유니티 프로젝트가 실행된 이후 플레이어가 하나 이상의 키를 길게 누르고 있다면 실행된다.
		}
		if (Input.GetKeyDown(KeyCode.Return))
		{
			Debug.Log("아이템을 구입하였습니다.");
		}

		if (Input.GetKey(KeyCode.LeftArrow))
		{
			Debug.Log("왼쪽으로 이동 중");
		}
		if (Input.GetKeyUp(KeyCode.RightArrow))
		{
			Debug.Log("오른쪽 이동을 멈췄습니다.");
		}

		if (Input.GetMouseButtonDown(0))
		{
			Debug.Log("미사일 발사!");
		}
		if (Input.GetMouseButton(0))
		{
			Debug.Log("미사일 모으는 중...");
		}
		if (Input.GetMouseButtonUp(0))
		{
			Debug.Log("슈퍼 미사일 발사!!");
		}

		if (Input.GetButtonDown("Jump"))
		{
			Debug.Log("점프!");
		}
		if (Input.GetButton("Jump"))
		{
			Debug.Log("점프 모으는 중...");
		}
		if (Input.GetButtonUp("Jump"))
		{
			Debug.Log("슈퍼 점프!!");
		}

		if (Input.GetButtonDown("SuperFire"))
		{
			Debug.Log("필살기!");
		}
		if (Input.GetButton("Fire1"))
		{
			Debug.Log("점프 모으는 중...");
		}
		if (Input.GetButtonUp("Fire1"))
		{
			Debug.Log("슈퍼 점프!!");
		}

		if (Input.GetButton("Horizontal"))
		{
			Debug.Log("횡 이동중..." + input.GetAxis("Horizontal"));
			Debug.Log("횡 이동중..." + input.GetAxisRaw("Horizontal"));
		}
		if (Input.GetButton("Vertical"))
		{
			Debug.Log("횡 이동중..." + input.GetAxis("Vertical"));
			Debug.Log("횡 이동중..." + input.GetAxisRaw("Vertical"));
		}
	}
}
