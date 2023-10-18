using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
using System.IO;
using TMPro;

public class CSVUploader : MonoBehaviour
{
//the user uploads a .csv file, and the contents are displayed in a TMP text object
    string path;

    public TMP_Text csvContentText; // UI Text to display the CSV content

    public void OpenExplorer()
    {
        //open file explorer
        path = EditorUtility.OpenFilePanel("Select CSV", "", "csv");
        GetCSVContents();
    }

    void GetCSVContents()
    {
        if (path != null)
        {
            // Read the content of the CSV file
            string[] fileLines = File.ReadAllLines(path);

            // Display the content of the CSV file
            DisplayCSVContent(fileLines);
        }
    }

    void DisplayCSVContent(string[] lines)
    {
        // Clear the previous content
        csvContentText.text = "";

        // Append each line of the CSV content to the UI Text
        foreach (string line in lines)
        {
            csvContentText.text += line + "\n";
        }
    }
}
