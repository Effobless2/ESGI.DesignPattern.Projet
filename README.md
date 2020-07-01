# ESGI.DesignPattern.Projet
## Phase 1
  - Nettoyage du code : Suppression des variables inutilis�es
  - Remplacement des getters et setters en Properties
Cette �tape nous a permis de simplifier le code sans modifier la logique m�tier et sans casser les tests.

## Phase 2
Analyse du code restant

## Phase 3
  - Mise en place d'un LoanBuilder
  - NewRevolver + NewAdvisedLine + NewTermLoan dans le LoanBuilder

## Phase 3
  - Abstract du DateTime.Now pour la valeur par d�faut de Loan.Today (m�me si elle est remise � null dans le constructeur)
Cela permet de pouvoir tester les dates sans avoir � changer la date du syst�me.

## Phase 4
  - Optimisation de la logique autour du DP Strategy d�j� existant.
Dans les tests, on instanciait un Loan avec une strat�gie sp�cifique mais cette derni�re n'�tait jamais utilis�e. 
Pour tester Capital et Duration de ce loan via cette strat�gie, on instanciait une nouvelle instance de la strat�gie du Loan.
On a alors ajout� la fonction Duration() � Loan qui appelle alors strategy.Duration(this), de m�me pour Capital().