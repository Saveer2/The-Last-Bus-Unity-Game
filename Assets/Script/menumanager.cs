using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    void StopMenuMusic()
    {
        MenuMusic music = FindObjectOfType<MenuMusic>();
        if (music != null)
            music.StopMusic();
    }
    void StopMenuMusic1()
    {
        GameMusic music = FindObjectOfType<GameMusic>();
        if (music != null)
            music.StopMusic();
    }

    public void maingame()
    {
        StopMenuMusic();
        SceneManager.LoadScene("disclamer");
    }

    public void Disclamer()
    {
        SceneManager.LoadScene("scene1");
    }

    public void scene1()
    {
        SceneManager.LoadScene("scene2");
    }

    public void scene2()
    {
        SceneManager.LoadScene("scene3");
    }

    public void scene3()
    {
        SceneManager.LoadScene("scene4");
    }

    public void scene4()
    {
        SceneManager.LoadScene("scene5");
    }

    public void scene5()
    {
        SceneManager.LoadScene("scene6");
    }

    public void scene6()
    {
        SceneManager.LoadScene("scene7");
    }

    public void scene7()
    {
        SceneManager.LoadScene("scene8");
    }

    public void scene8()
    {
        SceneManager.LoadScene("scene9");
    }

    public void scene9()
    {
        SceneManager.LoadScene("scene10");
    }

    public void scene10()
    {
        SceneManager.LoadScene("scene11");
    }

    public void scene11()
    {
        SceneManager.LoadScene("scene12");
    }

    public void scene12()
    {
        StopMenuMusic1();
        SceneManager.LoadScene("scene13");
    }

    public void scene13()
    {
        SceneManager.LoadScene("scene14");
    }

    public void scene14()
    {
        SceneManager.LoadScene("scene15");
    }

    public void scene17()
    {
        SceneManager.LoadScene("scene18");
    }

    public void scene18()
    {
        SceneManager.LoadScene("scene19");
    }

    public void scene19()
    {
        SceneManager.LoadScene("scene20");
    }

    public void scene22()
    {
        SceneManager.LoadScene("scene23");
    }

    public void scene23()
    {
        SceneManager.LoadScene("scene24");
    }

    public void scene24()
    {
        SceneManager.LoadScene("scene25");
    }

    public void scene25()
    {
        SceneManager.LoadScene("scene26");
    }

    public void scene26()
    {
        SceneManager.LoadScene("scene27");
    }

    public void scene26_1()
    {
        SceneManager.LoadScene("scene27.1");
    }

    public void scene26_2()
    {
        SceneManager.LoadScene("scene27.2");
    }

    public void scene27_22()
    {
        SceneManager.LoadScene("scene27.21");
    }

    public void scene27_1()
    {
        SceneManager.LoadScene("scene27.11");
    }

    public void scene27_2()
    {
        SceneManager.LoadScene("scene27.12");
    }

    public void scene27_3()
    {
        SceneManager.LoadScene("scene27.13");
    }

    public void scene27_4()
    {
        SceneManager.LoadScene("scene27.14");
    }

    public void scene28()
    {
        SceneManager.LoadScene("scene29");
    }

    public void scene29()
    {
        SceneManager.LoadScene("scene30");
    }

    public void scene31()
    {
        SceneManager.LoadScene("scene32");
    }

    public void scene32()
    {
        SceneManager.LoadScene("scene33");
    }

    public void scene33()
    {
        SceneManager.LoadScene("scene34");
    }

    public void scene34()
    {
        SceneManager.LoadScene("scene35");
    }

    public void scene37()
    {
        SceneManager.LoadScene("scene38");
    }

    public void scene38()
    {
        SceneManager.LoadScene("scene39");
    }

    public void scene39()
    {
        SceneManager.LoadScene("scene40");
    }

    public void scene41()
    {
        SceneManager.LoadScene("scene42");
    }

    public void scene42()
    {
        SceneManager.LoadScene("scene43");
    }

    public void scene43()
    {
        SceneManager.LoadScene("scene44");
    }

    public void scene44()
    {
        SceneManager.LoadScene("scene45");
    }

    public void scene46()
    {
        SceneManager.LoadScene("scene47");
    }

    public void scene47()
    {
        SceneManager.LoadScene("scene48");
    }

    public void scene48()
    {
        SceneManager.LoadScene("scene49");
    }

    public void scene51()
    {
        SceneManager.LoadScene("scene52");
    }

    public void scene52()
    {
        SceneManager.LoadScene("scene53");
    }

    public void scene54()
    {
        SceneManager.LoadScene("scene55");
    }

    public void scene55()
    {
        SceneManager.LoadScene("scene56");
    }

    public void scene57_1()
    {
        SceneManager.LoadScene("scene58.1");
    }

    public void scene57_2()
    {
        SceneManager.LoadScene("scene58.2");
    }

    public void scene58_11()
    {
        SceneManager.LoadScene("scene58.12");
    }

    public void scene58_12()
    {
        SceneManager.LoadScene("scene58.13");
    }

    public void scene58_16()
    {
        SceneManager.LoadScene("scene58.17");
    }

    public void scene58_17()
    {
        SceneManager.LoadScene("scene58.18");
    }

    public void scene58_21()
    {
        SceneManager.LoadScene("scene58.22");
    }

    public void scene58_22()
    {
        SceneManager.LoadScene("scene58.23");
    }

    public void scene58_24()
    {
        SceneManager.LoadScene("scene58.25");
    }

    public void scene58_25()
    {
        SceneManager.LoadScene("scene58.26");
    }

    public void scene58_26()
    {
        SceneManager.LoadScene("end");
    }

    public void end()
    {
        StopMenuMusic1();
        SceneManager.LoadScene("menu");
    }

    public void enddd()
    {
        StopMenuMusic1();
        SceneManager.LoadScene("end");
    }

    public void OpenAbout()
    {
        SceneManager.LoadScene("About");
    }

    public void OpenCharacters()
    {
        SceneManager.LoadScene("charac");
    }

    public void OpenCredits()
    {
        SceneManager.LoadScene("credits");
    }

    public void GoBack()
    {
        SceneManager.LoadScene("menu");
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit"); // editor test
    }
}
