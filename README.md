## Welcome!
Welcome to the CLT Accessibility Week Game Source Code Directory! Within this file is a quick small walkthrough to set things up, provide an overview of the projects purpose and provide a list of resources and references used in developing this project as well as a list of everyone involved in contributing to this project! 

This project was built using Unity and was first initially launched on September 2022 with hopes that it'd be released by November 27th, 2022 for Accessibility Week. The game's 1st official release was on December 10th, 2022 with 3 stories.


## Project Purpose
From November 27th to December 3rd 2022 is Accessibility Week at Dalhousie University. This year the Center for Learning and Teaching would like to spread awareness and educate people on the topic of accessibility and disabilities with 7 short online games. 
(Excerpt taken from our Initial Project Plan under the section 'Initial Problem')


## Initial (Unity) Project Setup:
1. Clone this GitLab repo. onto your local device (git clone [Gitlab Repo HTTPS Link])
2. Open the cloned project on Unity and let it compile the project on your device
- The Unity Editor we used was LTS 2020.3.39f1, it is recommended that for future work to update the editor version.
    - For next team we suggest LTS Release 2021.3.9f1.
3. Once project has compiled and opened and no issues are present on console then you are all good to go to start/continue collaborating on this project!
    - In case any issues are encountered refer to 'Guidance on Avoiding Potential Encounter-able Unity Project Issues' below!
    - Under Assets/Scenes is a directory called 'Gameplay Mechanics', it comprises of scenes our team developed and tested around with in our initial stages of developing this game. They have been collected here to help future teams to build and test with.


## Guidance on Avoiding Potential Encounter-able Unity Project Issues:
- Depending on your Team size it is recommended to use Plastic over GitLab or GitHub as it can handle Unity errors efficiently. However if sticking with Gitlab just ensure that proper version control is followed
- Unity Scenes are the most susceptible to conflict errors so communication of what is being changed and considering that in resolving merge conflicts is vital
- Lessons learned: 100's of files can be changed over time, keep things small and logically compact; that is to say avoid wide sweeping changes and in long periods of time to avoid merge conflicts
- Avoid making changes in Playmode (unless for testing) as it will not save your work unless you specify it to manually.
- Make sure that you take care when moving items out of scenes etc., as this can lead to GameObjects missing an item(s) that it needs to call.
- There is your (C#) code and there is also the Unity Engine (via Inspector), both work together to make the game, make sure that methods are called correctly and by the appropriate GameObject.



## Acknowledgements:
- **General Acknowledgements:**
    - This project was created for Accessibility Week by the request of Tereigh Ewert on behalf of the Centre for Learning and Teaching (CLT) at Dalhousie University.
    - The (dis)Ability Caucus and other related entity groups who helped to compile and create the stories used in our game. Members of our team helped to edit them into scripts that can be easily integrated into game.
    - Maria McNeil from the Student Accessibility Center who provided initial guidance and support of what to consider in making our game accessible.

- **Winter 2023 Project Team Members (8 Members):**
    - Team Directors (2):
        - Development Director: Jonathan Robichaud
        - Technical Director: Thomas Hong
    - Development Team (8):
        - Zephyr Xyd Espino (Me)
        - Keenan Baird
        - Sofia Rincon Parada
        - Yisong Zhao
        - Yahia Abou El Fetouh
        - Dorian Germain Zambo Zambo

- **Fall 2022 Project Team Members (10 Members):**
    - Team Directors (2):
        - Development Director: Tom Campbell
        - Technical Director: Joel Kuruvilla
    - Development Team (8):
        - Joseph Burton
        - Ayah Abaza
        - Andrew Cole
        - Ram Tejesh Reddy Maddi
        - Hesham Elokdah
        - Joseph Krajewski
        - Benny Mugisha
        - Shunwen Wu

- **3rd Party Plugins/Packages**:
    - **Packages**:
        - For player movability:
            - NavMesh 
            - NavMesh Plus
            - [NOTE: Packages and scene have been retained in codebase in case original concept makes a comeback]
        - For Dialog System:
            - Ink-Unity integration
            - TextMesh Pro

    - **Accessibility Plugins**:
        - BDKCreate - Text Resizing
        - UAP (Unity Accessibility Plugin)
