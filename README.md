# Workshop-CSharp

Ce guide vise à vous fournir une introduction claire et précise à l'apprentissage du langage de programmation C#.

Table des matières

    Exercice 1 : Récupération des arguments!
    Exercice 2 : Addition
    Exercice 3 : Recherche d'un élément dans un tableau
    Exercice 4 : Manipulation de référence/variable
    Exercice 5 : Création d'une structure de données
    Exercice 6 : Tableau de pointeur sur fonction
    Exercice 7 : Séparation et longueur des mots dans une chaîne de caractères
    Exercice 8 : Programmation orientée objet


# Exercice 1 : Récupération des arguments!

Compétence: récupérer les arguments.

L'exercice " Récupération des arguments" est un incontournable pour tout débutant en programmation. Il sert d'introduction simple à un nouveau langage de programmation.
L'objectif de cet exercice est de récupérer les arguments dans le main pour ensuite les afficher.
Pour vous aider, voici le lien de la doc officiel de Rust:
https://learn.microsoft.com/fr-fr/dotnet/csharp/programming-guide/

exemple :

    ./workshop_csharp arg1 arg2 arg3

    Arg 0 : ./workshop_csharp
    Arg 1 : arg1
    Arg 2 : arg2
    Arg 3 : arg3


# Exercice 2 : Addition

Compétence: création de fonction simple

Pour cette exercice commencez par créer un fichier ex02.cs
L'objectif de cet exercice est de créer une fonction qui prend en paramètre 2 int et qui retourne le résultat obtenu après les avoir additionner.
Ensuite, appeler la fonction dans le main en lui donnant deux floats donnés en paramètre puis afficher le résultat.

exemple :

    ./workshop_csharp -21 -21
    resultat: -42

# Exercice 3 : Recherche d'un élément dans un tableau

Compétence: Tableau.

Pour cette exercice commencez par créer un fichier ex03.cs
Une fois crée vous pouvez commencer à créer une fonction qui prends un vecteur de Int list et un Int nbr paramètre, celle-ci retournera l'index de nbr dans list.
Ensuite, appeler la fonction dans le main en lui donnant un vecteur de Int qui contient {1, 2, 3} et un Int qui sera par exemple 3 puis afficher le résultat.

exemple :

    ./workshop_csharp 3
    index: 2

# Exercice 4 : Manipulation de référence/variable

Compétence: Variable mutable / réference.

Dans cette exercice nous allons voir comment changer une chaînes de caractères en C# sans la retourner.
D'abord commencez par créer un fichier ex04.cs
Une fois fait, créer une fonction qui prends un tableau de Int [1, 2, 3] en paramètre, celle-ci ne retourne rien.
Dans cette fonction modifier le tableau pour que chaque variable sois égale à elle même +1.

exemple :

    ./workshop_csharp
    tab: 2,3,4

# Exercise 5 : Création d'une structure de données

Compétence: Structure.

Dans cette exercice ont va voir comment créer une structure la remplir et l'afficher
Comme les exercices précedents créer un fichier ex05.cs
Vous pouvez maintenant créer une structure Person qui contient deux Int (Id, Age), créer ensuite une fonction qui la remplie et l'affiche.

exemple :

    ./workshop_csharp 87484548454 42
    struct -> id: 87484548454 age: 42

# Exercice 6 : Tableau de pointeur sur fonction

Compétence: Pointeur sur fonction.

Créer un fichier ex06.cs
Dans celui-ci créer deux fonctions, une qui s'appelle fct1 et qui affiche "Fonction 1" et l'autre s'appelle fct2 et qui affiche "Fonction 2".
Maintenant créer une 3ème fonction qui prends une string (fct1 ou fct2) en paramètre.
Dans celle-ci créer un tableau de pointeur sur fonction qui lancera la fct1 ou fct2 en fonction de la string en paramètre.

exemple :

    ./workshop_csharp fct1
    Fonction 1

    ./workshop_csharp fct2
    Fonction 2

# Exercice 7 : Séparation et longueur des mots dans une chaîne de caractères

Dans cet exercice, vous allez pratiquer la séparation d'une chaîne de caractères en mots à l'aide d'un séparateur (Vous l'avez deja fait en C :D), puis mesurer la longueur de chaque mot. Vous allez donc écrire une fonction qui prend une chaîne de caractères, sépare les mots et renvoie la longueur de chaque mot dans un vecteur.

exemple :

    ./workshop_csharp "J'aime le CSharp !"
    Mot 1: 6 caractères
    Mot 2: 2 caractères
    Mot 3: 6 caractères
    Mot 4: 1 caractères

# Exercice 8 : Programmation orientée objet

Dans cet exercice, vous allez pratiquer les concepts de la programmation orientée objet. Vous allez créer une structure de données appelée Rectangle pour représenter un rectangle et définir des méthodes associées pour manipuler cette structure. Le rectangle est défini par sa longueur et sa largeur. Vous devez implémenter des méthodes pour calculer l'aire et le périmètre du rectangle.

# Félicitations à vous d'avoir terminé les 8 exercices ! Vous avez accompli un excellent travail en parcourant ces exercices qui couvraient différents aspects de la programmation en C#, allant de la récuperation des arguments à la manipulation des chaînes de caractères. Vous avez développé vos compétences en résolution de problèmes, en manipulation de données et en utilisation des fonctionnalités clés du langage C#.
