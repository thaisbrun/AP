# AP

AP3 2021 : FORMA’FLIX
Contexte : 
Une jeune entreprise Forma’Flix souhaite proposer un réseau social de regroupement de formations vidéos aux 
internautes, afin de rassembler par compétences des vidéos existantes ou à publier et ainsi aider à la recherche de 
formations pour tout public. 
Le principe est simple : centraliser les formations par leur identifiant vidéo unique en lui donnant un libellé, une 
description et en définissant si cette formation sera visible en mode public ou privé. Les formations permettent de 
développer des compétences (très variées, de la technique à la méthode de projet ou au développement personnel). 
Pour accéder au mode privé et ainsi avoir accès à plus de formations, les internautes sont inscrits au réseau social 
Forma’Flix. 
La gestion des formations est gérée par des utilisateurs authentifiés (des administrateurs). 
Cette jeune entreprise souhaite développer davantage ce réseau et proposer d’autres fonctionnalités. 
La société 1FO@SIO leur a déjà fourni une première version V1 (principe de développement par itération : méthode 
AGILE). Cette version V1.0 repose sur 2 applicatifs : 
● un site Internet en M.V.C en PHP, HTML, CSS 
○ qui permet en mode public 
■ de visualiser toutes les formations de visibilité publique 
■ de se connecter en tant qu’inscrit au réseau social
○ qui permet en mode inscrit 
■ de consulter toutes les formations de visibilité privée 
● une application C# en M.V.C en mode connecté pour la base de données 
○ qui permet en mode administrateur 
■ de se connecter à l’application (ex : admin / ap3) 
■ de visualiser toutes les formations déjà répertoriées (READ du CRUD (Create Read Update 
Delete)) 
■ d’insérer de nouvelles formations (CREATE du CRUD) dans la table FORMATION de la base de 
données. 
● une Base de données commune aux 2 applications : 
Contrainte : données CENTRALISÉES sur un même serveur de Base de Données : 
2TSSIOD – AP3 2021-2022 page 2/9 Lycée Chevrollier - Angers 
Le modèle conceptuel de la base de données initiale vous est fourni selon le schéma suivant : 
Le script issu de cette modélisation vous est fourni dans le fichier : « AP3_BD_FORMAFLIX.sql ». 
La table FORMATION regroupe toutes les formations proposées sur le site, le champ visbilitePublic est à 0 par 
défaut et signifie qu’une formation est visible pour tous en accès public. Si un accès privé en tant qu’inscrit est 
obligatoire pour cette formation, ce champ sera à 1. 
La table INSCRIT regroupe les inscrits au site qui peuvent donc avoir un accès privé aux formations. 
La table UTILISATEUR regroupe les administrateurs de l’application C# de gestion des formations, habilitées à 
gérer les données. 
Déploiement : Le site Web devra être accessible par n’importe quel utilisateur donc devra être installé sur un 
serveur Web distant (ferme ou extérieur). Pas d’obligation de systèmes d’exploitation, mais être capable de justifier 
ses choix. 
La base de données sera mise en place sur un serveur mutualisé pour l’ensemble des groupes, chaque groupe devra 
faire une demande de création de comptes : http://bdd.ap3.local/
Base de 
Données 
CENTRALE
MySQL
Application 
WEB 
(Front End )
Application 
C# 
connectée
2TSSIOD – AP3 2021-2022 page 3/9 Lycée Chevrollier - Angers 
Votre proposition de Service Informatique : 
Vous êtes embauchés par le SSII 1FO_SIO en tant que développeur/concepteur d’applications pour continuer le 
développement de ce service Forma’Flix en vous intégrant à la structure déjà mise en place dans les existants. Vous 
serez affecté à une équipe de développement de 2 personnes qui travailleront à la fois sur le Web et sur le C# 
(répartition libre entre les 2, mais à organiser). 
Vous êtes encadrés par les 2 responsables M.O.E (Maîtrise d'œuvre) : Valentin Brosseau et Carine Autret 
Durée : 9 semaines du 10 septembre au 19 novembre 2021.
Oral intermédiaire Partie 1 Prise en main de l’existant et V1 : vendredi 24 Septembre 
Oral de fin de projet V2 et V3 : semaine du 22 au 26 novembre (pendant la semaine du BTS BLANC). 
Les outils à votre disposition pour ces missions : 
● Outil de développement : PHP Storm, Visual Studio Code, VisualStudio2019 
● Technologies Web : CSS3, PHP8 avec Boostrap 
● Gestion de projet en groupe : GitHub (pour gérer le versionning et le travail collaboratif), 
● planification selon diagramme de GANTT (Microsoft Project par exemple) ou gestion en tâches (Trello par 
exemple). 
Liste des documents fournis : 
● Fichier descriptif du projet : AP3 2021 Projet FormaFlix.pdf (ce document, disponible sous Moodle) 
● Modèle conceptuel de la BDD : AP3_MCD_Initial.mcd (disponible sous Moodle) 
● Script de la BDD : AP3_BD_FORMAFLIX.sql (disponible sous Moodle) 
● Fiche d’évaluation : Fiche-evaluation-AP3.pdf (disponible sous Moodle)
● Code fourni des applications WEB et C# existantes : sur GitLab 
● Documentation technique Site Web : https://cours.brosseau.ovh/tp/php/mvc/tp1.html
● Site web existant : http://formaflix.ap3.local
● Pour la création des accès BD : http://bdd.ap3.local/
● Pour administrer votre BD (une fois créée) : phpmyadmin.ap3.local
Codes sources : 
● Site Web : https://gitlab.com/bts-sio-chevrollier/formaflix/formaflix-web
● Application C# : https://gitlab.com/bts-sio-chevrollier/formaflix/ap3-c
Connexion à l’application C# via un compte utilisateur enregistré dans la BD : 
exemple d’utilisateur : nom : admin / mot de passe crypté : ap3 
2TSSIOD – AP3 2021-2022 page 4/9 Lycée Chevrollier - Angers 
PARTIE I : Prise en main de l’existant 
Réponses écrites et formalisées dans une documentation technique. 
Cette partie sera évaluée lors l’oral du 24 septembre avec la V1 
1. Base de données 
Analyser la base de données et la schématisation conceptuelle (MCD) et répondre aux questions suivantes : 
a. expliquer pourquoi la contrainte UNIQUE est-elle utile pour le champ IDENTIFIANTVIDEO de la table 
FORMATION ? Où peut-on voir que cette contrainte est mise en place ? Qu’empêche-t-elle ? 
b. LIEN TABLE FORMATION et COMPETENCE 
Dans le modèle conceptuel, il existe une association DEVELOPPER entre FORMATION et COMPETENCE. 
Comment est traduite cette association dans la base de données ? Pourquoi ce choix ? 
c. Pourquoi dans la table DEVELOPPER de la BD, a-t-on mis les paramètres suivants dans les contraintes 
(« Vue Relationnelle »): 
i. Sur quels champs sont ces paramétrages ? 
ii. À quels autres champs sont-ils liés ? 
iii. Que signifie ON DELETE NO ACTION ? Est-ce judicieux sur l’IDFORMATION ? Si non, proposer 
une autre solution. 
iv. Que signifie ON DELETE RESTRICT ? 
v. Que signifie ON UPDATE CASCADE ? 
vi. Quelles autres possibilités avons-nous ? 
2TSSIOD – AP3 2021-2022 page 5/9 Lycée Chevrollier - Angers 
d. Gestion des mots de passe : comment sont gérés les mots de passe ? cela donne-t-il une indication 
sur leur hashage dans les applicatifs ? 
e. Lors de la phase d’initialisation du projet, vous avez fait un choix concernant le nombre de comptes 
utilisateur pour votre base de données, quel choix avez-vous fait ? pour quelles raisons ? 
2. Site web 
Analyser le code existant et la représentation UML des classes du projet afin de répondre aux questions suivantes. 
Modèle : 
Contrôleurs : 
2TSSIOD – AP3 2021-2022 page 6/9 Lycée Chevrollier - Angers 
Diagramme de séquence : 
2TSSIOD – AP3 2021-2022 page 7/9 Lycée Chevrollier - Angers 
a. Comment les mots de passe sont-ils gérés dans le code PHP? Est-ce suffisant ? 
b. Comment le contrôle d’accès au vidéo privé est-il effectué dans le code ? Est-ce que cette 
vérification est suffisante ? 
3. Application C# 
a. Comment est gérée la gestion des mots de passe dans le code C# ? Quelle librairie est utilisée ? 
b. Lors de la connexion, le nom de l’utilisateur connecté est récupéré et indiqué en haut de la page 
principale de l’application : comment l’information est-elle transmise d’une vue à l’autre ? 
c. Lors de l’ajout d’une formation : étudier le code de cet évènement et expliquer pourquoi cet ajout se 
fait en deux temps dans la base de données (appel à deux ordres d’insertion) ? 
PARTIE I Applicatifs : VERSION 1 : finir les fonctionnalités manquantes 
Partie I V1 à faire valider par un maître d’œuvre 
Avant le vendredi 24 septembre 2021 (fin séance) 
Implanter la base de données et les applicatifs existants donnés dans un environnement client-serveur (ferme du 
lycée : serveur de BD, serveur web) et mettre en place les outils pour la gestion du travail de groupe (GitHub au moins). 
Les modifications demandées peuvent avoir des impacts aussi sur la base de données existante. 
(Version 1.1) : C# : Modification de l’existant 
a. Ajout d’une propriété dateVisibilité d’une formation qui permet de rendre visible une formation sur le web 
qu’à partir d’une date donnée. Modifier la consultation et l’insertion en conséquence. 
b. Compléter le CRUD sur la table FORMATION dans l’application lourde C# : Ajouter la modification et la 
suppression. Attention de vérifier ce qui se passe lors de la suppression d’une formation par rapport aux 
compétences associées.
(Version 1.2) : Web : Modification de l’existant 
a. N’afficher que les formations dont la date de visibilité présente une disponibilité de la formation.
b. Dans la partie Public : Proposer un groupement des formations selon les compétences. 
 
2TSSIOD – AP3 2021-2022 page 8/9 Lycée Chevrollier - Angers 
PARTIE II : VERSION 2 : les nouveaux besoins. 
Présentation orale finale (fonctionnelle) 
Pendant la semaine du BTS BLANC du 22 au 26 novembre 2021 
Forma’Flix souhaite faire évoluer les fonctionnalités. Voici ces nouveaux besoins précisés dans plusieurs missions. 
Certaines missions peuvent avoir des répercussions sur les 2 applicatifs (Site et C#) et sur la base de données. 
Mission1 : (Version2.1 C#) : C# Gestion des commentaires (modération) et ajout des auteurs
Un inscrit, sur le web, peut émettre un commentaire sur une formation suivie. Un commentaire est constitué d’un 
libellé, d’une note entre 0 et 5 et d’un statut. Ce statut sert à la modération : au départ, suite à leur post sur le site 
web, les commentaires restent non publiés (statut 0 par défaut). Les utilisateurs pourront via l’application C# 
accepter ou non la publication de ces commentaires et donc en modifier le statut. Ainsi seuls les commentaires au 
statut 1 pourront être lisibles par les internautes. 
a. Ajouter cette gestion de la modération des commentaires. Pas de suppression mais permettre de rendre 
publiable ou non un commentaire émis par un inscrit sur le web. 
Gestion des auteurs des formations : 
b. Permettre d’enregistrer l’auteur d’une formation, qui est l’administrateur connecté (cet auteur devra être 
affiché aussi lors de la consultation des formations sur le web)
c. Ajouter la notion de super administrateur qui aura les droits d’ajouter des administrateurs dans la table 
UTILISATEUR
Mission2 : (Version2.2 Web ) : Web : gestion des inscriptions, de leur diplôme et ajout de commentaires 
a. Permettre l’inscription d’un internaute 
Si un internaute souhaite disposer du service privé avec les vidéos accessibles qu’aux inscrits, il doit être inscrit. 
Permettre, en plus de sa connexion déjà faite, de s’inscrire pour avoir accès au service privé. 
b. Un inscrit : enregistrement du dernier diplôme obtenu 
On souhaite connaître le dernier diplôme obtenu pour les inscrits, choix à faire parmi une liste des diplômes 
préalablement renseignée. 
c. Ajout des commentaires en tant qu’inscrit 
Un inscrit doit pouvoir proposer un commentaire sur les vidéos. Ce commentaire aura un statut non publié au départ, 
soumis à modération via l’application C#. Les commentaires deviennent lisibles si la modération est positive.
Mission3 : (Version3 Web et C#) : Gestion des certifications 
Proposer des formations qui délivrent une certification pour les inscrits qui les ont suivies. (certificat en mode pdf ou 
autre format, sur le web ou le C# au choix).
