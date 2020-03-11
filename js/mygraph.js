/*** 

CREATION TABLEAU 

***/

var donnee_tableau = document.querySelectorAll('.donnee-chiffree');
//console.log(donnee_tableau);
for (var i = 0; i < donnee_tableau.length; i++) {
    donnee_tableau[i].addEventListener("change", function () {
        createTableauUI();
    });
}

function createTableauUI(donneesJSON) {
    var tableau = document.querySelector('.tableau-donnees');
            tableau.innerHTML = " ";

    console.log(tableau);
    for (mydata in donneesJSON) {
        var donnees = donneesJSON[mydata]
        if (mydata == "Mois") {
            var entete = document.createElement('tr');
            var info_ligne = document.createElement('th');
            info_ligne.textContent = mydata;
            entete.appendChild(info_ligne);
            for (var i = 0; i < donnees.length; i++) {

                var cellule_donnee = document.createElement('th');
                cellule_donnee.textContent = donnees[i];
                entete.appendChild(cellule_donnee);
            }
            tableau.appendChild(entete);

        } else {
            var row = document.createElement('tr');
            var info_ligne = document.createElement('td');
            info_ligne.textContent = mydata;
            row.appendChild(info_ligne);
            for (var i = 0; i < donnees.length; i++) {
                var cellule_donnee = document.createElement('td');
                var input_donnee = document.createElement('input');
                input_donnee.type = "text";
                input_donnee.value = donnees[i];
                cellule_donnee.appendChild(input_donnee);
                //cellule_donnee.textContent = donnees[i];
                row.appendChild(cellule_donnee);
            }
            tableau.appendChild(row);
        }
    }
}

/*** 

CREATION GRAPHIQUES 

***/

var couleursgraph = ['#6464ff', '#6fd060', '#EBC65D', '#FF8882', '#886BE8', '#75FFEC'];


function getTableauGraph(donneesJSON, mois) {
    var array_mois = [];
    console.log(Array.isArray(donneesJSON), "TYPE RECU DONNEES");
    if(Array.isArray(donneesJSON)){
        for (var i = 1 ; i<donneesJSON.length ; i++){
            var unedata = [];
            unedata.push(donneesJSON[i][0]);
            unedata.push(donneesJSON[i][1]);
            array_mois.push(unedata);
        }
    }
    else{
    for (mydata in donneesJSON) {
        var meschiffres = donneesJSON[mydata];
        var unedata = [];
        unedata.push(mydata);
        unedata.push(meschiffres[mois]);
        array_mois.push(unedata);
    }
    }
    console.log("Array_mois", array_mois);
    return (array_mois);
        
}



/*
var ctx = document.getElementById('graphique-annuel').getContext('2d');
var chart = new Chart(ctx, {
    // The type of chart we want to create
    type: 'line',
    // The data for our dataset
    data: {
        labels: ['January', 'February', 'March', 'April', 'May', 'June', 'July'],
        datasets: [
            {
                label: 'My First dataset',
                fill: false,
                backgroundColor: "red",
                borderColor: "red",
                data: [1, 10, 5, 125, 20, 230, 45],
            },
            {
                label: 'My Second dataset',
                fill: false,
                backgroundColor: "blue",
                borderColor: "blie",
                data: [10, 110, 15, 42, 120, 130, 145],
            },
            {
                label: 'My Third dataset',
                fill: false,
                backgroundColor: "green",
                borderColor: "green",
                data: [15, 115, 55, 45, 125, 50, 95],
            }
        ]
    },

    // Configuration options go here
    options: {}
});
*/


/*var ctxtwo = document.getElementById('graphique-mensuel').getContext('2d');
var charttwo = new Chart(ctxtwo, {
    // The type of chart we want to create
    type: 'bar',
    // The data for our dataset
    data: {
        labels: ['January'],
        datasets: [
            {
                label: 'My First dataset',
                fill: false,
                backgroundColor: "red",
                borderColor: "red",
                data: [1],
            },
            {
                label: 'My Second dataset',
                fill: false,
                backgroundColor: "blue",
                borderColor: "blue",
                data: [10],
            },
            {
                label: 'My Third dataset',
                fill: false,
                backgroundColor: "red",
                borderColor: "red",
                data: [15],
            }
        ]
    },

    // Configuration options go here
    options: {}
});*/




var graphselecteur = document.querySelectorAll('.graph-selecteur');
getGraph();
for (var i = 0; i < graphselecteur.length; i++) {
    graphselecteur[i].addEventListener("change", function () {
        getGraph();
    });
}

/** PERMET D'ATTRIBUER UNE COULEUR DIFFERENTE AUX DATAS **/
// RETOURNE UNE COULEUR DEFINIE DANS LA VARIABLE "couleursgraph"  ligne 21
function attributeColor() {
    var getcouleur = couleursgraph[0];
    couleursgraph.shift();
    //console.log(couleursgraph);
    return getcouleur;
}

//ON VA CREER L'OBJET QUI SERA UTILISE POUR CREER LES DATASETS COMPOSANT LES GRAPHS
// --> RETOURNE UN OBJET 
function createDataSet(mylabel, myColor, mydata_numbers) {
    var dataset = { //PARAMETRES DE L'OBJET
        label: mylabel,
        fill: false,
        backgroundColor: myColor,
        borderColor: myColor,
        data: mydata_numbers
    }
    return dataset
}

//ON VA CREER UN TABLEAU DE DATASETS EN FONCTION DE LA LONGUEUR DU TABLEAU dataJSON
// --> RETOURNE UN TABLEAU
function getDataSet(donneesJSON, typeofgraph, moisbar = 0 /**JANVIER PAR DEFAUT**/ ) {
    var arrayOfDataSets = [];
    if (typeofgraph == "line") {
        console.log("graph-line");
        for (label in donneesJSON) {
            if (label != "Mois") {
                //console.log(donneesJSON[label]);
                var meschiffres = donneesJSON[label];
                //console.log(mydata, dataJSON[mydata]);
                arrayOfDataSets.push(createDataSet(label, attributeColor(), meschiffres));
            }
        }
    } else {
        console.log("graph-bar");
        var mybar = getTableauGraph(donneesJSON, moisbar)
        console.log(mybar);

        for (var i = 1; i < mybar.length; i++) {
            var label_bar = mybar[i][0];
            var data_bar = mybar[i][1];
            console.log("label_bar", label_bar, typeof label_bar);
            console.log("data_bar", data_bar, typeof data_bar);
            //console.log(typeof data_parsed);
            
            var dataset = createDataSet(label_bar, attributeColor(), data_bar);
            console.log(dataset)
            arrayOfDataSets.push(dataset);
        }
    }
    console.log(arrayOfDataSets)
    return arrayOfDataSets;
}

function getMois(donneesJSON) {
    for (mydata in donneesJSON) {
        if (mydata == "Mois") {
            //console.log(mydata);
            return donneesJSON[mydata];
        }
    }
}

// ON VA CREER LE GRAPHIQUE SUR BASE DES DATASETS RECUES
// --> CREE LE GRAPHIQUE
function createGraph(place_graph, type_graph, labels, dataJSON2) {
    //console.log(type_graph);
    var graph_place = document.getElementById(place_graph).getContext('2d');
    var graph = new Chart(graph_place, {
        type: type_graph,
        data: {
            labels: labels,
            datasets: getDataSet(dataJSON2, type_graph)
        }
    });
    //console.log(getDataSet(dataJSON2));
    //console.log(graph);
    return graph;
}

//ON VA AFFICHER AFFICHER LE GRAPH CREE EN
function getGraph() {
    var anneeselect = document.querySelector('#annee-tableau').value;
    //console.log(anneeselect);
    var categorieselect = document.querySelector('#categorie-tableau').value;
    //console.log(categorieselect);
    //var moisselect = document.querySelector('#mois-graphique').value;
    //console.log(moisselect);
    let formData = new FormData(); // L'équivalent d'un formulaire utilisé par XHR
    //    formData.set('query', 'all');   // Les valeurs permises de query sont (like | priceRange | category)
    let dataJson;

    formData.set('annee', anneeselect); // Si query == 'like', il faut aussi un paramètre annee (String)
    //formData.set('mois', moisselect); // Si query == 'priceRange', il faut aussi min (Number) et max (Number)
    formData.set('categorie', categorieselect); // Si category == 'priceRange', il faut aussi category (CD | BOOK | GAME)
    //console.log(formData);
    let urlAPI = './jsonproduction.json';
    let xhr = new XMLHttpRequest();
    xhr.addEventListener('readystatechange', function (e) {
        if (this.readyState == 1) {
            //pleaseWait.style['display'] = 'flex';
        } else if (this.readyState == 4) {
            if (this.status == 200) {
                // CONSTRUCTION DES GRAPHIQUES
                dataJson = JSON.parse(this.responseText);
                //console.log(dataJson);
                //console.log(getMois(dataJson));
                //getDataSet(dataJson);
                createTableauUI(dataJson);
                //console.log(getTableauGraph(dataJson, 4)[1]);
                couleursgraph = ['#6464ff', '#6fd060', '#EBC65D', '#FF8882', '#886BE8', '#75FFEC'] //On réinitalise le tableau des couleurs
                createGraph("graphique-annuel", "line", getMois(dataJson), dataJson);
                //console.log(getDataSet(dataJson, 2));
                //console.log(getTableauGraph(dataJson, 0));
                //couleursgraph = ['#6464ff', '#6fd060', '#EBC65D', '#FF8882', '#886BE8', '#75FFEC'] //On réinitalise le tableau des couleurs
                //var tempgetTableauGraph = [getTableauGraph(dataJson, moisselect)[0]];
                //console.log ("tempgetTableauGraph", tempgetTableauGraph);
                //var getTableauGraph2 = getTableauGraph(dataJson, moisselect);
                //console.log("getTableauGraph2", getTableauGraph2);
                //createGraph("graphique-mensuel", "bar", tempgetTableauGraph, getTableauGraph2);

            } else {
                // ERREUR
            }
        }
    })
    xhr.open('POST', urlAPI, true);
    xhr.send(formData);
}
