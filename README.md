# ESGI.DesignPattern.Projet
## Phase 1
  - Nettoyage du code : Suppression des variables inutilisées
  - Remplacement des getters et setters en Properties
Cette étape nous a permis de simplifier le code sans modifier la logique métier et sans casser les tests.

## Phase 2
Analyse du code restant

## Phase 3
  - Mise en place d'un LoanBuilder
  - NewRevolver + NewAdvisedLine + NewTermLoan dans le LoanBuilder

## Phase 3
  - Abstract du DateTime.Now pour la valeur par défaut de Loan.Today (même si elle est remise à null dans le constructeur)
Cela permet de pouvoir tester les dates sans avoir à changer la date du système.

## Phase 4
  - Optimisation de la logique autour du DP Strategy déjà existant.
Dans les tests, on instanciait un Loan avec une stratégie spécifique mais cette dernière n'était jamais utilisée. 
Pour tester Capital et Duration de ce loan via cette stratégie, on instanciait une nouvelle instance de la stratégie du Loan.
On a alors ajouté la fonction Duration() à Loan qui appelle alors strategy.Duration(this), de même pour Capital().