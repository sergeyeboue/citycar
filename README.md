# 🚗 CityCar

CityCar est une plateforme web de gestion et de visualisation de véhicules. Elle permet à des propriétaires de proposer des voitures à la location ou à la vente. Les utilisateurs peuvent consulter les véhicules, classés par catégories, ainsi que lire et laisser des commentaires.

Le projet a été développé avec le framework ASP.NET Core MVC en C#, avec une base de données intégrée via Entity Framework Core.

## ✨ Fonctionnalités principales

- Ajout, affichage et gestion de voitures.
- Système de catégories (SUV, Coupé, Berline...).
- Gestion des propriétaires.
- Affichage et enregistrement de commentaires sur les voitures.
- Intégration d'images de voitures.
- Données pré-remplies via `HasData` pour la démonstration.

## 🛠️ Technologies utilisées

- ASP.NET Core MVC
- Entity Framework Core
- Identity Framework
- C#
- Razor Pages

## 💽 Base de données

Le projet utilise un `DbContext` personnalisé (`ApplicationDbContext`) avec des entités :
- `Voiture`
- `Proprietaire`
- `Categories`
- `Commentaire`

Les données initiales sont injectées dans la base via la méthode `HasData`.

## ▶️ Lancer le projet
```bash
1. Cloner le projet :
   
   git clone https://github.com/sergeyeboue/citycar.git
2. Ouvrir dans Visual Studio (2022 ou supérieur).
3. Exécuter les commandes suivantes dans le Package Manager Console :
   Update-Database
4.Lancer l’application avec IIS Express ou en CLI avec :
  dotnet run
```

🙌 Auteurs

Ce projet a été développé par :

- Serge Yeboue – @sergeyeboue 
- @jr922579
- @kossilaba

Contributions bienvenues via pull requests ou issues !


