# Projet PingApp2 - Application de Ping via Interface Graphique (Windows Forms)

## Objectif
Ce projet permet d'effectuer des tests de connectivité réseau via un outil de ping intégré à une application Windows Forms. L'application permet de pinger plusieurs adresses IP (ou un intervalle d'adresses) et de visualiser les résultats dans une interface utilisateur graphique.

## Fonctionnalités
- **Ping multiple IPs** : Possibilité de pinger une série d'adresses IP successives.
- **Affichage des résultats** : Affichage des temps de réponse, du statut de la connexion (Succès ou Échec), et du statut de chaque adresse dans un tableau.
- **Interface utilisateur simple** : Interface Windows Forms pour saisir l'adresse de départ, le nombre de pings à envoyer, et afficher les résultats.
- **Gestion des erreurs** : Validation des entrées et gestion des erreurs liées au réseau.

## Structure du Projet
- **Form1** : Point d'entrée principal avec l'interface utilisateur (saisie de l'adresse IP de départ et du nombre de pings, affichage des résultats).
- **PingApp** : Classe de logique métier qui gère les calculs et opérations de ping.
- **IPV4** : Interface pour les adresses IPv4, permettant d'incrémenter les adresses IP successivement.
- **Calculipv4** : Classe implémentant l'interface IPV4 et fournissant la logique pour l'incrémentation des adresses IP.

## Exécution
1. Cloner le dépôt :
    ```bash
    git clone https://github.com/<sorin04>/<projet>.git
    ```
2. Ouvrir le projet avec **Visual Studio**.
3. Compiler et exécuter l'application.

## Exemple de Résultat
Lorsqu'un utilisateur effectue un test de ping, les résultats seront affichés sous forme de tableau dans l'application :

![Tableau des résultats](https://github.com/user-attachments/assets/d7fec452-ffc1-41dd-8019-a1589dee6c35)

Les résultats incluent le temps de réponse en millisecondes pour chaque adresse IP, et un statut qui peut être soit "Succès" (si le ping a répondu), soit "Échec" (si le ping a échoué).
