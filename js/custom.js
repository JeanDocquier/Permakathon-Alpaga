/***
****
AJOUTER UTILISATEUR 
****
***/

/**TOGGLE MENU**/
var ajout_utilisateur = document.querySelector('.rajouter-employe');

ajout_utilisateur.addEventListener("click", function () {
    var formulaire = document.querySelector('.ajout-utilisateur');
    formulaire.classList.toggle('active');
});

var fermeture_ajout_utilisateur = document.querySelector('.fermeture-ajout-utilisateur');
fermeture_ajout_utilisateur.addEventListener("click", function () {
    var formulaire = document.querySelector('.ajout-utilisateur');
    formulaire.classList.toggle('active');
});
/** FIN TOGGLE MENU**/


/** AJOUT UTILISATEUR TABLEAU **/
var submit = document.querySelector('.valider-ajout');
submit.addEventListener("click", function (e) {
    e.preventDefault();
    var tableau_utlisateur = document.querySelector('.liste-utilisateur');
    var post_identifiant = document.querySelector('.identifiant-inscription');
    console.log(post_identifiant);
    var post_fonction = document.querySelector('.fonction-inscription');
    var nouveau_employe = document.createElement('tr');
    var nouveau_identifiant = document.createElement('td');
    nouveau_identifiant.textContent = post_identifiant.value;
    var nouvelle_fonction = document.createElement('td');
    nouvelle_fonction.textContent = post_fonction.value;

    nouveau_employe.appendChild(nouveau_identifiant);
    nouveau_employe.appendChild(nouvelle_fonction);
    tableau_utlisateur.appendChild(nouveau_employe);
    post_identifiant.value = "";
    post_fonction.value = "";
});
/** FIN AJOUT UTILISATEUR TABLEAU **/


/***
****
FIN AJOUTER UTILISATEUR 
****
***/
