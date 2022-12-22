using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputHandler : MonoBehaviour {
    [SerializeField] InputField nameInput;
    [SerializeField] string filename;
    ScoreScript SS;
    List<InputEntry> entries = new List<InputEntry> ();

    private void Start () {
        entries = FileHandler.ReadListFromJSON<InputEntry> (filename);
        SS = GetComponent<ScoreScript>();
    }

    public void AddNameToList () {
        entries.Add(new InputEntry(nameInput.text, SS.h));
        nameInput.text = "";

        FileHandler.SaveToJSON<InputEntry> (entries, filename);
    }
}