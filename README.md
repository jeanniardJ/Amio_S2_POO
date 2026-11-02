# S2_POO

Ce dépôt contient une série de travaux pratiques en C# autour de la programmation orientée objet (POO). Il regroupe plusieurs mini-projets indépendants qui illustrent les concepts fondamentaux de la POO : classes, objets, encapsulation, héritage, polymorphisme, interfaces, collections, tests unitaires et modélisation de cas concrets.

## Objectif du projet

Le but de ce repository est de pratiquer et de consolider les notions suivantes :

- création et utilisation de classes et d’objets ;
- conception de propriétés et de méthodes ;
- encapsulation des données ;
- héritage entre classes ;
- polymorphisme avec classes abstraites et interfaces ;
- gestion de collections et structures de données ;
- mise en œuvre de petites applications console en C#.

## Structure du dépôt

La solution contient plusieurs projets C# indépendants, chacun représentant un exercice ou un thème de cours :

- `S2_POO` : projet principal de démonstration / tests de concepts ;
- `S2_POO_TP_1` à `S2_POO_TP_5` : exercices progressifs de la POO ;
- `S2_POO_TP_POINT` : manipulation de points géométriques ;
- `S2_POO_TP_DES` : exercices autour des classes et des méthodes diverses ;
- `S2_POO_TP_CERCLE` : modélisation d’un cercle ;
- `S2_POO_TP_EMPLOIE` : contexte professionnel / employés ;
- `S2_POO_TP_ARTICLE` : gestion d’articles ;
- `S2_POO_TP_BOOK` : gestion de bibliothèque ;
- `S2_POO_TP_BATIMENT` : modélisation de bâtiments ;
- `S2_POO_TP_VECTEUR` : calcul vectoriel ;
- `S2_POO_TP_BANQUE` : gestion de comptes bancaires ;
- `S2_POO_TP_BANQUE_TESTS` : tests unitaires du projet banque ;
- `S2_POO_TP_ANIMAUX` : hiérarchie d’animaux ;
- `S2_POO_INTERFACE` : exercices sur les interfaces ;
- `S2_POO_POLYMORPH` : démonstration du polymorphisme.

La solution principale est :

- `S2_POO.sln`

## Prérequis

Pour exécuter les projets du dépôt, il faut :

- .NET 8 SDK ;
- un éditeur compatible comme Visual Studio 2022 ou VS Code ;
- Windows (le dépôt a été créé dans un environnement Windows, mais le code C# reste compatible avec les outils .NET standards).

## Installation

1. Clonez le dépôt :

   ```bash
   git clone https://github.com/jeanniardJ/Amio_S2_POO.git
   cd Amio_S2_POO
   ```

2. Restaurez les dépendances du projet :

   ```bash
   dotnet restore
   ```

3. Compilez la solution :

   ```bash
   dotnet build "S2_POO.sln"
   ```

## Exécution

Chaque projet peut être lancé indépendamment. Par exemple, pour lancer le projet de banque :

```bash
dotnet run --project .\S2_POO_TP_BANQUE\S2_POO_TP_BANQUE.csproj
```

Pour exécuter les tests du projet banque :

```bash
dotnet test .\S2_POO_TP_BANQUE_TESTS\S2_POO_TP_BANQUE_TESTS.csproj
```

## Exemple de thématiques abordées

- classes et objets ;
- attributs, méthodes et constructeurs ;
- encapsulation avec propriétés ;
- héritage et redéfinition ;
- abstraction et classes abstraites ;
- interfaces et contrats ;
- collections et listes ;
- gestion de données métier avec des cas concrets (banque, bibliothèque, animaux, etc.).

## Contribution

Ce dépôt sert essentiellement de support pédagogique. Les modifications peuvent être faites localement pour compléter les exercices, corriger des erreurs ou améliorer la structure du code.

## Auteur

Projet réalisé dans le cadre d’un cours de programmation orientée objet en C#.
