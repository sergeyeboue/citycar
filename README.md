# 🚗 CityCar

**CityCar** est une application web développée avec ASP.NET Core MVC permettant de répertorier des véhicules appartenant à différents propriétaires. Chaque véhicule est associé à une catégorie et peut recevoir des commentaires d'utilisateurs. Ce projet met en œuvre les concepts de base de l'architecture MVC ainsi que l'Entity Framework Core pour la gestion de la base de données.

---

## 🔧 Technologies utilisées

- ASP.NET Core MVC
- Entity Framework Core (Code First)
- ASP.NET Identity (gestion des utilisateurs)
- Razor Pages
- SQL Server LocalDB
- Bootstrap (frontend)

---

## 📦 Fonctionnalités

- Gestion des véhicules avec image, prix, marque, modèle, cylindrée
- Classement des véhicules par catégories (SUV, Berline, Coupé, etc.)
- Association d’un véhicule à un propriétaire
- Ajout de commentaires sur les véhicules
- Authentification utilisateur avec Identity
- Données de test préchargées (seed data)

---

## 🛠️ Installation et exécution
```bash
### 1. Prérequis

- .NET SDK 6.0 ou supérieur
- Visual Studio 2022 ou VS Code avec C# extension
- SQL Server LocalDB (installé avec Visual Studio)

### 2. Cloner le dépôt


git clone https://github.com/sergeyeboue/citycar.git
cd citycar

### 3. Appliquer les migrations et créer la base de données
dotnet ef database update

### 4. Lancer l'application
dotnet run
Ou via Visual Studio : bouton "Exécuter" ▶️

