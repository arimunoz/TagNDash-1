using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour {
    //so we can display dialogue sentences in UI
    // Need using UnityEngine.UI, this two datatypes below
    public Text nameText;
    public Text dialogueText;

    //animation
    public Animator animator;


    //private string array of object strings; will use Quenes
    private Queue<string> sentences;

	// Use this for initialization
	void Start () {
        sentences = new Queue<string>();
		
	}

    //creating method to comunicate back to DialogueTrigger class
    public void StartDialogue(Dialogue dialogue) 
    {
        //animation
        animator.SetBool("IsOpen", true);
        //Use this code and comment out nameText.. if you want to display in console if it worked
        //Debug.Log("Starting conversation with " + dialogue.name);

        nameText.text = dialogue.name;

        //load previous sentences
        sentences.Clear();

        //looks up the strings in dialogue array; loop through all sentences in dialogue
        foreach (string sentence in dialogue.sentences)
        {

            sentences.Enqueue(sentence);
        }
        //Display them here
        DisplayNextSentence();

    }
    public void DisplayNextSentence ()
    {

        //check if there is extra sentences
        if (sentences.Count == 0)
        {
            EndDialogue();
            return;
        }
        string sentence = sentences.Dequeue();
        dialogueText.text = sentence;
        //to display in UI
        //if you want to show in console use this text and comment out above text
        //Debug.Log(sentence);
    }
    void EndDialogue()
    {
        //animation
        animator.SetBool("IsOpen", false);
        //for Debug you can view in console in unity if it works/communicates properly.
        //Debug.Log("End of conversation");
    }
}
