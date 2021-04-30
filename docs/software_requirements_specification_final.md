# Overview

This document serves as the software requirements specification for our Unity-based 2D platformer, CIS 350 Spectacular Never Been Seen Before Super Awesome Game. The listed functional and non-functional requirements lay out what the game will be capable of and how it will behave, respectively. Each requirement has its own ID for traceability purposes. Each requirement will need to be fulfilled before completion of this project.

# Software Requirements

All functional and non-functional requirements are listed below. Both types of requirements have categories to sort them by feature. Each category is represented by a table of related requirements and their IDs.

## Functional Requirements

### Gameplay

| ID | Requirement |
| :-------------: | :----------: |
| FR1 | Levels shall be completable by the playable character crossing an endpoint on the stage. |
| FR2 | The game shall implement a playable character and have that character move in response to input from the user. |
| FR3 | The game shall have a basic enemy with the ability to interact with the playable character. |
| FR4 | The playable character's attributes shall change in response to death from enemies or the geometry of the level. |
| FR5 | The player shall move to the next level automatically upon completion of the current level. |

### Menus

| ID | Requirement |
| :-------------: | :----------: |
| FR6 | The game's controls shall be shown to the player on the main menu and on the pause menu. |
| FR7 | The game shall have a pause menu. |
| FR8 | The game shall have a main menu that is displayed upon launch. |
| FR9 | The pause and main menus shall both have an option to exit the game. |
| FR10 | The game shall have a menu to allow the user to choose a level to start from. |
| FR11 | The pause menu shall be accessible from all of the levels. |

### Health and Knockback

| ID | Requirement |
| :-------------: | :----------: |
| FR12 | The player's health shall be displayed on screen. |
| FR13 | The player shall be knocked back in response to horizontal enemy collision. |
| FR14 | The player shall lose one point of health in response to horizontal enemy collision. |
| FR15 | The player shall respawn upon their health reaching zero or falling off the stage. |
| FR16 | The player's health shall be refilled to a random value upon respawning. |

## Non-Functional Requirements

### Aesthetics

| ID | Requirement |
| :-------------: | :----------: |
| NFR1 | Levels shall feel aesthetically distinct from one another through visual and musical theming. |
| NFR2 | Different enemies shall have distinct differences so they are easy to tell apart. |
| NFR3 | Menus should be easy to interact with to allow for easy access to the game. |
| NFR4 | The end of the level shall be denoted by a symbol that is easily recognizable. |
| NFR5 | Levels, while distinct, shall keep the same general feel. |

### Controls

| ID | Requirement |
| :-------------: | :----------: |
| NFR6 | The game's controls shall be responsive. |
| NFR7 | The game's controls shall be consistent with other games of its genre, so as to be intuitive to the user. |
| NFR8 | The game's controls shall be easily located by the user on the menus. |
| NFR9 | The game's controls shall be consistent between each level. |
| NFR10 | The game's controls shall not be changed as character attributes change. |

### Difficulty

| ID | Requirement |
| :-------------: | :----------: |
| NFR11 | Levels shall be challenging but not stressful. |
| NFR12 | The usability of the platformer shall make it easy for people outside of the team to understand how to use it. |
| NFR13 | Levels shall scale up in difficulty as the game progresses. |
| NFR14 | The game shall implement different enemy types that require different strategies. |
| NFR15 | Levels shall be completable without changes in the player's attributes. |

# Software Artifacts

Links to all of the software artifacts generated during the development of this project are provided below. These artifacts include project plans, design documents, use case diagrams, and presentation resources.

- [Burn-up chart (as of 04/02/2021)](burn-up_chart.pdf)
- [Final presentation slides](final_presentation.pdf)
- [Final presentation talking points](final_presentation_talking_points.md)
- [Project proposal](proposal.md)
- [Midterm software requirements specification](software_requirements_specification.md)
- [Task list (as of 04/02/2021)](task_list.md)
- [Use case diagram - combat](/artifacts/use_case_diagrams/combat.pdf)
- [Use case diagram - menus and options](/artifacts/use_case_diagrams/menus_and_options.pdf)
- [Use case diagram - movement and respawning](/artifacts/use_case_diagrams/movement_and_respawning.pdf)
- [Expanded use case description - respawning](/artifacts/use_case_diagrams/respawn_use_case_description.md)
