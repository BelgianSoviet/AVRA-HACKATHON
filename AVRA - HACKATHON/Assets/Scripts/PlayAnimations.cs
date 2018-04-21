using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayAnimations : MonoBehaviour {

    public GameObject startObj;
    Animation anim;
	// Use this for initialization
	void Start ()
    {
        anim = startObj.GetComponent<Animation>();
        StartCoroutine(this.PlayAnim());
    }
    // Update is called once per frame
    void Update ()
    {
    }
    IEnumerator PlayAnim()
    {
        anim.Play();
        yield return new WaitForSeconds(anim.clip.length);
        SceneManager.LoadScene("Working");
    }

}
