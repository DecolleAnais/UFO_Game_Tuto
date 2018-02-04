using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public GameObject m_player;
    public Vector3 m_offset;

	// Use this for initialization
	void Start () {
        m_offset = transform.position - m_player.transform.position;
	}
	
	// LateUpdate is called once per frame
	void LateUpdate () {
        transform.position = m_player.transform.position + m_offset;
	}
}
