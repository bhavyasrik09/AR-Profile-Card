using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinkManager : MonoBehaviour
{
    public void openLinkedin()
    {
        Application.OpenURL("https://www.linkedin.com/in/bhavyasrik09/");
    }
    public void openGithub()
    {
        Application.OpenURL("https://github.com/bhavyasrik09");
    }
    public void openLeetcode()
    {
        Application.OpenURL("https://leetcode.com/u/Bhavyasrik/");
    }
    public void openEmail()
    {
        Application.OpenURL("mailto:bhavyasrik2023@gmail.com");
    }
}
