# Inventaire des tests

- DONE **IsSafe (Validations)**
  - IsSafe_FalseIfNumInLine : Doit retourner faux si valeur inadéquate
  - IsSafe_FalseIfNumInCol : Doit retourner faux si valeur inadéquate
  - IsSafe_FalseIfNumInBox : Doit retourner faux si valeur inadéquate
  - IsSafe_TrueIfNumIsSafe : Doit retourner vrai si valeur adéquate
- DONE **IsValid (Validations)**
  - IsValid_FalseIfNumInLine : Doit retourner faux si valeur inadéquate
  - IsValid_FalseIfNumInCol : Doit retourner faux si valeur inadéquate
  - IsValid_FalseIfNumInBox : Doit retourner faux si valeur inadéquate
  - IsValid_TrueIfNumIsSafe : Doit retourner vrai si valeur adéquate
- DONE **IsGameWon (Validations)**

  - IsGameWon_FalseGridNotFull : Doit retourner faux si partie non complétée
  - IsGameWon_FalseCellNotValid : Doit retourner faux si partie non complétée
  - IsGameWon_TrueGridCompleted : Doit retourner vrai si partie complétée

- DONE **FillBox (Sudoku)**
  - FillBox_ValidParamsFalse : Considérant un sudoku de 9 carré, les valeurs reçues par la fonction doivent correspondre à un début de carré 3x3
  - FillBox_NotEmpty : Doit se basé sur un carré qui n'a pas déjà été rempli
  - FillBox_Filled : 3 valeurs ont été saisies dans le carré
- DONE **FillDiagonal (Sudoku)**
  - FillDiagonal_Filled : 3 carrés doivent avoir reçu des valeurs
- DONE **GenerateSudokuGrid (Sudoku)**
  - GenerateSudokuGrid_Difficutly30 : Le nombre de cases vides doit correspondre à la difficulté
  - GenerateSudokuGrid_Difficutly40 : Le nombre de cases vides doit correspondre à la difficulté
  - GenerateSudokuGrid_Difficutly50 : Le nombre de cases vides doit correspondre à la difficulté
  - GenerateSudokuGrid_Difficutly60 : Le nombre de cases vides doit correspondre à la difficulté
- DONE **SolveSudoku (Sudoku)**
  - SolveSudoku_PartiallyResolved : Compléter la grille de jeu
  - SolveSudoku_NewGrid : Compléter la grille de jeu
  - SolveSudoku_EmptyGrid : La grille doit d'abord été chargé
- DONE **RemoveNumbers (Sudoku)**
  - RemoveNumbers_NumbersRemoved40 : Les cases doivent être remises à 0
  - RemoveNumbers_NumbersRemoved50 : Les cases doivent être remises à 0
- **PlayGrid (Sudoku)**
  - PlayGrid_InitialValue : On ne doit pas pouvoir modifier une valeur initiale
  - PlayGrid_ValueEntered : On doit pouvoir saisir une valeur dans une case qui était vide
  - PlayGrid_InvalidPosition : On ne doit pas pouvoir jouer en dehors de la grille

---

# Liste des tests

## Fonction isSafe (Validations)

Cette fonction vise à évaluer dans la grille si une valeur que j'envoie peut être saisie à une position donnée. (Est-ce que 3 peut aller à la case A3?)
| Test | Objectif | Critères | Particularités |
| --- | --- | --- | --- |
| IsSafe_FalseIfNumInLine | Doit retourner faux si valeur inadéquate | Le nombre existe déjà dans la ligne |
| IsSafe_FalseIfNumInCol | Doit retourner faux si valeur inadéquate | Le nombre existe déjà dans la colonne |
| IsSafe_FalseIfNumInBox | Doit retourner faux si valeur inadéquate | Le nombre existe déjà dans la le 3x3 |
| IsSafe_TrueIfNumIsSafe | Doit retourner vrai si valeur adéquate | Le nombre n'existe ni dans la ligne, ni dans la colonne et ni dans le 3x3 |

## Fonction IsValid (Validations)

Cette fonction vise à évaluer dans la grille si le nombre à une position que la fonction reçoit est valide ou non. (Est-ce que la case A3 est valide?)
| Test | Objectif | Critères | Particularités |
| --- | --- | --- | --- |
| IsValid_FalseIfNumInLine | Doit retourner faux si valeur inadéquate | Le nombre existe déjà dans la ligne |
| IsValid_FalseIfNumInCol | Doit retourner faux si valeur inadéquate | Le nombre existe déjà dans la colonne |
| IsValid_FalseIfNumInBox | Doit retourner faux si valeur inadéquate | Le nombre existe déjà dans la le 3x3 |
| IsValid_TrueIfNumIsSafe | Doit retourner vrai si valeur adéquate | Le nombre n'existe ni dans la ligne, ni dans la colonne et ni dans le 3x3 |

## Fonction IsGameWon (Validations)

Cette fonction vise à valider une grille de jeu, toutes les cases doivent être remplies, et toutes les cases doivent être valides.
| Test | Objectif | Critères | Particularités |
| --- | --- | --- | --- |
| IsGameWon_FalseGridNotFull | Doit retourner faux si partie non complétée | Une cellule = 0 |
| IsGameWon_FalseCellNotValid | Doit retourner faux si partie non complétée | Une cellule n'est pas valide |
| IsGameWon_TrueGridCompleted | Doit retourner vrai si partie complétée | Toutes les cellules de la grille sont remplies et valides |

## Fonction FillBox (Sudoku)

Cette fonction vise à remplir de nombre aléatoires dans un bloc de 3x3 spécifique (sans répétition). Elle reçoit en paramètre la ligne et la colonne de départ du carré. Doit également valider par rapport aux autres carrés du sudoku.
| Test | Objectif | Critères | Particularités |
| --- | --- | --- | --- |
| FillBox_ValidParamsFalse | Considérant un sudoku de 9 carré, les valeurs reçues par la fonction doivent correspondre à un début de carré 3x3 | Si valeur ne correspond pas à une liste précise renvoie erreur |
| FillBox_NotEmpty | Doit se basé sur un carré qui n'a pas déjà été rempli | Retourne erreur si déjà remplie |
| FillBox_Filled | 9 valeurs ont été saisies dans le carré | 3 carré rempli les autres valeurs sont à 0 |

## Fonction FillDiagonal (Sudoku)

Cette fonction vise à remplir 3 carrés 3x3 diagonaux avec des valeurs aléatoires.
| Test | Objectif | Critères | Particularités |
| --- | --- | --- | --- |
| FillDiagonal_Filled | 3 carrés doivent avoir reçu des valeurs | Valider grille n'est plus vide |

## Fonction GenerateSudokuGrid (Sudoku)

Cette fonction vise à générer la grille de sudoku selon la difficulté configurée au préalable
| Test | Objectif | Critères | Particularités |
| --- | --- | --- | --- |
| GenerateSudokuGrid_Difficutly30 | Le nombre de cases vides doit correspondre à la difficulté | nombre case vide = 30 |
| GenerateSudokuGrid_Difficutly40 | Le nombre de cases vides doit correspondre à la difficulté | nombre case vide = 40 |
| GenerateSudokuGrid_Difficutly50 | Le nombre de cases vides doit correspondre à la difficulté | nombre case vide = 50 |
| GenerateSudokuGrid_Difficutly60 | Le nombre de cases vides doit correspondre à la difficulté | nombre case vide = 60 |

## Fonction SolveSudoku (Sudoku)

Cette fonction vise à compléter la grille de jeu sans l'aide du joueur. Une fois la fonction terminée, la grille doit être entièrement remplie et valide.
| Test | Objectif | Critères | Particularités |
| --- | --- | --- | --- |
| SolveSudoku_PartiallyResolved | Compléter la grille de jeu | Toutes les cellules sont remplies et valide |
| SolveSudoku_NewGrid | Compléter la grille de jeu | Toutes les cellules sont remplies et valide |
| SolveSudoku_EmptyGrid | La grille doit d'abord été chargé | La grille doit rester vide |

## Fonction RemoveNumbers (Sudoku)

Cette fonction vise à retirer des nombres qui avaient été générés dans la grille selon le niveau de difficulté sélectionné pour avoir le nombre de cases vides correspondant à la difficulté. Elle reçoit le nombre de cases à vider en paramètre.
| Test | Objectif | Critères | Particularités |
| --- | --- | --- | --- |
| RemoveNumbers_NumbersRemoved40 | Les cases doivent être remises à 0 | Validé nombre de cases vides correspond à la difficulté |
| RemoveNumbers_NumbersRemoved50 | Les cases doivent être remises à 0 | Validé nombre de cases vides correspond à la difficulté |

## Fonction PlayGrid (Sudoku)

Cette fonction vise à saisir la valeur indiquée du joueur à la position qu'il donne. Reçois l’entrée sous format string?.
| Test | Objectif | Critères | Particularités |
| --- | --- | --- | --- |
| PlayGrid_InitialValue | On ne doit pas pouvoir modifier une valeur initiale | La valeur est = à celle d'origine |
| PlayGrid_ValueEntered | On doit pouvoir saisir une valeur dans une case qui était vide | La valeur = la valeur entrée par le joueur |
| PlayGrid_InvalidPosition | On ne doit pas pouvoir jouer en dehors de la grille | Aucune modification apportée à la grille |
