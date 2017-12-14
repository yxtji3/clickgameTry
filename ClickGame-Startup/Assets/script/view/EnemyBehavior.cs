using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Animator))]//animator綁定
[RequireComponent(typeof(MeshFader))]
public class EnemyBehavior : MonoBehaviour {

    private Animator animator;
    private MeshFader meshFader;
    private AudioSource audiosource;
	
    private void Awake()
    {
        animator = GetComponent<Animator>();
        meshFader = GetComponent<MeshFader>();
        audiosource = GetComponent<AudioSource>();
    }

    private void OnEnable() {
        StartCoroutine(meshFader.FadeIn());
    }

    [ContextMenu("DeDemage")]
    public void Update()
    {
        if (Input.GetButtonDown("Fire1")) { 
        DoDemage(10);
    }
    }

    public void DoDemage(int attack)
    {
        animator.SetTrigger("hurt");
        audiosource.Play();
    }

    public IEnumerator Execute()
    {
        yield return null;
        
        }

}
