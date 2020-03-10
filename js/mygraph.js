var couleursgraph = ['#6464ff', '#6fd060', '#EBC65D', '#FF8882', '#886BE8', '#75FFEC']

var moistableau = ["Janvier", "Février", "Mars", "Avril", "Mai", "Juin", "Juillet", "Aout", "Septembre", "Octobre", "Novembre", "Décembre"];
//function getJSONAnnee(annee, categorie){
//    return data;
//}
//
//function getJSONMois(annee, mois, categorie){
//    return data
//}
//var creationlabel = data[0].janvier
var ctx = document.getElementById('graphique-annuel').getContext('2d');
var chart = new Chart(ctx, {
    // The type of chart we want to create
    type: 'line',
    // The data for our dataset
    data: {
        labels: ['January', 'February', 'March', 'April', 'May', 'June', 'July'],
        datasets: 
        [
            {
                label: 'My First dataset',
                fill: false,
                backgroundColor: couleursgraph[0],
                borderColor: couleursgraph[0],
                data: [1, 10, 5, 125, 20, 230, 45],
            },
            {
                label: 'My Second dataset',
                fill: false,
                backgroundColor: couleursgraph[1],
                borderColor: couleursgraph[1],
                data: [10, 110, 15, 42, 120, 130, 145],
            },
            {
                label: 'My Third dataset',
                fill: false,
                backgroundColor: couleursgraph[3],
                borderColor: couleursgraph[3],
                data: [15, 115, 55, 45, 125, 50, 95],
            }
        ]
    },

    // Configuration options go here
    options: {
    }
});


var ctxtwo = document.getElementById('graphique-mensuel').getContext('2d');
var charttwo = new Chart(ctxtwo, {
    // The type of chart we want to create
    type: 'bar',
    // The data for our dataset
    data: {
        labels: ['January'],
        datasets: 
        [
            {
                label: 'My First dataset',
                fill: false,
                backgroundColor: couleursgraph[0],
                borderColor: couleursgraph[0],
                data: [1],
            },
            {
                label: 'My Second dataset',
                fill: false,
                backgroundColor: couleursgraph[1],
                borderColor: couleursgraph[1],
                data: [10],
            },
            {
                label: 'My Third dataset',
                fill: false,
                backgroundColor: couleursgraph[3],
                borderColor: couleursgraph[3],
                data: [15],
            }
        ]
    },

    // Configuration options go here
    options: {
    }
});




var graphselecteur = document.querySelectorAll('.graph-selecteur');

for (var i = 0; i < graphselecteur.length; i++) {
    graphselecteur[i].addEventListener("change", function () {
        getGraph();
    });
}

//ON VA CREER UN TABLEAU COMPRENANT LES DONNEES CHIFFREES
// --> RETOURNE UN TABLEAU
function getDataNumbers(datanumbers){ //datanumbers equivaut aux datas chiffrées sous forma JSON
    var arrayofDataNumbers = [] // Tableau des datas chiffées qu'on reverra 
    for (var i = 0 ; i<datanumbers ; i++){
        var unedata // RECUPERER LA DATA DU JSON
        arrayofDataNumbers.push(unedata)
    }
    return arrayofDataNumbers;
}


//ON VA CREER L'OBJET QUI SERA UTILISE POUR CREER LES DATASETS COMPOSANT LES GRAPHS
// --> RETOURNE UN OBJET 
function aDataSet(label, fill, backgroundColor, borderColor, data){
    var dataset = { //PARAMETRES DE L'OBJET
        label : data.label,
        fill : false,
        backgroundColor : '#6fd060',
        borderColor : '#6fd060',
        data : getDataNumbers(datanumbers)
    }
        return dataset
}

//ON VA CREER UN TABLEAU DE DATASETS EN FONCTION DE LA LONGUEUR DU TABLEAU dataJSON
// --> RETOURNE UN TABLEAU
function getDataSet(dataJSON) {
    var arrayOfDataSets = [];
    for (var i = 0; i < dataJSON.length ; i++) {
        arrayOfDataSet.push(aDataSet());
    }
    return arrayOfDataSets;
}
// ON VA CREER LE GRAPHIQUE SUR BASE DES DATASETS RECUES
// --> CREE LE GRAPHIQUE
function createGraph(place_graph, type_graph, label_array, datasets) {
    var graph_place = document.getElementById(place_graph).getContext('2d');
    var graph = new Chart(graph_place, {
        type: type_graph,
        data: {
            labels: label_array,
            datasets: getDataSet(dataJSON)
        }
    });
}

//ON VA AFFICHER AFFICHER LE GRAPH CREE EN
function getGraph() {
    
    var anneeselect = document.querySelector('#annee-tableau').value;
    console.log(anneeselect);
    var categorieselect = document.querySelector('#categorie-tableau').value;
    console.log(categorieselect);
    var moisselect = document.querySelector('#mois-graphique').value;
    console.log(moisselect);
    let formData = new FormData(); // L'équivalent d'un formulaire utilisé par XHR
    //    formData.set('query', 'all');   // Les valeurs permises de query sont (like | priceRange | category)
    let dataJson;

    formData.set('annee', anneeselect); // Si query == 'like', il faut aussi un paramètre annee (String)
    formData.set('mois', moisselect); // Si query == 'priceRange', il faut aussi min (Number) et max (Number)
    formData.set('categorie', categorieselect); // Si category == 'priceRange', il faut aussi category (CD | BOOK | GAME)
    console.log(formData);
    let urlAPI = './api.php';
    let xhr = new XMLHttpRequest();

    xhr.addEventListener('readystatechange', function (e) {
        if (this.readyState == 1) {
            //pleaseWait.style['display'] = 'flex';
        } else if (this.readyState == 4) {
            if (this.status == 200) {
                // CONSTRUCTION DES GRAPHIQUES
                dataJson = JSON.parse(this.responseText);
                createGraph("graphique-annuel", line, moistableau, dataJson);
                createGraph("graphique-mensuel", bar, moisselect, dataJson);

            } else {
                // ERREUR
            }
        }
    })
    xhr.open('POST', urlAPI, true);
    xhr.send(formData);
}
